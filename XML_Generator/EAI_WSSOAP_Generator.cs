
using System.Xml.Serialization;
using XML_Head;
using XML_LWS2;
using XML_LWS4;

public class EAI_WSSOAP_Generator : XML_Generator{
    Header_LWS header; 
    public EAI_WSSOAP_Generator(string name) : base(name){        
        this.header = new Header_LWS("TEBOIL_INT", "TEBOIL_INT", "None");
        if(name.Equals("LWS2")){
            this.ns.Add("jet", "jetE");
            this.xser = new XmlSerializer(typeof(LWS2));
            XML_LWS2.Body bodyLWS2 = new XML_LWS2.Body();
            Console.WriteLine("Укажите сколько продуктов:");
            int orderCount = Convert.ToInt32(Console.ReadLine());
            List<LineItems> lineItems = new List<LineItems>();
            for(int i = 0; i < orderCount; i++){
                LineItems lineItemsElement = new LineItems();
                lineItems.Add(lineItemsElement);
            }                      
            Order order = new Order(Utilities.OrderUtilities.getFinalAmount(lineItems));
            order.lineItems = lineItems; 
            ListOfJetorderaccrualredemptionrequest listOfJetorderaccrualredemptionrequest  =
            new ListOfJetorderaccrualredemptionrequest();
            listOfJetorderaccrualredemptionrequest.order = order;
            JETLWS2OrderAccrualRedemption_1_Input jETLWS2OrderAccrualRedemption_1_Input =
            new JETLWS2OrderAccrualRedemption_1_Input();
            jETLWS2OrderAccrualRedemption_1_Input.listOfJetorderaccrualredemptionrequest = 
            listOfJetorderaccrualredemptionrequest;
            bodyLWS2.jETLWS2OrderAccrualRedemption_1_Input = jETLWS2OrderAccrualRedemption_1_Input;
            LWS2 lWS2 = new LWS2();
            lWS2.body = bodyLWS2;
            lWS2.header = this.header;
            xser.Serialize(xml, lWS2, ns);
        } else {
            this.xser = new XmlSerializer(typeof(LWS4));
            XML_LWS4.Body body = new XML_LWS4.Body();    
            LWS4 lWS4 = new LWS4();
            lWS4.body = body;
            lWS4.header = this.header;
            xser.Serialize(xml, lWS4, ns);
        }
        Menu.LWSEndPointChoise();
        xml.Close();
        string xmlTextLWS = File.ReadAllText(name + ".xml");
        xmlTextLWS = xmlTextLWS.Replace("cusE", "http://siebel.com/CustomUI")
            .Replace("soapenvE", "http://schemas.xmlsoap.org/soap/envelope/");
        if(name.Equals("LWS2")) xmlTextLWS = xmlTextLWS
        .Replace("jetE", "http://www.siebel.com/xml/JETOrderAccrualRedemptionRequest");
        File.WriteAllText(name + ".xml", xmlTextLWS);        
    }
}