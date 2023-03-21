namespace Practice_9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int result = Division(10, 5);
                Console.WriteLine(result);
            }
            catch(System.DivideByZeroException) 
            {
                Console.WriteLine("На ноль делить нельзя");
            }
        }
        static int Division(int a, int b)
        {
            return a / b;
        }
    }
}