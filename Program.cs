// Задача 41. Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"Введите {i+1}-е число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

System.Console.Write("Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
System.Console.WriteLine($"Введены числа {string.Join(", ", array)}");
Console.WriteLine($"Количество чисел больше нуля равно {CountPositive(array)}");
*/



// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// проверка k1=k2 - прямые параллельны
// проверка b1=b2 - прямые совпадают

/*
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}

else if (b1 == b2)
{
    Console.WriteLine("Прямые совпадают");
}

else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Точка пересечения двух прямых х = {Math.Round(x, 2)}, y = {Math.Round(y, 2)}");
}
*/