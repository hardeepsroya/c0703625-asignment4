
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
            p.ReadTextFile();
            p.Wordfind();
            p.Wordfind2();
            Console.ReadKey();


        }
        public void Run()
        {
            this.ReadTextFile();
        }
        public void ReadTextFiles()
        {
            // Read file using StramReader. Read file line by line
            using (StreamReader file = new StreamReader("U:/Users/703625/hardeep/Beowulf.txt"))
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

            var reader = new StreamReader("U:/Users/703625/hardeep/Beowulf.txt");
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
            Console.WriteLine("Total number of lines which contains word sea and Fare:" + chr);
        }

        public void Wordfind2()
        {
            int chr = 0, y = 0, z = 0;

            foreach (var line in File.ReadAllLines("U:/Users/703625/hardeep/Beowulf.txt"))
            {
                if (line.Contains("fare"))
                {
                    chr++;
                }

            }
            foreach (var line in File.ReadAllLines("U:/Users/703625/hardeep/Beowulf.txt"))
            {
                if (line.Contains("war") && line.Contains("fare"))
                {
                    y++;
                }

            }
            z = chr - y;
            Console.WriteLine("Total number of Lines which contain fare but not war: " + z);
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
