namespace Task_9._3
{
    internal class Program
    {
        /*Создайте консольное приложение, в котором есть функция, принимающая на вход два числа int, 
         * и возвращающая результат int вычитания второго числа из первого. 
         * Вызовите эту функцию в классе Main при помощи делегата и отобразите результат в консольном сообщении.*/
        static void Main(string[] args)
        {
            SubtractionDelegate subtractionDelegate = Subtraction;
            int result = subtractionDelegate(50, 40);
            Console.WriteLine(result);
        }
        static int Subtraction(int a, int b)
        {
            return a - b;
        }
        public delegate int SubtractionDelegate(int a, int b);
    }
}