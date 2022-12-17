Console.WriteLine("Данная программа по номеру определяет день недели.");
int numberDate;
Console.Write("Введиьте число (от 0 до 6): ");
numberDate = int.Parse(Console.ReadLine()!);
switch (numberDate) {
    case 0 :
    {
        Console.WriteLine("Это воскресенье!");
        break;
    }

    case 1 :
    {
        Console.WriteLine("Это понедельник!");
        break;
    }

    case 2 :
    {
        Console.WriteLine("Это вторник!");
        break;
    }

    case 3 :
    {
        Console.WriteLine("Это среда!");
        break;
    }

    case 4 :
    {
        Console.WriteLine("Это четверг!");
        break;
    }

    case 5 :
    {
        Console.WriteLine("Это пятница!");
        break;
    }

    case 6 :
    {
        Console.WriteLine("Это суббота!");
        break;
    }

    default: 
    {
        Console.WriteLine("Вы превысили диапозон или ввели не число.");
        break;
    }
}
