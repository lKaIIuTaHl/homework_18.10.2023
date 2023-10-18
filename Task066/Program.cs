// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumElements(int numM, int numN)
{
    if (numN == numM) return numM;
    if (numM > numN)
    {
        return numN + SumElements(numM,numN + 1) ;
    }
    return numN + SumElements(numM,numN - 1);
} 
Console.Write("Введите число M : ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N : ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber < 1 || secondNumber < 1)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

int result = SumElements(firstNumber, secondNumber);
Console.WriteLine($"M = {firstNumber}; N = {secondNumber} -> {result}");