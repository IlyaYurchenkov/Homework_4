// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

int size=ReadInt("Введите размер массива: ");
int [] array = new int [size];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(int.MinValue,int.MaxValue);
}

PrintArray(array);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}