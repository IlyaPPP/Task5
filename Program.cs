/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int n = 5;   // количество чисел М
int[] array = FillArray(n);     // список введеных чисел переданных функцией FillArray()
int count_pol = 0;      // количество положительных чисел 
Count_Pol();        // Функция по нахождению количества полложительных чисел

int[] FillArray(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите число: ");
        int.TryParse(Console.ReadLine()!, out arr[i]);
    }
    return arr;
}

void Count_Pol()
{
    for (int i = 0; i < n; i++)
        if (array[i] > 0)
            count_pol++;
        else
            continue;
}




Console.Write($"{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]} -> {count_pol}");
