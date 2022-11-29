using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////string[] isimler = new string[] { "mustafa", "başak", "damla", "songul" };
            ////Console.WriteLine(isimler[0]);
            ////Console.WriteLine(isimler[1]);
            ////Console.WriteLine(isimler[2]);
            ////Console.WriteLine(isimler[3]);
            ////isimler = new string[5];
            ////isimler[4] = "ilker";
            ////Console.WriteLine(isimler[4]);
            ////Console.WriteLine(isimler[0]);


            List<string> isimler2 = new List<string> { "mustafa", "başak", "damla", "songul" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            

        }
    }
}
