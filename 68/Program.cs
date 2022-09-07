int n = InputNumbers("Введите значение (n)");
int m = InputNumbers("Введите значение (m)");

int functionAkkerman = Akkerman(m,n);

Console.WriteLine($"Функция Аккермана = {functionAkkerman}");


int Akkerman(int m, int n)
{
    if(m == 0) return n+1;
    else if (n == 0) return Akkerman(m-1, 1);
    else return Akkerman(m-1, Akkerman(m, n -1));
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
return output;
}


Console.WriteLine();
