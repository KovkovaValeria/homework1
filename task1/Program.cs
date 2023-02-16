// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите число а = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b = ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB)
{
	Console.WriteLine("Число a равно числу b");
}
else

{
	if (numberA > numberB)
	{
		Console.WriteLine("Число a больше числа b");
	}
	else
	{
		Console.WriteLine("Число b больше числа a");
	}
}