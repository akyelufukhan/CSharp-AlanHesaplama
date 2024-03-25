using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplamaProgrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Menü Değeri
            int secilen;

            // Dik Üçgen
            int du_a, du_h, du_alan;

            // Dikdörtgen 
            int dd_k, dd_u, dd_alan;

            // Kare
            int k_a, k_alan;

        baslangic_menu:
            Console.WriteLine("### Alan Hesaplama Menüsü ###");
            Console.WriteLine("(1) Dik Üçgen Alan Hesaplama");
            Console.WriteLine("(2) Dikdörtgen Alan Hesaplama");
            Console.WriteLine("(3) Kare Alan Hesaplama\n");

            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz (1)(2)(3): ");
            secilen = Convert.ToInt32(Console.ReadLine());

            if (secilen <= 0 || secilen > 3)
            {
                Console.WriteLine("Lütfen doğru seçim yapınız.");
                goto baslangic_menu;
            }

            //Dik Üçgen
            if (secilen == 1)
            {
            dik_ucgen:
                Console.Write("\nÜçgenin yüksekliğini girin: ");
                du_h = Convert.ToInt32(Console.ReadLine());
                if (du_h <= 0)
                {
                    Console.WriteLine("Lütfen pozitif değer girin.");
                    goto dik_ucgen;
                }

                Console.Write("Üçgenin tabanını girin: ");
                du_a = Convert.ToInt32(Console.ReadLine());
                if (du_a <= 0)
                {
                    Console.WriteLine("Lütfen pozitif değer girin.");
                    goto dik_ucgen;
                }

                du_alan = (du_a * du_h) / 2;
                Console.WriteLine("\nDik üçgeninin alani: " + du_alan);
                Console.WriteLine("\nProgramdan çıkmak için herhangi bir tuşa basın.");
                Console.ReadKey();
            }

            //Dikdörtgen
            if (secilen == 2)
            {
            dikdortgen:
                Console.Write("\nDikdörtgenin kısa kenarını girin: ");
                dd_k = Convert.ToInt32(Console.ReadLine());
                if (dd_k <= 0)
                {
                    Console.WriteLine("Lütfen pozitif değer girin.");
                    goto dikdortgen;
                }

                Console.Write("Dikdörtgenin uzun kenarını girin: ");
                dd_u = Convert.ToInt32(Console.ReadLine());
                if (dd_u <= 0)
                {
                    Console.WriteLine("Lütfen pozitif değer girin.");
                    goto dikdortgen;
                }

                if (dd_k == dd_u)
                {
                    Console.WriteLine("Dikdörtgen değildir.\n");
                    goto baslangic_menu;
                }

                if (dd_k > dd_u)
                {
                    Console.WriteLine("Kısa kenar uzun kenardan büyük olamaz.");
                    goto dikdortgen;
                }

                dd_alan = dd_k * dd_u;
                Console.WriteLine("\nDikdörtgenin alanı: " + dd_alan);
                Console.WriteLine("\nProgramdan çıkmak için herhangi bir tuşa basın.");
                Console.ReadKey();
            }

            //Kare
            if (secilen == 3)
            {
            kare:
                Console.Write("Karenin bir kenarını girin: ");
                k_a = Convert.ToInt32(Console.ReadLine());
                if (k_a <= 0)
                {
                    Console.WriteLine("Karenin kenarı negatif olamaz.");
                    goto kare;
                }

                k_alan = k_a * k_a;
                Console.WriteLine("\nKarenin alanı: " + k_alan);
                Console.WriteLine("\nProgramdan çıkmak için herhangi bir tuşa basın.");
                Console.ReadKey();
            }
        }
    }
}
