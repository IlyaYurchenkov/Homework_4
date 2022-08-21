// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
int number = ReadInt("Введите ваше число: ");
int sum = 0;

while (number > 0)
{
int i = number % 10;
number = number / 10;
sum = sum + i;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
