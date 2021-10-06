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
            string fp = @"C:\temp\output.txt";
            StreamReader sr = new StreamReader(fp);
            string line = null;
            string[] tempWords = new string[] { };
            Stopwatch sw = new Stopwatch();

            List<string> tempWordList = new List<string>();
            List<string> wordList = new List<string>();
            
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                line.Trim();
                tempWords = line.Split(' ', '"', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < tempWords.Length; i++)
                {
                    if (tempWords[i].StartsWith('"'))
                    {
                        tempWords[i] = tempWords[i].TrimStart('"');
                    }
                    else if (tempWords[i].EndsWith('"'))
                    {
                        tempWords[i] = tempWords[i].TrimEnd('"');
                    }
                    tempWordList.Add(tempWords[i]);
                }
            }
            sr.Close(); //close the file we read from
            
            //measure the time it takes to move the elements from the temp list to the main list
            sw.Start();
            foreach (string tmpStr in tempWordList)
            {                
                wordList.Add(tmpStr);
            }
            sw.Stop();
            Console.WriteLine($"Execution time  {sw.ElapsedMilliseconds}ms");

            //measure the time it takes to sort the elements in the list
            sw.Start();        
            wordList.Sort();
            sw.Stop();
            Console.WriteLine($"Execution time  {sw.ElapsedMilliseconds}ms");         
            Console.ReadLine();
        }
    }
}
