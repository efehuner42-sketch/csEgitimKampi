using System.Diagnostics.CodeAnalysis;

namespace csDersleri
{
    class loopsWithStars
    {
        static void Main()
        {
            #region Alt alta 10 tane yıldız oluşturma

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana 10 tane yıldız oluşturma

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun 

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Dik Üçgen 

            //for (int i = 0; i <5 ; i++)
            //{
            //    for(int j = 0; j < i+1 ; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            #endregion

            #region Ters Dik Üçgen 

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5-i ; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}
            #endregion

            #region Dik Ve Ters Üçgen Beraber

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4 - i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}
            #endregion

            #region Baklava Dilimi

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 4 - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.Write("*");
            //    if (i > 0 )
            //    {
            //        for (int k = 0; k < 2*i-1 ; k++)
            //        {
            //            Console.Write(" ");
            //        }
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < 4; i++)
            //{
            //    for(int j = 0;j < i+1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.Write("*");
            //    if (i < 3)
            //    {
            //        for (int k = 0; k < 5-i*2; k++)
            //        {
            //            Console.Write(" ");
            //        }
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region İçi Boş Piramit

            //int n = 5;
            //for (int i = 0; i < n; i++)
            //{
            //    if(i != 4)
            //    {
            //        for(int j = 0; j < n-1-i; j++)
            //        {
            //            Console.Write(" ");

            //        }
            //        Console.Write("*");
            //        if(i != 0)
            //        {
            //            for (int k = 0; k < 2*i-1 ; k++)
            //            {
            //                Console.Write(" ");

            //            }
            //            Console.Write("*");
            //        }
            //    }
            //    else
            //    {
            //        for (int m = 0; m <i*2+1 ; m++)
            //        {
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region İçi Dolu Ters Piramit

            //int n = 5;
            //for (int i = n; i > 0; i--)
            //{
            //    for (int j = 0; j < n - i; j++)
            //    {
            //        Console.Write(" ");

            //    }
            //    for (int k = 0; k < 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion



            Console.ReadKey();
        }


    }
}