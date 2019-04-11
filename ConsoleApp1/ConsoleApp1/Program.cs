
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
            p.ReadTextFiles();
            p.Wordfind();
            Console.ReadKey();

        }
        public void Run()
        {
            this.ReadTextFiles();
        }

        public void ReadTextFiles()
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
        public void Wordfind()

        {
            int chr = 0;
            foreach (var line in File.ReadAllLines("U:/Users/703625/hardeep/Beowulf.txt"))
            {
                if (line.Contains("sea") && line.Contains("fare"))
                {
                    chr++;
                }

            }
            Console.WriteLine("Total words sea and fare in File are:" + chr);


        }
        public int FindNumberOfBlankSpaces(string line)
        {



            int countletters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c))
                {
                    countletters++;
                }

                if (char.IsWhiteSpace(c))
                {
                    countletters++;
                }
            }
            return countSpaces;

        }






    }

}