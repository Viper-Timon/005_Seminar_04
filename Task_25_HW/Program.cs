// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A -> ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B -> ");
int b = int.Parse(Console.ReadLine());

// через метод
void AdegB (int argA,int argB)
{
    int res = 1;
    if (argB < 0)
    {
        Console.WriteLine("Необходимо вводить натуральное число B");
    }
    else
    {
        for (int i = 0; i < argB; i++)
        {
            res = res * argA;
        }
        Console.WriteLine($"Число A в степени B = {res}");
    }
}

AdegB (a, b);