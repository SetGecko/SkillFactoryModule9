namespace Task_9._4._3v1
{
    internal class Program
    {
        public delegate Parent HandlerMethod();
        delegate void ChildInfo(Child child);
        static void Main(string[] args)
        {
            ChildInfo childInfo = GetParentInfo;

            childInfo.Invoke(new Child());
        }
        public static Parent ParentHandler()
        {
            return null;
        }
        public static Child ChildHandler()
        {
            return null;
        }
        public static void GetParentInfo(Parent p)
        {
            Console.WriteLine(p.GetType());
        }
    }
    class Parent { }
    class Child : Parent { }
}