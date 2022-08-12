// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
string str=Console.ReadLine();
Console.Write(str[1]);
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
string str=Console.ReadLine();
if (3<=str.Length)
{
    Console.Write(str +"-> "+ str[2]);
}
else
{
    Console.Write("No 3 number");
}
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
int day;
day=Convert.ToInt32(Console.ReadLine());
if (day<=0 | day>=8)
{
   Console.Write(day+"-> Incorrect data ");
   Environment.Exit( 0 );
}
if (day<=5)
{
   Console.Write(day+"-> No");
}
else
{
   Console.Write(day+"-> Yes"); 
}
*/