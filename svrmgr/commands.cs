public static class svrmgr{
    
    public static void chooseAction(){
        Console.WriteLine("1 - установить лог");
        Console.WriteLine("2 - получить список сессий");
        Console.WriteLine("3 - получить ветку с компоненты");
        Console.WriteLine("4 - установить ветку для компоненты");
        Console.WriteLine("5 - получить список параметров");
        Console.WriteLine("6 - сменить параметр");
        Console.WriteLine("7 - скомпилировать View из PLSQL");
        int svrMgrChoise = Convert.ToInt32(Console.ReadLine());
        switch(svrMgrChoise){
            case 1:
                setLog();
                break;
            case 2:
                getSessions();
                break;
            case 3:
                getBranch();
                break;
            case 4:
                setBranch();
                break;
            case 5:
                getCompParam();
                break;
            case 6:
                changeParam();
                break;
            case 7:
                showViewUpdateInstruction();
                break;
            default:
                Console.WriteLine("no case");
                break;
        } 

    }
    public static void setLog(){        
        Console.WriteLine("Введите название компоненты.");
        string? comp = Console.ReadLine();
        Console.WriteLine("На каком сервере установить лог");
        string? server = Console.ReadLine();
        Console.WriteLine("Установите уровень лога");
        int endPointChoise = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"change evtloglvl %= {endPointChoise} for server {server} component {comp}");
    }

    public static void getSessions(){
        Console.WriteLine("Введите название компоненты.");
        string? comp = Console.ReadLine();
        Console.WriteLine("На каком сервере установить лог");
        string? server = Console.ReadLine();
        Console.WriteLine($"list session for comp {comp} server {server}");
    }

    public static void getBranch(){
        Console.WriteLine("Введите название компоненты.");
        string? comp = Console.ReadLine();
        Console.WriteLine("На каком сервере");
        string? server = Console.ReadLine();
        Console.WriteLine($"list param %Branch% for comp {comp} server {server}");
    }

    public static void setBranch(){
        Console.WriteLine("Введите название компоненты.");
        string? comp = Console.ReadLine();
        Console.WriteLine("На каком сервере");
        string? server = Console.ReadLine();
        Console.WriteLine("Название ветки");
        string? branch = Console.ReadLine();
        Console.WriteLine($"change param WorkspaceBranchName={branch} for comp {comp} server {server}");    
    }

    public static void getCompParam(){
        Console.WriteLine("Введите название компоненты.");
        string? comp = Console.ReadLine();
        Console.WriteLine("На каком сервере");
        string? server = Console.ReadLine();
        Console.WriteLine($"list param for comp {comp} server {server}"); 
    }

    public static void changeParam(){
        Console.WriteLine("Нужно менять на определении компоненты или самой компоненты");
        Console.WriteLine("Если поменять на определении компоненты, то поменяется сразу на всех созданных от нее компоненты");
        Console.WriteLine("Введите определение компоненты или компоненты.");
        string? comp = Console.ReadLine();
        Console.WriteLine("Введите параметр");
        string? param = Console.ReadLine();
        Console.WriteLine("Введите значение");
        string? value = Console.ReadLine();
        Console.WriteLine("На каком сервере");
        string? server = Console.ReadLine();
        Console.WriteLine("Компонента? 1 - Да, 2 - Нет");
        int compChoise = Convert.ToInt32(Console.ReadLine());      
        if(compChoise==1) Console.WriteLine($"change param {param} = {value} for comp {comp} server {server}");
        else 
        Console.WriteLine($"change param {param} = {value} for compdef {comp}"); 
    }

    public static void showViewUpdateInstruction(){
        Console.WriteLine("Нужно создать файл tables.txt\nУказать какие работы с таблицей");
        Console.WriteLine("Например EX_LOY_0000005:Update или Insert");
        Console.WriteLine("Комманда: C:\\Siebel\\Tools\\BIN\\siebdev.exe /c C:\\Siebel\\Tools\\BIN\\enu\\tools.cfg /l enu /d ServerDataSrc /u arefev /p arefev /IncrementalTablePublish D:\\AREFEV\\tables.txt");
    }
}



//// + siebdev