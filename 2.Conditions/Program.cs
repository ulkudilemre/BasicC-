namespace Conditions{
    class Conditions{
        static void Main(string[] args){
            int sayi = 10;
            // If Bloku
            if(sayi > 5){
                Console.WriteLine("If bloku: Sayı 5'ten büyük.");
            }

            // Tek satırda if bloku
            if(sayi > 5) Console.WriteLine("Tek satır if loku: Sayı 5'ten büyük.");

            // Birden fazla koşulu kontrol etme
            if(sayi > 15){
                Console.WriteLine("Birden çok koşul: Sayı 15'ten büyük.");
            }else if(sayi > 5){
                Console.WriteLine("Birden çok koşul: Sayı 5'ten büyük.");
            }else{
                Console.WriteLine("Birden çok koşul: Sayı 5'ten küçük veya eşit.");
            }

            // İç içe if bloku
            if(sayi > 5){
                Console.WriteLine("İç içe if: Sayı 5'ten büyük.");
                if(sayi > 8){
                    Console.WriteLine("İç içe if: Sayi 8'den büyük.");
                }
            }

            // Switch Bloku
            int gun = 3;
            switch(gun){
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("Geçersiz gün numarası.");
                    break;
            }

            // Tenary Operatörü
            // Tek satırda if-else enzeri bbir kontrol sağlar
            string sonuc = (sayi>5) ? "Sayı 5'ten büyük." : "Sayı 5'e eşit veya küçük.";
            Console.WriteLine("Tenary: " + sonuc);

            // Null Coalescing Operator (??)
            // Bir nesnenin null olup olmadığını kontrol eder. Eğer null ise elirtilen değeri döndürür.
            string? ad = null;
            sonuc = ad ?? "isimsiz";
            Console.WriteLine("Null Coalescing: "+ sonuc);

            // Null Condditional Operator (?)
            // Bir nesnenin null olup olmadığını kontrol eder, null ise sonraki işlemi yapmaz.
            string[]? dizi = null;
            int? uzunluk = dizi?.Length;
            Console.WriteLine("Null Conditional: Hata almadan program devam eder.");

            // Pattern Matching
            // Switch için faklı tiplere veya yapıya sahip nesneler için koşul oluşturulur.
            object obj = "Merhaba!";
            switch(obj){
                case int i when i>5:
                    Console.WriteLine("Pattern Matching: Sayı 5'ten büyük");
                    break;
                case string s:
                    Console.WriteLine($"Metin: {s}");
                    break;
            }

        }
    }
}