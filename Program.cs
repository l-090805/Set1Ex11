namespace Set1Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar n: ");
            int n = int.Parse(Console.ReadLine());

            while (n>0)
            {
                Console.WriteLine(n%10);
                n /= 10;
            }
        }
    }
}
