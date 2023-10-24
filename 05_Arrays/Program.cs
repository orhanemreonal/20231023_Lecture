using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _05_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string student1 = "Orhan";
            //string student2 = "Birey";
            //string student3 = "Mert";

            //string[] students = new string[3];
            //students[0] = "Orhan";
            //students[1] = "Birey";
            //students[2] = "Mert";

            //string[] students = new string[3] { "Orhan", "Birey", "Mert" };

            //string[] students2 = { "Orhan", "Birey", "Salih" };
            //// students2[3] = "Ahmet" olmuyor çünkü array 2. elemena kadar


            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale"  },
                {"Antalya","Adana","Mersin" },
                { "Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa"  },
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("**********");
            }

            Console.ReadKey();
        }
    }
}
