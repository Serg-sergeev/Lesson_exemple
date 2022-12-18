Console.WriteLine("Данная программа определяет какое число из двух больше, а какое меньше.");
Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число В: ");
int numberB = int.Parse(Console.ReadLine()!);
if (numberA > numberB) {
    Console.WriteLine($"Число {numberA} больше числа {numberB}");
    Console.WriteLine($"max = {numberA}");
    Console.WriteLine($"min = {numberB}");
} else {
    Console.WriteLine($"Число {numberB} больше числа {numberA}");
    Console.WriteLine($"max = {numberB}");
    Console.WriteLine($"min = {numberA}");    
}