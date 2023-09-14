namespace TypesAndValues{
    class Kisiler{
        public string? Isim{get; set;}
        public int Yas{get; set;}
    }

    interface IHayvan{
        void SesCikar();
    }

    class Kopek : IHayvan{
        public void SesCikar(){
            Console.WriteLine("Hav Hav!");
        }
    }
    class TypesAndValues{
        enum Gunler{
            Pazartesi, Sali, Carsamba, Persembe, Cuma, Cumartesi, Pazar
        }

        private delegate void MesajVerDelegate(string mesaj);

        struct Nokta{
            public int X;
            public int Y; 
        }
        static void Main(string[] args){
            // ValueTypes
            int tamSayi = 2;
            long uzunTamSayi = 1234567890123456789;
            short kisaTamSayi = 32767;
            byte byteDegeri = 255;
            double ciftHassasiyetli = 3.141592653589793;
            float tekHassasiyetli = 3.14F;
            decimal ondalikliDeger =  3.141592653589793238846M;
            char karakter = 'A';
            bool kosul = true;
            Gunler bugun = Gunler.Pazartesi;
            Nokta nokta = new Nokta{X=5, Y=10};

            Console.WriteLine("Tam Sayı: {0}\nUzun Tam Sayı: {1}\nKısa Tam Sayı: {2}\nByte: {3}\nÇift Hassasiyetli: {4}" +
            "\nTek Hassasiyetli: {5}\nOndalıklı Değer: {6}\nKarakter: {7}\nKoşul: {8}\nBugün: {9}\nNokta X: {10}\nNokta Y: {11}",
            tamSayi, uzunTamSayi, kisaTamSayi, byteDegeri, ciftHassasiyetli, tekHassasiyetli, ondalikliDeger,
            karakter, kosul, bugun, nokta.X, nokta.Y);

            // ReferencesTypes
            string metin = "Merhaba!";
            int[] sayiDizisi = {1, 2, 3, 4, 5};
            string[] metinDizisi = new String[5]; // Boyutu 5 olan boş bir dizi
            List<int> sayiListesi = new List<int> {1, 2, 3, 4, 5}; 
            sayiListesi.Add(5); // Boyut sınırı yok
            dynamic dinamikDeger = "Merhaba!";
            
            Console.WriteLine("Metin: {0}\nSayı Dizisi son değeri: {1}\nMetin Dizisi ilk değeri: {2}\nSayı Listesi uzunluğu: {3}\nDinamik Değer ilk değeri: {4}",
            metin, sayiDizisi[4], metinDizisi[0], sayiListesi.Count, dinamikDeger);
            
            dinamikDeger = 42; // Hata almadan değer tipi değiştirilir
            Kisiler kisi = new Kisiler{ Isim = "Dilemre", Yas = 25};

            Console.WriteLine("Dinamik Değer sonraki değeri: {0}\nKişi İsmi: {1}\nKişi Yaşı: {2}", dinamikDeger, kisi.Isim, kisi.Yas);
            
            IHayvan hayvan = new Kopek();
            MesajVerDelegate mesajVer = (msj) => Console.WriteLine("Deleate: \"" + msj + ".\" diyor");
            mesajVer("Merhaba");
        }
    }
}
