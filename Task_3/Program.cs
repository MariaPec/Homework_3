//  Напишите программу, которая принимает на вход число N т выдает таблицу кубов чисел от 1 до N.

int Prompt(string message)
{
System.Console.WriteLine(message);
string param = Console.ReadLine();
return int.Parse(param);
}

int N = Prompt("Введите N => ");
int i = 0;

if (N < 1)
{
    Console.WriteLine($"Введите положительное число");
}

for (i = 1; i <= N; i++)
{
    Console.WriteLine($"{i}*{i}*{i} = {i * i * i}");
}
