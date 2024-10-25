public static class sql_Work_Menu{
    public static void showMenu(){
        Console.WriteLine("Выберите интересующие вас работы");
        Console.WriteLine("1 Промо-акция абонемент 2000\n");
        int sqlChoise = Convert.ToInt32(Console.ReadLine());
                        switch(sqlChoise){
                                case 1:
                                        Abonement2000.showMenu();      
                                break;
                                       
                                default:
                                break;
                        }   
    }
}