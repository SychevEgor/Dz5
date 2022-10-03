/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
double[] array = new double[10];    
    for (int i = 0; i < array.Length; i++)
    {
            array[i] = Convert.ToDouble(new Random().Next(-100, 100));
    }

double[] Findmax(double[]array)
{   double max = array[0];
    double min = array[0];
    double result=0;
    for (int i = 0; i < array.Length; i++)
    {    
        if (array[i] < min )
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
       
    }
    if(max>0&& min>0)
    {
        result = max - min;
    }
    else
    {
        result = max + min;
    }
    Console.WriteLine($"Минимальное значение =  {min} Максивальное значение =  {max}");
    Console.WriteLine($"Разница между минимальным и максимальным значением = {result}");
     return array;
}
void printArray(double[] arrayToPrint, string name)
{
    System.Console.WriteLine($"-------------------{name}-------------------");
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
    Console.WriteLine();
}
printArray(array,"Наш массив");
Findmax(array);