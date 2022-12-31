// Задача 64: Задайте значение N. Напишите программу, которая выведет
//  все натуральные числа в промежутке от 1 до 2. Выполнить с помощью рекурсии. 0.2, +

// 




Console.WriteLine("Введите число");
int N = Convert.ToInt32 (Console.ReadLine());

string PrintNumber(double start, double end)
{
    if (start == end)
    {
        return start.ToString();
    }

    return (start  +"  "+  PrintNumber( (start + 0,2), end));

}
Console.WriteLine(PrintNumber(1, N));
