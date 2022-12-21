// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int DataEntry(string str)
{
    Console.WriteLine(str);
    int N = int.Parse(Console.ReadLine());
    return N;
}

string NumbersRec(int M, int N)
{
    if (M <= N) return $" {N} " + NumbersRec(M, N - 1);
    else return string.Empty;
}
int M = DataEntry(" Insert M ");
int N = DataEntry(" Insert N ");
System.Console.WriteLine($"{N} => {NumbersRec(M, N)}");

