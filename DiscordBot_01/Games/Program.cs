using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var sb = new StringBuilder();
            int value;


            do
            {
                value = rand.Next(33,126);
                sb.Append((char) value);
            } while (sb.Length < 10);

            Console.WriteLine(sb.ToString());
        }
    }
}
