Console.WriteLine("Данная программа принимает на вход число N, а на выходе показывает все четные числа от 1 до N.");
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number % 2 == 0){
    int i = 2;
    while (i <= number){
        Console.Write($"{i} ");
        i += 2;
    }
} else {
    int i = 2;
    while (i < number){
        Console.Write($"{i} ");
        i += 2;
    }
}