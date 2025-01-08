using Base_Class;

class Program
{
    static void Main(string[] args)
    {
        //Öğrenci nesnesinin tüm özelliklerini yazdıralım.

        Ogrenci Ogrenci1 = new Ogrenci();
        Ogrenci1.Ad = "Jack";
        Ogrenci1.Soyad = "London";
        Ogrenci1.OgrenciNo = 989898;

        //Öğrenci bilgilerinin tamamını bir bütün halde yazdıralım.
        Ogrenci1.YazdirOgrenci();



        //Öğretmen nesnesinin tüm özelliklerini yazdıralım.
        Ogretmen Ogretmen1 = new Ogretmen();
        Ogretmen1.Ad = "Cane";
        Ogretmen1.Soyad = "Corso";
        Ogretmen1.Maas = 70000M;

        //Öğretmen bilgilerinin tamamını bir bütün halde yazdıralım.
       Ogretmen1.YazdirOgretmen();
    }
}