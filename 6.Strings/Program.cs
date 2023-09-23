using System.Text;

namespace Strings{
    class Strings{
        static void Main(String [] args){
            // String'ler değiştirilemezdir (Immutability). 
            // Bir string üzerinde değişiklik yapmak yeni bir string oluşturur. Bu performans sorununa neden olabilir.
            
            // Temel Metotlar ve Özellikler
            // 1. String Interpolation: string içerisine direkt olarak değişken dahil edilmesini sağlar.
            int yas = 26;
            string sonuc = $"Benim yaşım {yas}";
            Console.WriteLine(sonuc);

            // 2. String Literalleri: 
            // @ Kullanımı:  Gerçek dosya yolları veya regex gibi özel karakterleri içeren strinleri tanımlamak için kullanılır.
            string yol = @"C:\Kullanıcılar\Dosya";
            Console.WriteLine("Yol: " + yol);

            // $ ve @ Kombinasyonu: iki özellik aynı anda kullanılabilir.
            string klasor = "Dosyalar";
            string tamYol = @$"C:\Kullanıcılar\{klasor}";
            Console.WriteLine(tamYol);

            // 3. String Pooling:Aynı değere sahip stringler aynı referansa sahiptir. 
            // Oluşturulan stringler otomatik olarak string havuzuna alınır.
            // Ancak `new` anahtar kelimesi ile veya `string` metotuy ile oluşturulanlar strin havuzuna otomatik alınmaz.
            // Bir stringi havuza eklemek için `Strin.Intern` metodu kullanılır.
            string s1 = "merhaba";
            string s2 = "merhaba";
            Console.WriteLine($"\n1. string: {s1}, 2. string: {s2}, aynı mı: {object.ReferenceEquals(s1, s2)}");
            string s3 = new(new char[] {'m', 'e', 'r', 'h', 'a', 'b', 'a'});
            Console.WriteLine($"1. string: {s1}, 3. string: {s3}, aynı mı: {object.ReferenceEquals(s1, s3)}");

            // 4. Length: stringlerin karakter sayısını döndürür.
            Console.WriteLine($"\n{s1}'de {s1.Length} tane karakter vardır."); 

            // 5. IndexOf ve LastIndexOf:
            Console.WriteLine($"\na harfi {s1} kelimesinin {s1.IndexOf('a')+1}. ve {s1.LastIndexOf('a')+1}. harfidir.");

            // 6. Substring: stringin belirli bir kısmını alır.
            Console.WriteLine($"\n{s1} kelimesinin 1. ve 3. isdeksleri arasındaki karakterler: {s1.Substring(1, 3)}");

            // 7. Replace: stringin içerisinde belirli bir dizeyi başka bir dize ile değiştirir.
            Console.Write($"\nOrjinal metin: {s2}");
            s2 = s2.Replace("rha", "RHA");
            Console.WriteLine($" Değiştirilmiş metin: {s2}");

            // 8. ToUpper ve ToLower: stringin tüm karakterlerini büyük/küçük harfe çevirir.
            Console.WriteLine($"\nOrjinal metin: {s2}\nBütün herfleri küçük harfe dönüştürülmüş hali: {s2.ToLower
            ()}\nBütün harfleri büyük harfe dönüştürülmüş hali: {s2.ToUpper()}");

            // 9. Trim: stringin başındaki ve sonundaki boşlukları kaldırır. 
            s3 = "    Merhaba ben   Dilemre    ";    
            Console.WriteLine($"\nOrjinal metin: {s3}\nBaştaki ve sonraki boşlukları temizlenmiş metin: {s3.Trim
            ()}\nBaştaki boşlukları temizlenmiş metin: {s3.TrimStart()}\nBaştaki boşlukları temizlenmiş metin:{s3.TrimEnd()}");

            // 10. Split: stringi belirli bir karakter veya diziye göre böler ve sonucu bir dizi olarak döndürür.
            string meyveler = "Elma, Armut, Muz, Karpuz";
            Console.WriteLine($"\nOrjinal metin: {meyveler}");
            string[] meyveDizisi = meyveler.Split(", ");
            Console.Write("Meyve dizisi: ");
            Array.ForEach(meyveDizisi, x=>Console.Write($" {x} "));

            // 11. StartsWith ve EndsWith: stringin belirli bir dize ile başladığını/ bittiğini kontrol eder.
            Console.WriteLine($"\n\n{s1} metini M ile başlıyor mu: {s1.StartsWith('M')}");
            Console.WriteLine($"{s1} metini a ile bitiyor mu: {s1.EndsWith('a')}");

            // 12. Contains: stringin belirli bir dizeyi içerip içermediğiniz kontrol eder.
            Console.WriteLine($"\n{s1} metini elma içeriyor mu: {s1.Contains("elma")}");

            // 13. String.IsNullOrEmpty ve String.IsNullOrWhiteSpace: bir stringin boş veya null olup olmadığını
            // kontrol etmek için IsNullOrEmpty kullanılır. Stringin boş, null veya boş karakterlerden oluştuğunu kontrol etmek için
            // IsNullOrWhiteSpace kullanılır.
            string bosString = "";
            string beyazBosluk = "    ";
            Console.WriteLine($"\nBu string boş mu, beyaz boşluk mu?\nBoş string: {String.
            IsNullOrEmpty(bosString)}\nBeyaz boşluk: {String.IsNullOrWhiteSpace(bosString)}");
            Console.WriteLine($"\nBu string boş mu, beyaz boşluk mu?\nBoş string: {String.
            IsNullOrEmpty(beyazBosluk)}\nBeyaz boşluk: {String.IsNullOrWhiteSpace(beyazBosluk)}");

            // 14. Normalize: Unicode karakterler farklı şekilde temsil edilebilir. `Normalize` metodu
            // bu karakterleri standart forma getirmek için kullanılır.
            string anormalMetin = "Çağıl";
            Console.WriteLine($"\nOrjinal metin: {anormalMetin}\nNormalize edilmiş metin: {anormalMetin.
            Normalize(NormalizationForm.FormKD)}");

            // 15. String.Format: Yer tutucuları ve biçimlendirme özelliklerini kullanarak karmaşık string
            // yapıları oluşturur.
            Console.WriteLine($"\n{String.Format("{0} ve {1} {2} yaşında.", "Hüseyin", "Emre", 13)}");


        }
    }
}