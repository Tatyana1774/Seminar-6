﻿    /*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    0, 7, 8, -2, -2 -> 2
    1, -7, 567, 89, 223-> 4 */
    Console.WriteLine("Введите числа через запятую ");
    int[] ar = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
    int count = 0;

    for (int i = 0; i < ar.Length; i++)
    {
    if (ar[i] > 0)
    {
    count++;
    }
    }
    Console.WriteLine($"Вы ввели чисел больше 0 -> {count}");

