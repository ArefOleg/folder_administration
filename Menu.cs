using LWS10Generator;
using LWS8Generator;
using S12Generator;
public static class Menu{
    public static void showMenu(){
        Console.WriteLine("1 Генерация XML для интеграции \n2 Создать папку и файл для Листа поставки\n3 Работы с srvmgr\n4 Вызвать sql скрипты\n"
        + "5 Техническая информация");
        int baseChoise = Convert.ToInt32(Console.ReadLine());
        switch(baseChoise){
                case 1:                
                Console.WriteLine("Выберите веб сервис:");
                Console.WriteLine("1 LWS4 \n2 LWS2\n3 LWS10\n4 LWS8\n5 S21\n6 S12");
                int xmlChoise = Convert.ToInt32(Console.ReadLine());
                XML_Generator xml;
                        switch(xmlChoise){
                                case 1:
                                        xml = new EAI_WSSOAP_Generator("LWS4");
                                break;
                                case 2:
                                        xml = new EAI_WSSOAP_Generator("LWS2");
                                break;
                                case 3:
                                        xml = new LWS10_Generator("LWS10");
                                break;
                                case 4:
                                        xml = new LWS8_Generator("LWS8");
                                break;
                                case 5:
                                        xml = new S21_Generator("S21");
                                break;
                                case 6:
                                        xml = new S12_Generator("S12");
                                break;
                                default:
                                break;
                        }
                break;
                case 2:
                        File_Folder.showMenu();
                break;
                case 3:
                        svrmgr.chooseAction();                                        
                break;
                case 4:
                        sqlMenu.showMenu();
                break;
                case 5:{
                        TechInfo.techMenu();
                        break;
                        }                                                       
                default:
                break;
        }
        }
    public static void LWSEndPointChoise(){
        Console.WriteLine("Выберите энд пойнт");
        Console.WriteLine("1 DEV");
        Console.WriteLine("2 TEST");
        Console.WriteLine("3 PRE");
        int endPointChoise = Convert.ToInt32(Console.ReadLine());
        switch(endPointChoise){
                case 1:
                        Console.WriteLine("https://msk03-sbldev2.licard.com/siebel/app/eai_teboil/rus?SWEExtSource=WebService&SWEExtCmd=Execute&WSSOAP=1");
                        break;
                case 2:
                        Console.WriteLine("https://msk03-sbl2-tt1.licard.com/siebel/app/eai/enu?SWEExtSource=WebService&SWEExtCmd=Execute&WSSOAP=1");
                        break;
                case 3:
                        Console.WriteLine("https://msk03-sw3-pre.licard.com:9001/siebel/app/eai/enu?SWEExtSource=WebService&SWEExtCmd=Execute&WSSOAP=1");
                        break;
                default:
                break;
        }
        Console.WriteLine("Файл сформирован");
    }

   public static void EAI_AnonEndPointChoise(){
        Console.WriteLine("Выберите энд пойнт");
        Console.WriteLine("1 DEV");
        Console.WriteLine("2 TEST");
        Console.WriteLine("3 PRE");
        int endPointChoise = Convert.ToInt32(Console.ReadLine());
        switch(endPointChoise){
                case 1:
                        Console.WriteLine("https://msk03-sbldev2.licard.com:9001/siebel/app/eai_anon/rus?SWEExtSource=SecureWebService&SWEExtCmd=Execute");
                        break;
                case 2:
                        Console.WriteLine("https://msk03-sbl2-tt1.licard.com:9001/siebel/app/eai_anon/enu?SWEExtSource=SecureWebService&SWEExtCmd=Execute");
                        break;
                case 3:
                        Console.WriteLine("https://msk03-sw2-pre.licard.com:9001/siebel/app/eai_anon/rus?SWEExtSource=SecureWebService&SWEExtCmd=Execute");
                        break;
                default:
                break;
        }
        Console.WriteLine("Файл сформирован");
   }
}