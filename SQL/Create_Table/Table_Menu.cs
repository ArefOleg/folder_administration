public static class TableMenu{
    public static void showMenu(){
        Console.WriteLine("1 - Declare\n2 - Копирование таблицы\n3 - Создать таблицу\n4 - Информация для апплая");
                        int sqlChoise = Convert.ToInt32(Console.ReadLine());
                        switch(sqlChoise){
                                case 1:
                                        sqlDeclares.sqlDeclare.GenerateSql();      
                                break;
                                case 2:
                                        TableUtility.TableUtility.copyTableAsync();      
                                break;
                                case 3:
                                        TableUtility.TableUtility.createTable();      
                                break;
                                
                                default:
                                break;
                        }   
    }
}