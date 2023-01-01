using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exeception
{//Types are internal by defult, and type member are private by defults
    public class Program
    {
        static void Main(string[] args)
        {


            StreamReader streamReader = null;

            try
            {
              streamReader = new StreamReader(@"C:\Test\Try.txt"); //file to read  
              Console.WriteLine(streamReader.ReadToEnd()); //read all Char in file
              Console.ReadLine();
            }
            catch (FileNotFoundException ex)// FileNotFoundException if the file not found
            {
                Console.WriteLine("The file {0} is not found",ex.Message);// To show the exception MSG, and print it
                Console.ReadLine();

            }
            catch (Exception ex)// FileNotFoundException if the file not found
            {
                if (File.Exists(@"C:\Test\Wr.txt")) {
                    StreamWriter streamWriter = new StreamWriter(@"C:\Test\Wr.txt"); //file to write
                    streamWriter.Write(ex.GetType().Name);
                    streamWriter.Close();
                    Console.WriteLine("----There was a problem-----");

                    //Console.WriteLine(ex.Message);// To show the exception message, and prnt it
                    //Console.WriteLine("---------");
                    //Console.WriteLine(ex.StackTrace);//provide a call stack to the line number where exception occured.
                    //Console.ReadLine();
                }//
                else
                {
                    throw new FileNotFoundException(@"C:\Test\Wr.txt" + "is not found"); //inner exc
                }
            }
              
            finally//clean and free resources
            {
               if (streamReader != null) {
                   streamReader.Close(); //close reading
                }
            }

            //We can custom the Exception as we need and not like .Not Exception, by creat a class and call him.
            

        }
    }
}               

        

