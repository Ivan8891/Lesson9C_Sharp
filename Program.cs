
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

Console.WriteLine(PrintNumber(EnterNumber("Введите число для старта: ")));