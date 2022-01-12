using System;
using System.Linq;

namespace Test2
{


    class Program
    {
        public class Stroki
        {
            private string line;
            private int n;
            private string reversed;//число символов в строке


            public Stroki(string str)
            {
                line = str;
                n = str.Length;

            }

            public void ReverseLine()
            {
                string str = "";
                char[] reverse = str.Reverse().ToArray();
                Console.WriteLine(reverse);
            }
            static void Main(string[] args)

            {
                var rev = new Stroki(str:Convert.ToString(Console.ReadLine()));
                 rev.ReverseLine();

            }
        }
    }
}
   
            
        
    

       
    



    

