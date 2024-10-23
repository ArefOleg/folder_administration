using System.Xml.Serialization;
using XML_Head;

public class JET_S21_Get_Client_Info_Input{
    [XmlElement("LoginLK", Namespace = "cusE")]
    public string LoginLK;
    [XmlElement("ProgramName", Namespace = "cusE")]
    public string ProgramName = "Teboil";
    [XmlElement("Source", Namespace = "cusE")]
    public string Source = "МП";
    public JET_S21_Get_Client_Info_Input(){
        Console.WriteLine("Введите номер карты по которой хотите получить информацию");
        Console.WriteLine("DEV 7030040020000577\nTEST 7030040020015959\nPRE 7030040016723301");
        this.LoginLK = Console.ReadLine();
    }
}
public class S21_Body{
    [XmlElement("JET_S21_Get_Client_Info_Input", Namespace = "cusE")]
    public JET_S21_Get_Client_Info_Input jET_S21_Get_Client_Info_Input;    
}
[XmlRoot("Envelope", Namespace = "soapenvE")]
public class S21{
    [XmlElement("Header", Namespace = "soapenvE")]   
    public Header_Eai_Anon_UserName_Token header_Eai_Anon_UserName_Token; 
    [XmlElement("Body", Namespace = "soapenvE")]
    public S21_Body s21_Body;
    
}