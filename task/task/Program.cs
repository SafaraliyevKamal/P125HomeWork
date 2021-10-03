using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {

            #region // Tek ve Cut
            //int n = 10;
            //if (n == 0) 
            //{
            //    Console.WriteLine("Don't enter zero");
            //}
            //else
            //{
            //    if (n % 2 == 1) 
            //    {
            //        Console.WriteLine("Odd");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Even");
            //    }
            //}
            #endregion

            #region // 3 ve 7 bolunen ededler
            //int n = 21;
            //if (n == 0) 
            //{
            //    Console.WriteLine("Don't enter zero");
            //}
            //else
            //{
            //    if (n % 3 == 0 && n % 7 == 0) 
            //    {
            //        Console.WriteLine("This number is divisible by 3 and 7");
            //    }
            //    else
            //    {
            //        Console.WriteLine("This number is not divisible by 3 and 7");
            //    }
            //}
            #endregion

            #region // Wardrobe and Door

            //int a = 10; // Heigh of Wardrobe
            //int b = 22; // Length of Wardrobe
            //int c = 39; // Width of Wardrobe
            //int d = 14; // Heigh of Door
            //int e = 37; // Length of Door

            //if (a < d && b < e) 
            //{
            //    Console.WriteLine("The Wardrobe goes through th Door");
            //}
            //else
            //{
            //    if (a < d && c < e) 
            //    {
            //        Console.WriteLine("The Wardrobe goes through th Door");
            //    }

            //    else
            //    {
            //        if (c < d && b < e)
            //        {
            //            Console.WriteLine("The Wardrobe goes through th Door");
            //        }

            //        else
            //        {
            //            if (b < d && c < e) 
            //            {
            //                Console.WriteLine("The Wardrobe goes through th Door");
            //            }

            //            else
            //            {
            //                Console.WriteLine("Wardrobe is bigger than the Door");
            //            }
            //        }
            //    }
            //}
            #endregion

            #region // n ve m ededleri arasinda tek ededleri yazdir

            //int n = 1;
            //int m = 10;

            //for (int i = n; i <= m; i++) 
            //{
            //    if (i % 2 == 1) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region // n ve m ededleri arasinda tek ededlerin cemini yazdir

            //int n = 1;
            //int m = 5;
            //int sum = 0;

            //for (int i = n; i <= m; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            #endregion

            #region // n ve m arasindaki tek ededler
            //int n = 1;
            //int m = 10;
            //int sum = 0;

            //if (n < m) 
            //{
            //    for (int i = n; i <= m; i++) 
            //    {
            //        if (i % 2 == 0) 
            //        {
            //            sum++;
            //        }

            //    }
            //    Console.WriteLine(sum);
            //}
            //else
            //{
            //    Console.WriteLine("m>n");
            //}
            #endregion

            #region // sade ve murekkeb

            //int n = 2;
            //int sum = 0;

            //if (n == 0 || n == 1) 
            //{
            //    Console.WriteLine("sade");
            //}
            //else
            //{
            //    for (int i = 1; i <= n; i++)
            //    {
            //        if (n % i == 0)
            //        {
            //            sum++;
            //        }
            //    }
            //    if (sum > 2)
            //    {
            //        Console.WriteLine("murekkeb");
            //    }
            //    else
            //    {
            //        Console.WriteLine("sade");
            //    }
            //}
            #endregion

            #region // mertebe sayi (For'nan)

            //int n = 123456789; 
            //int sum = 0;
            //for (int i = n; i >= 1; i /= 10)  
            //{
            //    sum++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region // mertebe sayi (While'nan)

            //int n = 123456789;
            //int sum = 0;

            //while (n >= 1) 
            //{
            //    n /= 10;
            //    sum++;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region // 2'nin quvveti

            //int n = 4;

            //while (n % 2 == 0) 
            //{
            //    n /= 2;
            //}
            //if (n == 1) 
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}
            #endregion

            #region // bilmirem ))

            //int[] arr = { 2, 3, 1, 2, 3, 4, 3 };
            //int sum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}
            //Console.WriteLine(sum);
            #endregion

        }
    }
}
