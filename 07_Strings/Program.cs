using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _07_Strings
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string sentence = "My name is Orhan Emre Önal";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Emre Orhan";

            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My Name");

            var result5 = sentence.IndexOf("Name"); // bulamadığında -1 döner
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ","-");
            var result13 = sentence.Remove(2);


            Console.WriteLine(result8);
            Console.ReadLine();


            //string city = "Ankara";
            ////Console.WriteLine(city[0]);


            //foreach (var item in city)
            //{
            //    Console.WriteLine(item);
            //}

            //string city2 = "İstanbul";
            ////string result = city + city2;

            //Console.WriteLine(String.Format("{0} {1}", city, city2));
            //Console.ReadLine();
        }
    }
}
