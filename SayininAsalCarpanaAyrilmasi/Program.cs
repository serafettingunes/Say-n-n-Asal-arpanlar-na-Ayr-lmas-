using System;
using System.Collections;

namespace SayininAsalCarpanaAyrilmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            int sayac = 0, carp = 1, carp2 = 1;
            for (int i = 2; i <= 1000; i++)
            {
                for (int J = 1; J <= i; J++)
                {
                    if (i % J == 0)
                    {
                        sayac++;
                    }
                }
                if (sayac == 2)
                {
                    ar.Add(i);

                }
                sayac = 0;
            }
            int xx = 0, yy = 0, k = 1;
            Console.Write("Sayı giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());


            foreach (var item in ar)

            {

                for (; ; )
                {

                    if (x % (int)item == 0)
                    {
                        Console.WriteLine(item);
                        carp *= (int)item;
                        xx = x / (int)item;
                        x = xx;
                    }


                    else
                    {
                        break;
                    }




                }


            }



        }
    }
}
