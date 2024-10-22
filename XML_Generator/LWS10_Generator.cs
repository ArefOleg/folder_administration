using System.Xml.Serialization;
using XML_Head;
using XML_LWS10;
namespace LWS10Generator;
public class LWS10_Generator : EAI_Anon_Generator{
    public LWS10_Generator(string name)
     : base(name){
        this.xser = new XmlSerializer(typeof(LWS10));
            JET_spcLWS10_spc_Input jET_SpcLWS10_Spc_Input = new JET_spcLWS10_spc_Input();
            LWS10_Body lWS10_Body = new LWS10_Body();
            LWS10 lWS10 = new LWS10();
            lWS10.lWS10_Body = lWS10_Body;
            lWS10.header_Eai_Anon_UserName_Token = this.header_Eai_Anon_UserName_Token;
            lWS10_Body.jET_SpcLWS10_Spc_Input = jET_SpcLWS10_Spc_Input;
            xser.Serialize(xml, lWS10, ns); 
            setNameSpaces();
    }
}