Console.Write("Введите вещественное число X: ");
double X = double.Parse(Console.ReadLine());
Console.Write("Введите целое число N (> 0): ");
int N = int.Parse(Console.ReadLine());
if (N <= 0)
{
    Console.WriteLine("Ошибка: N должно быть больше 0.");
    return;
}
double sum = 1.0;
for (int k = 1; k <= N; k++)
{
    double term = Math.Pow(X, 2 * k) / (2 * k);
    if (k % 2 == 1)
        sum -= term;
    else
        sum += term;
}
Console.WriteLine($"Результат: {sum}");
