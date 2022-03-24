using System;


// rastgele 2 esit elmanli double dizi olustur ve elemanlarini topla

namespace Dizi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] asd = new int[2, 3];
            asd[1, 2] = 2;
            int sutun, satir;
            Console.Write("Satir sayisi: ");
            satir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sütun sayisi: ");
            sutun = Convert.ToInt32(Console.ReadLine());
            double[,] dizi1 = new double[satir, sutun];
            double[,] dizi2 = new double[satir, sutun];
            dizi1 = DiziOku(satir, sutun);
            dizi2 = DiziOku(satir, sutun);
            DiziTopla(dizi1, dizi2);
        }

        static double[,] DiziOku(int satir, int sutun)
        {
            double[,] dizi = new double[satir, sutun];

            Random rnd = new Random();
            Console.WriteLine("");
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {

                    dizi[i, j] = Convert.ToDouble(rnd.Next(100));
                }
            }
            return dizi;
        }


        static void DiziTopla(double[,] dizi1, double[,] dizi2)
        {
            Console.WriteLine("");
            int satir = dizi1.GetLength(0);
            int sutun = dizi1.GetLength(1);

            double[,] toplam = new double[satir, sutun];

            for (int i = 0; i < satir; i++)
            {
               
                for (int j = 0; j < sutun; j++)
                {
                    Console.WriteLine(j);
                    toplam[i, j] = dizi1[i,j] + dizi2[i, j];
                }
            }

            Console.WriteLine("\n\nDizi 1");
            for (int i = 0; i < satir ; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write("{0}   ", dizi1[i, j]);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\n\nDizi 2");
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write("{0}   ", dizi2[i, j]);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\n\ntoplam:");
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write("{0}   ", toplam[i, j]);
                }
                Console.WriteLine("");
            }
        }

    }
}
