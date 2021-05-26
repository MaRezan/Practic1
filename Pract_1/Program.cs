using System;

namespace Pract_1
{
    static class lib1
    {
        public static void stpow(string a, int b)
        {
            string str = "";
            for (int i = 0; i < b; i++)
            {
                str += a;
            }
            Console.Write(str);

        }
        public static void rev1(string a)
        {


            var total = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                total += a[i];
            }
            Console.WriteLine(total);

        }
        public static void rev2(string a)
        {


            var total = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                total += a[i];
            }
            Console.WriteLine(total);

        }

        public static void rem(string str, string s)
        {
            char[] a = str.ToCharArray();
            string total = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Equals(Convert.ToChar(s)))
                {


                }
                else
                {
                    total += a[i];
                }
            }
            Console.WriteLine(total);
        }

        public static void len(string str)
        {
            var a = str.Length.ToString();
            Console.WriteLine(a);
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            //Task2
            //string a1;
            //int b1;
            //Console.Writeline("Введите слово");
            //a =Console.ReadLine();
            //Console.WriteLine("Введите число");
            //b = Convert.ToInt32(Console.ReadLine());
            //lib1.stpow(a,b);

            //Task3
            //string b2;
            //Console.WriteLine("Введите слово");
            //b2 = Console.ReadLine();
            //lib1.rev1(b2);


            //Task4
            //string b3;
            //b3 = Console.ReadLine();
            //lib1.rev2(b3);

            //Task5
            //string a4;
            //string b4;
            //a4 = Console.ReadLine();
            //b4 = Console.ReadLine();
            //lib1.rem(a4, b4);

            //Task6
            //string a5;
            //a5 = Console.ReadLine();
            //lib1.len(a5);



        }
    }
}
