using eszhednevnik;

datas nin = new datas()
{
    numb = 13,
    mon = 10,
    year = 2023,
    flag = false
};
deladny del = new deladny()
{
    delo1 = "  1.Сходить на учёбу",
    delo2 = "  2.Сходить на работу",
    delo3 = "  3.Помочь папе",
    delo4 = "  1.Погулять с другом",
    delo5 = "  2.Почитать книгу",
    delo6 = "  1.Сделать практическую работу",

};
zadach zad = new zadach()
{
    zadacha1 = "Описание: Просидеть 3 пары(это будет считаться победой)",
    zadacha2 = "Описание: Помогать программисту",
    zadacha3 = "Описание: Убрать грязную посуду, почистить камин, вымыть полы по всему замку и собрать зерна с пола, посадить 1001 розу ):",
    zadacha4 = "Описание: Съездить в Авиапарк, подраться с бомжами",
    zadacha5 = "Описание: Прочитай хотябы 20 страниц, а то совсем отубел ",
    zadacha6 = "Описание: Написать код для есжедневника (:",
    
};
int poz = 1;

Menu(nin: nin, del: del);

while(true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    if (key.Key == ConsoleKey.Escape)
    {
        return;
    }
    if (key.Key == ConsoleKey.RightArrow && nin.numb < 30)
    {
        nin.numb += 1;
    }
        

    else if (key.Key == ConsoleKey.LeftArrow && nin.numb > 1)
    {
        nin.numb -= 1;
        
    }
        

    if (key.Key == ConsoleKey.UpArrow && poz != 1)
    {
        poz--;
    }
    else if (key.Key == ConsoleKey.DownArrow && poz != 3)
    {
        poz++;
    }

    Console.Clear();
    Menu(nin: nin, del: del);
    Console.SetCursorPosition(0, poz);
    Console.WriteLine("->");

    if (nin.numb == 13)
    {
        if (poz == 1 && key.Key == ConsoleKey.Enter)
        {
            Console.Clear();
            Console.WriteLine("Дата " + nin.numb + '.' + nin.mon + '.' + nin.year + "год");
            Console.WriteLine("------------------------------");
            Console.WriteLine(zad.zadacha1);
        }

        else if (poz == 2 && key.Key == ConsoleKey.Enter)

        {
            Console.Clear();
            Console.WriteLine("Дата " + nin.numb + '.' + nin.mon + '.' + nin.year + "год");
            Console.WriteLine("------------------------------");
            Console.WriteLine(zad.zadacha2);
        }

        else if (poz == 3 && key.Key == ConsoleKey.Enter)

        {
            Console.Clear();
            Console.WriteLine("Дата " + nin.numb + '.' + nin.mon + '.' + nin.year + "год");
            Console.WriteLine("------------------------------");
            Console.WriteLine(zad.zadacha3);
        }
    }
    else if (nin.numb == 14)
    {
        if (poz == 1 && key.Key == ConsoleKey.Enter)
        {
            Console.Clear();
            Console.WriteLine("Дата " + nin.numb + '.' + nin.mon + '.' + nin.year + "год");
            Console.WriteLine("------------------------------");
            Console.WriteLine(zad.zadacha4);
        }

        else if (poz == 2 && key.Key == ConsoleKey.Enter)
        {
            Console.Clear();
            Console.WriteLine("Дата " + nin.numb + '.' + nin.mon + '.' + nin.year + "год");
            Console.WriteLine("------------------------------");
            Console.WriteLine(zad.zadacha5);
        }
    }
    else if (nin.numb == 12)
    {
        if (poz == 1 && key.Key == ConsoleKey.Enter)
        {
            Console.Clear();
            Console.WriteLine("Дата " + nin.numb + '.' + nin.mon + '.' + nin.year + "год");
            Console.WriteLine("------------------------------");
            Console.WriteLine(zad.zadacha6);
        }
    }


    
    
}


static void Menu(datas nin, deladny del)
{
    Console.WriteLine("Выбранная дата " + nin.numb + '.'+ nin.mon + '.' + nin.year + "год");
    if (nin.numb == 13)
    {
        Console.WriteLine(del.delo1);
        Console.WriteLine(del.delo2);
        Console.WriteLine(del.delo3);
    }
    else if (nin.numb == 14)
    {

        Console.WriteLine(del.delo4);
        Console.WriteLine(del.delo5);
        
          
        
    }
    else if (nin.numb == 12)
    {

        Console.WriteLine(del.delo6);

    }

}


