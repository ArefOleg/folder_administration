using System.Xml.Serialization;
using XML_Head;
namespace XML_LWS8;
public class JETLWS8GetTransactions_1_Input{
    [XmlElement("CardNumber", Namespace = "cusE")]
    public string CardNumber;
    [XmlElement("PageSize", Namespace = "cusE")]
    public string PageSize;
    [XmlElement("Source", Namespace = "cusE")]
    public string Source = "МП";
    [XmlElement("StartRowNum", Namespace = "cusE")]
    public string StartRowNum = "1";
    [XmlElement("StartDate", Namespace = "cusE")]
    public string StartDate = "Teboil";
    [XmlElement("EndDate", Namespace = "cusE")]
    public string EndDate;
    public JETLWS8GetTransactions_1_Input(){
        Console.WriteLine("Введите номер карты");
        Console.WriteLine("DEV 7030040020000577\nTEST 7030040020015959\nPRE 7030040016723301");
        this.CardNumber = Console.ReadLine();
        Console.WriteLine("Введите количество записей, которое хотите увидеть");
        this.PageSize = Console.ReadLine();
        Console.WriteLine("Введите начальный промежуток даты транзакций");
        Console.WriteLine("Например 10/15/2023 ММ/ДД/Год");
        this.StartDate = Console.ReadLine();
        Console.WriteLine("Введите конечный промежуток даты транзакций");
        Console.WriteLine("Например 10/15/2025 ММ/ДД/Год");
        this.EndDate = Console.ReadLine();
    }

}
public class JETLWS8Body{
    [XmlElement("JETLWS8GetTransactions_1_Input", Namespace = "cusE")]
    public JETLWS8GetTransactions_1_Input jETLWS8GetTransactions_1_Input;    
}
[XmlRoot("Envelope", Namespace = "soapenvE")]
public class LWS8{
    [XmlElement("Header", Namespace = "soapenvE")]   
    public Header_Eai_Anon_UserName_Token header_Eai_Anon_UserName_Token; 
    [XmlElement("Body", Namespace = "soapenvE")]
    public JETLWS8Body jETLWS8Body;
    
}
