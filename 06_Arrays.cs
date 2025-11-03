namespace csDersleri
{
    class Arrays
    {
        static void Main()
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];
            //colors[0] = " Kırmızı ";
            //colors[1] = " Mavi ";
            //colors[2] = " Beyaz ";
            //colors[3] = " Sarı ";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "İstanbul";
            //cities[1] = "Bursa";
            //cities[2] = "Ankara";
            //cities[3] = "Antalya";
            //cities[4] = "İzmir";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 2;
            //numbers[1] = 32;
            //numbers[2] = 120;
            //numbers[8] = 974;
            //numbers[9] = 1026;

            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Ankara", "Atina", "Verşova", "Pekin", "Tokyo" };

            //Console.WriteLine(cities[4]);



            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Lacivert", "Kırmızı", "Yeşil", "Pembe", "Siyah", "Beyaz" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 123, 145, 1257, 34579, 123599, 1241, 3579, 12479, 3421, 686, 242, 180765, 234 };
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if(numbers[i] % 3  == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 23, 565, 53, 12, 45, 265, 478, 1025 };
            //int max = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if(myArray[i] > max)
            //    {
            //        max = myArray[i];
            //    }
            //}
            //Console.WriteLine(max);

            //string[] persons = { "Ali", "Ayşe", "Efe", "Murat", "Nisa", "Ece" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 14, 36, 12, 11, 2, 68, 99, 52, 14, 35 };
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 14, 36, 12, 11, 2, 68, 99, 52, 14, 35 };
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion

            #region Dizi Metotları

            //string[] customers = { "Ali", "Ayşenur", "Kaya", "Enes", "Onur" };
            //int index;
            //index = Array.IndexOf(customers, "Enes");
            //Console.WriteLine(index);

            //int[] numbers = { 56, 23, 569, 26, 1, 36, 58, 59 };
            //Console.WriteLine("Dizinin en büyük Elemanı: " + numbers.Max() + " " + "Dizinin En küçük Elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Veri Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{

            //    Console.Write($"Lütfen {i + 1}. şehri giriniz: ");
            //    cities[i] = Console.ReadLine();

            //}
            //Console.WriteLine("----------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 23, 56, 89, 11, 14 };
            //int sum = 0;   
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 45, 36, 258, 1456, 23, 147, 39, 32 };
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("-------------------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();

        }
    }
}
