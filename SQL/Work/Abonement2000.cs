public static class Abonement2000{
    public static void showMenu(){
        Console.WriteLine("Выберите интересующие вас работы");
        Console.WriteLine("1 Клиенты, у которых 2 стикера, и нет купонов");
        Console.WriteLine("2 Информация по карте, о начислении стикеров и купонов");
        Console.WriteLine("3 Вызов ЛВС10 по карте");

        int sqlChoise = Convert.ToInt32(Console.ReadLine());
                        switch(sqlChoise){
                                case 1:
                                    showClient2Stickers0Coupons();      
                                break;
                                case 2:
                                    showCDCAbonement2000Info();      
                                break;
                                case 3:
                                    LWS10Abonement2000Info();      
                                break;
                                default:
                                break;
                        }   
    }

    

    public static async void showClient2Stickers0Coupons(){
        Console.WriteLine("Выполните скрипт");
        Console.WriteLine("select row_id from siebel.s_loy_attrdefn where display_name = '2000x2CouponIssued'");
        Console.WriteLine("Введите полученный Id");
        string? couponId = Console.ReadLine();
        Console.WriteLine("Выполните скрипт");
        Console.WriteLine("select row_id from siebel.s_loy_attrdefn where display_name = '2000x2Counter'");
        Console.WriteLine("Введите полученный Id");
        string? stickerId = Console.ReadLine();
        string path = "ShowClient2Stickers0Coupons.txt";
        string inputText = "SELECT card.card_num, sla1.LAST_UPD FROM SIEBEL.S_LOY_ATTRIB sla1\n" 
        + "INNER JOIN SIEBEL.S_LOY_ATTRIB sla2 ON sla1.member_id = sla2.member_id\n"
        + "INNER JOIN SIEBEL.S_LOY_CARD card ON sla1.member_id = card.member_id\n"
        + $"WHERE sla1.attrib_defn_id = '{stickerId}' AND sla1.value = '2' AND sla2.attrib_defn_id = '{couponId}' AND sla2.value = '0';\n";       

        using (StreamWriter writer = new StreamWriter(path, false)){
            await writer.WriteLineAsync(inputText);
        }
    }

    public static async void showCDCAbonement2000Info(){
        Console.WriteLine("Введите номер карты");
        string? cardNumber = Console.ReadLine();
        string path = "ShowCDCAbonement2000Info.txt";
        string inputText = $"SELECT * FROM SIEBEL.CX_NTFCTN_TEB cx WHERE cx.card_num = ('{cardNumber}')\n"
        + "AND TYPE IN ('2000x2CouponIssued', '2000x2Counter')\n"
        + "ORDER BY CREATED DESC";
        using (StreamWriter writer = new StreamWriter(path, false)){
            await writer.WriteLineAsync(inputText);
        }
    }

    public static async void LWS10Abonement2000Info(){
        Console.WriteLine("Введите номер карты");
        string? cardNumber = Console.ReadLine();
        string path = "ShowCDCAbonement2000Info.txt";
        string inputText = $"SELECT * FROM SIEBEL.CX_INT_LOG WHERE NAME "
        +$"= 'LWS10 Accrual For Action' AND ORDER_NUMBER  = '{cardNumber}'";
        using (StreamWriter writer = new StreamWriter(path, false)){
            await writer.WriteLineAsync(inputText);
        }
    }


}