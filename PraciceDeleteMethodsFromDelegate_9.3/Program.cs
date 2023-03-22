namespace PraciceDeleteMethodsFromDelegate_9._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowDelegate showDelegate = ShowMessage1;
            showDelegate += ShowMessage2;
            showDelegate += ShowMessage3;
            showDelegate += ShowMessage4;

            showDelegate -= ShowMessage4;
            showDelegate -= ShowMessage3;
            showDelegate -= ShowMessage2;

            showDelegate.Invoke();
        }
        public delegate void ShowDelegate();
        static void ShowMessage1()
        {
            Console.WriteLine("Метод 1");
        }

        static void ShowMessage2()
        {
            Console.WriteLine("Метод 2");
        }

        static void ShowMessage3()
        {
            Console.WriteLine("Метод 3");
        }

        static void ShowMessage4()
        {
            Console.WriteLine("Метод 4");
        }
    }
}