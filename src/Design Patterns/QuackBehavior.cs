using static System.Console;


namespace Design_Patterns.Factory
{
    //鸭子叫声的能力，接口类
    public interface QuackBehavior
    {
        void quack();
    }

    //真正鸭子叫声的实现类，实现鸭子叫声能力的接口
    public class Quack : QuackBehavior
    {

        public void quack()
        {

            WriteLine("我可以像鸭子一样叫");
        }
    }

    //木头鸭子吱吱响的实现类，实现鸭子叫声能力的接口
    public class Spueak : QuackBehavior
    {

        public void quack()
        {

            WriteLine("我可以吱吱响");
        }
    }

    //不能发出声音的实现类，实现鸭子叫声能力的接口
    public class MuteQuack : QuackBehavior
    {

        public void quack()
        {

            WriteLine("我不能发出任何声音");
        }
    }
}