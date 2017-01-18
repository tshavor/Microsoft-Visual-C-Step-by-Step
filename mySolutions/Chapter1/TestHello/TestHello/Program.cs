using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHello             //name of our project, also becomes the top level solution file in the Solution Explorer window to the right
{
    class Program
    {
        static void Main(string[] args)      //this is the starting point for the app.  It should also be "static", which means the METHOD DOES NOT return a value
        {
            Console.WriteLine("Hello World!");  //Console.Writeline is exactly like "Console.log"

        }
    }
}

/*  Note: the "using" directive simply brings items in a namespace into SCOPE and frees us from having to fully qualify 
 *  the names of classes in our code.
 * 
 * ex: Console.Writeline = System.Console.Writeline
 * 
 * /