using System.Xml.Serialization;
using XML_Head;
using XML_LWS8;
namespace LWS8Generator;
public class LWS8_Generator : EAI_Anon_Generator{
    public LWS8_Generator(string name)
     : base(name){
        this.xser = new XmlSerializer(typeof(XML_LWS8.LWS8));
        JETLWS8GetTransactions_1_Input jETLWS8GetTransactions_1_Input =
        new JETLWS8GetTransactions_1_Input();
        JETLWS8Body jETLWS8Body =
        new JETLWS8Body();
        LWS8 lWS8 = new LWS8();
        lWS8.jETLWS8Body = jETLWS8Body;
        lWS8.header_Eai_Anon_UserName_Token = header_Eai_Anon_UserName_Token;
        jETLWS8Body.jETLWS8GetTransactions_1_Input = jETLWS8GetTransactions_1_Input;
        xser.Serialize(xml, lWS8, ns);
        setNameSpaces();
    }
}