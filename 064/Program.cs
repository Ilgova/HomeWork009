// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите любое число N( до  1): ");
int n = Convert.ToInt32(Console.ReadLine());
void RekNum(int n)
{
   
    if (n < 0) 
    Console.WriteLine("Число не входит в заданный промежуток!!!");
    if (n <= 0) 
    return;
    Console.Write("{0,3}",n);
    RekNum (n - 1);
}
RekNum(n);