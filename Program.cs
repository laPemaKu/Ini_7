using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inicijalno_ponavljanje_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int number_of_divisions = 0;
            for (int i = 2; i < 100;  i++)
            {
                for (int j = 2; j < i ; j++) 
                { 
                    if(i%j == 0)
                    {
                        number_of_divisions++;
                    }
                }
                if (number_of_divisions == 0)
                {
                    list.Add(i);
                }
                number_of_divisions = 0;
            }
            Console.WriteLine("Broj primova od 100 je: " + list.Count);
            Console.ReadKey();
        }
    }
}
