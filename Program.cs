using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamHW
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of StreamReader to read from a file.
            StreamReader reader = new StreamReader("..\\..\\..\\Shakespere.txt");

            
                int lineNumber = 0;


                //read the first line from the text file
                string line = reader.ReadLine();

                Console.WriteLine(line);


            //read the rest of the file.
            while (line != null)
            {
                lineNumber++;
                Console.WriteLine("Line {0}: {1}", lineNumber, line);
                line = reader.ReadLine();
            }

        }
    }
}
