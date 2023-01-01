using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a single Delegate
public delegate void MyDelegate(String s);

namespace Exception
{
    public class Delegate
    {
        static void Main(string[] args)
        {

            MyDelegate dll1 = new MyDelegate(function1);     //Create an instance 1 from delegate
            dll1(" This string is written by delegate 1");    //delegate can call the method

            MyDelegate dll2 = new MyDelegate(function2);     //Create an instance 2 from delegate
            dll2(" This string is written by delegate 2");    //delegate can call the method

            MyDelegate dll3 = new MyDelegate(function3);     //Create an instance 3 from delegate
            dll3(" This string is written by delegate 3");    //delegate can call the method
            Console.ReadLine();

            MyDelegate dll4 = dll1 + dll2 - dll3; //multi delegate , + for include and - to disinclude
            dll4(""); // well call dll 1, 2, 3  
            Console.ReadLine(); */



        }

        public static void function1(String l)
        {
            Console.WriteLine(l);
        }

        public static void function2(String l)d
        {
            Console.WriteLine(l);
        }

    public static void function3(String l)
    {
        Console.WriteLine(l);
    }

    public static void function4(String l)
    {
        Console.WriteLine(l);
    }

    public static void function5(String l)
    {
        Console.WriteLine(l);
    }
}
}
