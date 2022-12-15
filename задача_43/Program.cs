/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
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


float b1 = (float)GetNumber("Введите число b1");
float k1 = (float)GetNumber("Введите коэф k1");
float b2 = (float)GetNumber("Введите число b2");
float k2 = (float)GetNumber("Введите коэф k2");
float x = (b2-b1)/(k1-k2);
float y = k1*x + b1;
Console.WriteLine($"( {x}; {y})");