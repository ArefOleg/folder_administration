static class Folder{
    public static string path = @"C:\Users\ov.arefev\Documents\Работа";


    public static void Generate(string name, string type){
        Console.WriteLine("Создание папки");
        DirectoryInfo dirInfo = new DirectoryInfo(path);
        switch(type){
            case "XML":
                Directory.CreateDirectory($"{path}/XML/{name}");
                break;
            case "ЛП":
                Directory.CreateDirectory($"{path}/Лист поставки/{name}");
                break;
            case "Задача":
                Directory.CreateDirectory($"{path}/Задача/{name}");
                break;
            default:
                Console.WriteLine("no case");
                break;
        } 
    }
}