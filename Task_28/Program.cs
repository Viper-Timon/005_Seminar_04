// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите число N ");
int n = int.Parse(Console.ReadLine());

int Method1 (int num)
{
    int comp = 1;
    for (int i = 1; i <= num; i++)
    {
        comp = comp * i;
    }
    return comp;
}  
int result = Method1(n);
Console.WriteLine($"Произведение = {result}");