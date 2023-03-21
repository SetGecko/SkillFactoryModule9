namespace Task_9._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new ArgumentOutOfRangeException("Аргумент находится за пределами диапазона допустимых значений.");
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Блок finally.");
            }
        }
    }
}