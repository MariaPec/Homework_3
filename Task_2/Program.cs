// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве


int Prompt(string message)
{
System.Console.WriteLine(message);
string param = Console.ReadLine();
return int.Parse(param);
}

int x1 = Prompt("Введите X1 => ");
int y1 = Prompt("Введите Y1 => ");
int z1 = Prompt("Введите Z1 => ");
int x2 = Prompt("Введите X2 => ");
int y2 = Prompt("Введите Y2 => ");
int z2 = Prompt("Введите Z2 => ");

int katet1 = x2 - x1;
int katet2 = y2 - y1;
int katet3 = z2 - z1;

int result = katet1*katet1 + katet2*katet2 + katet3*katet3;

Console.WriteLine($"Расстояние между двумя точками {Math.Sqrt(result)}");