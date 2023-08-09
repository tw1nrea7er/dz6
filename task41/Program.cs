// Задача 41:
//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Write("Введите количество чисел ");
int m = Convert.ToInt32(Console.ReadLine());
int k = 0;
for (int i = 0; i < m; i++)
{
    int c = Convert.ToInt32(Console.ReadLine());
    if (c > 0)
    {
        k++;
    }
}
Console.WriteLine(k);


