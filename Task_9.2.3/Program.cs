namespace Task_9._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new RankException("Какое-то сообщение");
            }
            catch(RankException ex)
            {
                Console.WriteLine(ex.GetType());
            }
            finally
            {
                Console.WriteLine("Блок finally.");
            }
        }
    }
}