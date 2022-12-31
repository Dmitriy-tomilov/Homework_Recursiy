// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число");
int M = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите второе число");
int N = Convert.ToInt32 (Console.ReadLine());


string SumNumber(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    if (start>end)
    {
        return ("Числа введены некорректно");
    }
    int sum = 0;
    sum = SumNumber + Sum;


    return (start  +"  "+  SumNumber( (start + 1), end));

}
Console.WriteLine(sum);
