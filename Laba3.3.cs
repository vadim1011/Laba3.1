Console.Write("Введите значение x:");
double x = double.Parse(Console.ReadLine());
double t = (x - 1) / (x + 1);
double sum = 0;
for (int i = 1; i <= 5; i++)
{
    double chlen = 0;
    double stepen = 2 * i - 1;
    switch (stepen)
    {
        case double s when s > 0:
            double koeffitsient = 1.0 / s;
            chlen = koeffitsient * Math.Pow(t, s);
            break;
        default:
            chlen = 0;
            break;
    }
    sum += chlen;
    Console.WriteLine($"Член {i}: {chlen}");
}
Console.WriteLine($"Сумма ряда: {sum}");
