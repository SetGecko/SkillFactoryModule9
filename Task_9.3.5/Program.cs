namespace Task_9._3._5
{
    internal class Program
    {
        /*Используя решение из предыдущей задачи 9.3.4, 
         * реализуйте удаление метода CalculateTwo из многоадресного делегата CalculateDelegate.*/
        static void Main(string[] args)
        {
            Calculate calc = Subtraction;
            calc += Addition; // добавидл метод в делегат
            calc -= Addition; // удалил метод из делегата
            calc.Invoke(50, 10);
        }
        //Объявим делегат
        delegate void Calculate(int a, int b);
        // Метод для вычитания
        static void Subtraction(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        // Метод для сложения
        static void Addition(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}