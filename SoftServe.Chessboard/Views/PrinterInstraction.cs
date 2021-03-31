using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SoftServe.Chessboard
{
    class PrinterInstraction
    {
        private static string instractionPath = "..\\..\\..\\..\\instraction.txt";

        public static void PrintInstraction()
        {

            StreamReader sr = new StreamReader(instractionPath);
            string line = sr.ReadLine();

            Console.Clear();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }

            sr.Close();
            Console.ReadKey();
        }
    }
}
