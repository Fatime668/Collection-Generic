using System;
using System.Collections;

namespace ProgrammingLan
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList pl = new SortedList();
            Console.WriteLine("Tarixlere gore siralama: ");
            pl.Add(1995, "JavaScript");
            pl.Add(1952, "Autocode");
            pl.Add(2000, "C#");
            pl.Add(1949, "Shortcode");
            pl.Add(1957, "FORTRAN");
            pl.Add(1964, "BASIC");
            pl.Add(1958, "LISP");
            pl.Add(1970, "PASCAL");
            pl.Add(1972, "SQL");
            foreach (DictionaryEntry item in pl)
            {
                Console.WriteLine(item.Key);
            }
            SortedList epl = new SortedList();
            Console.WriteLine("*****************************\n");

            Console.WriteLine("Adlara gore siralama: ");
            epl.Add("JavaScript",1995);
            epl.Add("Autocode",1952);
            epl.Add("C#",2000);
            epl.Add("Shortcode",1949);
            epl.Add("FORTRAN",1957);
            epl.Add("BASIC",1964);
            epl.Add("LISP",1958);
            epl.Add("PASCAL",1970);
            epl.Add("SQL",1972);
            foreach (DictionaryEntry item in epl)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
