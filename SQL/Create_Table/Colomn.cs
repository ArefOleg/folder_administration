public class Colomn{
    public KeyValuePair <int, string> colomn;
    public string type;
    public Colomn(){
        Console.WriteLine("Выберите тип данных\n1 Varchar\n2 Date\n3 CHAR");
        int choiseType = Convert.ToInt32(Console.ReadLine());
        
        string? name = Console.ReadLine();
        string? value = Console.ReadLine();
    }


}
