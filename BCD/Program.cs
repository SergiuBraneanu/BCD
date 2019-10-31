using System;
using System.Text;
namespace BCD
{
    class Program
    {
        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main(string[] args)
        {
            int n,n2=0,c;
            char s;
            StringBuilder k = new StringBuilder();
            Console.WriteLine("Introduceti numarul:");
            n = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                n2 = n2 * 10 + n % 10;
                n = n / 10;
            }
            if (n2 > 0) Console.Write("0000 ");
            else if (n2 < 0) n2 = 9999 - n2 + 1;

            while(n2!=0)
            {
                s = ' ';
                c = n2 % 10;
                n2= n2 / 10;
                switch(c)
                {
                    case 0:Console.Write("0000 ");break;
                    case 1:Console.Write("0001 ");break;
                    case 2:Console.Write("0010 ");break;
                    case 3:Console.Write("0011 "); break;
                    case 4:Console.Write("0100 "); break;
                    case 5:Console.Write("0101 ");break;
                    case 6:Console.Write("0111 "); break;
                    case 7:Console.Write("1000"); break;
                    case 8:Console.Write("1001 "); break;
                    case 9:Console.Write("1010"); break; 

                }
                k.Append(s);
            }
            Console.WriteLine(Reverse(k.ToString()));
           
        }
    }
}
