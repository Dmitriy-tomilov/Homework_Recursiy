// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите первое число");
int M = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите второе число");
int N = Convert.ToInt32 (Console.ReadLine());

string Number(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    if (start>end)
    {
        return ("Числа введены некорректно");
    }
    
    if ( start <= end)
    {
        
    }
    return (start  +"  "+  Number( (start + 1), end));

}
Console.WriteLine();
