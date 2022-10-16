internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            string plus = new string('+', 5 - i);
            System.Console.Write(plus);

            for (int j = 1; j <= i; j++)
            {
                System.Console.Write(i);
            }

            System.Console.WriteLine("");
        }
    }
}