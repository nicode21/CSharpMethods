using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Method1(41));

            Console.WriteLine(Method2(42, 62));

            Console.WriteLine(Method3(5, 10));

            Console.WriteLine(Method4(5, 10));

            Console.WriteLine(Method5(new int[] {1,2,3,4,5,6 }));

            Console.WriteLine(Method6(new int[] { 2,4,5,3,5,62,24,21}));

            Console.WriteLine(Method7(14));

            Console.WriteLine(Method8(128));

            Console.WriteLine(Method9(new int[] { 2, 3, 34, 53, 52, 32, 42, 3, 21, 33, 23 }));

            Console.WriteLine(Method10(new int[] { 2,3,35,41,6,33,13,12}));
        }
        //<-----------



        #region <----------- Method1 : Ededlerin 3 e ve 7 ye bolunub bolunmemesi
        public static bool Method1(int n)
        {
            if (n % 21 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion


        #region <----------- Method2 : n ve m ededleri cutdurse cemini hesabla

        public static string Method2(int n, int m)
        {

            int S = 0;

            if (n % 2 == 0 && m % 2 == 0)
            {
                S = n + m;

                return S.ToString();
            } else
            {
                return "Sehv ededleri daxil etmisiniz";
            }

        }


        #endregion


        #region <----------- Method3 : n ve m ededlerinin arasindaki tek ededlerin sayi

        public static int Method3(int n, int m)
        {
            int C = 0;
            if (n < m) {
                for (int i = n; i <= m; i++)
                {
                    if (i % 2 == 1)
                    {
                        C++;
                    }
                }
            }
            return C;
        }

        #endregion


        #region <----------- Method4 : n ve m ededlerinin arasindaki ededlerin cemi

        public static int Method4(int n, int m)
        {
            int S = 0;

            if (n < m)
            {
                for (int i = n; i <= m; i++)
                {
                    if (i % 2 == 1)
                    {
                        S += i;
                    }
                }
            }
            return S;
        }

        #endregion


        #region <----------- Method5 : Arrayin icindeki tek ededlerin cemi


        public static int Method5(int[] arr)
        {
            int S = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    S += arr[i];
                }
            }
            return S;
        }

        #endregion


        #region <----------- Method6 : Arrayin icindeki cut ededlerin sayi

        public static int Method6(int[] arr)
        {
            int C = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    C++;
                }
            }
            return C;
        }

        #endregion


        #region <----------- Method7 : n ededinin sade ve ya murekkeb olmasi

        public static string Method7(int n)
        {

            int C = 0;

            for (int i = 2; i < n; i++)
            {
                if (n%i==0)
                {
                    C++;
                }
            }

            if (C == 0)
            {
                return "Sade ededdir";
            }
            else
            {
                return "Murekkeb ededdir";
            }
        }

        #endregion


        #region <----------- Method8 : Ededin 2 nin quvveti olub olmamasi

        public static string Method8(int n)
        {

            int a = 2;

            if (n > 1)
            {
                while (a <= n)
                {
                    a *= 2;
                }
            }
            if (a / 2 == n)
            {
                return n + " ededi 2 nin quvvetidir";
            }
            else
            {
                return n + " ededi 2 nin quvveti deyil";
            }

        }

        #endregion


        #region <----------- Method9 : Array de 1-20 arasinda olanlarin hasilini tapmaq

        public static int Method9(int[]arr)
        {

            int M = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>1 && arr[i]<20)
                {
                    M *= arr[i];
                }
            }

            return M;
        }


        #endregion


        #region <----------- Method10 : Array de olan cut ededlerin ceminin kvadrati

        public static int Method10(int[] arr)
        {
            int S = 0;

            int M = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    S += arr[i];
                }
            }

            M = S * S;

            return M;
        }


        #endregion
    }
}
