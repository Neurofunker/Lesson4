// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

//int[] array = new int[8];
//int[] array = new int[8]{1,2,3,4,5,6,7,8};
//int[] array2 = {1,2,3};

int[] Generatearray()
{
    int[] arr =new int[8];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,2);
    }
    return arr;
}

void PrintArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] array = Generatearray();
PrintArray(array);