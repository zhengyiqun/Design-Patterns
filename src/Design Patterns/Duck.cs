

namespace Design_Patterns.Factory
{
    //抽象鸭子类，有两个接口对象
    public abstract class Duck
    {
        public FlyBehavior flyBehavior;

        public QuackBehavior quackBehavior;

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {

            quackBehavior.quack();
        }

    }

    //野鸭类，继承抽象鸭子类
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();

            quackBehavior = new Quack();
        }
        
    }

    //木头鸭子类，继承抽象鸭子类
    public class WoodDuck : Duck
    {

        public WoodDuck()
        {

            flyBehavior = new FlyNoWay();

            quackBehavior = new MuteQuack();
        }
    }
}