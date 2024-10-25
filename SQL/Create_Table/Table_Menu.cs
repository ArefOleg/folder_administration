public static class sqlMenu{
    public static void showMenu(){
        Console.WriteLine("0 - Получить опеределенный скрипты из задач");
        Console.WriteLine("1 - Declare\n2 - Копирование таблицы\n3 - Создать таблицу\n4 - Формат для даты");
                        int sqlChoise = Convert.ToInt32(Console.ReadLine());
                        switch(sqlChoise){
                                case 0:
                                        sql_Work_Menu.showMenu();      
                                break;
                                case 1:
                                        sqlDeclares.sqlDeclare.GenerateSql();      
                                break;
                                case 2:
                                        TableUtility.TableUtility.copyTableAsync();      
                                break;
                                case 3:
                                        TableUtility.TableUtility.createTable();      
                                break;
                                case 4:
                                        Console.WriteLine("to_date('09.02.2019 12:00:00','dd.mm.yyyy hh24:MI:SS')");
                                break;        
                                default:
                                break;
                        }   
    }
}