
namespace Design_Patterns.Factory
{

    public interface QuackBehavior
    {
        void quack();
    }

    //真正的鸭子叫
    public class Quack : QuackBehavior
    {

        public void quack()
        {

        }
    }

    //木头鸭子吱吱响
    public class Spueak : QuackBehavior
    {

        public void quack()
        {

        }
    }

    //不会叫的鸭子
    public class MuteQuack : QuackBehavior
    {

        public void quack()
        {

        }
    }
}