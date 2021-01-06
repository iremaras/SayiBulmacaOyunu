using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiBulmacaOyunu
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rastgeleSayiUreteci = new Random();
            bool devamEtmekIstiyorMusunuz = false;

            while (!devamEtmekIstiyorMusunuz)
            {
                int uretilenSayi = rastgeleSayiUreteci.Next(1, 100); // 100 dahil değil
                bool sayiBulunduMu = false;

                while (!sayiBulunduMu)
                {
                    Console.WriteLine("Tahminizi Girin: ");
                    int tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());

                    if (uretilenSayi > tahminEdilenSayi)
                    {
                        Console.WriteLine("Yukarı çık!");
                    }
                    else if (uretilenSayi < tahminEdilenSayi)
                    {
                        Console.WriteLine("Aşağı in!");
                    }
                    else
                    {
                        Console.WriteLine("Eşittir.");
                        sayiBulunduMu = true;
                        Console.WriteLine("Bir tur daha oynamak istiyor musunuz? (evet/hayır)");
                        string cevap = Console.ReadLine();
                        switch (cevap)
                        {
                            case "evet":
                            case "Evet":
                            case "EVET":
                                devamEtmekIstiyorMusunuz = false;
                                break;
                            case "hayır":
                            case "Hayır":
                            case "HAYIR":
                                devamEtmekIstiyorMusunuz = true;
                                break;
                            default:
                                Console.WriteLine("Geçerli bir cevap girmelisin");
                                break;
                        }
                    }
                } 
            }

            Console.ReadLine();
        }
    }
}
