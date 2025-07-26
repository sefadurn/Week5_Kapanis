using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapanisSorulari
{
    public class Araba  // ARABA SINIFI TANIMLADIK.
    {
        public DateTime UretimTarihi { get; set; }  // ARABANIN PROPERTY'LERİNİ TANIMLADIK.
        public string SeriNo { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int KapiSayisi { get; set; }

        public Araba()  // ARABA NESNESİ OLUŞTURULURKEN ÜRETİM TARİHİNİ ŞİMDİYE AYARLADIK.
        {
            UretimTarihi = DateTime.Now; // Araba üretilir üretilmez otomatik olarak atanacak!
        }

        static void Main()
        {
            List<Araba> arabalar = new List<Araba>();  // ARABA'LARI İÇERİSİNDE TUTACAK BİR LİSTE OLUIŞTURDUK.

            while (true)  // SONSUZ BİR DÖNGÜ TANIMLADIK. KULLANICI CIKMAK İSTEYENE KADAR DEVAM EDER.
            {
                Console.Write("Araba üretmek istiyor musunuz? (e/h): ");
                string cevap = Console.ReadLine().Trim().ToLower();  // BOŞLUKLARI KALDIR VE KÜÇÜK HARFE ÇEVİR. 

                if (cevap == "h")
                {
                    Console.WriteLine("Program sonlandırıldı.");
                    break;
                }
                else if (cevap != "e")
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen sadece 'e' veya 'h' giriniz.\n");
                    continue;  // !!!!!! continue komutu, içinde bulunduğu döngünün o anki turunu (iteration) atlayarak doğrudan başa dönmesini sağlar. Altındaki kodlar çalıştırılmaz!!!!!
                }

                // YENİ BİR ARABA NESNESİ OLUŞTURDUK.
                Araba yeniAraba = new Araba();

                Console.Write("Seri Numarası: ");
                yeniAraba.SeriNo = Console.ReadLine();

                Console.Write("Marka: ");
                yeniAraba.Marka = Console.ReadLine();

                Console.Write("Model: ");
                yeniAraba.Model = Console.ReadLine();

                Console.Write("Renk: ");
                yeniAraba.Renk = Console.ReadLine();

                // KAPI SAYISI DOĞRU GİRİLİP GİRİLMEDİĞİNE GÖRE TEKRAR SORMAK İÇİN BOOL DEĞİŞKEN TANIMLADIK.
                bool gecerliMi = false;
                while (!gecerliMi)
                {
                    Console.Write("Kapı Sayısı: ");
                    string giris = Console.ReadLine();

                    if (int.TryParse(giris, out int kapiSayisi))  // TRYPARSE İLE GİRİLEN STRİNG DEĞER SAYİYA ÇEVRİLİYOR MU KONTROL EDİLİYOR.
                    {
                        yeniAraba.KapiSayisi = kapiSayisi;
                        gecerliMi = true;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
                    }
                }

                arabalar.Add(yeniAraba);  // kULLANICIDAN ALINAN ÖZELLİKLER İLE ÜRETİLEN ARABA LİSTEYE EKLENDİ.

                Console.Write("Başka bir araba eklemek ister misiniz? (e/h): ");
                string devamCevap = Console.ReadLine().Trim().ToLower();

                if (devamCevap != "e")
                {
                    Console.WriteLine("\nTüm Araçlar:");
                    foreach (var araba in arabalar)  // FOREACH İLE ARABALAR LİSTESİNDEKİ HER BİR ARABANIN SERİNO VE MARKASI YAZDIRILIYOR.
                    {
                        Console.WriteLine($"Seri No: {araba.SeriNo}, Marka: {araba.Marka}");
                    }
                    break; // DÖNGÜYÜ BİTİR
                }
            }
        }
    }
}

