using Design_Patterns.Factory;

namespace Design_Patterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*****野鸭子
            Duck test = new MallardDuck();

            test.performFly();
            test.performQuack();

            //木头鸭子
            Duck test2 = new WoodDuck();

            test2.performFly();
            test2.performQuack();

            System.Console.ReadLine();
            *****/

            long lg = 5000000000000000000;            

            System.Console.WriteLine( lg >> 0x10 );
            System.Console.WriteLine( lg >> 0x18 );
            System.Console.WriteLine( lg >> 0x20 );
            System.Console.WriteLine( lg >> 40 );
            System.Console.WriteLine( lg >> 0x30 );
            System.Console.WriteLine( lg >> 0x38 );

            uint num = (uint)(((lg | (lg << 8)) | (lg << 0x10)) | (lg << 0x18));
            System.Console.WriteLine(num);
        }
    }
}
