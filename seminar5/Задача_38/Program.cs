// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
int[] array = {5, 10, 53, 4, 2};

int maxElement(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

int minElement(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

int maxNum = maxElement(array);
int minNum = minElement(array);
void MaxMinusMin(int max, int min)
{
    int result = max - min;
    Console.WriteLine(result);
}


MaxMinusMin(maxNum, minNum);