// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30    4 + 5 + 6 + 7 + 8 = 30 

// Поскольку даже между положительным и отрицательным числами могут быть натуральные числа я пишу функцию для всех вариантов.

Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

int FindSummOfNumbers(int start, int end)
{
    if (start >= 0 && end >= 0)
    {
        if(start <= end)
        {
            if (start == end) return start;
            int summ = start + FindSummOfNumbers(start + 1, end);
            return summ;
        }
        else 
        {
            if (start == end) return end;
            int summ = end + FindSummOfNumbers(start, end + 1);
            return summ;
        }
    }
    else if (start < 0 && end >= 0)
    {
        start = 0;
        if (start == end) return start;
        int summ = start + FindSummOfNumbers(start + 1, end);
         return summ;
    }
    else if (start >= 0 && end < 0)
    {
        end = 0;
        if (start == end) return end;
         int summ = end + FindSummOfNumbers(start, end + 1);
         return summ;
    }
    else 
    {
        Console.WriteLine("Оба числа отрицательные, в промежутке между ними нет натуральных чисел для сложения!");
        return 0;
    }
}

Console.WriteLine(FindSummOfNumbers(M, N));