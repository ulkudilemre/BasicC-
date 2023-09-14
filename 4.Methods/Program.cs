using System;
using System.Threading.Tasks;

namespace Methods
{
    // Uzantı Metotları (Extension Methods)
    // Bir sınıfın, arayüzün veya yapının kaynak koduna erişmeden yeni metotlar eklenmesini sağlar.
    // Uzantı metotları statik bir sınıf içinde tanımlanmalıdır. 
    // Genişletilmek istenilen tipi belirtmek için this anahtar kelimesi kullanılır.
    public static class StringExtension{
        public static bool BaslangicKontrol(this string str, string baslanic){
            return str.StartsWith(baslanic);
        }
    }

    // Yeniden Yazma (Overriding)
    // Bir sınıftan türetilen (devided) sınıfın türetildiği sınıfın (base class) metotlarını değiştirmesine
    // olanak tanır. Yaniden yazılacak metodun 'virtual', 'abstract' veya 'override' metot olması gerekmektedir.
    // Bir override metotdun alt sınıflar tarfından daa fazla değiştirilmesi istenmiyorsa 'sealed' kullanılır.

    public class Hayvan{
        public virtual void SesCikar(){
            Console.WriteLine("Bir hayvan sesi");
        }
    }

    public class Kedi : Hayvan{
        public override void SesCikar(){
            Console.WriteLine("Miyav!");
        }
    }

    public class Kaplan : Kedi{
        public sealed override void SesCikar(){
            Console.WriteLine("Rrrr!");
        }
    }

    class Methods{
        // Bir metot belirli bir işlevi yerine getiren kod bloğunu tanımlar.
        public void MerhabaDe(){
            Console.WriteLine("Metottan merhaba!");
        }


        // Metotlar varsayılan parametrelere sahip olabilirler. 
        // Metot çağrısına isimli parametre (named parameter) kullanabilir.
        public void MesajGoster(string msj = "Merhaba"){
            Console.WriteLine(msj);
        }


        // Parametreler değer alabilir ve değer döndürebilir.
        public int Topla(int a, int b){
            return a+b;
        }


        // Params Anahtar Kelimesi ve Method Overloading
        // Bir metodun değişken sayıda parametre alması için params anatar kelimesi kullanılır.
        // Aynı zamanda aynı isimde farklı parametreler ile iki metot tanımlarsak Method Overloading yapmış oluruz.
        public int Topla(params int[] sayilar){
            int toplam = 0;
            foreach(int i in sayilar){
                toplam += i;
            }
            return toplam;
        }


        // Ref ve Out Anatar Kelimeleri
        // ref ve out anahtar kelimeleri bir metotda geçirilen değişkenin metot içinde değiştirilmesini sağlar.
        // Değişkenin kopyasını almak yerine referansını alırlar.
        // ref ile geçirilen bir parametrenin metoda gönderilmeden önce mutlaka değer atamasının yapılması
        // gerekmektedir fakat metot içinde değer ataması yapılmasına gerek yoktur.
        void RefDegistir(ref int sayi){
            sayi = 42;
        }
        // out ile geçirilen bir parametrenin ilk değer atamasının yapılmasına gerek yoktur fakat mutlaka metot 
        // içinde değer ataması yapılmalıdır. Genellikle mototun birden fazla çıkış dedğeri olduğu durumlarda kullanılır.
        void OutDegistir(out int sayi){
            sayi = 100;
        }


        // Asekron Metotlar
        // Uzun süren işlemlerin ana iş parçacığını (thread) bloke etmeden çalışmasını sağlar. 
        // Bir metodu asenkron olarak tanımlamak için 'async' kullanlır.
        // Asenkron metotlar genellikle 'Task' veya 'Task<T>' döndürür.
            // 'await' asenkron bir işlemin tamamlanmasını beklerken mevcut iş parçacığının bloke olmasını engeller.
        public static async Task UzunSureliIslem(){
            Console.WriteLine("Uzun süreli işlem başlıyor...");
            await Task.Delay(10000);  // 5 saniye bekler
            Console.WriteLine("Uzun süreli işlem bitti.");
        }


        // Delegeler (Delegates) ve Olaylar (Events)
        // Bir delegate bir metoda referans tutabilen bir türdür.
        public delegate void MyDelegate(string message);
        // Olaylar bir sınıfın veya nesnenin belirli bir işlem gerçekleştiğinde dış dünyaya bildirimde
        // bulunmasını sağlar. Bu yayıncı-abone (publisher-subscriber) modelini destekler.
        public delegate void EventHandler(string eventData);


