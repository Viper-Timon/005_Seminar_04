// Задача 29: Напишите программу, которая задаёт массив целых чисел и выводит их на экран.
// Размер массива определяется пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Размер массива -> ");
int lenArray = int.Parse(Console.ReadLine());
int [] array = new int [lenArray];

void FillArray (int[] col1)
{
    int lenFill = col1.Length;
    int index = 0;
        while (index < lenFill)
    {
        // Console.Write ($"Введите эл.№ {index} -> "); // для ввода вручную
        // array[index] = int.Parse(Console.ReadLine()); // для ввода вручную
        array[index] = new Random().Next(1, 100); // для ввода случайным образом
        index++;
    }
}

void PrintArray(int[] col2)
{
    int count = col2.Length;
    int pos = 0;
    Console.Write("[");
    while (pos < count) 
    {
        if (pos < count -1)
        {
            Console.Write($"{col2[pos]}, ");
            pos++;
        }
        else
        {
            Console.WriteLine($"{col2[pos]}]");
            pos++;
        }
        
    }
}

FillArray(array);
PrintArray(array);