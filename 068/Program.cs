// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Write("Введите число m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m < 0 || n < 0) Console.WriteLine("Введено отрицательое число!");
    int result = FunctionAckermann(m, n);
    Console.WriteLine($"Результат вычисления функции Аккермана c помощью рекурсии A({m},{n}) = {result}.");


int FunctionAckermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return FunctionAckermann(m - 1, 1);
    if (m > 0 && n > 0) return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));
    return FunctionAckermann(m, n);
}