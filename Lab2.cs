////////////1
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace lab2z1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            string d = Console.ReadLine();
//            string[] words = d.Split(' ');
//            Console.WriteLine("reversed:");
//            Array.Reverse(words);

//            for (int i = 0; i < words.Length; i++)


//            {


//                Console.Write(words[i] + " ");


//            }



//            Console.ReadKey();


//        }
//    }
//    }
//2
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace lab2z2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Введите строку :");

//            String words = Console.ReadLine();

//            for (int i = 0; i < words.Length; i++)
//            {
//                char c = words[i];
//                if ((c >= 'А') && (c <= 'Я'))
//                {

//                    Console.WriteLine("Заглавные русские буквы:" + words[i]);
//                }
//            }

//            Console.ReadLine();
//        }
//    }
//}
//////3
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace lab2z3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(" Введите стороны: ");
//            string d = Console.ReadLine();
//            string e = Console.ReadLine();
//            string f = Console.ReadLine();

//            int a = Convert.ToInt32(d);
//            int b = Convert.ToInt32(e);
//            int c = Convert.ToInt32(f);

//            double p = (a + b + c) / 2;

//            Console.WriteLine("Радиус вписанной окружности:");
//            double radiusmal = Math.Sqrt(((p - a) * (p - b) * (p - c)) / p);
//            Console.WriteLine(radiusmal);

//            Console.WriteLine("Радиус описанной окружности:");
//            double radiusbig = (a * b * c) / (4 * Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
//            Console.WriteLine(radiusbig);

//            Console.WriteLine("Площадь:");
//            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
//            Console.WriteLine(s);

//            Console.WriteLine("Периметр:");
//            double P = a + b + c;
//            Console.WriteLine(P);

//            Console.ReadKey();
//        }
//    }
//}