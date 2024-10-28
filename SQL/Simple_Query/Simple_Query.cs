using System.ComponentModel.Design;

public static class SimpleQuery{
    public static void simpleQueryMenu(){
        Console.WriteLine("1 ЛОГ по процессингу\n");
        Console.WriteLine("2 ЛОГ по eai_anon\n");
        Console.WriteLine("3 Проверка перед СМА\n");
        int sqlChoise = Convert.ToInt32(Console.ReadLine());
                        switch(sqlChoise){
                                case 1:
                                        Abonement2000.showMenu();      
                                break;
                                case 2:
                                        getEAI_ANONLog();      
                                break;
                                case 3:
                                        getPreparationsBefore();      
                                break;     
                                default:
                                break;
                        }  
    }

    public static void getLWSLog(){
        Console.WriteLine("SELECT * FROM SIEBEL.CX_LOY_LOG WHERE SERVICE_NAME = 'имя LWS' AND CARD_NUM = 'номер карты'");
    }

    public static void getEAI_ANONLog(){
        Console.WriteLine("SELECT * FROM SIEBEL.CX_INT_LOG WHERE NAME = 'Имя сервиса'");
    }

    public static void getPreparationsBefore(){
        Console.WriteLine("Введите дату в формате yyyy/mm/dd HH24:MI:SS, например 2024/10/17 12:00:00");
        string? date = Console.ReadLine();
        Console.WriteLine("/*отчет по проверке изменений в схеме и манифестах\n"
        +"/*Перед SMA необходимо выполнить на DEV контуре селекты ниже. Они не должны возвращать строк.\n"
        +"Если хотябы один из селектов вернул строки, необходимо обратиться к Архитекутору сопровождающему поставку, за разъяснениями.\n"
        +"Если строки не вернулись, то можно запускать SMA.*/\n"
        +"select * from siebel.s_rr_obj_item i where type_cd='Table'"
        +$" and i.last_upd >= TO_DATE ('{date}', 'yyyy/mm/dd HH24:MI:SS') order by created desc;\n"
        +"select c.last_upd,c.name,t.name from siebel.s_column c, siebel.s_table t where t.row_id=c.tbl_id"
        +$" and c.last_upd>to_date('{date}', 'yyyy/mm/dd HH24:MI:SS') order by c.last_upd desc;\n"
        +"select ic.created,ic.last_upd,ic.name,t.name from siebel.s_index_column ic, siebel.s_table t, siebel.s_index ind\n"
        +"where t.row_id=ind.tbl_id \nand ind.row_id=ic.index_id\n"
        +$"and ic.last_upd >= TO_DATE ('{date}', 'yyyy/mm/dd HH24:MI:SS')\n"
        +"order by ic.last_upd desc;\n"
        +"select ind.created,ind.last_upd,t.name,ind.name from  siebel.s_index ind , siebel.s_table t\n"
        +"where t.row_id=ind.tbl_id \n"
        +$"and ind.last_upd >= TO_DATE ('{date}', 'yyyy/mm/dd HH24:MI:SS')\n"
        +"order by ind.last_upd desc;\n"
        +"select distinct(fl.name) from S_UI_OBJECT obj\n"
        +"join S_UI_OBJ_EXPR expr on (obj.row_id=expr.UI_OBJECT_ID)\n"
        +"join S_UI_OBJ_EXP_FL exfl on (expr.row_id=exfl.UI_OBJ_EXPR_ID)\n"
        +"join S_UI_FILE fl on (exfl.UI_FILE_ID = fl.row_id)\n"
        +"where\n"
        +$"obj.last_Upd >= TO_DATE ('{date}', 'yyyy/mm/dd HH24:MI:SS');\n"
        +$"Select row_id,name,last_upd from  siebel.S_ESCL_OBJECT s where last_upd >  TO_DATE ('{date}', 'yyyy/mm/dd HH24:MI:SS') and inactive_flg='N';\n"
        +$"Select row_id,name,last_upd from siebel.S_ASGN_ITEM_TYPE t where last_upd >  TO_DATE ('{date}', 'yyyy/mm/dd HH24:MI:SS') and inactive_flg='N';\n"
        +$"select row_id,name,last_upd from  siebel.S_ASGN_ATTR a where last_upd >  TO_DATE ('{date}', 'yyyy/mm/dd HH24:MI:SS') and inactive_flg='N';\n"
        +$"select row_id,name,last_upd from siebel.S_ASGN_OBJECT where last_upd >  TO_DATE ('{date}', 'yyyy/mm/dd HH24:MI:SS') and inactive_flg='N';");

        












    }
}