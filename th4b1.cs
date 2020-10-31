using System;

namespace th4b1
{
    namespace TH4B1

    {

        class MaTran

        {

            private static int n;

            private int[,] a;



            public MaTran()

            {

                n = 2;

                a = new int[n, n];

            }



            public static int N

            {

                get

                {

                    return n;

                }

                set

                {

                    if (value >= 2) n = value;

                }

            }



            public void Nhap()

            {

                Console.WriteLine("Nhap thong tin cho cac phan tu cua ma tran");

                for (int i = 0; i < n; i++)

                    for (int j = 0; j < n; j++)

                    {

                        Console.Write("a[{0},{1}] = ", i, j);

                        a[i, j] = int.Parse(Console.ReadLine());

                    }

            }



            public void Hien()

            {

                Console.WriteLine("Cac phan tu cua ma tran la");

                for (int i = 0; i < n; i++)

                {

                    for (int j = 0; j < n; j++)

                        Console.Write("{0}\t", a[i, j]);

                    Console.WriteLine();

                }

            }



            public MaTran Tong(MaTran t2)

            {

                MaTran t = new MaTran();



                for (int i = 0; i < n; i++)

                    for (int j = 0; j < n; j++)

                        t.a[i, j] = this.a[i, j] + t2.a[i, j];

                return t;



            }



            class QLMT

            {

                private MaTran[] ds;

                private int somt;



                public void Nhap()

                {

                    Console.Write("Nhap cap ma tran: ");

                    MaTran.N = int.Parse(Console.ReadLine());

                    Console.Write("Nhap so ma tran: ");

                    somt = int.Parse(Console.ReadLine());

                    ds = new MaTran[somt];

                    for (int i = 0; i < somt; i++)

                    {

                        Console.WriteLine("Nhap ma tran thu " + i);

                        ds[i] = new MaTran();

                        ds[i].Nhap();

                    }

                }



                public MaTran Tong()

                {

                    MaTran t = new MaTran();

                    for (int i = 0; i < somt; i++)

                        t = t.Tong(ds[i]);

                    return t;

                }

            }

            static void Main(string[] args)

            {

                QLMT t = new QLMT();

                t.Nhap();

                Console.WriteLine("Ma tran tong");

                t.Tong().Hien();

                Console.ReadLine();

            }

        }

    }
}
