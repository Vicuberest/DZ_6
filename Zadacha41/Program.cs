﻿// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите количество М чисел: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите сами числа: ");

int [] array = new int [size];
int count=0;

for (int i = 0; i < size; i++)
{
    
    array [i] = Convert.ToInt32(Console.ReadLine());
    if ( array [i] > 0 ) count++;

}
Console.WriteLine($"Количество чисел, которые больше нуля = {count} ");
