
// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число -> ");
int number = int.Parse(Console.ReadLine());

int FindSumNum(int num)
{
    if (num < 0) num = num * -1;
    int sum = 0;
    int num1 = num;
    while (num1 > 0)
    {
        sum = sum + (num1 % 10);
        num1 = num1 / 10;
    }
    return sum;
}

Console.WriteLine($"Сумма всех цифр = {FindSumNum(number)}");
