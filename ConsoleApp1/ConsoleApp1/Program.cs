
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;

namespace c0703625
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            // p.ReadTextFiles();
            p.Run();
            Console.ReadKey();

        }
        public void Run()
        {
            this.ReadTextFile();
            Console.WriteLine("xxxxx    number of words is {0} ", WalkOverArrayList());

        }

        public int WalkOverArrayList()
        {
            int totalNumberOfWords = 0;
            foreach (var thing in Beowulf)
            {
                totalNumberOfWords += CountWordsPerLine(thing.ToString());
            }

            return totalNumberOfWords;
        }

        public int CountWordsPerLine(string str)
        {
            int a = 0;
            int numberOfWords = 0;
            while (a <= str.Length - 1)
            {
                if (str[a] == ' ' || str[a] == '\n' || str[a] == '\t')
                {
                    numberOfWords++;
                }
                a++;
            }

            return numberOfWords;
        }

        public void ReadTextFiles()
        {

            using (StreamReader file = new StreamReader("U:/Users/696464/ravinder/Beowulf.txt"))
            {

                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {

                    Beowulf.Add(ln);

                }

                file.Close();
                counter = File.ReadLines("U:/Users/703625/hardeep/Beowulf.txt").Count();
                Console.WriteLine($"File has {counter} lines.");

            }
        }

        public void ReadTextFile()
        {

            StreamReader reader = new StreamReader("U:/Users/703625/hardeep/Beowulf.txt");
            string script = reader.ReadToEnd();

            var text = script.Trim();
            int Count = 0, index = 0;

            while (index < text.Length)
            {

                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;

                Count++;

                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }

            Console.WriteLine("Total Number of Words are " + Count);

        }


        public int FindNumberOfBlankSpaces(string line)
        {

            int countletters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c))
                { countletters++; }

                if (char.IsWhiteSpace(c))
                { countletters++; }
            }
            return countSpaces;

        }

    }

}