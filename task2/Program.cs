//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите число а = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b = ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c = ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB & numberA > numberC)
{
	Console.WriteLine($"Число {numberA} максимальное");
}
if (numberB > numberA & numberB > numberC)
{
	Console.WriteLine($"Число {numberB} максимальное");
}
if (numberC > numberA & numberC > numberB)
{
	Console.WriteLine($"Число {numberC} максимальное");
}