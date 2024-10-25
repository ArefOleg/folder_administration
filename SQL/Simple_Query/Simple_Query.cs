using System.ComponentModel.Design;

public static class SimpleQuery{
    public static void simpleQueryMenu(){
        Console.WriteLine("1 ЛОГ по процессингу\n");
        Console.WriteLine("2 ЛОГ по eai_anon\n");
        int sqlChoise = Convert.ToInt32(Console.ReadLine());
                        switch(sqlChoise){
                                case 1:
                                        Abonement2000.showMenu();      
                                break;
                                case 2:
                                        getEAI_ANONLog();      
                                break;     
                                default:
                                break;
                        }  
    }

    public static void getLWSLog(){
        Console.WriteLine("SELECT * FROM SIEBEL.CX_LOY_LOG WHERE SERVICE_NAME = 'имя LWS' AND CARD_NUM = 'номер карты'");
    }

    public static void getEAI_ANONLog(){
        Console.WriteLine("SELECT * FROM SIEBEL.CX_INT_LOG WHERE NAME = 'Имя сервиса'");
    }
}