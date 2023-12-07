// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(n,m) = 29

Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());

int Ackerman(int n, int m)
{
    if(n == 0) return m + 1;
    else if (m == 0) return Ackerman(n -1, 1);
    else 
    {
        return Ackerman(n -1, Ackerman(n, m - 1));
    }
}

// int Ack2(int n, int m)
//     {
//         if(n == 0)
//         {
//             return m + 1;
//         } 
//         else if (m == 0)
//         {
//             return Ack2(n - 1, 1);
//         } 
//         else 
//         {
//             return Ack2(n - 1, Ack2(n, m - 1));
//         }
//     }

Console.WriteLine(Ackerman(N, M));
