/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
int[] generateArray(int length)

{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1,999);
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
     int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
      if(array[i] % 2 != 0)
      {
        result+= array[i];
      }
    }
      Console.WriteLine($"Сумма нечетных чисел: {result}");
}
int[] currentArray = generateArray(3);
printArray(currentArray,"Наш массив");
CheckEven(currentArray);