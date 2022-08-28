// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string number = Console.ReadLine();
string[] array = number.Split(',');
int i = 0;
Console.Write("[ ");
for (i = 0; i < array.Length - 1; i++)
{
    Console.Write(array[i] + ", ");
}
Console.Write(array[array.Length - 1] + " ]");
Console.WriteLine();
int count = 0;
for (i = 0; i < array.Length; i++)
{
    int x = Convert.ToInt32(array[i]);
    if (x > 0)
    {
        count++;
    }
}
Console.Write("Количество чисел больше 0 = ");
Console.Write(count);

