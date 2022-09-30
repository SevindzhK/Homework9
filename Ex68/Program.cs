// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

Console.Write("Enter non-negative first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter non-negative second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine()); 

if (firstNumber < 0 || secondNumber < 0)
{
    Console.WriteLine("Error. Numbers aren't non-negative");
}
else 
{
    Console.WriteLine(CalculateAkkermanFunction(firstNumber, secondNumber));
}

int CalculateAkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return CalculateAkkermanFunction(m - 1, 1);
    }

    return CalculateAkkermanFunction(m - 1, CalculateAkkermanFunction(m, n - 1));
}

