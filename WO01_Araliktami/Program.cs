using System.ComponentModel.Design;

namespace WO01_Araliktami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

             // Ekrandan girilen bir sayının 0-100 arasında olup olmadığını gösteren (arasında veya arasında değil şeklinde gösteren pp

            int sayi = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Lütfen Sayınızı Giriniz :");
                sayi = Convert.ToInt32(Console.ReadLine());


                if (sayi >= 0 && sayi <= 100)
                {
                    Console.WriteLine($"Girmiş olduğunuz sayı: {sayi} 0-100 arasındadır..");
                }
                else
                {
                    Console.WriteLine($"Girmiş olduğunuz sayı: {sayi} 0-100 arasında değildir...");
                }

            } while (true);
            
            
            

            Console.ReadKey();
        }
    }
}
