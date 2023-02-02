internal class Program
{
    private static void Main(string[] args)
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[,] mat = new int[m,n];
        for(int i = 0; i < m; i++)
        {
            string[] values = Console.ReadLine().Split(' ');
            for(int j = 0; j < n; j++ )
            {
                mat[i, j] = int.Parse(values[j]);
            }
        }
        int num = int.Parse(Console.ReadLine());
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(mat[i, j] == num)
                {
                    Console.WriteLine($"Position: {i},{j} ");
                    Console.WriteLine($"Left: {mat[i, j-1]}");
                    if(j+1 < n)
                    {
                        Console.WriteLine($"Right: {mat[i, j+1]}");
                    }
                    if(i > 0)
                    {
                        Console.WriteLine($"Up: {mat[i-1, j]}");
                    }
                    Console.WriteLine($"Down: {mat[i+1, j]}");
                }
            }
        }
    }
}