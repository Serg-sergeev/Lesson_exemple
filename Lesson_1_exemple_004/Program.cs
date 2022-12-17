Console.WriteLine("Данная программа принимает на вход число N и на выходе показывает все целые числа от -N до N");
Console.Write("Введите положительное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number < 0) {
    Console.WriteLine("Вы ввели не положтельное число.");
}
else {
    int i = -number;

    while (i <= number)
    {
        Console.Write($"{i} ");
        i++;
    }
}

