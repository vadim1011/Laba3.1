Console.Write("Введите значение x:");
double x = double.Parse(Console.ReadLine());
double t = (x - 1) / (x + 1);
double sum = 0;

for (int i = 1; i <= 5; i++)
{
    double stepen = 2 * i - 1;
    double koeffitsient = 1.0 / stepen;
    double chlen = koeffitsient * Math.Pow(t, stepen);
    sum += chlen;
    Console.WriteLine($"Член {i}: {chlen}");
}
Console.WriteLine($"Сумма ряда: {sum}");
    
