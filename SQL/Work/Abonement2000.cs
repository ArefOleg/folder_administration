public static class Abonement2000{
    public static void showMenu(){
        Console.WriteLine("Выберите интересующие вас работы");
        Console.WriteLine("1 Клиенты, у которых 2 стикера, и нет купонов");
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


}