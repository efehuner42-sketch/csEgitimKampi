namespace makingDecision
{
    class Csharp
    {
        static void Main()
        {
            #region If Else

            //Console.Write("Lutfen sifrenizi giriniz: ");
            //string password; 
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Sifreniz Dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Sifreniz Hatalı");
            //}

            //string capital, country;
            //Console.Write("Baskenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ulkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" && country == "türkiye")
            //{
            //    Console.WriteLine("Veriler dogrulandı");

            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi girisi");
            //}

            //int number;
            //Console.Write("Sayi giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayi dogru");
            //}
            //else 
            //{
            //    Console.WriteLine("Sayi yanlis");
            //}

            //int exam1, exam2, exam3, average;
            //string result="Hata!";

            //Console.Write("1.Sinavi giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sinavi giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3.Sinavi giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //if (average > 0 && average <= 50)
            //{
            //    result = "Sonuc vasat";
            //}
            //if (average > 50 && average <= 70)
            //{
            //    result = "Sonuc orta";
            //}
            //if (average > 70 && average <= 84)
            //{
            //    result = "Sonuc iyi";
            //}
            //if (average > 85 && average <= 100)
            //{
            //    result = "Sonuc cok iyi";
            //}
            //if(result != "Hata!") 
            //{
            //    Console.Write("Ortalamanız: ");
            //    Console.WriteLine(average);
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Yanlıs bilgi girisi");
            //}

            //string city;
            //Console.Write("Lutfen sehir giriniz: ");
            //city = Console.ReadLine();

            //if (city == "bursa" | city == "ankara" | city == "istanbul" | city == "tekirdag")
            //{
            //    Console.WriteLine("Sehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Sehir mevcut degil");
            //}

            //string username;
            //Console.Write("Kullanici adini giriniz: ");
            //username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanici adi kabul edilemez!");
            //}
            //else
            //{
            //    Console.WriteLine("Hos geldiniz");
            //}

            #endregion

            #region modIslemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lutfen 1.sayiyi giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen 2.sayiyi giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1.sayinin 2.sayiya bolumunden kalan: " + result);

            //Console.Write("Lutfen sayinizi giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayiniz cifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayiniz tektir.");
            //}
            #endregion

            #region charDegiskeniIleKararYapilari
            //char team;
            //Console.Write("Lutfen tuttugunuz takimin ilk harfini giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if(team == 'G' | team == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if(team == 'f' |  team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Besiktas");
            //}
            //else if (team == 't' | team == 'T')
            //{
            //    Console.WriteLine("Trabzonspor");
            //}
            //else 
            //{
            //    Console.WriteLine("Tuttugunuz takim 4 buyukten degildir.");
            //}
            #endregion

            #region ornekProjeUygulamasi

            //string menuItem;
            //Console.WriteLine("****** C# Restoran ******");

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("----------------------------");

            //Console.Write("Detayını görmek istediğiniz kategoriyi seçiniz: ");
            //menuItem = Console.ReadLine();
            //if (menuItem == "1") 
            //{
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Barbunya");
            //    Console.WriteLine("3-Taze fasulye");
            //    Console.WriteLine("4-Musakka");
            //    Console.WriteLine("5-Dolma");
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Ezogelin");

            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine("1-Margarita");
            //    Console.WriteLine("2-Sucuksever");
            //    Console.WriteLine("3-Tavuklu");


            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3-Ayran");


            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Baklava");
            //    Console.WriteLine("3-Kazandibi");


            //}
            #endregion

            #region switchCase

            //Console.Write("Lütfen girmek istediğiniz ayı seçin: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı veri girişi"); break;
            //}



            #endregion

            #region switchCaseHesapMakinesi

            int number1, number2;
            double result;
            char symbol;

            Console.Write("1.sayıyı giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2.sayıyı giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Yapmak istediğiniz işlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;
                case '/':
                    result = (double) number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;
                    default:
                    Console.WriteLine("Hesap makinesi bu işlemi desteklemiyor.");
                    break;



            }
            #endregion
            Console.Read();
            }
        }
    }