using System;

namespace CSharpMakeASpiral
{
    internal static class Program
    {
        private static int[,] Spiralize(int n)
        {
            var res = new int[n, n];
            for (var i = 0; i < n; i++)
            for (var j = 0; j < n; j++)
                res[i, j] = 1;
            
            for (int i = 1, j = n - 2; i < n; i += 2, j -=2)
            {
                for (var k = i - 1; k <= j; k++)
                    res[i, k] = 0;
                for (var k = i + 1; k <= j; k++)
                    res[k, j] = 0;
                for (var k = j - 1; k >= i; k--)
                    res[j, k] = 0;
                for (var k = j - 1; k > i + 1; k--)
                    res[k, i] = 0;
            }

            //if (n % 2 == 0) res[n / 2, n / 2 - 1] = 1;
            
            return res;
        }
    
        private static void Main(string[] args)
        {
            var res = Spiralize(10);

            for (var i = 0; i < res.GetLength(0); i++)
            {
                for (var j = 0; j < res.GetLength(1); j++)
                    Console.Write($"{res[i, j]} ");
                Console.WriteLine();
            }
        }
    }
}