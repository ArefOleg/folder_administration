
namespace TableUtility;

public static class TableUtility{
    public static async Task copyTableAsync(){

        Console.WriteLine("Введите название таблицы для копирования");
        string? tableOrigName = Console.ReadLine();
        Console.WriteLine("Введите название таблицы для создания");
        string? tableNewName = Console.ReadLine();
        Console.WriteLine("Введите колонки через запятую для копирования, если нужно копирнуть все, не вводите ничего");
        string? columnNames = Console.ReadLine();
        if(String.IsNullOrEmpty(columnNames)) columnNames = "*";
        string inputText = $"CREATE TABLE {tableNewName} AS \n"
        + $"(SELECT {columnNames} FROM SIEBEL.{tableOrigName} WHERE //УСЛОВИЕ ПРИ НЕОБХОДИМОСТИ)\n"
        + $"grant execute on SIEBEL.{tableNewName} TO SSE_ROLE";
        string path = "CopyTable.txt";
        using (StreamWriter writer = new StreamWriter(path, false)){
            await writer.WriteLineAsync(inputText);
        }
    }

    public static async Task createTable(){
        Console.WriteLine("Введите название таблицы для создания");
        string? tableNewName = Console.ReadLine();
        int columnCount = Convert.ToInt32(Console.ReadLine());
        List<string> colomns = new List<string>();
        for(int i = 0; i < columnCount; i++){
            
        }
    }
}