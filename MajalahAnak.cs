using System;

class MajalahAnak : Majalah
{
    public MajalahAnak(string judul, int tahun, int edisi) : base(judul, tahun, edisi) { }

    public void KategoriAnak()
    {
        Console.WriteLine("Kategori: majalah anak-anak");
    }

    public override void Deskripsi()
    {
        Console.WriteLine("Majalah Anak: " + Judul + " (" + Tahun + ") edisi " + Edisi);
    }
}
