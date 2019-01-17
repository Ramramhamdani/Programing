using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            List<F1Result> f1Results = new List<F1Result>();
            f1Results = ReadF1Reasults("F1-results-2018.csv");
            if (f1Results.Count==0)
            {
                return;
            }
            else
            {
                Console.WriteLine("number of read items: " + f1Results.Count);
            }
            Console.ReadKey();
        }
        List<F1Result> ReadF1Reasults(string filename)
        {
            string line = "";
            List<F1Result> F1results = new List<F1Result>();
            if (!File.Exists(filename))
            {
                return F1results;
            }
            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                string[] f1 = line.Split(',');
                F1Result results = new F1Result();
                results.raceNumber = int.Parse(f1[0]);
                results.ranking = int.Parse(f1[1]);
                results.driver = f1[2];
                results.team = f1[3];
                results.startPosition = int.Parse(f1[4]);
                F1results.Add(results);
            }
            return F1results;
        }
        Dictionary<string,int> GetDriverPoints(List<F1Result> results)
        {
            Dictionary<string, int> drivers = new Dictionary<string, int>();
            for (int i = 0; i < results.Count; i++)
            {
                if (!drivers.ContainsKey(results[i].driver))
                {
                    drivers.Add(results[i].driver, results[i].ranking);
                }
                else
                {
                    
                }
            }
            return drivers;
        }
        void DispalyDriverPoints(Dictionary<string,int> driverpoints)
        {
            
        }
        void DisplayUnchangedTop3Races(List<F1Result> results)
        {

        }
    }
}
