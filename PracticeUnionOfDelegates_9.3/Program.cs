namespace PracticeUnionOfDelegates_9._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Объявили делегат1, добавили в него метод 1
            ShowDelegate showDelegate1 = ShowMessage1;
            // Добавили в делегат1 метод 2
            showDelegate1 += ShowMessage2;
            // Объявили делегат2, добавили в него метод 3
            ShowDelegate showDelegate2 = ShowMessage3;
            // Добавили в делегат2 метод 4
            showDelegate2 += ShowMessage4;
            // Объявляем делегат 3 и внего соединяем делегат 1 и 2
            ShowDelegate showDelegate3 = showDelegate1 + showDelegate2;

            showDelegate3.Invoke();
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