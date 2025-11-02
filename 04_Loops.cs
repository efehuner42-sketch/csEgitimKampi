namespace csDersleri
{
    class Loops
    {
        static void Main()
        {

            #region forDongusu

            //int i;
            //for (i = 1; i <= 5 ; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampıs");
            //}

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i < 51; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen kaç defa yazmak istediğinizi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}


            #endregion

            #region forDongusuIleKararYapilari

            //for (int i = 1; i < 101; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for (int i = 0; i < 11; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine("1'den 10'a kadar olan sayıların toplamı: " + totalValue);

            //int totalValue = 0;
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("------------+");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for(int i = 1; i < 51; i++)
            //{
            //    if(i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int bakteri = 1;
            //for (int i = 0; i < 24; i++) 
            //{
            //    bakteri *= 2;
            //    Console.WriteLine(i+1 + "." + " saat sonunda oluşan bakteri sayısı: " + bakteri);
            //}






            #endregion

            #region whileDongusu

            //int i = 0;
            //while (i< 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if(i % 3  == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int sum = 0;
            //int i = 1;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);



            #endregion

            #region ornekSinavSorusu

            //Klavyeden girilen 3 basamaklı sayının basamaklarını toplayan kodu yazınız.

            //int val;
            //int sum = 0;
            //Console.Write("Basamaklarını toplanmasını istediğiniz sayıyı giriniz: ");
            //val = int.Parse(Console.ReadLine());
            //for (int i = 0; i < 3; i++)
            //{
            //    sum += val % 10;
            //    val = val / 10;
            //}
            //Console.WriteLine("Basamaklarının toplamı: " + sum );
            #endregion


            Console.Read();
        }
    }
}
