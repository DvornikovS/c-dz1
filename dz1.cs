/*
int a, b;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if (a%b == 0)
{
Console.WriteLine("Кратно");
} else {
    Console.WriteLine(a%b);
}
*/

/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
int a, b, max;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if (a>=b) 
{
    max=a;
} 
else
{
    max=b;
}
Console.WriteLine($"max = {max}");
*/

//-----------------------------------------------------------------------------------------------------------------------

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
int a, b, c, max;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
if (a>=b && a>=c) 
{
    max=a;
} 
else if (b>=c)
{
    max=b;
}
else 
{
    max=c;
}
Console.WriteLine($"max = {max}");
*/

//-----------------------------------------------------------------------------------------------------------------------

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

/*
int n;
n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
*/

//-----------------------------------------------------------------------------------------------------------------------

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

/*
int n;
n = Convert.ToInt32(Console.ReadLine());
if (n>=2)
{
    for (int i=2; i<=n; i=i+2)
    {
        Console.Write($"{i}, ");
    }
}
else
{
     Console.WriteLine("таких цифр нет");
}
*/