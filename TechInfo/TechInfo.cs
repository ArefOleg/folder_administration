public static class TechInfo{
    public static void techMenu(){
        Console.WriteLine("1 - Информация о АДМ на DEV\n2 - Доступы к средам\n3 - Информация для апплая");
        int techChoise = Convert.ToInt32(Console.ReadLine());
        switch(techChoise){
            case 1:

                break;            
            case 2:
                break;
            case 3:
                Console.WriteLine("Table space DATA01\nIndex space INDEX01\nSIEBEL/WseJ3oid");     
            break;

        }
    }
}