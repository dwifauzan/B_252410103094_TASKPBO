using System;

class Item
{
    public string Judul;
    public int Tahun;

    public Item(string judul, int tahun)
    {
        Judul = judul;
        Tahun = tahun;
    }

    public virtual void Deskripsi()
    {
        Console.WriteLine("Item: " + Judul + " (" + Tahun + ")");
    }

    public void InfoItem()
    {
        Console.WriteLine("Judul: " + Judul + ", Tahun: " + Tahun);
    }
}
