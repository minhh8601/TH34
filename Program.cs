using System;
class PS
{
    private int ts, ms;
    public PS()
    {
        ts = 0; ms = 1;
    }
    public PS(int ts, int ms)
    {
        this.ts = ts;
        this.ms = ms;
    }
    public void Nhap()
    {
        Console.Write("Nhap tu so:"); ts = int.Parse(Console.ReadLine());
        Console.Write("Nhap mau so:"); ms = int.Parse(Console.ReadLine());
    }
    public int Uscln(int x, int y)
    {
        x = Math.Abs(x); y = Math.Abs(y);
        while (x != y)
        {
            if (x > y) x = x - y;
            if (y > x) y = y - x;
        }
        return x;
    }
    public PS Rutgon()
    {
        int uc = Uscln(this.ts, this.ms);
        this.ts = this.ts / uc;
        this.ms = this.ms / uc;
        return this;
    }
    public PS Tong(PS t2)
    {
        PS t = new PS();
        t.ts = this.ts * t2.ms + this.ms * t2.ts;
        t.ms = this.ms * t2.ms;
        return t.Rutgon();
    }
    public static PS operator +(PS t1, PS t2)
    {
        PS t = new PS();
        t.ts = t1.ts * t2.ms + t1.ms * t2.ts;
        t.ms = t1.ms * t2.ms;
        return t.Rutgon();
    }
    public PS Hieu(PS t2)
    {
        PS t = new PS();
        t.ts = this.ts * t2.ms - this.ms * t2.ts;
        t.ms = this.ms * t2.ms;
        return t.Rutgon();
    }
    public static PS operator -(PS t1, PS t2)
    {
        PS t = new PS();
        t.ts = t1.ts * t2.ms - t1.ms * t2.ts;
        t.ms = t1.ms * t2.ms;
        return t.Rutgon();
    }
    public PS Tongvoi1so(PS t2)
    {
        PS t = new PS();
        t.ts = this.ts * 1 + this.ms * t2.ts;
        t.ms = this.ms * 1;
        return t.Rutgon();
    }
    public PS Hieuvoi1so(PS t2)
    {
        PS t = new PS();
        t.ts = this.ts * 1 - this.ms * t2.ts;
        t.ms = this.ms * 1;
        return Rutgon();
    }
}
class App
{
    static void Main()
    {
    }
}
