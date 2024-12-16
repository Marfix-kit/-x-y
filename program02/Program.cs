// Задание 4: Напишите программу, которая на вход принимает число (N), а на выхоже показывает все четные числа от 1 до N.

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i<= n; i += 2)
     Console.WriteLine("" + i);
    


