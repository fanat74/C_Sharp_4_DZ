// Задача 29: Напишите программу, которая 
//задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int [] array = new int[8];

FillArray(array);
WriteArray(array);

void FillArray(int[] arr)
{
    for(int i=0; i< arr.Length; i++)
    {
        Console.Write($"Введите число с индексом {i} ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void WriteArray(int[] arr)
{
    for(int i=0; i< arr.Length; i++)
    {
         Console.Write(arr[i] + " ");
    }
}
