// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Enter a number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1<num2)
{
    Console.Write("Max = " + num2);
}
else
{
    Console.Write("Max = " + num1);
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Enter a number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max=num1;

if (num2>max)
{
   max = num2;
}
if (num3>max)
{
    max = num3;
}
Console.Write("Max = " + max);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.Write("Numer is " + num + " an even number");
}
else
{
    Console.Write("Numer is " + num + " not an even number");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Enter a number: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
    if (i % 2 == 0)
        {
            Console.Write(i+" ");
        }
*/