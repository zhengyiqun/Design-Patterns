using static System.Console;

namespace Design_Patterns.Factory
{
    //鸭子飞行的能力，接口类。
    public interface FlyBehavior
    {
        void fly();
    }

    //鸭子可以飞的实现类，实现鸭子飞行能力的接口类
    public class FlyWithWings : FlyBehavior
    {

        public void fly()
        {

            WriteLine("我可以像鸭子一样飞");
        }
    }

    //鸭子不能飞行的实现类，实现鸭子飞行能力的接口类
    public class FlyNoWay : FlyBehavior
    {

        public void fly()
        {

            WriteLine("我不能飞");
        }
    }
}