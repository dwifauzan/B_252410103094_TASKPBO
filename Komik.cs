using System;

class Komik : Buku
{
    public Komik(string judul, int tahun, string penulis) : base(judul, tahun, penulis) { }

    public void TampilkanIlustrasi()
    {
        Console.WriteLine("Menampilkan ilustrasi komik " + Judul);
    }

    public override void Deskripsi()
    {
        Console.WriteLine("Komik: " + Judul + " (" + Tahun + ") oleh " + Penulis);
    }
}
