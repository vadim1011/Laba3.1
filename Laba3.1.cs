//Лабараторная 3.1
int s = 0;
int n = 1;
do
{
    switch (n % 9)
    {
        case 0 when n > 0:
            s += n;
            break;
    }
    n++;
} while (n <= 10);
Console.WriteLine($"Сумма положительных чисел кратных 9: {s}");
