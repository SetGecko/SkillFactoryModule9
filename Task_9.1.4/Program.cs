namespace Task_9._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception("Произошло какое-то исключение");

            exception.HelpLink = "www.pikabu.ru";
        }
    }
}