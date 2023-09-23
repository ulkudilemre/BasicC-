namespace ArraysAndLists{
    class ArraysAndLists{
        static void Main(string[] args){
            // Diziler sabit boyuta, Listeler dinamik boyuta sahiptir.
            // Dizi tanımlama ve ögeye ulaşma:
            int[] sayiDizisi = new int[5];
            string[] isimDizisi = {"Ali", "Ayşe", "Ahmet"}; 
            Console.WriteLine($"Sayi dizisi ilk eleman {sayiDizisi[0]}");

            // Liste tanımlama ve temel metotlar:
            List<int> sayiListesi = new List<int>();
            List<string> isimListesi = new List<string> {"Ali", "Ayşe", "Ahmet"};
            sayiListesi.Add(5);
            sayiListesi.Remove(5);
            Console.WriteLine($"İsim listesi ilk eleman {isimListesi[0]}\n");

            // Dizi Özellikleri ve Metotları
            // Çok oyutlu diziler (Multidimensional Arrays):
            int[,] matris = new int[3, 4];
            matris[0, 0] = 1;
            Console.WriteLine($"Çok boyutlu dizinin ilk elemanı: {matris[0, 0]}");
            int[,] matris2 = { {1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12} };
            int [,,] matris3 = new int[2, 2, 2];

            // Dizi boyutunu ve uzunluğunu alma
            Console.WriteLine($"İki boyutlu dizi satır sayısı: {matris.GetLength(0)}" + 
            $" sütun sayısı: {matris.GetLength(1)}" + 
            $" toplam eleman sayısı: {matris.Length}");
            Console.WriteLine($"Üç boyutlu dizi ilk boyut sayısı: {matris3.GetLength(0)}" + 
            $" ikinci boyut sayısı: {matris3.GetLength(1)}" + 
            $" üçüncü boyut sayısı: {matris3.GetLength(2)}" + 
            $" toplam eleman sayısı: {matris3.Length}");

            // Çok boyutlu dizi iterasyonu
            Console.WriteLine("Çok boyutlu dizinin tüm elemanları:");
            for (int i = 0; i < matris2.GetLength(0); i++){
                for (int j = 0; j < matris2.GetLength(1); j++)
                {
                    Console.Write(matris2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Dizi Dizisi (Jagged Arrays)
            int[][] jaggedDizi = new int[3][];
            jaggedDizi[0] = new int[5] { 1, 2, 3, 4, 5 };    // İlk dizi 5 elemana sahip
            jaggedDizi[1] = new int[3] { 6, 7, 8 };          // İkinci dizi 3 elemana sahip
            jaggedDizi[2] = new int[4] { 9, 10, 11, 12 };    // Üçüncü dizi 4 elemana sahip

            Console.WriteLine("\nJagged dizinin elemanları:");
            foreach (var diziler in jaggedDizi){
                foreach(var eleman in diziler){
                    Console.Write(eleman + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nJagged dizinin eleman sayısı: {0}",jaggedDizi.Length);
            Console.WriteLine("Jagged dizisinin ilk elemanının eleman sayısı: {0}",jaggedDizi[0].Length);

            // 1. Length: dizi içerisindeki toplam ögeyi döndürür.
            Console.WriteLine("\nSayı dizi içindeki toplam eleman sayısı: {0}", sayiDizisi.Length);

            // 2. Rank: dizinin kaç boyutlu olduğunu döndürür.
            Console.WriteLine("\nMatrisin boyut sayısı: {0}", matris.Rank);

            // 3. GetValue ve SetValue: belirli bir indeksteki değeri almak veya değer atamak için kullanılır.
            Console.WriteLine("\nSayı dizisi 2. indexteki eleman: " + sayiDizisi.GetValue(2));
            sayiDizisi.SetValue(100, 2);
            Console.WriteLine("Sayı dizisi 2. indeksteki yeni eleman " + sayiDizisi.GetValue(2));

            // 4. Clear: dizide istenilen aralıktaki degerleri varsayılan deger yapar.
            Array.Clear(sayiDizisi, 0, sayiDizisi.Length);

            // 5. Sort: diziyi sıralar
            Array.Sort(isimDizisi);
            Console.Write("\nSıralanmış isim dizisi: ");
            foreach(var eleman in isimDizisi){
                Console.Write(eleman + "\t");
            }

            // 6. Revers: dizinin sırasını ters çevirir.
            Array.Reverse(isimDizisi);
            Console.Write("\nTers sıralanmışş isim dizisi: ");
            foreach(var eleman in isimDizisi){
                Console.Write(eleman + "\t");
            }

            // 7. Copy: bir diziyi aşka bir diziye kopyalar.
            int[] kopyaDizi = {10, 20, 30, 40, 50};

            Console.WriteLine("\n\nKopyalanacak dizinin içeriği: ");
            foreach(var eleman in kopyaDizi){
                Console.Write(eleman + "\t");
            }

            Console.WriteLine("\nSayı dizi içeriği: ");
            foreach (var eleman in sayiDizisi)
            {
                Console.Write(eleman + "\t");
            }

            Array.Copy(kopyaDizi, sayiDizisi, 3);

            Console.WriteLine("\nSayı dizisine kopyalanan ilk 3 içerik: ");
            foreach (var eleman in sayiDizisi)
            {
                Console.Write(eleman + "\t");
            }

            // 8. IndexOf ve LastIndexOf: bir dizideki belirli bir ögenin ilk veya son indeksini döndürür.
            int[] dizi = {1, 2, 3, 4, 5, 4, 3, 2, 1};
            Console.WriteLine($"\n\n3'ün bulunduğu ilk dizi: {Array.IndexOf(dizi, 3)}");
            Console.WriteLine($"3'ün bulunduğu son dizi: {Array.LastIndexOf(dizi, 3)}");

            // 9. Resize: bir dizinin boyutu değiştirilmek istendiğinde kullanılır.
            // Ancak bu işlem yeni bir dizi oluşturduğundan verimli değildir.
            Console.WriteLine($"\nDizinin eski boyutu: {dizi.Length}");
            Array.Resize(ref dizi, 10);
            Console.WriteLine($"Dizinin yeni boyutu: {dizi.Length}");

            // 10. BinarySearch: bir dizide öge aramak için ikili arama algoritması kullanır. 
            // Ancak dizinin sıralı olması gerekir.
            Array.Sort(dizi);
            Console.WriteLine($"\nBinary Search ile bulunan 5 ögesinin indeksi: {Array.BinarySearch(dizi, 5)}");

            // 11. Find ve FindAll: dizi içindeki ögeleri belirli kriterlerle aramak için kullanılır.
            int tekSayi = Array.Find(dizi, sayi=>sayi % 2 != 0);
            int[] tumTekSayi = Array.FindAll(dizi, sayi=>sayi % 2 != 0);
            Console.WriteLine($"\nDizideki ilk tek sayi: {tekSayi}, toplam tek sayi: {tumTekSayi.Length}");

            // 12. ForEach: dizi üzerinde bir işlem gerçekleştirmek için kullanılır.
            // Ancak u yöntem array sınıfının metodu değil, LINQ metodudur.
            Console.WriteLine("\nLINQ ForEach ile bastırılan dizi:");
            Array.ForEach(dizi, eleman=>Console.Write(eleman + " "));

            // 13. LINQ: language interated query, koleksiyonlar üzerinde soru yapmayı kolaylaştırır.
            var tekSayilar = from sayi in dizi where sayi % 2 != 0 select sayi;
            var tekSayilarLINQ = dizi.Where(sayi => sayi % 2 != 0);

            Console.WriteLine("\n\nİki sorgu sonucu eşit mi: {0}", tekSayilar.SequenceEqual(tekSayilarLINQ));

            // Liste Özellikleri ve Metotları
            // 1. AddRange: listeye birden fazla eleman ekler.
            Console.WriteLine($"\nBoş liste: {sayiListesi.Any()}");
            sayiListesi.AddRange(new int[] {1, 2, 3, 4, 5});
            Console.WriteLine($"Birden çok eleman eklenmiş liste: {string.Join(", ", sayiListesi)}");

            // 2. Remove: Listeden belirtilen elemanı siler.
            sayiListesi.Remove(5);
            Console.WriteLine($"\n5 elemanı silinmiş liste: {string.Join(", ", sayiListesi)}");

            // 3. RemoveAt: Listede belirtilen inddeksteki elemanı siler.
            sayiListesi.RemoveAt(0);
            Console.WriteLine($"\n0. indeksteki elemanı silinmiş liste: {string.Join(", ", sayiListesi)}");
            
            // 4. Count: Listedeki eleman sayısını döndürür.
            Console.WriteLine($"\nListedeki eleman sayısı: {sayiListesi.Count}");

            // 5. Clear: Tüm elemanları varsayılan değer yapar.
            sayiListesi.Clear();
            Console.WriteLine($"\nTemizlenmiş liste eleman sayısı: {sayiListesi.Count}");

            // 6. IndexOf ve LastIndexOf:
            sayiListesi.AddRange(new int[] {1, 2, 3, 4, 5, 4, 3, 2, 1});
            Console.WriteLine($"\n3'ün listedeki ilk indeksi: {sayiListesi.IndexOf(3)}");
            Console.WriteLine($"3'ün listedeki son indeksi: {sayiListesi.LastIndexOf(3)}");

            // 7. Sort: 
            sayiListesi.Sort();
            Console.WriteLine($"\nSıralanmış liste: {string.Join(", ", sayiListesi)}");

            // 8. Reverse:
            sayiListesi.Reverse();
            Console.WriteLine($"\nTers çevirilmiş liste: {string.Join(", ", sayiListesi)}");

            // . Find ve FindAll:
            int ciftSayi = sayiListesi.Find(eleman => eleman % 2 == 0);
            List<int> tumCiftSayi = sayiListesi.FindAll(eleman => eleman % 2 == 0);
            Console.WriteLine($"Listedeki ilk çift sayi: {ciftSayi}, listedeki toplam çift sayi: {tumCiftSayi.Count}");

            // 10. Exists: belirli bir kritere göre elemanın var olup olmadığını kontrol eder.
            Console.WriteLine($"\nAli isminde biri var mı: {isimListesi.Exists(isim => isim == "Ali")}");

            // 11. ForEach: listedeki tüm elemanlar üzerinde işlem yapar:
            Console.Write("\nTüm isimler:");
            isimListesi.ForEach(isim => Console.Write(", " + isim)); 

            // 12. Contains: listede belirli bir elemanın olup olmadığını kontrol eder.
            Console.WriteLine($"\n\nAli var mı: {isimListesi.Contains("Ali")}");

            // 13. Insert: belirli bir indekse eleman ekler.
            isimListesi.Insert(1, "Mehmet");
            Console.WriteLine($"\n1. indekse eklendi: {isimListesi[1]}");

            // 14. TrueForAll: tüm ögelerin belirli bir koşşulu karşılayıp karşılamadığını kontrol eder.
            Console.WriteLine($"\ntüm elemanlar pozitif mi: {sayiListesi.TrueForAll(s=>s>0)}");

            // 15. AsReadOnly: listeyi salt-okunur bir koleksiyona dönüştürür.
            var readOnlyList = isimListesi.AsReadOnly();

            // 16. Capacity: toplam depolanabilecek kapasiteyi döndürür.
            Console.WriteLine($"\nListenin toplam kapasitesi: {sayiListesi.Capacity}");

            // 17. TrimExcess: kapasiteyi, ne kadarı kullanılıyorsa o kadara indiger.
            sayiListesi.TrimExcess();
            Console.WriteLine($"Kapasite gerçek boyuta indirildiğinde: {sayiListesi.Capacity}");

            // 18. ConvertAll: listedeki tüm elemanların başka bir tipe dönüştürür.
            List<string> stringListesi = sayiListesi.ConvertAll(sayi=>sayi.ToString());

            // 19. ToArray: listeyi bir diziye dönüştürür.
            string[] newDizi = stringListesi.ToArray();
        }
    }
}