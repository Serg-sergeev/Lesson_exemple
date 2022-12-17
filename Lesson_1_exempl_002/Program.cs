int numberA, numberB;
Console.WriteLine("Данная программа проверяет является ли второе число квадратом первого.");
Console.Write("Введите число А: ");
numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число В: ");
numberB = int.Parse(Console.ReadLine());
if ((numberA * numberA) == numberB){
    Console.WriteLine($"Число {numberB} является квадратом числа {numberA}.");
} else {
    Console.WriteLine($"Число {numberB} НЕ является квадратом числа {numberA}.");
}

