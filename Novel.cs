using System;

class Novel : Buku
{
    public Novel(string judul, int tahun, string penulis) : base(judul, tahun, penulis) { }

    public void BacaSinopsis()
    {
        Console.WriteLine("Membaca sinopsis novel " + Judul);
    }

    public override void Deskripsi()
    {
        Console.WriteLine("Novel: " + Judul + " (" + Tahun + ") oleh " + Penulis);
    }
}
