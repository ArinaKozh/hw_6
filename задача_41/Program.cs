/*
 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
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



int CountPositive(int[] array)
{
    int count = 0;
    for(int i = 0;i< array.Length;i++)
    {
        if (array[i]>0)
        {
            count++;
        }
    }
    return count;
}


void PrintArray(int[] array)
{
     for(int i = 0; i<array.Length;i++)
     {
        Console.Write($"{array[i]}  ");
     }
    Console.WriteLine();
}
int[] array = InputArray();
PrintArray(array);
Console.WriteLine($"Положительных чисел: {CountPositive(array)}");
