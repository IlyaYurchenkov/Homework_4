// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B

Console.Clear();
int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
int step = numberA;

for (int i = 1; i < numberB; i++)
    {
        step = step * numberA;
    }   

Console.WriteLine(step);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
