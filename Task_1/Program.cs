// Напишите программу, которая на вход принимает число и проверяет, является ли оно палиндромом


Console.Write("Введите число => ");
string paramString = Console.ReadLine();

int length = paramString.Length;

int indexFirst = 0;

int indexLast = length - 1;

while (indexFirst < length / 2)
 {
    if (paramString [indexFirst] == paramString [indexLast])
    {
    indexFirst++;
    indexLast--;
    }
else
{
    Console.WriteLine("Число не является палиндромом"); 
    Environment.Exit(0);
}
}
Console.WriteLine("Число является палиндромом");

