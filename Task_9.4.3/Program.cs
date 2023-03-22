namespace Task_9._4._2
{
    internal class Program
    {
        public delegate Car HandlerMethod();
        static void Main(string[] args)
        {
            HandlerMethod lexusHandler = LexusHandler;
        }
        public static Car CarHandler()
        {
            return null;
        }
        public static Lexus LexusHandler()
        {
            return null;
        }
    }
    class Car { }
    class Lexus : Car { }
}