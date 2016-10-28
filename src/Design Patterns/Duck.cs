

namespace Design_Patterns.Factory
{
    public abstract class Duck
    {
        public FlyBehavior flyBehavior;

        public QuackBehavior quackBehavior;

        public void performFly()
        {
            flyBehavior.fly();
        }

    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();

            quackBehavior = new Quack();
        }
        
    }
}