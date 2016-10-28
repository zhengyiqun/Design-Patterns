using Design_Patterns.Factory;

namespace Design_Patterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Duck test = new MallardDuck();

            test.performFly();

            System.Console.ReadLine();
        }
    }
}
