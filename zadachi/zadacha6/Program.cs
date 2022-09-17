// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Например
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Приветствую, путник! Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());
double numb2 = numb / 2;
Console.WriteLine($"{numb} является четным числом?");
if(numb % 2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}