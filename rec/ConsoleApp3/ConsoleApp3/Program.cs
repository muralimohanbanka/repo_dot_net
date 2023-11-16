/*using System;
namespace myapplication
{
    class Person
    {
        private string name; // field
        public string Name   // property
        /*{
            get { return name; }
            set { name = value; }
        }*/
/* }
 class Program
 {
     static void Main(string[] args)
     {
         Person myObj = new Person();
         myObj.Name = "Liam";
         Console.WriteLine(myObj.Name);

 }
}*/
//using abstractmethod;
//using myapplication;

/*using System;
namespace myapplication
{
    interface animal
    {
        void animalsound();
        //public void sleep()
        // {
        //    Console.WriteLine("zzz");
        // }
    }
    class pig : animal
    {
        public void animalsound()
        {
            Console.WriteLine("the pig says :wee wee");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            pig mypig = new pig();
            mypig.animalsound();

        }

    }
}*/
/*using System;
namespace myapplication
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] mynumbers = { 1, 2, 3 };
                Console.WriteLine(mynumbers[10]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("the 'try catch' is finished");
            }
        }
    }
}   */
/*using System;
namespace Myapplication
{
    class program
    {
        static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("access denied- you must be atleast 18 years old.");
            }
            else
            {
                Console.WriteLine("access granted- you are old enough!");
            }
        }
        static void Main()
        {
            try
            {
                CheckAge(15);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.message);
            }
        }

    }
}*/
using System;
public class  mycustomException:Exception
{
    public mycustomException(string message):base(message)
    { 
    }
}
public class customExceptiondemo
{
    public void Dosomething()
    {
        throw new mycustomException("Something went wrong Dosomething()");
    }
    public static void Main()
    {
        try
        {
            customExceptiondemo demo = new customExceptiondemo();
            demo.Dosomething();
        }
        catch (mycustomException e)
        {
            Console.WriteLine("customException caught" + e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine("exception caught" + e.Message);
        }
        
    }
}