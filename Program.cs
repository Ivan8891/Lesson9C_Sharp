
int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string PrintNumber(int n)
{
    if(n == 1)
    {
        return n.ToString();
    }
    return n + " " + PrintNumber(n - 1);
}

//Console.WriteLine(PrintNumber(EnterNumber("Введите число для старта: ")));

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

Console.WriteLine(PrintSum(EnterNumber("Введите число M: "), EnterNumber("Введите число N: ")));