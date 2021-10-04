using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {



            #region 7'ye bolunen edede en yaxin eded
            int input = 37;
            int result = input;

            if (input % 7 == 0)
            {
                Console.WriteLine($"{input} 7-ye bolunur");
            }
            else
            {
                int remainder = input % 7;

                if (remainder > 3)
                {
                    while (result % 7 != 0)
                    {
                        result++;
                    }
                }
                else
                {
                    while (result % 7 != 0)
                    {
                        result--;
                    }
                }
            }

            Console.WriteLine(result);
            #endregion





            #region Cut ededlerin cemi

            evenvoid(4);
            Console.WriteLine(evenint(4));

            #endregion

        }

        public static void evenvoid(int num)
        {
            int sum = 0;
            for (int i = 0; i <= num; i++) 
            {
                if (i % 2 == 0) 
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        } 

        public static int evenint(int num)
        {
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0) 
                {
                    sum += i;
                }
                
            }
            return sum;



        }
    }
}
