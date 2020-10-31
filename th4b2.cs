using System;

namespace th4b2
{
    class NhanVien

    {

        private string hoten, quequan;

        private double hesoluong;

        private static int luongcoban = 1050;



        public NhanVien()

        {

            hoten = quequan = "";

            hesoluong = 1.25;

        }



        public NhanVien(string hoten, string quequan, double hesoluong)

        {

            this.hoten = hoten;

            this.quequan = quequan;

            this.hesoluong = hesoluong;

        }



        public static int Luongcoban

        {

            get

            {

                return luongcoban;

            }

            set

            {

                if (value > 1050) luongcoban = value;

            }

        }



        public double Hesoluong

        {

            get

            {

                return hesoluong;

            }

        }



        public string Hoten

        {

            get

            {

                int n = hoten.LastIndexOf(" ");

                return hoten.Substring(n + 1) + " " + hoten.Substring(0, n);

            }

        }



        public void Nhap()

        {

            Console.Write("Nhap ho ten: ");

            hoten = Console.ReadLine();

            Console.Write("Nhap que quan: ");

            quequan = Console.ReadLine();

            Console.Write("Nhap he so luong: ");

            hesoluong = double.Parse(Console.ReadLine());

        }



        public virtual double TinhLuong()

        {

            return hesoluong * luongcoban;

        }

        public virtual void Hien()

        {

            Console.WriteLine("Ho ten: " + hoten);

            Console.WriteLine("Que quan: " + quequan);

            Console.WriteLine("He so luong: " + hesoluong);

        }



    }



    class QLNV

    {

        private NhanVien[] ds;

        private int snv;

        public void Nhap()

        {

            Console.Write("Nhap so nhan vien: ");

            snv = int.Parse(Console.ReadLine());

            ds = new NhanVien[snv];

            for (int i = 0; i < snv; i++)

            {

                ds[i] = new NhanVien();

                ds[i].Nhap();

            }

        }



        public void Hien()

        {

            for (int i = 0; i < snv; i++)

                ds[i].Hien();

        }



        public double MaxHsl()

        {

            double max = ds[0].Hesoluong;

            for (int i = 0; i < snv; i++)

                if (ds[i].Hesoluong > max) max = ds[i].Hesoluong;

            return max;

        }



        public void HienMaxHsl()

        {

            double max = MaxHsl();

            for (int i = 0; i < snv; i++)

                if (ds[i].Hesoluong == max) ds[i].Hien();

        }



        public void SapXep()

        {

            for (int i = 0; i < snv - 1; i++)

                for (int j = i + 1; j < snv; j++)

                    if (string.Compare(ds[i].Hoten, ds[j].Hoten) > 0)

                    {

                        NhanVien tg = ds[i];

                        ds[i] = ds[j];

                        ds[j] = tg;

                    }

        }



    }



    class Chay

    {

        static void Main2_4(string[] args)

        {

            QL t = new QL();

            t.Nhap();

            t.Hien();

            Console.WriteLine("Nhan vien sau khi sap xep");

            t.SapXep();

            t.Hien();

            Console.ReadLine();

        }

    }
}
