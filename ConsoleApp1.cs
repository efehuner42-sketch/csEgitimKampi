namespace Cs
{
    class App
    {
        static void Main()
        {
            #region Yazdırma komutları
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana yemekler");
            //Console.WriteLine("3- Soğuk başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-içecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region stringDegiskenler

            //string customerName, customerSurname, customerPhone, customerEmail;
            //string district, city;

            //customerName = "Ali";
            //customerSurname = "Bekir";
            //customerPhone = "+90 501 234 12 56";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";


            //Console.WriteLine("**** Rezarvasyon Kartviziti ****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("Musteri Adi: " + customerName + " " + customerSurname);
            //Console.WriteLine("Iletisim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adresi: " + district + "/" + city);
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("**** Rezarvasyon Kartviziti ****");

            //customerName = "Efe";

            //Console.WriteLine(customerName);






            #endregion

            #region intDegiskenler

            //int hamburgerPrice = 300;
            //int cokePrice = 60;
            //int pizzaPrice = 270;
            //int waterPrice = 35;
            //int friesPrice = 75;
            //int lemonadePrice = 45;

            //Console.WriteLine("**** Restoran Fiyat Listesi ****");
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Hamburger: " + hamburgerPrice + "TL");
            //Console.WriteLine("Kola : " + cokePrice + "TL");
            //Console.WriteLine("Su : " + waterPrice + "TL");
            //Console.WriteLine("Kızartma : " + friesPrice + "TL");
            //Console.WriteLine("Pizza : " + pizzaPrice + "TL");
            //Console.WriteLine("Limonata : " + lemonadePrice + "TL");
            //Console.WriteLine("----------------------------------");





            #endregion

            #region Variables

            #region doubleDegiskenler 
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //double apple, potato, strawberry, orange, tomato;

            //apple = 4.70;
            //potato = 15.67;
            //strawberry = 45.32;
            //orange = 21;
            //tomato = 14.12;

            //Console.WriteLine("----- Fiyat Listesi -----");
            //Console.WriteLine();

            //Console.WriteLine("Elma fiyatı: " + apple );
            //Console.WriteLine("Patates fiyatı: " + potato);
            //Console.WriteLine("Çilek fiyatı: " + strawberry);
            //Console.WriteLine("Portakal fiyatı: " + orange);
            //Console.WriteLine("Domates fiyatı: " + tomato);






            #endregion


            #region charDegiskenler

            // char degiskenler "" ile değil '' ile tanımlanır.

            //char symbol = 'a';
            //Console.WriteLine(symbol);



            #endregion




            #endregion

            #region klavyedenVeriGirisleri

            #region stringDegiskenler

            //string passengerName, passengerSurname, passengerId;

            //Console.WriteLine("---- Huner Havayolları -----");

            //Console.Write("Adınız: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Soyadınız: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("TC. Kimlik No: ");
            //passengerId = Console.ReadLine();

            //Console.WriteLine("Yolcu : " + passengerName + " " + passengerSurname);
            //Console.WriteLine("TC. Kimlik No: " + passengerId);






            #endregion

            #region intDegiskenlerVeDonusumler

            //int computer, tv, phone, tab;

            //computer = 30000;
            //tv = 25000;
            //phone = 20000;
            //tab = 15000;

            //int computerCount, tvCount, phoneCount, tabCount;

            //Console.Write("Aldıgınız bilgisayar adedini giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldıgınız TV adedini giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldıgınız telefon adedini giriniz: ");
            //phoneCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldıgınız tablet adedini giriniz: ");
            //tabCount = int.Parse(Console.ReadLine());

            //int totalPrice;
            //totalPrice = (tv*tvCount) + (phone*phoneCount) + (tab*tabCount) + (computer*computerCount);

            //Console.Write("Toplam ödemeniz gereken fiyat " + totalPrice + " " + "TL");


            #endregion

            #region ondalıklıSayıIslemleri

            //double exam1, exam2, exam3;

            //Console.Write("1.Sınav notunuzu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2.Sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3.Sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //double average;
            //average = (exam1 + exam2 +  exam3) / 3;
            //Console.Write("Ortalamanız: " +  average);


            #endregion

            #region charDegiskenler

            //char gender;
            //Console.Write("Cinsiyetinizi (E/K) giriniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Cinsiyetiniz: " + gender);

            #endregion
            #endregion


            Console.Read();
            
        }
    }
}