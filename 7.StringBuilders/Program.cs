using System.Text;

namespace StringBuilders{
    class StringBuilders{
        static void Main(String [] args){
            // .Net'te dinamik olarak değişen metinleri etkili bir şekilde işlemek için kullanılır.
            // System.Text altında bulunur. `string` tipinin aksine `String.Builder` değiştirilebilir (mutable)
            // bir yapıya sahiptir, bundan dolayı metin üzerinde birden çok değişiklik yapılacağı zaman performans sağlar.

            // Temel Metotlar ve Özellikler
            // 1. Append: metini StringBuilder'in sonuna ekler.
            StringBuilder sb = new StringBuilder();
            sb.Append("Merhaba");
            Console.WriteLine($"Yeni StringBuilder: {sb}");

            // 2. AppendLine: metini ekler ve sonraki satıra geçer.
            sb.AppendLine(" Dünya");
            Console.WriteLine(sb);

            // 3. Insert: belirtilen indekse metni ekler.
            sb.Insert(7, "Güzel");
            Console.WriteLine(sb);

            // 4. Remove: belirtilen indeksten itibaren belirtilen uzunluktaki metni siler. 
            sb.Remove(0, 8);
            Console.WriteLine(sb);

            // 5. Replace: belirtilen metni başka bir metin ile değiştirir.
            sb.Replace("Güzel", "Büyük");

            // 6. ToString: StringBuilder'ı String'e çevirir.
            string sonuc = sb.ToString();

            // 7. Clear: içeriği temizler.
            sb.Clear();
        }
    }
}
