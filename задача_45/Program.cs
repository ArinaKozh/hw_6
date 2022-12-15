/*
Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/


int GetNumber(string message)
{
   int result = 0;
   bool isCorrect = false;

   while(!isCorrect)
   {

    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out result) )
    {
        isCorrect = true;
    } 
    else
    {
        Console.WriteLine("Некорректно ввели число");
    }
   } 
   return result;
}


int[] InputArray()
{
    int M = GetNumber("Введите количество элементов");
    int[] array = new int[M];
    for(int i = 0; i<=M-1; i++)
    {
         array[i] = GetNumber($"Введите {i+1}-эй элемент массива");
    }
    return array;
}

void PrintArray(int[] array)
{
     for(int i = 0; i<array.Length;i++)
     {
        Console.Write($"{array[i]}  ");
     }
    Console.WriteLine();
}


int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];
    for(int i = 0; i<array.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}

int[] array = InputArray();
Console.WriteLine("Исходный");
PrintArray(array);
int[] copy = CopyArray(array);
Console.WriteLine("Копия");
PrintArray(copy);
