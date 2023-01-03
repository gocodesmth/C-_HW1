//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
int[] array = CreateRandomArray(5, 0, 15);

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    Random random = new Random();
     int[] array = new int[size];

     for (var i = 0; i < size; i++)
     {
            array[i] = random.Next(minValue, maxValue + 1);
     } 
     return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

void OddSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    Console.WriteLine("Сумма нечетных элементов: " + sum);
}

PrintArray(array);
OddSum(array);
