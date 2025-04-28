using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace alanCevreHesaplayici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n---------ANA MENU----------");
                Console.WriteLine("Hesaplama icin --> 1");
                Console.WriteLine("Cikis icin --> 0");
                int secim1 = girisKontrolu("Lutfen yapmak istediginiz islemi seciniz:", 0, 1);
                double sonuc = 0;
                switch (secim1)
                {
                    case 0:
                        Console.WriteLine("Cikis yapiliyor...");
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("\nAlan icin --> 1");
                        Console.WriteLine("Cevre icin --> 2");
                        int secim2 = girisKontrolu("Lutfen yapmak istediginiz islemi seciniz:", 1, 2);
                        int hangiCokgen = cokgenSecimi();
                        if (hangiCokgen == 1 && secim2 == 1)
                        {

                            int hangiUcgen = ucgenSecimi();
                            if (hangiUcgen == 1)
                            {
                                int kenar = girisKontrolu("Lutfen eskenar ucgenin kenar uzunlugunu giriniz:", 1, int.MaxValue);
                                sonuc = ucgenAlan(kenar, kenar, kenar);
                            }
                            else if (hangiUcgen == 2)
                            {
                                int kenar1 = girisKontrolu("Lutfen ikizkenar ucgenin ikizkenar kenar uzunlugunu giriniz:", 1, int.MaxValue);
                                int kenar2 = girisKontrolu("Lutfen ikizkenar ucgenin diger kenar uzunlugunu giriniz:", 1, int.MaxValue);
                                sonuc = ucgenAlan(kenar1, kenar1, kenar2);
                            }
                            else if (hangiUcgen == 3)
                            {
                                int kenar1 = girisKontrolu("Lutfen cesitkenar ucgenin 1.kenar uzunlugunu  giriniz:", 1, int.MaxValue);
                                int kenar2 = girisKontrolu("Lutfen cesitkenar ucgenin 2.kenar uzunlugunu  giriniz:", 1, int.MaxValue);
                                int kenar3 = girisKontrolu("Lutfen cesitkenar ucgenin 3.kenar uzunlugunu  giriniz:", 1, int.MaxValue);
                                sonuc = ucgenAlan(kenar1, kenar2, kenar3);
                            }
                        }
                        else if (hangiCokgen == 2 && secim2 == 1)
                        {
                            int kenar = girisKontrolu("Lutfen karenin kenar uzunlugunu girini:", 1, int.MaxValue);
                            sonuc = kenar * kenar;
                        }
                        else if (hangiCokgen == 3 && secim2 == 1)
                        {
                            int uzunKenar = girisKontrolu("Lutfen dikdortgenin uzun kenar uzunlugunu giriniz:", 1, int.MaxValue);
                            int kisaKenar = girisKontrolu("Lutfen dikdortgenin kisa kenar uzunlugunu giriniz:", 1, int.MaxValue);
                            sonuc = uzunKenar * kisaKenar;
                        }
                        else if (hangiCokgen == 4 && secim2 == 1)
                        {
                            int yariCap = girisKontrolu("Lutfen dairenin yaricap uzunlugunu giriniz:", 1, int.MaxValue);
                            sonuc = Math.PI * yariCap * yariCap;
                        }

                        else if (hangiCokgen == 1 && secim2 == 2)
                        {
                            int hangiUcgen = ucgenSecimi();
                            if (hangiUcgen == 1)
                            {
                                int kenar = girisKontrolu("Lutfen eskenar ucgenin kenar uzunlugunu giriniz:", 1, int.MaxValue);
                                sonuc = kenar * 3;
                            }
                            else if (hangiUcgen == 2)
                            {
                                int kenar1 = girisKontrolu("Lutfen ikizkenar ucgenin ikizkenar kenar uzunlugunu giriniz:", 1, int.MaxValue);
                                int kenar2 = girisKontrolu("Lutfen ikizkenar ucgenin diger kenar uzunlugunu giriniz:", 1, int.MaxValue);
                                sonuc = kenar1 * 2 + kenar2;
                            }
                            else if (hangiUcgen == 3)
                            {
                                int kenar1 = girisKontrolu("Lutfen cesitkenar ucgenin 1.kenar uzunlugunu  giriniz:", 1, int.MaxValue);
                                int kenar2 = girisKontrolu("Lutfen cesitkenar ucgenin 2.kenar uzunlugunu  giriniz:", 1, int.MaxValue);
                                int kenar3 = girisKontrolu("Lutfen cesitkenar ucgenin 3.kenar uzunlugunu  giriniz:", 1, int.MaxValue);
                                sonuc = kenar1 + kenar1 + kenar2;
                            }
                        }
                        else if (hangiCokgen == 2 && secim2 == 2)
                        {
                            int kenar = girisKontrolu("Lutfen karenin kenar uzunlugunu girini:", 1, int.MaxValue);
                            sonuc = kenar * 4;
                        }
                        else if (hangiCokgen == 3 && secim2 == 2)
                        {
                            int uzunKenar = girisKontrolu("Lutfen dikdortgenin uzun kenar uzunlugunu giriniz:", 1, int.MaxValue);
                            int kisaKenar = girisKontrolu("Lutfen dikdortgenin kisa kenar uzunlugunu giriniz:", 1, int.MaxValue);
                            sonuc = uzunKenar * 2 + kisaKenar * 2;
                        }
                        else if (hangiCokgen == 4 && secim2 == 2)
                        {
                            int yariCap = girisKontrolu("Lutfen dairenin yaricap uzunlugunu giriniz:", 1, int.MaxValue);
                            sonuc = 2 * Math.PI * yariCap;
                        }
                        Console.WriteLine("Sonuc:" + sonuc);
                        break;
                    default:
                        Console.WriteLine("Lutfen gecerli deger giriniz!!!");
                        break;
                }
            }
        }

        static int cokgenSecimi()
        {
            while (true)
            {
                Console.WriteLine("\nUcgen icin --> 1");
                Console.WriteLine("Kare icin --> 2");
                Console.WriteLine("Dikdortgen icin --> 3");
                Console.WriteLine("Daire icin --> 4");
                int secim = girisKontrolu("Lutfen yapmak istediginiz islemi seciniz:", 1, 4);
                return secim;
            }
        }

        static int ucgenSecimi()
        {
            while (true)
            {
                Console.WriteLine("\nEskenar ucgen icin --> 1");
                Console.WriteLine("Ikizkenar ucgenicin --> 2");
                Console.WriteLine("Cesit kenar ucgen icin --> 3");
                int secim = girisKontrolu("Lutfen yapmak istediginiz islemi seciniz:", 1, 3);
                return secim;
            }
        }

        static double ucgenAlan(int kenar1, int kenar2, int kenar3)
        {
            double s = (kenar1 + kenar2 + kenar3) / 2;
            double alan = Math.Sqrt(s * (s - kenar1) * (s - kenar2) * (s - kenar3));
            return alan;
        }

        static int girisKontrolu(string mesaj, int min, int max)
        {
            int sayi;
            while (true)
            {
                Console.Write(mesaj);
                string secim = Console.ReadLine();

                if (int.TryParse(secim, out sayi))
                {
                    if (sayi >= min && sayi <= max)
                    {
                        return sayi;
                    }
                    else
                    {
                        Console.WriteLine("Lutfen " + min + " ile " + max + " arasinda bir deger giriniz!!!");
                    }
                }
                else
                {
                    Console.WriteLine("Lutfen gecerli bir deger giriniz!!!");
                }
            }
        }

    }
}