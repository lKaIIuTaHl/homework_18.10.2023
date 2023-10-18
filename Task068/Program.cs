// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FunctionAckermann(int firstNum, int secondNum)
{
    if (firstNum == 0)
    {
        return secondNum + 1;
    }
    else if (secondNum == 0)
    {
        return FunctionAckermann(firstNum - 1, 1);
    }
    return FunctionAckermann(firstNum - 1, FunctionAckermann(firstNum, secondNum - 1));
}
Console.Write("Введите число M : ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N : ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0)
{
    Console.WriteLine("Ошибка ввода!");
    return;
}

int result = FunctionAckermann(m, n);
Console.WriteLine($"m = {m}; n = {n} -> {result}");