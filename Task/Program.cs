// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длинна которых меньше либо равна 3. 

void Calc(string[] inarr, string[] outarr)
{
    int count = 0;
    for(int i = 0; i < inarr.Length; i++)
    {
        if(inarr[i].Length <= 3)
        {
            outarr[count] = inarr[i];
            count += 1;
        }
    }
}

string Print(string[] text)
{
    string count = string.Empty;
    for(int i = 0; i < text.Length; i++)
        count = count + $" {text[i]}";
    return count;    
}

Console.Clear();
Console.WriteLine("Введите данные через пробел: ");
string[] inarr = Console.ReadLine()!.Split(' ');
string[] outarr = new string[inarr.Length];
Calc(inarr, outarr);
Console.WriteLine();
Console.Write($"{Print(outarr)}");

