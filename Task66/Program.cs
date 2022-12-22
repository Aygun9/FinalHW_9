// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int DataEntry(string str)
{
    Console.WriteLine(str);
    int N = int.Parse(Console.ReadLine());
    return N;
}


int SumRec(int M, int N)
{
    if (M == N) return M;
    else return SumRec(M, N - 1) + N;
}


int M = DataEntry(" Insert M ");
int N = DataEntry(" Insert N ");
int temp = 0;
if (M > N)
{
    temp = M;
    M = N;
    N = temp;
}

Console.Write($"->{SumRec(M, N)}");