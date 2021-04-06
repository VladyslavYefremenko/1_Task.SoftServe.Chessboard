using System;
using System.IO;

namespace SoftServe.ChessboardView
{
    class Printer : IPrinter
    {
        public void PrintInstraction(string instractionFilePath)
        {
            StreamReader sr = new StreamReader(instractionFilePath);
            string line = sr.ReadLine();

            Console.Clear();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }

            sr.Close();
        }
    }
}
