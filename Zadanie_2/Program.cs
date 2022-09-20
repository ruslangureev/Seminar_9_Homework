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

void SumNumber(int arg1, int arg2, int sum)
{
    if (arg1 == arg2)
    {
        sum += arg1;
        Console.WriteLine($" {sum}");
        return;
    }
    if (arg1 < arg2)
    {
        sum += arg1;
        SumNumber(arg1 + 1, arg2, sum);
    }
}

int sum = 0;
Console.Write($"Ответ: сумма натуральных чисел от {m} до {n}:");
SumNumber(m, n, sum);