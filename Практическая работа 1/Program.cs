using System;

namespace Практическая_работа_1
{
    public class lib1
    {
        public static string stpow(string a, int b, string c)
        {
            for(int i = 0; i <b; i++)
            {
                c += a;
            }
            return c;
        }
        public static string rev(string z, string s)
        {
            char[] d = z.ToCharArray();
            Array.Reverse(d);
            s = new string(d);
            return s;
        }
        public static string remov(string f, string h, char j)
        {
            f = f.Replace(j, ' ');
            h = f.Replace(" ", "");
            return h;
        }
        public static string leng(string q, string w)
        {
            w = Convert.ToString(q.Length);
            return w;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите строку");
            string a = Console.ReadLine();
            Console.WriteLine("Введите число");
            int b = Convert.ToInt32(Console.ReadLine());
            string c = "";
            Console.WriteLine(lib1.stpow(a, b, c));

            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите строку");
            string z = Console.ReadLine();
            string s = "";
            Console.WriteLine(lib1.rev(z, s));

            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите строку");
            string f = Console.ReadLine();
            Console.WriteLine("Введите элемент для удаления");
            char j = Convert.ToChar(Console.ReadLine());
            string h = "";
            Console.WriteLine(lib1.remov(f, h, j));

            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите строку");
            string q = Console.ReadLine();
            string w = "";
            Console.WriteLine(lib1.leng(q, w));
        }
    }
}
