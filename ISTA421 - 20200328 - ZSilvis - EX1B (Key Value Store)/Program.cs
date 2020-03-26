using System;

namespace ISTA421___20200328___ZSilvis___EX1B__Key_Value_Store_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ISTA421 - 20200328 - ZSilvis - EX1B - (Key Value Store).\n");

            var d = new MyDictionary();
            try
            {
                Console.WriteLine(d["Cats"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            d["Cats"] = 42;
            d["Dogs"] = 17;
            Console.WriteLine($"{(int)d["Cats"]}, {(int)d["Dogs"]}");
        }
    }
}
