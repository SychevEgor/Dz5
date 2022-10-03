/*Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/
int[] generateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100,999);
    }
    return array;
}
    void printArray(int[] arrayToPrint, string name)
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
    void CheckEven(int[] array)
{
     int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
      if(array[i] % 2 == 0)
      {
        count++;
      }
    }
      Console.WriteLine($"Кол-во четных чиссел в массиве: {count}");
}


int[] currentArray = generateArray(3);
printArray(currentArray,"Наш массив");
CheckEven(currentArray);



