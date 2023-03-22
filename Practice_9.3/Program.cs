namespace Practice_9._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumDelegate sumDelegate = Sum;
            sumDelegate.Invoke(1, 10, 50);
        }
        static int Sum (int a, int b, int c)
        {
            return a + b + c;
        }
        public delegate int SumDelegate(int a, int b, int c);
    }
}