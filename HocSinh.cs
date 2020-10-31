using System;
using System.Collections.Generic;
using System.Text;

namespace th4
{
    class Sinhvien
    {
        private string Hoten;
        private double Diemtoan;
        private double Diemli;
        private double Diemhoa;
        public void Nhap()
        {
            Console.Write("Nhap ho ten sinh vien:");
            Hoten = Console.ReadLine();
            Console.Write("Nhap diem toan cua sinh vien:");
            Diemtoan = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem li cua sinh vien:");
            Diemli = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa cua sinh vien:");
            Diemhoa = double.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", Hoten, Diemtoan, Diemli, Diemhoa);
        }
        public double DiemToan
        {
            get
            {
                return Diemtoan;
            }
            set
            {
                if (value >= 0 && value <= 10)
                    Diemtoan = value;
            }
        }
        public double DiemLi
        {
            get
            {
                return Diemli;
            }
            set
            {
                if (value >= 0 && value <= 10)
                    Diemli = value;
            }
        }
        public double DiemHoa
        {
            get
            {
                return Diemhoa;
            }
            set
            {
                if (value >= 0 && value <= 10)
                    Diemhoa = value;
            }
        }
    }
    class QLsinhvien
    {
        private Sinhvien[] ds;
        private int ssv;
        public void Nhap()
        {
            Console.Write("Nhap so sinh vien:"); ssv = int.Parse(Console.ReadLine());
            ds = new Sinhvien[ssv];
            for (int i = 0; i < ds.Length; ++i)
            {
                Console.WriteLine("Nhap thong tin cho sinh vien:" + i);
                ds[i] = new Sinhvien();
                ds[i].Nhap();
            }
        }

        public void Hienthilai()
        {
            for(int i = 0; i < ds.Length; ++i)
            {
                Console.Write("Danh sach sinh vien phai thi lai:");
                ds[i].Hien();
            }
        }
        public void Hienquamon()
        {
            for(int i = 0; i < ds.Length; ++i)
            {
                Console.Write("Danh sach sinh vien qua mon:");
                ds[i].Hien();
            }
        }
    }
    class App
    {
        static void main()
        {
            QLsinhvien a = new QLsinhvien();
            a.Nhap();
            Console.WriteLine("Danh sach sinh vien thi lai");
            a.Hienthilai();
            Console.WriteLine("Danh sach sinh vien qua mon");
            a.Hienquamon();
            Console.ReadKey();

        }
    }
}
