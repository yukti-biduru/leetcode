
namespace Leetcode.Solutions
{
    internal class CS587_Project
    {
        public class BaseClass
        {
            public virtual void Print()
            {
                Console.WriteLine("Base implementation.");
            }
        }

        public class DerivedClass : BaseClass
        {
            public override void Print()
            {
                Console.WriteLine("Derived implementation.");
                var number = "12345";
                Console.WriteLine(number);
            }
        }
        public void Log(string message, bool isError = false)
        {
            if (isError) Console.Error.WriteLine(message);
            else Console.WriteLine(message);
        }



    }
}

