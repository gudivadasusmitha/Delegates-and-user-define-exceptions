using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //*****************single delegate************
    
    public delegate void mydel(int x, int y);
    class A
    {
        public void add(int x, int y)
        {
            Console.WriteLine("the sum is " + (x + y));
        }
        public void sub(int x, int y)
        {
            Console.WriteLine("the diffrence is " + (x - y));
            Console.ReadKey();
        }
    }
    class program
    {
        static void Main (string[] args)
        {
            A obj = new A();
            mydel m = new mydel(obj.add);
            m(10, 20);
            mydel m1 = new mydel(obj.sub);
            m1(10, 20);
        }
    }
    
    //*****************multi delegate*************
    
    class Test
    {
        public delegate void NewDelegate();
        static void Display1()
        {
            Console.WriteLine("susmi");
            Console.ReadLine();
        }
        static void Display2()
        {
            Console.WriteLine("women's day");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            NewDelegate d = Display1;
            d = d + Display2;
            d();
            d = d - Display2;
            d();
        }
    }
    
    //************passing delegate ************
    
    class Test
    {
        public delegate int NewDelegate(int x, int y);

        static void Display(NewDelegate d)
        {
            Console.WriteLine(d(10, 20));
            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            NewDelegate d1 = new NewDelegate(Add);
            Display(d1);
        }
    }
    
    //****************** user defined exception**************
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message)
            :base(message)
        {

        }
    }
    public class TestUserDefinedException
    {
        static void validate(int age)
        {
            if(age< 18)
            {
                throw new InvalidAgeException("sorry age must be greater than 18");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                validate(10);
            }
            catch(InvalidAgeException e)
            {
                Console.WriteLine("rest of the code");
                Console.ReadLine();
            }
        }
    }
}
