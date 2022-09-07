int sum = 0;
int i = 0;
void Number(int n, int m)
{
    if (n == m) Console.Write($"{n} ");

    else
    {
        Number(n - 1, m);
        sum += n;
        Console.Write($"{n} ");
        i = m;
    }

}
Console.WriteLine("Введите число (M): ");
if (!int.TryParse(Console.ReadLine(), out var m)!)
{ Console.WriteLine("Ошибка! "); }
Console.WriteLine("Введите число (N): ");
if (!int.TryParse(Console.ReadLine(), out var n)!)
{ Console.WriteLine("Ошибка! "); }

Number(n, m);
Console.WriteLine();
Console.WriteLine($"Сумма чисел от M до N = {sum + i}");