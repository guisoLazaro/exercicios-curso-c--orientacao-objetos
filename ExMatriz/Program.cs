internal class Program
{
    public static void Main(string[] args)
    {
        int num, quantidade = 0;
        int n = int.Parse(Console.ReadLine());

        int[,] mat = new int[n, n];

        for(int i = 0; i < n; i++)
        {
            string[] x = Console.ReadLine().Split();
            for(int j = 0; j < n; j++)
            {
                num = int.Parse(x[j]);
                mat[i,j] = num;
                
            }
        }
        Console.WriteLine();
        Console.WriteLine("Diagonal Principal: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write(mat[i, i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Quantidde de numeros negativos: ");
        for (int i = 0; i < n; i ++)
        {
             for(int j = 0; j < n; j++)
            {
                if(mat[i, j] < 0)
                {
                    quantidade++;
                }
            }
        }
        Console.WriteLine(quantidade);
    }
}