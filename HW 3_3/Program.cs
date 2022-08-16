// Задача 23
// Напишите программу, которая принимает на вход
//  число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int[] PowNumbers(int arg)
{
    int[] array = new int[arg];
    for (int i = 1; i <= number; i++)
    {
        array[i - 1] = Convert.ToInt32(Math.Pow(i,3));
    }
    return array;
}
int[] result = PowNumbers(number);
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}