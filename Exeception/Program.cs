using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exeception
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                StreamReader streamReader = new StreamReader(@"C:\Test\Try.txt"); //file to read  
                Console.WriteLine(streamReader.ReadToEnd()); //read all Char in file
                streamReader.Close(); //close reading
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);// To show the exception message
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);//provide a call stack to the line number where exception occured.
                Console.ReadLine();

            }
        }
    }
}               

        

