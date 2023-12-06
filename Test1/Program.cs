//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число меньшее чем N - M: ");
int M = Convert.ToInt32(Console.ReadLine());
if (M > N)
{
    Console.Write("Неверно поставлены значения");
}
if (M < 0)
{
    M = 0;
}
if (N > 0)
{
while (M < N + 1)
{
Console.Write(M + " ");
M += 1;
}
}
else
{
    Console.Write("Натуральных чисел нет");
}
