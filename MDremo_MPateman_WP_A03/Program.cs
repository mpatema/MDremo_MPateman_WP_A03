using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace MDremo_MPateman_WP_A03
{
    class Program
    {
        static void Main(string[] args)
        {
            string fp = @"C:\temp\Sample.txt";
            StreamReader sr = new StreamReader(fp);
            string line = null;
            string[] tempWords;
            Stopwatch sw = new Stopwatch();


            List<string> wordList = new List<string>();


            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                line.Trim();
                tempWords = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < tempWords.Length; i++)
                {
                    wordList.Add(tempWords[i]);
                    sw.Start();
                    //Console.WriteLine(tempWords[i]);                   
                }
            }
            sw.Stop();
            sr.Close();
            Console.WriteLine($"Execution time  {sw.ElapsedMilliseconds}ms");
            foreach (string str in wordList)
            {
            }


            Console.ReadLine();
        }
    }
}
