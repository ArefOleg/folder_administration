using System.Xml.Serialization;
using XML_Head;
using XML_LWS10;
namespace S12Generator;
public class S12_Generator : EAI_Anon_Generator{
    public S12_Generator(string name)
     : base(name){
        this.xser = new XmlSerializer(typeof(S21));
        S12_PersonalAddress s12_PersonalAddress =
        new S12_PersonalAddress();
        ListOfPersonalAddress listOfPersonalAddress = 
        new ListOfPersonalAddress();
        listOfPersonalAddress.s12_PersonalAddress = s12_PersonalAddress;
        S12_Contact s12_Contact =
        new S12_Contact();
        JET_spcS12_spcCreate_spcAnketa jET_SpcS12_SpcCreate_SpcAnketa =
        new JET_spcS12_spcCreate_spcAnketa();
        JET_spcS12_Body jET_SpcS12_Body = new JET_spcS12_Body();
        jET_SpcS12_Body.jET_SpcS12_SpcCreate_SpcAnketa = jET_SpcS12_SpcCreate_SpcAnketa;
        S12 s12 = new S12();
        ListOfContact listOfContact = new ListOfContact();
        jET_SpcS12_SpcCreate_SpcAnketa.listOfContact = listOfContact;
        s12_Contact.listOfPersonalAddress = listOfPersonalAddress;
        s12.header_Eai_Anon_UserName_Token = header_Eai_Anon_UserName_Token;
        s12.jET_SpcS12_Body = jET_SpcS12_Body;
        xser.Serialize(xml, s12, ns);
        setNameSpaces();
    }
}