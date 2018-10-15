using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a text> ");
            string text = Console.ReadLine();
            int nrOfFullStops = 0;
            int nrOfCommas = 0;
            int nrOfSemiColons = 0;
            SearchText(text, out nrOfFullStops, out nrOfCommas, out nrOfSemiColons);
            Console.WriteLine("Result: {0} full stops, {1} commas, {2} semicolons"
                                     ,nrOfFullStops,nrOfCommas,nrOfSemiColons);
            Console.ReadKey();
        }
        static void SearchText(string text, out int nrOfFullStops, out int nrOfCommas, out int nrOfSemiColons)
        {
            nrOfSemiColons = 0;
            nrOfFullStops = 0;
            nrOfCommas = 0;
           
            foreach (char c in text)
            {
                if (c == ';')
                {
                    nrOfSemiColons++;
                }
                else if (c=='.')
                {
                    nrOfFullStops++;
                }
                else if (c==',')
                {
                    nrOfCommas++;
                }

            }
           

        }

    }
}
