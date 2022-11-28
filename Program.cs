//                                   ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 8

// //ЗАДАЧА 54. Задайте двумерный массив. Напишите программу, 
// //           которая упорядочит по убыванию элементы каждой строки двумерного массива

// int [,] FullTwoArray(int m, int n)
// {
//     int [,] array = new int [m, n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             array [i, j] = new Random().Next(0, 20);
//         }
//     }
//     return array;
// }

// void PrintTwoArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("{0, 5}", array [i, j] + "|");
//         }
//         Console.WriteLine("\b.");
//     }
// }

// int [,] RankingElementsRowArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         int max = array [i, 0];
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1); k++)
//             {
// 				for (int l = 0; l < array.GetLength(1) - 1; l++)
//                 {
// 					if (array[i, l] < array[i, l + 1])
// 					{
// 						int temp = array[i, l + 1];
// 						array[i, l + 1] = array[i, l];
// 						array[i, l] = temp;
// 					}
//                 }
//             }
//         }
//     }
//     return array;
// }

// int [,] newTwoArray = FullTwoArray(5, 5);
// Console.WriteLine("The original array:");
// PrintTwoArray(newTwoArray);
// Console.WriteLine("The ranked array:");
// PrintTwoArray(RankingElementsRowArray(newTwoArray));



// // ЗАДАЧА 56. Задайте прямоугольный двумерный массив. 
// //            Напишите программу, которая будет находить строку с наименьшей суммой элементов

// int [,] FullTwoArray(int m, int n)
// {
//     int [,] array = new int [m, n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             array [i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }

// void PrintTwoArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("{0, 5}", array [i, j] + "|");
//         }
//         Console.WriteLine("\b.");
//     }
// }

// void MinSumStringArray(int [,] array)
// {
//     int [] sumArray = new int [array.GetLength(0)];
    
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array [i, j];
//         }
//         sumArray [i] = sum;
//     }
//     int minString = 0;
//     int min = sumArray [0];
//     for(int i = 1; i < sumArray.Length; i++)
//     {
//         if(sumArray [i] < min)
//         {
//             min = sumArray [i];
//             minString = i;
//         }
//     }
//     Console.WriteLine($"The row the array with the smallest sum of the elements is the row number {minString} with the sum of {min}: ");
//     for(int i = 0; i < array.GetLength(1); i++)
//     {
//         Console.Write("{0, 5}", array [minString, i] + "|");
//     }
//     Console.WriteLine("\b.");
// }


// int [,] newTwoArray = FullTwoArray(5, 3);
// Console.WriteLine("The original array:");
// PrintTwoArray(newTwoArray);
// MinSumStringArray(newTwoArray);

// // ЗАДАЧА 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// int [,] FullTwoArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     int row = 0;
//     int col = 0;
//     int dx = 1;
//     int dy = 0;
//     int dirChanges = 0;
//     int gran = n;

//     for (int i = 0; i < array.Length; i++)
//     {
//        array [col, row] = i + 1;
//        if (--gran == 0)
//             {
//                 gran = n * (dirChanges % 2) + m * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
//                 int temp = dx;
//                 dx = -dy;
//                 dy = temp;
//                 dirChanges++;
//             }
//             col += dy;
//             row += dx;
//     }
//     return array;
 
// }      

// void PrintTwoArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("{0, 3}", array [i, j] + "|");
//         }
//         Console.WriteLine("\b.");
//     }
// }

// int [,] newTwoArray = FullTwoArray(4, 4);
// PrintTwoArray(newTwoArray);








//                                          ЗАДАЧИ СЕМИНАРА 8

// // ЗАДАЧА 1. Задайте двумерный массив. Напишите программу, 
// //           которая поменяет местами две любые строки массива

// int [,] FullArray(int m, int n)
// {
//     int [,] twoArray = new int [m, n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             twoArray [i, j] = new Random().Next(0, 10);
//         }
//     }
//     return twoArray;
// }

// void PrintTwoArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("{0, 5}", array [i, j] + "|");
//         }
//         Console.WriteLine("\b.");
//     }
// }

// int [,] ReplacingArrayStrings (int [,] array, int firstLine, int secondLine)
// {
//     if(firstLine < 0 | firstLine > array.GetLength(0) - 1 
//         | secondLine < 0 | secondLine > array.GetLength(0) - 1 
//         | firstLine == secondLine)
//     {
//         Console.WriteLine($"The entered line numbers {firstLine} or {secondLine} do not exist in the array");
//     }
//     else
//     {    
//     int temp = 0;
//     for(int i = 0; i < array.GetLength(1); i++)
//     {
//         temp = array [firstLine, i];
//         array [firstLine, i] = array [secondLine, i];
//         array [secondLine, i] = temp;
//     }
//     }
//     return array;
// }

// int [,] newTwoArray = FullArray(10, 5);

// Console.WriteLine("The original array:");
// PrintTwoArray(newTwoArray);

// Console.Write("Enter the number of the first row of the array to be changed: ");
// int firstLine = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the number of the second row of the array to be changed: ");
// int secondLine = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Modified array:");
// PrintTwoArray(ReplacingArrayStrings(newTwoArray, firstLine, secondLine));


// // ЗАДАЧА 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// //           В случае, если это невозможно, программа должна вывести сообщение для пользователя

// int [,] FullTwoArray(int m, int n)
// {
//     int [,] twoArray = new int[m, n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             twoArray[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return twoArray;
// }

// void PrintTwoArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("{0, 5}", array[i, j] + "|");
//         }
//         Console.WriteLine("\b.");
//     }
// }

// int [,] FlippingTwoArray(int [,] array)
// {
//     int [,] flippingArray = new int [array.GetLength(1), array.GetLength(0)];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             flippingArray [j, i] = array [i, j];
//         }
//     }
//     return flippingArray;
// }

// int [,] newTwoArray = FullTwoArray(3, 4);

// Console.WriteLine("The original array:");
// PrintTwoArray(newTwoArray);

// Console.WriteLine("The modified array:");
// PrintTwoArray(FlippingTwoArray(newTwoArray));

// // ЗАДАЧА 3. Задайте двумерный массив из целых чисел. 
// //           Напишите программу, которая обнулит строку и столбец, 
// //           на пересечении которых расположен наименьший элемент массива

// int [,] FullTwoArray(int m, int n)
// {
//     int [,] twoArray = new int [m, n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             twoArray [i, j] = new Random().Next(0, 20);
//         }
//     }
//     return twoArray;
// }

// void PrintTwoArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("{0, 5}", array [i, j] + "|");
//         }
//         Console.WriteLine("\b.");
//     }
// }

// int [,] FindMinElementArray(int [,] array)
// {
//     int min = array [0, 0];
//     int rowMin = 0;
//     int columnMin = 0;
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             if(array [i, j] < min)
//             {
//                 min = array [i, j];
//                 rowMin = i;
//                 columnMin = j;
//             }
//         }
//     }
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         array [i, columnMin] = 0;
//     }

//     for(int j = 0; j < array.GetLength(1); j++)
//     {
//         array [rowMin, j] = 0;
//     }
//     return array;
// }

// int [,] newTwoArray = FullTwoArray(10, 10);

// Console.WriteLine("The original array:");
// PrintTwoArray(newTwoArray);

// Console.WriteLine("The modified array:");
// PrintTwoArray(FindMinElementArray(newTwoArray));