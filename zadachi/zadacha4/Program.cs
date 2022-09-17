// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Например
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Ввведите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if(a > b&&a > c)
{
    Console.WriteLine($"наибольшее число:{a}");
}
else if(b > c)
{
    Console.WriteLine($"наибольшее число::{b}");
}
else
{
    Console.WriteLine($"наибольшее число::{c}");
}