/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double[] array = FillArray();     // список введеных значений переданных функцией FillArray()

double[] FillArray()            // функция на ввод значений
{
    double[] arr = new double[4];
    Console.Write($"Введите k1: ");
    double.TryParse(Console.ReadLine()!, out arr[0]);
    Console.Write($"Введите b1: ");
    double.TryParse(Console.ReadLine()!, out arr[1]);
    Console.Write($"Введите k2: ");
    double.TryParse(Console.ReadLine()!, out arr[2]);
    Console.Write($"Введите b2: ");
    double.TryParse(Console.ReadLine()!, out arr[3]);
    return arr;
}

double x = (array[1] - array[3]) / (-(array[0] - array[2]));   /* вычитание второго уравнения из первого, 
                                                                неизвестная переменная "y" сокращается,
                                                                неизвестная переменная "x" опускается 
                                                                найденный "x" является первой координатой
                                                                пересечения двух прямых */
double y = array[2] * x + array[3]; /* полученный "x" подставляем во второе уравнение и находим вторую координату
                                     точки пересечения двух прямых */
Console.Write($"{array[0]}, {array[1]}, {array[2]}, {array[3]} -> {x}, {y}");
