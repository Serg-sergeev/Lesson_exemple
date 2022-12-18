Console.WriteLine("Данная программа выдает максимальное число из 3 чисел.");
Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число В: ");
int numberB = int.Parse(Console.ReadLine()!);
Console.Write("Введите число С: ");
int numberC = int.Parse(Console.ReadLine()!);
int max = numberA;
if (numberB > max){
    max = numberB;
    if (numberC > max){
        Console.WriteLine($"Число {numberC} больще всех");
    } else {
        Console.WriteLine($"Число {numberB} больше всех");
    }
}  else {
    Console.WriteLine($"Число {numberA} больше всех");
}