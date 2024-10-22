using System.Xml.Serialization;
using XML_Head;
using XML_LWS10;
namespace LWS10Generator;
public class S21_Generator : EAI_Anon_Generator{
    public S21_Generator(string name)
     : base(name){
        this.xser = new XmlSerializer(typeof(S21));
        JET_S21_Get_Client_Info_Input jET_S21_Get_Client_Info_Input =
        new JET_S21_Get_Client_Info_Input();
        S21_Body s21_Body =
        new S21_Body();
        S21 s21 = new S21();
        s21.s21_Body = s21_Body;
        s21.header_Eai_Anon_UserName_Token = header_Eai_Anon_UserName_Token;
        s21_Body.jET_S21_Get_Client_Info_Input = jET_S21_Get_Client_Info_Input;
        xser.Serialize(xml, s21, ns);
        setNameSpaces();
    }
}