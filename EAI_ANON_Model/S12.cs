using System.Xml.Serialization;
using XML_Head;

public class S12_PersonalAddress{
    [XmlElement("Street", Namespace = "jetE")]
    public string Street;
    [XmlElement("House", Namespace = "jetE")]
    public string House;
    [XmlElement("Flat", Namespace = "jetE")]
    public string Flat;
    [XmlElement("District", Namespace = "jetE")]
    public string District;
    [XmlElement("Corps", Namespace = "jetE")]
    public string Corps;
    [XmlElement("City", Namespace = "jetE")]
    public string City;
    [XmlElement("Region", Namespace = "jetE")]
    public string Region;
    [XmlElement("Index", Namespace = "jetE")]
    public string Index;
    [XmlElement("Country", Namespace = "jetE")]
    public string Country;
    [XmlElement("Type", Namespace = "jetE")]
    public string Type;
    [XmlElement("Id", Namespace = "jetE")]
    public string Id;
    public S12_PersonalAddress(){
        Console.WriteLine("Адрес");
        Console.WriteLine("Введите страну");
        this.Country = Console.ReadLine();
        Console.WriteLine("Введите регион");
        this.Region = Console.ReadLine();
        Console.WriteLine("Введите город");
        this.City = Console.ReadLine();
        Console.WriteLine("Введите индекс");
        this.Index = Console.ReadLine();
        Console.WriteLine("Введите район");
        this.District = Console.ReadLine();
        Console.WriteLine("Введите улицу");
        this.Street = Console.ReadLine();
        Console.WriteLine("Введите дом");
        this.House = Console.ReadLine();
        Console.WriteLine("Введите корпус");
        this.Corps = Console.ReadLine();
        Console.WriteLine("Введите квартиру");
        this.Flat = Console.ReadLine();
        this.Type = "Домашний";
    }
}

public class ListOfPersonalAddress{
    [XmlElement("ListOfPersonalAddress", Namespace = "jetE")]
    public S12_PersonalAddress s12_PersonalAddress;
}
public class S12_Contact{
    [XmlElement("YlUserName", Namespace = "jetE")]
    public string YlUserName;
    [XmlElement("YlPassword", Namespace = "jetE")]
    public string YlPassword;
    [XmlElement("WorkPhone", Namespace = "jetE")]
    public string WorkPhone;
    [XmlElement("SinceDate", Namespace = "jetE")]
    public string SinceDate;
    [XmlElement("SecurityAnswer", Namespace = "jetE")]
    public string SecurityAnswer;
    [XmlElement("NewCardNumber", Namespace = "jetE")]
    public string NewCardNumber;
    [XmlElement("MiddleName", Namespace = "jetE")]
    public string MiddleName;
    [XmlElement("LastName", Namespace = "jetE")]
    public string LastName;
    [XmlElement("LanguageCode", Namespace = "jetE")]
    public string LanguageCode="RUS";
    [XmlElement("JETSignFlag", Namespace = "jetE")]
    public string JETSignFlag;
    [XmlElement("JETRegistrationSource", Namespace = "jetE")]
    public string JETRegistrationSource="МП";
    [XmlElement("JETOSI", Namespace = "jetE")]
    public string JETOSI="WIN_10";
    [XmlElement("JETMarketingCampaignAgreement", Namespace = "jetE")]
    public string JETMarketingCampaignAgreement;
    [XmlElement("FirstName", Namespace = "jetE")]
    public string FirstName;
    [XmlElement("EmailAddress", Namespace = "jetE")]
    public string EmailAddress;
    [XmlElement("CellularPhone", Namespace = "jetE")]
    public string CellularPhone;
    [XmlElement("BirthDate", Namespace = "jetE")]
    public string BirthDate;
    [XmlElement("Status", Namespace = "jetE")]
    public string Status;
    [XmlElement("MF", Namespace = "jetE")]
    public string MF;
    [XmlElement("ListOfPersonalAddress", Namespace = "jetE")]
    public ListOfPersonalAddress listOfPersonalAddress;
    public S12_Contact(){
        Console.WriteLine("Введите номер карты для регистрации, для этого нужна карта в статусе Новая");        
        this.NewCardNumber = Console.ReadLine();
        Console.WriteLine("Введите Логин");        
        this.YlUserName = Console.ReadLine();
        Console.WriteLine("Введите пароль");        
        this.YlPassword = Console.ReadLine();
        Console.WriteLine("Введите имя");        
        this.FirstName = Console.ReadLine();
        Console.WriteLine("Введите фамилию");        
        this.LastName = Console.ReadLine();
        Console.WriteLine("Введите отчество");        
        this.MiddleName = Console.ReadLine();
        Console.WriteLine("Введите рабочий телефон или можно использовать " +
        "+7" + DateTime.Now.ToString("mmddhhmmss"));      
        this.WorkPhone = Console.ReadLine();
        Console.WriteLine("Наличие подписи в анкете Y/N");        
        this.JETSignFlag = Console.ReadLine();
        Console.WriteLine("Согласие на маркетинговые рассылки Y/N");   
        this.JETMarketingCampaignAgreement = Console.ReadLine();
        Console.WriteLine("Введите почту");   
        this.EmailAddress = Console.ReadLine();
        Console.WriteLine("Введите мобильный телефон или можно использовать " +
        "+7" + DateTime.Now.ToString("mmddhhmmss"));  
        this.CellularPhone = Console.ReadLine();
        Console.WriteLine("Введите дату рождения например 08/15/1992 ММ/ДД/Год");   
        this.BirthDate = Console.ReadLine();
        Console.WriteLine("Введите пол");   
        this.MF = Console.ReadLine();
        Console.WriteLine("Введите дату участия например 10/15/2023 ММ/ДД/Год");   
        this.SinceDate = Console.ReadLine();
        Console.WriteLine("Кодовое слово");   
        this.SecurityAnswer = Console.ReadLine();
    }
}

public class ListOfContact{    
    [XmlElement("Contact", Namespace = "jetE")]
    public S12_Contact s12_Contact;
}

public class JET_spcS12_spcCreate_spcAnketa{
    [XmlElement("ListOfContact", Namespace = "jetE")]
    public ListOfContact listOfContact;
    [XmlElement("SourceSystem", Namespace = "cusE")]
    public string SourceSystem = "МП";
}

public class JET_spcS12_Body{
    [XmlElement("JET_spcS12_spcCreate_spcAnketa_spcContact_spcWF_spc-_spcNL_Input", Namespace = "cusE")]
    public JET_spcS12_spcCreate_spcAnketa jET_SpcS12_SpcCreate_SpcAnketa;
}


[XmlRoot("Envelope", Namespace = "soapenvE")]
public class S12{
    [XmlElement("Header", Namespace = "soapenvE")]   
    public Header_Eai_Anon_UserName_Token header_Eai_Anon_UserName_Token; 
    [XmlElement("Body", Namespace = "soapenvE")]
    public JET_spcS12_Body jET_SpcS12_Body;
    
}