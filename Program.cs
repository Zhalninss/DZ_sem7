// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// void ShowNumbers (int M, int N)
// {

// if(M == N) 
// {
// Console.Write(M);
// return;
// }
// Console.Write(M + ","); 
// ShowNumbers(M + 1, N);
// }


// ShowNumbers(M, N);


// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

// Console.WriteLine("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int akkerman(int m, int n)
// {
// if (m == 0) 
// return n + 1;
// else if (n == 0) 
// return akkerman(m - 1, 1);
// else return akkerman(m - 1, akkerman(m, n - 1));
// }

// Console.Write($"Функция Аккермана равна {akkerman(m, n)} ");



// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


int [] arr = {1, 2, 5, 0, 10, 34};
int size = arr.Length;


void ShowArrayReverse(int[]arr, int size)
int j = size - 1;

if (j == 0)
{
    Console.Write(arr[j]);
    return;
}
