

Console.WriteLine("Введите натуральное  число"); 
int N = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(AllNumber(N)); 


string AllNumber(int N) 
{ 
    if (N==1) return $"1"; 
    return  $"{N} " +  AllNumber(N - 1); 
}










