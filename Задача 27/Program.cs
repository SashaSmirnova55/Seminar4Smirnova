// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
//9012 -> 12
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}


int SumNumbers(int number)
{
    int ostatok = 0;
    int result = 0;
    while (number > 0)
    {
        ostatok = number % 10;
        number /= 10;
        result += ostatok;
    }
    return result;
}



//---------------------------------------------------------------------------

int number = ReadInt("Введите число: ");
System.Console.WriteLine($"Сумма цифр равна-> {SumNumbers(number)}");