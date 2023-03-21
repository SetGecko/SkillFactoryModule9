namespace Task_9._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception();

            exception.Data.Add("Дата создания исключения: ",DateTime.Now);
        }
    }
}