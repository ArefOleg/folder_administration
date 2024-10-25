public static class sqlMenu{
    public static void showMenu(){
        Console.WriteLine("0 - Получить опеределенный скрипт из задач");
        Console.WriteLine("1 - Простые запросы \n2 - Копирование таблицы\n3 - Создать таблицу\n4 - Формат для даты\n5 - Declare");
                        int sqlChoise = Convert.ToInt32(Console.ReadLine());
                        switch(sqlChoise){
                                case 0:
                                        sql_Work_Menu.showMenu();      
                                break;
                                case 1:
                                        SimpleQuery.simpleQueryMenu();
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
                                case 5:
                                        sqlDeclares.sqlDeclare.GenerateSql();      
                                break;        
                                default:
                                break;
                        }   
    }
}