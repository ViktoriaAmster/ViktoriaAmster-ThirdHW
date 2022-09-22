// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// Console.WriteLine("Введите число: ");
// long N = Convert.ToInt64(Console.ReadLine());
// long Help = N;
// int Len = 0;

// while (Help > 0)
// {
// Help = Help / 10;
// Len++;
// };

// long[] arr = new long[Len];

// long Num = N;
// for (int i = 0; i < Len; i++)
// {
//     long h= Convert.ToInt64(Math.Pow(10, Len - 1 - i));
//     arr[i] = Num / h;
//     Num = Num % h;
// };

// int k = 0;
// bool Result = true;
// while (k <= Len / 2)
// {
//     if (arr[k] != arr[Len - 1 - k])
//     {
//         Result = false;
//         break;
//     }
//     else {
//         Result = true;
//     }
//     k++;
// }

// if (Result == true) Console.WriteLine("Да! Это палиндром.");
// else Console.WriteLine("Нет! Это не палиндром.");


// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координату Х первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Х второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double D = Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2) + Math.Pow(z1 - z2,2));
Console.WriteLine($"Расстояние равно {Math.Round(D,2)}");