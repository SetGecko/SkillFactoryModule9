namespace Task_9._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Используя ваше приложение из задания 9.3.2, реализуйте вызов делегата двумя разными способами.*/
            SubtractionDelegate subtractionDelegate = Subtraction;
            int result = subtractionDelegate(50, 40);
            int result2 = subtractionDelegate.Invoke(50, 30);
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
        static int Subtraction(int a, int b)
        {
            return a - b;
        }
        public delegate int SubtractionDelegate(int a, int b);
    }
}