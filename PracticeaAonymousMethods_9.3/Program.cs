namespace PracticeaAonymousMethods_9._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GreetingsDelegate gd = delegate (string name)
            {
                return "Привет @" + name + " и добро пожаловать на SkillFactory!";
            };
            string GreetingsMessage = gd.Invoke("Pranaya");
            Console.WriteLine(GreetingsMessage);


            CalculateDelegate calculateDelegate = delegate (int a, int b)
            {
                return a + b;
            };

            int result = calculateDelegate.Invoke(50, 10);
            Console.WriteLine(result);
        }
        public delegate string GreetingsDelegate(string name);
        delegate int CalculateDelegate(int a, int b);
    }
}