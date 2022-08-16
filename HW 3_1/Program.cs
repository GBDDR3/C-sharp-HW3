// Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число");
string number = Console.ReadLine();
string number1 = "";

string flipNumber(string number)
{
    for (int i = number.Length - 1; i >= 0; i--)
    {
        number1 += number[i];
    }
    if (number == number1)
    {
        return "Да";
    }
    else
    {
        return "Нет";
    }

}
string result = flipNumber(number);
Console.WriteLine(result);