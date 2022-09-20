int Akkerman(int m, int n)
{
    if (m == 0)
    {
        n = n + 1;
        return n;
    }
    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

Console.Write("Введите положительное число m А(m,n): ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите положительное число n А(m,n): ");
int numberN = int.Parse(Console.ReadLine());

while (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Вы ввели отрицательное число.");
    Console.Write("Введите значение m в функции Аккермана А(m,n): ");
    numberM = int.Parse(Console.ReadLine());
    Console.Write("Введите значение n в функции Аккермана А(m,n): ");
    numberN = int.Parse(Console.ReadLine());
}

int resul = Akkerman(numberM, numberN);
Console.WriteLine($"Функция Аккермана при А({numberM},{numberN}) = {resul}");