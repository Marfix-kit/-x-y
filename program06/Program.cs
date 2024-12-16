// задача №17 Напишите программу, которая принимает  на вход коордитнаты точки  (х и y), 
//причем х не = 0 и y не = 0 и выдает номер четверти плоскости,  в которой находится эта точка.

string f(int x, int y)
{
    if (x>0 && y>0)
    return"I";
    else if (x<0 && y>0)
    return"II";
    else if (x<0 && y<0)
    return"III";
    return "IV";
}


Console.Write("Введите число: ");
int x =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int y =  Convert.ToInt32(Console.ReadLine());
Console.Write(f(x,y));
