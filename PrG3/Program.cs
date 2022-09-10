//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Данная команда выводит массив из случайных чисел от 1 до 10. ");

void AllArray(int[] massiv1)
{
 int LengthArray = massiv1.Length;
 int index = 0;
 while (index < LengthArray)
 {
    massiv1[index] = new Random().Next(0, 10);
    index++;
 }
}

void ArrayWrite(int[] massiv2)
{
    int index1 = 0;
    int count = massiv2.Length;
    Console.Write("[ ");
    while (index1 < count)
{
    Console.Write($"{massiv2[index1]}, ");
    index1++;
}
Console.Write("]");
Console.WriteLine();
}

int [] array = new int [8]; 

AllArray(array);
ArrayWrite(array);



   