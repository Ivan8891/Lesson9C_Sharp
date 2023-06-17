
int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Задача 64");
string PrintNumber(int n)
{
    if(n == 1)
    {
        return n.ToString();
    }
    return n + " " + PrintNumber(n - 1);
}

Console.WriteLine(PrintNumber(EnterNumber("Введите число для старта: ")));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int PrintSum(int m, int n)
{
    if(m == n)
    {
        return m;
    }
    return m + PrintSum(m + 1, n);
}
Console.WriteLine("Задача 66");
Console.WriteLine(PrintSum(EnterNumber("Введите число M: "), EnterNumber("Введите число N: ")));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Acker (int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    else if (m != 0 && n == 0)
    {
        return Acker(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Acker(m - 1, Acker(m, n - 1));
    }
    return Acker(m, n);
}
Console.WriteLine("Задача 68");
Console.WriteLine(Acker(EnterNumber("Введите число M: "),EnterNumber("Введите число N: ")));