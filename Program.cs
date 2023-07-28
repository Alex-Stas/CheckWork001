// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string[] CreateArray(int size)
{
    return new string[size];
}

void FillRandomArray(string[] array, int lenght)
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
string[] myArray = CreateArray(arraySize);

FillRandomArray(myArray, wordLength);
Print2DArray(myArray);

