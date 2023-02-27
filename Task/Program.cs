// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длинна которых меньше либо равна 3. 

Console.Clear();
Console.WriteLine("Введите данные через пробел: ");
string[] inarr = Console.ReadLine()!.Split(' ');
string[] outarr = new string[inarr.Length];

