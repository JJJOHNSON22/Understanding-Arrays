using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Eddie", "Alex", "Micheal", "David Lee" };
            
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            

            
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            
            //this will reverse the givin string

            string zig = "You can get what you want out of life" +
                "if you help enough other people get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
        }
    }
}
