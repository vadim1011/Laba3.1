//Лабараторная 3.1
int s = 0;
int n = 1;
do
{
    if (n % 9 == 0)
    {
        s += n;
    }
    n++;
} while (n <= 10);
Console.WriteLine($"Сумма положительных чисел кратных 9: {s}");