public static class File_Folder{
    public static void showMenu(){        
        Console.WriteLine("1 - Создать минимальный лист поставки\n" +
        "2 - Лист поставки с изменениями аттрибутов");
        int sqlChoise = Convert.ToInt32(Console.ReadLine());
        switch(sqlChoise){
                case 1:
                        SimpleQuery.simpleQueryMenu();
                break;
                case 2:
                        TableUtility.TableUtility.copyTableAsync();      
                break;
                        
                default:
                break;
        }   
    }

    
}