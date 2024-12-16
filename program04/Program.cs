// складывает x и n, показывает сумму

void f(ref int x)
{
   x +=5;
    Console.WriteLine(x);
}
int n = 10;
Console.WriteLine(n);
f(ref n);
Console.WriteLine(n);

