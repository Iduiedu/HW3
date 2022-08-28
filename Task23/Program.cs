// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите целое положительное число");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
int numbercub = 0;
do
{
    numbercub = a * a * a;
    Console.WriteLine(numbercub);
    a++;
}
while (a <= N);

