// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int lenarray = 8;
int [] array = new int [lenarray];

//запонение и вывод обноверменно (лучше разделять на 2 метода запонление и вывод)
void FillArray (int [] col1)
{
    int lenFill = col1.Length;
    int index = 0;
    Console.Write($"Массив [");
    while (index < lenFill)
    {
       if (index < (lenFill -1))
       {
            col1[index] = new Random().Next(0, 2);
            Console.Write($"{col1[index]}, ");
            index++;
       }
    else
        {
            col1[index] = new Random().Next(0, 2);
            Console.WriteLine($"{col1[index]}]");
            index++;
        }
    }

}

FillArray(array);
