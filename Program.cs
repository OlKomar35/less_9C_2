// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumNums(int m, int n)
{
    if (n == m) { return n; }
    else if (n < m)
    {
        return n + SumNums(n + 1, m);
    }
    else
    {
        return m + SumNums(m + 1, n);
    }
}

Console.Write("Введите m= ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n= ");
int n = Convert.ToInt32(Console.ReadLine());

int result = SumNums(m, n);
Console.WriteLine($"Сумму натуральных элементов в промежутке от M до N= {result}");