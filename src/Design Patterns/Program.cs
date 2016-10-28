using Design_Patterns.Factory;

namespace Design_Patterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //野鸭子
            Duck test = new MallardDuck();

            test.performFly();
            test.performQuack();

            //木头鸭子
            Duck test2 = new WoodDuck();

            test2.performFly();
            test2.performQuack();

            System.Console.ReadLine();
        }
    }
}
