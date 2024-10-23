Console.WriteLine("Выберите тип работы:");

string exit = "N";
while (!exit.Equals("exit")){
        Menu.showMenu();
        Console.WriteLine("Нажмите любую клавишу для продолжения, или введите exit для выхода.");
        exit = Console.ReadLine();
}






