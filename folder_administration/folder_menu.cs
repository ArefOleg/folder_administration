public static class File_Folder{
    public static void showMenu(){
        Console.WriteLine(@"Укажите путь для формирования отчета вида C:\");
        string? path = Console.ReadLine();
        Console.WriteLine("Название листа поставки");
        string? name = Console.ReadLine();
        DirectoryInfo dirInfo = new DirectoryInfo(path + @"\" + name);
        dirInfo.Create();
        Console.WriteLine("1 Создать минимальный лист поставки\n" +
        "2  Лист поставки с изменениями аттрибутов\n");
        int sqlChoise = Convert.ToInt32(Console.ReadLine());
        switch(sqlChoise){
                case 1:
                        //
                break;
                case 2:
                        //     
                break;
                        
                default:
                break;
        }   
    }

    
}