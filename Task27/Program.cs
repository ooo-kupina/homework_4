// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int absol = Math.Abs(number);

while (absol > 0)
{
int num = absol % 10;
absol = absol / 10;
sum = sum + num;
}
Console.WriteLine("Сумма всех цифр в данном числе равна: " + sum);

