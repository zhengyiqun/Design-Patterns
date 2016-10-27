using static System.Console;

namespace Design_Patterns.Factory
{

    public interface FlyBehavior
    {
        void fly();

    }

    //让鸭子飞
    public class FlyWithWings : FlyBehavior
    {

        public void fly()
        {

            WriteLine("I can fly");
        }
    }

    //不是动物鸭子的不能飞
    public class FlyNoWay : FlyBehavior
    {

        public void fly()
        {

            WriteLine("I can`t fly");
        }
    }
}