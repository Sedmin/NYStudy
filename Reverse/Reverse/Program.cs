using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //debagging mode
            //string destPath = args[0];  // c:\Temp\fileEng.txt
            //string soursePath = args[1]; // c:\Temp\fileEngBase.txt     

            if (args.Length > 1)
            {
                ReverseText(args[0], args[1]);
            }
            else if (args[0] != "")
            {
                ReverseText(args[0]);
            }
            else
            {
                Console.WriteLine("Enter a path to file as a command line");
            }

        }

        static void ReverseText(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            string reverseText = "ReverseText(string filePath)" + Environment.NewLine;
            string[] reversLines = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                reversLines[i] = lines[lines.Length - 1 - i];
                reverseText += reversLines[i] + Environment.NewLine;
            }

            File.WriteAllText(filePath, reverseText);
        }

        static void ReverseText(string destPath, string soursePath)
        {
            Console.WriteLine("Check. Get file:{0}", soursePath);

            string[] lines = File.ReadAllLines(soursePath);

            Console.WriteLine("Check. \nFist Line of base mass: {0} \nLast line of base mass: {1}", lines[0], lines[lines.Length - 1]);

            string reverseText = "ReverseText(string destPath, string soursePath)" + Environment.NewLine;
            string[] reversLines = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {

                reversLines[i] = lines[lines.Length - 1 - i];
                reverseText += reversLines[i] + Environment.NewLine;
            }


            Console.WriteLine("Check. \nFist Line of reverse mass: {0} \nLast line of reverse mass: {1}", reversLines[0], reversLines[reversLines.Length - 1]);

            File.WriteAllText(destPath, reverseText);
        }


    }
}
