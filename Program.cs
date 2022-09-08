public class Program
{
    private static void Main(string[] args)
    {
         int n = 4; //4,3,2,1
        int result = Factorial(n);
         Console.WriteLine(result);
    }
    
 static int Factorial(int n)
{
    if (n == 0)
    {
        return 1;
    }
    int partialResult = Factorial(n-1);
    return n * partialResult;
}
}
