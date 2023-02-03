// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();

if (number.Length != 5)
{
    Console.WriteLine("Введено неверное число");
    Console.WriteLine("Введите число от 10000 до 99999");
}

int halfLenNumber = number.Length / 2;
int tailInd = number.Length - 1;
string result = "да";
for (int frontInd = 0; frontInd <= halfLenNumber; frontInd++)
{
    if (number[frontInd] == number[tailInd]) tailInd--;
    else
    {
        result = "нет";
        break;
    }
}
Console.WriteLine($"{number} -> {result}");
