using System;

class Majalah : Item
{
    public int Edisi;

    public Majalah(string judul, int tahun, int edisi) : base(judul, tahun)
    {
        Edisi = edisi;
    }

    public void InfoEdisi()
    {
        Console.WriteLine("Edisi: " + Edisi);
    }

    public override void Deskripsi()
    {
        Console.WriteLine("Majalah: " + Judul + " (" + Tahun + ") edisi " + Edisi);
    }
}
