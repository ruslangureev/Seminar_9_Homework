Console.WriteLine("Введите целое положительное число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите ещё одно целое положительное число, больше первого");
int n = int.Parse(Console.ReadLine());
while (m < 0 || n < 0)
{
    if (m < 0)
    {
        Console.Write("Вы ввели отрицательное первое число. Введите число заново : ");
        m = int.Parse(Console.ReadLine());
    }
    if (n < 0)
    {
        Console.Write("Вы ввели отрицательное второе число. Введите число заново : ");
        n = int.Parse(Console.ReadLine());
    }
}
while (m >= n)
{
    Console.Write("Вы ввели второе число меньше чем первое. ");
    Console.Write("Введите второе число, больше первого: ");
    n = int.Parse(Console.ReadLine());    
}

void NaturalNumber(int arg1, int arg2)
{
    if (arg1 == arg2)
    {
        Console.WriteLine($" {arg1}");
        return;
    }
    if (arg1 < arg2)
    {
        Console.Write($" {arg1},");
        NaturalNumber(arg1 + 1, arg2);
    }
}

Console.Write($"Ответ: натуральные числа от {m} до {n}:");
NaturalNumber(m, n);