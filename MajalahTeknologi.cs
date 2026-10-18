using System;

class MajalahTeknologi : Majalah
{
    public MajalahTeknologi(string judul, int tahun, int edisi) : base(judul, tahun, edisi) { }

    public void TopikTeknologi()
    {
        Console.WriteLine("Topik: teknologi");
    }

    public override void Deskripsi()
    {
        Console.WriteLine("Majalah Teknologi: " + Judul + " (" + Tahun + ") edisi " + Edisi);
    }
}
