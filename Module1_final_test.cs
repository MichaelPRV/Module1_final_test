
// Задача: Написать программу, которая из имеюегося массива строк формирует массив из строк, длина которых меньше или равна 3. 
// Первоначальный массив можно ввести с клавиатуры или задать на старте выполнения алгоритма.

string[] CreateArray()
{
    Console.Write("Input number of strings in array: ");
    int numStr = Convert.ToInt32(Console.ReadLine());

    string[] array = new string[numStr];

    for(int i = 0; i < numStr; i++)
    {
        Console.Write("Input string: ");
        array[i] = Console.ReadLine();
    }
   
   return array;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);

    Console.WriteLine();
}

int CountStringsUpTo3symb(string[] array)
{
    int numUpTo3symb = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        numUpTo3symb++;
    }

    return numUpTo3symb;
}

string[] Create3symbolArray(string[] array, int num)
{
    string[] newArray = new string[num];

    for(int i = 0, j = 0; i < array.Length; i++, j++)
    {
        if (array[i].Length <= 3)
            newArray[j] = array[i];
        else
            j--;
    }

    return newArray;
}
