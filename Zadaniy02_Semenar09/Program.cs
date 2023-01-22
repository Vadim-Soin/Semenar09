


Console.WriteLine("Введите натуральное число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SummaRec(M, N));



int SummaRec(int M, int N)
{
    if (M > N) return 0;
    return M + SummaRec(M + 1, N);
}





