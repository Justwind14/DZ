// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// например
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Ввведите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a < b)
{
    Console.WriteLine($"большее число:{b}, меньшее число:{a}");
}
else
{
    Console.WriteLine($"большее число:{a}, меньшее число:{b}");
}
