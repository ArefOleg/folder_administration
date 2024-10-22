
public static class Hard_Query{
    public static void innerJoinSelect(){
        string path = "InnerJoinSelect.txt";
        string inputText = "SELECT card.card_num, sla.value as_is_coupon,"
        +" slap.counter_delimeter to_be_coupon, sla2.value as abonement_counter\n" 
        +" FROM SIEBEL.S_LOY_ATTRIB\n"
        +" sla INNER JOIN SIEBEL.S_LOY_CARD card ON sla.member_id = card.member_id\n"
        +" INNER JOIN (SELECT MEMBER_ID, floor(TO_NUMBER(VALUE)/2) counter_delimeter"
        +" FROM SIEBEL.S_LOY_ATTRIB sla WHERE sla.attrib_defn_id = '1-6SJR7ZPX' ) slap ON"
        +" sla.member_id = slap.member_id\n"
        +" INNER JOIN SIEBEL.S_LOY_ATTRIB sla2 ON sla.member_id = sla2.member_id"
        +" AND sla2.attrib_defn_id = '1-6SJR7ZPX'\n"
        +" where sla.attrib_defn_id = '1-6SJR7ZPY' AND TO_NUMBER(sla.VALUE) > slap.counter_delimeter;"
    }
    using (StreamWriter writer = new StreamWriter(path, false)){
            await writer.WriteLineAsync(inputText);
        }

}



/*SELECT card.card_num, sla.value as_is_coupon, slap.counter_delimeter to_be_coupon, sla2.value as abonement_counter
 FROM SIEBEL.S_LOY_ATTRIB
  sla INNER JOIN SIEBEL.S_LOY_CARD card ON sla.member_id = card.member_id
  INNER JOIN (SELECT MEMBER_ID, floor(TO_NUMBER(VALUE)/2) counter_delimeter FROM SIEBEL.S_LOY_ATTRIB sla WHERE sla.attrib_defn_id = '1-6SJR7ZPX' ) slap ON sla.member_id = slap.member_id
   INNER JOIN SIEBEL.S_LOY_ATTRIB sla2 ON sla.member_id = sla2.member_id AND sla2.attrib_defn_id = '1-6SJR7ZPX'
   where sla.attrib_defn_id = '1-6SJR7ZPY' AND TO_NUMBER(sla.VALUE) > slap.counter_delimeter;*/