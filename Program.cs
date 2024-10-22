Console.WriteLine("Для выхода напишите команду exit");
Console.WriteLine("Выберите тип работы:");

string exit = "N";
while (!exit.Equals("exit")){
        Menu.showMenu();
        exit = Convert.ToString(Console.ReadLine());
}






