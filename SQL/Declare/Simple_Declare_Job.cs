namespace sqlDeclares;
public static class sqlDeclare{
    public static async void GenerateSql(){
        string path = "Declare.txt";
        string inputText = "DECLARE\n" 
        + " counter integer:=0;\n batch_size integer:=0;\n _id varchar2(15 char):='';"
        + " cursor C IS SELECT ROW_ID FROM SIEBEL.S_ORG_SRV_LOC\n WHERE PARAM = 'VALUE'\n ORDER BY CREATED DESC;\n"
        + " begin\n  for vrec in C\n  loop\n   counter := counter + 1;\n"
        + "   insert/update/delete\n  end loop\n end;";

        using (StreamWriter writer = new StreamWriter(path, false)){
            await writer.WriteLineAsync(inputText);
        }
    }
}