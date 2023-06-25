// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Degree(int A, int B)
{
    if (A == 0) return 1;
    int count = 0;
    int result = 1;
    while (count < A)
    {
        result  *= B;
        count++;
    }
    return result;
}
//---------------------------------------------------------------------------

int A = ReadInt("Введите число: ");
int B = ReadInt("Введите показатель степени: ");
if (B < 0)
{
    System.Console.WriteLine("Вы ввели некорректное число");
}
else
{
System.Console.WriteLine($"Число {A} в степени {B} равно: {Degree(A, B)}");
}