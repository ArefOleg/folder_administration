public static class TechInfo{
    public static void techMenu(){
        Console.WriteLine("1 - Информация о АДМ на DEV\n2 - Доступы к средам\n3 - Информация для апплая\n"
        + "\n4 Как узнать расположение tns\n5 Доступы");
        int techChoise = Convert.ToInt32(Console.ReadLine());
        switch(techChoise){
            case 1:
                Console.WriteLine("Ввести при выгрузке ADM /opt/siebel/fs/adm");
                break;            
            case 2:
                Console.WriteLine("DEV: ORACLE_SERVER - 10.30.17.12, WIN_SERVER - 10.30.17.11\n"
                + "TEST: ORACLE_SERVER - 10.30.15.86, WIN_SERVER - 10.30.15.85");

                break;
            case 3:
                Console.WriteLine("Table space DATA01\nIndex space INDEX01\nSIEBEL/WseJ3oid");     
            break;
            case 4:
                Console.WriteLine("В PL SQL открыть SupportInfo");     
            break;
            default:
            break;
        }
    }
}