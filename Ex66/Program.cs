// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120

Console.Write("Enter first natural number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second natural number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber <= 0 || secondNumber <= 0)
{
    Console.WriteLine("Error. Numbers aren't natural");
}
else 
{
    Console.WriteLine(PrintSumNumbers(firstNumber, secondNumber));
}

int PrintSumNumbers(int num1, int num2)
{
    if (num1 == num2)
    {
        return num1;
    }

    if (num1 < num2)
    {
        return num1 + PrintSumNumbers(num1 + 1, num2);
    }

    return num2 + PrintSumNumbers(num2 + 1, num1);
}


