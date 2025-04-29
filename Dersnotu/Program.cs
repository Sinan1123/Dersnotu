namespace Dersnotu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Merhaba ders notu hesaplayıcı ve harf notu belirleme aracına hoşgeldiniz!");
            Console.WriteLine("Ders adı giriniz!");

            string dersAdi = Console.ReadLine();
        Baslangıc:
            Console.WriteLine("Vize notunuzu girin:");

            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunuzu girin");
            int final = Convert.ToInt32(Console.ReadLine());
            if (vize <= 0 || vize > 100)
            {
                Console.WriteLine("Notlar 0 dan küçük yada 100 den büyük olamaz!");
                goto Baslangıc;
            }
            else if (final <= 0 || final > 100)
            {
                Console.WriteLine("Notlar 0 dan küçük yada 100 den büyük olamaz!");
                goto Baslangıc;
            }
 
            string harfNotu = "";

            int puan = (int)((vize * 0.40) + (final * 0.60));
            if (puan < 50)
                harfNotu = "D";
            else if (puan >= 50 && puan <= 59)
                harfNotu = "C2";
            else if (puan >= 60 && puan <= 64)
                harfNotu = "C1";
            else if (puan >= 65 && puan <= 69)
                harfNotu = "B2";
            else if (puan >= 70 && puan <= 74)
                harfNotu = "B1";
            else if (puan >= 75 && puan <= 84)
                harfNotu = "A2";
            else if (puan >= 85 && puan <= 100)
                harfNotu = "A1";

            string durum = puan >= 50 ? "Geçtiniz " : "Kaldınız";

            Console.WriteLine($"{dersAdi} dersi dönem sonu puanınız: {harfNotu} - {durum}");
        }
    }
}