using System;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Odd Numbers:");

            var generator = new OddGenerator();
            foreach(int odd in generator)
            {
                if (odd > 50)
                    break;
                Console.WriteLine(odd);
            }

            Console.Read();
        }
    }
}
