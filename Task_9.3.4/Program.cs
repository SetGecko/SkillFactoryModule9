namespace Task_9._3._4
{
    internal class Program
    {
        /*Реализуйте консольное приложение, в котором существует две функции: 
         * первая функция вычитает второе число из первого и отображает результат в консольном сообщении, 
         * вторая функция складывает два числа и отображает результат в консоли. 
         * Реализуйте вызов этих двух функций через многоадресный делегат.*/
        static void Main(string[] args)
        {
            Calculate calc = Subtraction;
            calc += Addition;
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