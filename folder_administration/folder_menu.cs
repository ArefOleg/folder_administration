public static class File_Folder{
    public static void showMenu(){
        Console.WriteLine(@"Укажите путь для формирования отчета вида C:\");
        string? path = Console.ReadLine();
        Console.WriteLine("Название листа поставки");
        string? name = Console.ReadLine();
        DirectoryInfo dirInfo = new DirectoryInfo(path + @"\" + name);
        dirInfo.Create();
        Console.WriteLine("1 Создать минимальный лист поставки\n" +
        "2  Лист поставки с изменениями аттрибутов\n"+
        "3  Лист поставки минимальный с АДМ\n" +
        "4  Лист поставки с изменениями аттрибутов и АДМ\n");
        int sqlChoise = Convert.ToInt32(Console.ReadLine());
        switch(sqlChoise){
                case 1:
                        File.Copy(@"Word Template/ЛП минимальный.docx", path + @"\" + name + @"\" + name + ".doc");
                break;
                case 2:
                        File.Copy(@"Word Template/ЛП с аттрибутами.docx", path + @"\" + name + @"\" + name + ".doc");     
                break;
                case 3:
                        File.Copy(@"Word Template/ЛП минимальный c АДМ.docx", path + @"\" + name + @"\" + name + ".doc");     
                break;
                case 4:
                        File.Copy(@"Word Template/ЛП с аттрибутами с АДМ.docx", path + @"\" + name + @"\" + name + ".doc");     
                break;   
                default:
                break;
        }   
    }

    
}