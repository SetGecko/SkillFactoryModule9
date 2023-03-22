namespace PracticeContravarianceInDelegates_9._4
{
    internal class Program
    {
        delegate void BwmInfo(BMW bwm);
        static void Main(string[] args)
        {
            BwmInfo bmwInfo = GetCarInfo; // контравариантность
            BMW bwm = new BMW
            {
                Model = "X6"
            };
            bmwInfo(bwm);
            Console.Read();
        }
        private static void GetCarInfo(Car p)
        {
            Console.WriteLine(p.Model);
        }
    }
    class Car
    {
        public string Model { get; set; }
    }
    class BMW : Car { }
}