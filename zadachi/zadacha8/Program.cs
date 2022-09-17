// Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
// Например
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Приветствую, путник! Введите любое число больше ноля: ");
int numb = Convert.ToInt32(Console.ReadLine());
int count = 1;
if(numb == 1)
{
    Console.WriteLine($"четных чисел от 1 до {numb} нет");
}
else while(count <= numb)
{
    if(count % 2 == 0)
    {
        Console.Write($"{count}, ");
    }
    count++;
}