        // Yerel (Local) Fonksiyonlar ve Özyinelemeli (Recursive) Fonksiyonlar
        // Yerel fonksiyonlar bir metot içerisinde tanımlanan ve sadece bu metot içerisinde kullanılabilen
        // fonksiyonlardır. GGenellikle iç içe eçmiş fonksiyonlar için kullanılır.
        public int CalculateFactorial(int n){
            int LocalFactorial(int number){
                if(number <= 1) return 1;
                return number * LocalFactorial(number -1);
            }
            return LocalFactorial(n);
        }

        public class Publisher{
            public event EventHandler MyEvent;
            public void RaiseEvent(string data){
                MyEvent?.Invoke(data);
            }
        }


        public class Subscriber{
            public void RegisterToEvent(Publisher pub){
                pub.MyEvent += HandleEvent;
            }

            public void HandleEvent(string data){
                Console.WriteLine($"Olay şu data ile alındı: {data}");
            }
        }


        public static async Task Main(string[] args){
            Methods methodInstance = new Methods();
            methodInstance.MerhabaDe();

            Console.WriteLine("\nVarsayılan parametreli metot: ");
            methodInstance.MesajGoster();
            Console.WriteLine("Parametre verilmiş varsayılan parametreli metot: ");
            methodInstance.MesajGoster("Yeni Parametre");

            int a = 5, b = 10;
            int result = methodInstance.Topla(a, b);
            Console.WriteLine("\nParametreli metot\nParametreler a = {0}, b = {1}\nSonuç = {2}", a, b, result);
            
            int c = 15, d = 20;
            result = methodInstance.Topla(a, b, c, d);
            Console.WriteLine("params ile bir metotda farklı sayıda parametre gönderilebilir.\n"+
            "Bu metot bir önceki metot ile aynı isime fakat farklı parametrelere saip olduğundan method overloading yapılmıştır."+
            "\nParametreler a = {0}, b = {1}, c = {2}, d = {3}\nSonuç = {4}", a, b, c, d, result);


            Console.WriteLine("\nref anatar kelimesi ile gönderilen değişkenin ilk değeri: {0}", a);
            methodInstance.RefDegistir(ref a);
            Console.WriteLine("void metotdun içinde değer ataması yapılan değişkenin son değeri: {0}", a);

            int temp;
            Console.WriteLine("\nout anatar kelimesi ile gönderilen değişkenin ilk değeri yoktur.");
            methodInstance.OutDegistir(out temp);
            Console.WriteLine("void metotdun içinde değer ataması yapılan değişkenin son değeri: {0}", temp);


            string metin = "Merhaba Dünya!";
            bool sonuc = metin.BaslangicKontrol("Merhaba");
            Console.WriteLine("\nString Extension result: {0}", sonuc);


            // Lambda ifadelerive İfade Gövdeli Metotlar
            // Lambda ifadeleri isimsiz metotlardır ve kısa, tek kullanımlık işlevler için kullanılır.
            // (parametreler) => ifade şeklinde söz dizimine saiptir.
            // x => x * x ya da (x,y) => x + y örnek gösterilebilir.
            // İfade gövdeli metot:
            int Add(int a, int b) => a + b;
            // İfade gövdeli özellik:
            // public string Nick{get; set;}
            // public string Hosgeldin => $"Merhaba, {Nick}!";
            // İfade gövdeli okuma/yazma erişimcisi:
            // private string isim;
            // public string Isim{
            //     get => isim;
            //     set => isim = value?.Trim() ?? "İsimsiz";
            // }
            Console.WriteLine("\nİfade gövdeli Metot sonuç: {0}", Add(2, 3));


            Console.WriteLine("\nOverriding: ");
            Hayvan hayvan = new Hayvan();
            hayvan.SesCikar();
            Kedi kedi = new Kedi();
            kedi.SesCikar();
            Kaplan kaplan = new Kaplan();
            kaplan.SesCikar();


            Console.WriteLine("Asenkron işlem başladı.");
            await UzunSureliIslem();
            Console.WriteLine("Asenkron işlem tamamlandı.");


            MyDelegate del = methodInstance.MesajGoster;
            del("\nDelegeden merhaba!");

            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();
            subscriber.RegisterToEvent(publisher);
            publisher.RaiseEvent("Event Data Merhaba!");


            result = methodInstance.CalculateFactorial(5);
            Console.WriteLine($"\nYerel ve özyinelemeli fonksiyonla hesaplanan faktoriyel sonucu: {result}");

        }

    }
}