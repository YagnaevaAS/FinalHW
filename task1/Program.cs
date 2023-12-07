// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

// Поскольку даже между положительным и отрицательным числами могут быть натуральные числа я пишу функцию для всех вариантов.

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

string PrintNumbers (int start, int end)
{
    if (start >= 0 && end >= 0)
    {
        if(start <= end)
        {
            if (start == end) return start.ToString();
            return (start + "\t" + PrintNumbers(start + 1, end));
        }
        else 
        {
            if (start == end) return start.ToString();
            return (end + "\t" + PrintNumbers(start, end + 1));
        }
    }
    else if (start < 0 && end >= 0)
    {
        start = 0;
        if (start == end) return start.ToString();
        return (start + "\t" + PrintNumbers(start + 1, end));
    }
    else if (start >= 0 && end < 0)
    {
        end = 0;
        if (start == end) return start.ToString();
        return (end + "\t" + PrintNumbers(start, end + 1));
    }
    else 
    {
        Console.WriteLine("Оба числа отрицательные, в промежутке между ними нет натуральных чисел!");
        return 0.ToString();
    }
}

Console.WriteLine(PrintNumbers(M, N));

