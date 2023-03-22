namespace Screencast_9._4
{
    internal class Program
    {
        public delegate Animal HandlerMethod();
        delegate void DogInfo(Dog dog);
        public static Animal AnimalHandler()
        {
            return null;
        }
        public static Dog DogHandler()
        {
            return null;
        }
        public static void GetAnimalInfo(Animal p)
        {
            Console.WriteLine(p.GetType());
        }
        static void Main(string[] args)
        {
            HandlerMethod handlerMethod = AnimalHandler;
            HandlerMethod handlerDog = DogHandler;

            DogInfo dogInfo = GetAnimalInfo;
            dogInfo.Invoke(new Dog());
        }
    }
    class Animal { }
    class Dog : Animal { }
}