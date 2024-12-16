// задание 2: Напишите программу которая на вход принимает три числа и выдает максимальное из этих трех чисел.\


Console.Clear();
Console.WriteLine("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n2;
if (n2 > max)
    max = n2;
if (n3 > max)
    max = n3;
Console.WriteLine(max);