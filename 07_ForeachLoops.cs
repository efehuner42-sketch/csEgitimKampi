using System.Numerics;

namespace CsharpDersleri
{
    class ForeachLoops
    {
        public static void Main()
        {
            #region Foreach Döngüsü

            //string[] cities = { "Istanbul", "Londra", "Berlin", "Milano", "Madrid", "Oslo" };

            //foreach (string x in cities) 
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 5465, 6, 7, 47, 476421, 756, 4576, 21246, 4347831, 413, 11, 23, 77 };

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 5465, 6, 7, 47, 476421, 756, 4576, 21246, 4347831, 413, 11, 23, 77 };

            //foreach(int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 5465, 6, 7, 47, 476421, 756, 4576, 21246, 4347831, 413, 11, 23, 77 };
            //int total = 0;

            //foreach(int i in numbers)
            //{
            //    total += i;
            //}

            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.Write("Kaç tane öğrenci girişi olacak: ");
            //int studentNumber = int.Parse(Console.ReadLine());

            //string[] studentNames = new string[studentNumber];
            //double[] studentGrade1 = new double[studentNumber];
            //double[] studentGrade2 = new double[studentNumber];
            //double[] studentAverage = new double[studentNumber];

            //for (int i = 0; i < studentNumber; i++) 
            //{
            //    Console.WriteLine();
            //    Console.Write("{0}. öğrencinin ismini giriniz: ", i+1);
            //    studentNames[i] = Console.ReadLine();

            //    Console.Write("{0}. öğrencinin 1.notunu giriniz: ", i + 1);
            //    studentGrade1[i] = double.Parse(Console.ReadLine());

            //    Console.Write("{0}. öğrencinin 2.notunu giriniz: ", i + 1);
            //    studentGrade2[i] = double.Parse(Console.ReadLine());

            //    studentAverage[i] = (studentGrade1[i] + studentGrade2[i]) / 2 ;

            //}

            //for (int i = 0; i < studentNumber; i++) 
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("{0}.Öğrencinin Bilgileri", i+1);
            //    Console.WriteLine("-------------------------------");
            //    Console.WriteLine("Adı: {0}", studentNames[i]);
            //    Console.WriteLine("1.Notu: {0}", studentGrade1[i]);
            //    Console.WriteLine("2.Notu: {0}", studentGrade2[i]);
            //    Console.WriteLine("Ortalaması: {0}", studentAverage[i]);
            //    if (studentAverage[i] < 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kalmıştır.");
            //    }
            //    else 
            //    {
            //        Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçmiştir.");
            //    }
            //}

            #endregion

            Console.Read();
        }
    }

}
