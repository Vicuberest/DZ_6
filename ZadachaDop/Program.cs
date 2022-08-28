// Напишите программу, которая будет преобразовывать десятичное число в двоичное.


Console.WriteLine("Введите число: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());

string binNumber = Convert.ToString(decimalNumber, 2);
Console.WriteLine(binNumber);

// Метод решения подглядела тут :)) 
// https://www.cyberforum.ru/csharp-beginners/thread389391.html
