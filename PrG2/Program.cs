//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Clear();
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());

int KolChisel (int number1)
{
    int count = 10;
    int i = 1;
    while(number1 >= count)
    {
        count = count*10;
        i++;
    }
    return i;
}

int i1 = KolChisel(a);

int SumChisel (int kol2, int number1)
{
    int index = 1;
    int sum = 0;
    while (index <= kol2)
    {
        sum = sum + number1 % 10;
        number1 = number1 / 10;
        index ++;
    }
    return sum;
}
Console.WriteLine($"{a} -> {SumChisel(i1, a)}");
