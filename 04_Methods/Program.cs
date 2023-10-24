using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2(20);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(out number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            Console.WriteLine(Multiply(2, 4));

            Console.WriteLine(Add4(2,4,5,6,7));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!!!");
        }


        // Default Değerler Method'un en sonunda olsun.
        static int Add2(int number1, int number2 = 30)
        {
            var result = number1 + number2;
            return result;

        }
        

        // ref keyword'ün için değer set edilmesi lazım. Out için değer atamadan kullanabilirsin.
        static int Add3(out int number1, int number2)
        {

            // out kullanırken kesinlikle kullanılmadan önce 1 kere set edilmesi lazım yoksa hata verir
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }


        // Method Overloading --> Method imzası farklıysa aynı ismi kullanabilirsin
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2 * number3;
        }


        // Params keyword'ü ile istediğin kadar parametre yollayabilirsin.
        // params methodun son parametresi olmak zorundadır
        static int Add4(int number,params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
