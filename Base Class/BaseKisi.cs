using System;

namespace Base_Class
{
    public class BaseKisi // Burada tanımlanan özellikler ortak kullanılacak olanlardır.
    {
        public string Ad {  get; set; }
        public string Soyad  { get; set; }
        public void YazdirAdSoyad ()
        {
            Console.WriteLine($"Adı: {Ad}, Soyadı: {Soyad}");
        }
     }
    public class Ogrenci : BaseKisi //Ortak özelliklerin dışında kalan özellikler burada tanımlanır.
    {
        public int OgrenciNo { get; set; }
        public void YazdirOgrenci()
        {
            Console.WriteLine($"Adı: {Ad}, Soyadı: {Soyad}, Öğrenci Numaranız: {OgrenciNo}");
        }
    }
    public class Ogretmen : BaseKisi //Ortak özelliklerin dışında kalan özellikler burada tanımlanır.
    {
        public decimal Maas { get; set; }
        public void YazdirOgretmen()
        {
            Console.WriteLine($"Adı: {Ad}, Soyadı: {Soyad}, Maaşınız: {Maas}");
        }
    }
}
