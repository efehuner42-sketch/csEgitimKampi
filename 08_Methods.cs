namespace CsharpDersleri
{
    class Methods
    {
        public static void Main()
        {
            #region Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Efe Yılmaz");
            //    Console.WriteLine("Ela Yılmaz");
            //    Console.WriteLine("Hakan Kaya");
            //    Console.WriteLine("Melike Şentürk");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x=1 ; 
            //    int y=2;
            //    int z = x + y ;

            //    Console.Write(z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);

            //}
            //WriteMethod("Mustafa Kemal");

            //void customerCard(string name, string surNanme)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surNanme);

            //}

            //customerCard("Ali", "Tahir");
            //customerCard("Ayşegül", "Yıldız");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3) 
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);

            //}

            //Sum(7, 8, 9);


            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Büşra Yılmaz";
            //}

            //string CustomerCard()
            //{
            //    string name = "Ali";
            //    string surName = "Yılmaz";

            //    return name + " " + surName;
            //}

            //Console.WriteLine(CustomerCard());


            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{

            //    string countryInfo = "Ülkenin adı: " + countryName + " - " + "Başkenti: " + capital + " - " + "Bayrağının rengi: " + flagColor;

            //    return countryInfo;

            //}

            //Console.Write("Ülkenin Adı: ");
            //string x = Console.ReadLine();

            //Console.Write("Ülkenin Başkenti: ");
            //string y = Console.ReadLine();

            //Console.Write("Ülkenin Bayrağının Rengi: ");
            //string z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("İtalya", "Roma", "Yeşil-Beyaz-Kırmızı" ));


            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45,96));
            //Console.WriteLine(Sum(87,12));
            //Console.WriteLine(Sum(20,30));
            //Console.WriteLine(Sum(11,43));

            #endregion

            #region Örnek Soru

            //string ExamResult(string studentName, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1  + exam2 + exam3)/ 3;
            //    if (result > 50) 
            //    {
            //        return studentName + " Adlı öğrenci geçmiştir. " + "Ortalaması: " + result;
            //    }
            //    else
            //    {
            //        return studentName + " Adlı öğrenci kalmıştır. " + "Ortalaması: " + result;

            //    }
            //}

            //Console.WriteLine(ExamResult("Ahmet", 45,23,56));
            //Console.WriteLine(ExamResult("Ayşe", 68,100,98));


            #endregion





            Console.Read();


        }
    }
}
