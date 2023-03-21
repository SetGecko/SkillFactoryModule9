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
            catch(Exception ex) 
            {
                if(ex is DivideByZeroException)
                {
                    Console.WriteLine("На ноль делить нельзя");
                }
                else
                {
                    Console.WriteLine("Произошла непредвиденная ошибка в приложении.");
                }
            }
        }
        static int Division(int a, int b)
        {
            return a / b;
        }
    }
}