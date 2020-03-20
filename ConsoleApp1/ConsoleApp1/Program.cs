using System;
using System.IO;

namespace C_ConsoleInput
{
    class book
    {
        public string Name;
        public string Autor;
        public string PublHouse;
        public int year;
    };
    class Class1
    {
        [STAThread]
        static void Main(string[] args)
        {
            
        string[] first = { "Andjei Sapkovskii", "Voz'mak", "Poland edition", "2008", "Taras Shevchenko", "Kobzar", "Ukrainian edition", "1900", "Daniel Deffo", "Robinzon Kruzo", "British edition", "1850", "Lesia Ukrainka", "Lisova Pisnia", "Ukrainian edition", "1988" };
            System.IO.File.WriteAllLines(@"F:\Knigi.txt", first);
            string[] lines = System.IO.File.ReadAllLines(@"F:\Knigi.txt");
            System.Console.WriteLine("Вміст файлу Knigi.txt");
            foreach (string line in lines)
            { Console.WriteLine("\t" + line); }
            book First = new book();
            First.Autor = lines[0];
            First.Name = lines[1];
            First.PublHouse = lines[2];
            int value = int.Parse(lines[3]);
            First.year = value;
            book Second = new book();
            Second.Autor = lines[4];
            Second.Name = lines[5];
            Second.PublHouse = lines[6];
            value = int.Parse(lines[7]);
            Second.year = value;
            book Third = new book();
            Third.Autor = lines[8];
            Third.Name = lines[9];
            Third.PublHouse = lines[10];
            value = int.Parse(lines[11]);
            Third.year = value;
            book Fourth = new book();
            Fourth.Autor = lines[12];
            Fourth.Name = lines[13];
            Fourth.PublHouse = lines[14];
            value = int.Parse(lines[15]);
            Fourth.year = value;
            book[] Books = new book[4];
            Books[0] = First;
            Books[1] = Second;
            Books[2] = Third;
            Books[3] = Fourth;
            for(int i=0; i<4; i++)
            {
                if (Books[i].year <= 1889)
                    Console.WriteLine("\t Book " + Books[i].Name + ". Autor: " + Books[i].Autor + ". Published from " + Books[i].PublHouse + " in " + Books[i].year);
            }
        }
    }
}