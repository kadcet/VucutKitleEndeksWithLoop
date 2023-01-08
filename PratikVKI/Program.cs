


namespace PratikVKI
{
    public class Program
    {
        public static void Main()
        {
            bool x ;
            string cevap = "";
            do
            {


                Console.Clear();
                Console.WriteLine("Hastanın Boyunu Girin :");
                decimal boy = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Hastanın Kilosunu Girin :");
                decimal kilo = Convert.ToDecimal(Console.ReadLine());

                decimal VKI = kilo / (boy * boy);

                if (VKI <= 18.49m)
                    Console.WriteLine($"Hastanın Boyu:{boy} Hastanın Kilosu:{kilo} VKI indeksi:{VKI}, Teşhis: ZAYIF");
                else if (VKI > 18.49m && VKI <= 24.99m)
                    Console.WriteLine($"Hastanın Boyu:{boy} Hastanın Kilosu:{kilo} VKI indeksi:{VKI}, Teşhis: İDEAL");
                else if (VKI >= 25m && VKI <= 29.99m)
                    Console.WriteLine($"Hastanın Boyu:{boy} Hastanın Kilosu:{kilo} VKI indeksi:{VKI}, Teşhis: HAFİF KİLOLU");
                else if (VKI > 30m)
                    Console.WriteLine($"Hastanın Boyu:{boy},Hastanın Kilosu:{kilo}, VKI indeksi:{VKI}, Teşhis: OBEZ");


                do
                {
                    Console.WriteLine("Yeni bir hesaplama yapmak istiyor musunuz ? (E / H)");
                    cevap = Console.ReadLine();
                    if (cevap == "h" || cevap == "H" || cevap == "e" || cevap == "E")
                        x = false;
                    else
                    {
                        Console.WriteLine("Hatalı Seçim");
                        x = true;
                    }
                } while (x==true);

            } while (cevap == "e" || cevap == "E");


        }

       
    }
}


