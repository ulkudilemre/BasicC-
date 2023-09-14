using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Loops{
    class Loops{
        public static IEnumerable<int>YieldKareUret(int max){
            for(int i = 1; i < max; i++){
                Console.WriteLine("Yield metot:");
                yield return i*i;
            }
        }
        public static List<int>KareUret(int max){
            List<int> kareler = new();
            for(int i = 1; i < max; i++){
                Console.WriteLine("Normal metot:");
                kareler.Add(i*i);
            }
            return kareler;
        }
        static void Main(string[] args){
            // For Döngüsü
            // Belirli sayıda tekrar gerçekleştirilmek istendiğinde kullanılır.
            int i;
            Console.WriteLine("\nFor Döngüsü:");
            for(i = 0; i < 5; i++){
                Console.WriteLine(i);
            }

            // While Döngüsü
            // Belirli bir koşul doğru olduğu sürece çalışır
            Console.WriteLine("\nWhile Döngüsü:");
            i = 0;
            while(i < 5){
                Console.WriteLine(i);
                i++;
            }

            // Do-While Döngüsü
            // While döngüsünden farkı koşul sağlanmasa bile en az bir kez döngü içerisindeki kod bloğunun çalışmasıdır.
            Console.WriteLine("\nDo-While Döngüsü:");
            i = 0;
            do{
                Console.WriteLine(i);
                i++;
            } while(i<5);

            // Foreach Döngüsü
            // Koleksiyonlarda (dizilerde, listelerde) dolaşmak için kullanılır.
            Console.WriteLine("\nForeach Döngüsü:");
            int[] sayilar = {1, 2, 3, 4, 5};
            foreach(int sayi in sayilar){
                Console.WriteLine(sayi);
            }

            // Kontrol İfaddeleri
            // Döngü içerisinde kullanılan bazı kontrol ifadeleri vardır.
            // break - döngüyü sonlandırır.
            // continue - mevcut yinelemeyi sonlandırıp yenisine geçer
            Console.WriteLine("\nKontrol İfadeleri:");
            for(i = 0; i < 10; i++){
                if(i==5){
                    Console.WriteLine("Break");
                    break;
                }
                if(i%2==0){
                    Console.WriteLine("Continue");
                    continue;
                }
                Console.WriteLine(i);
            }

            // Paralel Döngüler
            // Döngü paralel olarak çalıştırılır. Büyük verilerde performans sağlar.
            Console.WriteLine("\nParalel Döngü:");
            Parallel.For(0, 5, i =>{
                Console.WriteLine(i);
            });

            // Yield Kullanımı
            // Yinelenebilir metotlar üretir ve dönü içinde kullanılan bu metotlar sadece çağırıldıklarında bir değer üretir
            Console.WriteLine("\nYield Olmayan Döngü");
            foreach(int kare in KareUret(5)){
                Console.WriteLine(kare);
            }
            
            Console.WriteLine("\nYield Olan Döngü:");
            foreach(var kare in YieldKareUret(5)){
                Console.WriteLine(kare);
            }

        }
    }
}