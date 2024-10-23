public class Colomn{
    public string name;
    public string type;
    public Colomn(){
        Console.WriteLine("Название колонки с большой буквы");
        string? name = Console.ReadLine();
        this.name = name;
        Console.WriteLine("Выберите тип данных\n VARCHAR(Размер CHAR)\n Date\n CHAR(1 CHAR)\n NUMBER(Размер)");
        string? type = Console.ReadLine();
        this.type = type;
        
    }


}
