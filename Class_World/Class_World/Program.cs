using System;

namespace Class_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Azerbaijan Aze = new Azerbaijan("Baku",
                             "Azerbaijani", 86600, 10127874,
                             "Manat(AZE)", "Az1000");

            
            Console.WriteLine(Aze.AzeDetail());


            
        }
    }
}
