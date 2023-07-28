/*
* Задача 53:
* Задайте двумерный массив.
* Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/
// int InputNum(string message)
// {
// Console.WriteLine(message);
// return int.Parse(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int columns)
// {
// return new int[rows, columns];
// }

// void Fill2DArray(int[,] array, int min, int max)
// {
// Random rnd = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// for (int j = 0; j < array.GetLength(1); j++)
// array[i, j] = rnd.Next(min, max + 1);
// }

// void ChangeRows(int[,] array)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// int temp = array[0, j];
// array[0, j] = array[array.GetLength(0) - 1, j];
// array[array.GetLength(0) - 1, j] = temp;
// }
// }

// void Print2DArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// Console.Write($"{array[i, j]}\t");
// Console.WriteLine();
// }
// }

// int rows = InputNum("Введите количество строк: ");
// int cols = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");

// int[,] myArray = Create2DArray(rows, cols);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();
// ChangeRows(myArray);
// Print2DArray(myArray);

// *************************************************************************************
// Задача 55:
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int InputNum(string message)
// {
// Console.WriteLine(message);
// return int.Parse(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int columns)
// {
// return new int[rows, columns];
// }

// void Fill2DArray(int[,] array, int min, int max)
// {
// Random rnd = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// for (int j = 0; j < array.GetLength(1); j++)
// array[i, j] = rnd.Next(min, max + 1);
// }

// void ChangeRowColumns(int[,] array)
// {
// if (array.GetLength(0) != array.GetLength(1)) Console.WriteLine("Поменять строки на столбцы нельзя");
// else
// {
// int temp = 0;
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = i; j < array.GetLength(1); j++)
// {
// // (array[i, j], array[j, i]) = (array[j, i], array[i, j]); // Кортеж - одновременная замена
// temp = array [j,i];
// array[j,i] = array [i,j];
// array[i,j] = temp;
// }
// }
// }
// }

// void Print2DArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// Console.Write($"{array[i, j]}\t");
// Console.WriteLine();
// }
// }

// int rows = InputNum("Введите количество строк: ");
// int cols = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");

// int[,] myArray = Create2DArray(rows, cols);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();
// ChangeRowColumns(myArray);
// Print2DArray(myArray);

// *************************************************************************************
// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// int InputNum(string message)
// {
// Console.WriteLine(message);
// return int.Parse(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int columns)
// {
// return new int[rows, columns];
// }

// void Fill2DArray(int[,] array, int min, int max)
// {
// Random rnd = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// for (int j = 0; j < array.GetLength(1); j++)
// array[i, j] = rnd.Next(min, max + 1);
// }
// int[] Dict(int[,] array, int min, int max)
// {
// int[] result = new int[max - min + 1];
// // 0 1 2 3 4 5 6 7
// //min min + 1... max - частота встречаемости
// // 0 1 2 3
// // -5 -4
// // 5 6 7

// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// int index = array[i, j] - min; // min = -5
// result[index]++; // array[i, j] = -4
// } // index = -4 -(-5) = -4 + 5 = 1
// }
// return result;
// }
// void Result(int[] dict, int min)
// {
// for (int i = 0; i < dict.Length; i++)
// {
// Console.WriteLine($"Число {i + min} встречается {dict[i]} раз(а)");
// }
// }

// void Print2DArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// Console.Write($"{array[i, j]}\t");
// Console.WriteLine();
// }
// }

// int rows = InputNum("Введите количество строк: ");
// int cols = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");

// int[,] myArray = Create2DArray(rows, cols);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();
// int[] dictionary = Dict(myArray, minValue, maxValue);
// Result(dictionary, minValue);

// *************************************************************************************
// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }
// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }
// void Fill2DArray(int[,] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = rnd.Next(min, max + 1);
// }
// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]}\t");
//         Console.WriteLine();
//     }
// }
// int[] MinNum(int[,] array)
// {
//     int minN = array[0, 0];
//     int[] index = new int[2];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < minN)
//             {
//                 minN = array[i, j];
//                 index[0] = i;
//                 index[1] = j;
//             }
//         }
//     }
//     return index;
// }
// int[,] ChangeArray (int [,] array, int [] index)
// {
//     int [,] ChangedArray = new int [array.GetLength(0)-1, array.GetLength(1)-1];
//     int row = 0;
//     int col = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         if (i == index[0]) continue;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (j == index[1]) continue;
//             ChangedArray[row,col] = array[i,j];
//             col++;            
//         }
//         col = 0;
//         row++;
//     }
//     return ChangedArray;
// }
// int rows = InputNum("Введите количество строк: ");
// int cols = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");
// int[,] myArray = Create2DArray(rows, cols);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();
// int[] minimum = MinNum(myArray);
// int[,] resultArray = ChangeArray(myArray,minimum);
// Print2DArray(resultArray);

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string[] Create2DArray(int size)
{
    return new string[size];
}

void Fill2DArray(string[] array, int lenght)
{
    
    Random rnd = new Random();
    char[] alphabet = {'A', 'B', 'C','D', 'E', 'F', 'G', 'H', 'I', 'J','K', 'L', 'M', 'N', 'O','P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'}; 
    int alphabetLength = alphabet.Length;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        int wordLength = rnd.Next(1, lenght + 1);
        array[i] = String.Empty; 
        for (int j = 1; j <= wordLength; j++)
        {
            int letter = rnd.Next(0, alphabetLength);
            array[i] = array[i] + alphabet[letter];
        }
            
    }
}
void Print2DArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
}



int arraySize = InputNum("Введите размер массива (количество строк): ");
int wordLength = InputNum("Введите максимальную длинну слова: ");
string[] myArray = Create2DArray(arraySize);

Fill2DArray(myArray, wordLength);
Print2DArray(myArray);
