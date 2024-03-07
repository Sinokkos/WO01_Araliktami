namespace WO03_Girilen20sayiIcındanAraliktakiniBulma
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // Ekrandan 20 tane yaş bilgisi gireceğim. 
            // Bunlardan 25-30 yaş arası kaç personel olduğunu bulan pp
            // Burada iki farklı kullanım olabilir (for/while)


            
            int yas = 0, adet = 0;

            // for ile
            for (int i1 = 1; i1 <= 10; i1++) 
            {
                Console.Write($"{i1}. yaşı giriniz:\n");
                yas=Convert.ToInt32( Console.ReadLine());

                if (yas >= 25 && yas <= 30) 
                {
                    adet++;
                }
            }

            SonucYaz(adet);

            //while ile
            int i2 = 0;
            adet = 0; // İlk haline getir
            while (i2 <= 10)
            {
                Console.Write($"{i2}. yaşı giriniz:\n");
                yas = Convert.ToInt32(Console.ReadLine());

                if (yas >= 25 && yas <= 30)
                {
                    adet++;
                }

                i2++;
            }

            SonucYaz(adet);
            Console.WriteLine($"\n\n25-30 yaş aralığında {adet} personel vardır.");
            Console.ReadKey ();
        }

        #region Methods

        private static void SonucYaz(int padet) 
        {
            Console.WriteLine($"\n\n25-30 yaş aralığında {padet} personel vardır.");
        }

        #endregion
    }
}
