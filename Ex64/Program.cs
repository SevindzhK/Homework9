// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"

Console.WriteLine("Enter natural number: ");
int number = Convert.ToInt32(Console.ReadLine()); 

if (number <= 0) 
{
    Console.WriteLine("Error. The number isn't natural number");
}
Console.WriteLine(NumbersRec(number)); 

string NumbersRec(int num)
{
    if (num >= 1) return ($"{num}, " + NumbersRec(num - 1));
    else return String.Empty; 
}

