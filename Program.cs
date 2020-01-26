using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string GivenString = "";
             string ReversString = "";
            int Lenght = 0;
            Console.WriteLine("Enter A Word");
            GivenString = Console.ReadLine();
            Lenght = GivenString.Length - 1;
            while(Lenght>=0)
            {
                ReversString += GivenString[Lenght];
                Lenght--;
            }
            Console.WriteLine("Reverse Word is:{0}", ReversString);
            Console.ReadLine();
        }
    }
}
