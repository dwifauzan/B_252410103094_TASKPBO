using System;

class Buku : Item
{
    public string Penulis;

    public Buku(string judul, int tahun, string penulis) : base(judul, tahun)
    {
        Penulis = penulis;
    }

    public void CekPenulis()
    {
        Console.WriteLine("Penulis: " + Penulis);
    }

    public override void Deskripsi()
    {
        Console.WriteLine("Buku: " + Judul + " (" + Tahun + ") oleh " + Penulis);
    }
}
