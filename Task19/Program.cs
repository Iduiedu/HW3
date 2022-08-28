// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите положительное пятизначное число и узнаете, является ли оно палиндромом");
string? number = Console.ReadLine();
if (number != null && number.Length != 5)
{
    Console.WriteLine("Нужно было ввести пятизначное число!");
}
else
{
    if (number != null && number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Это палиндром!");
    }
    else
        Console.WriteLine("Это не палиндром!");
}