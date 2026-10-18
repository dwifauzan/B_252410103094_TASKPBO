using System;

class Program
{
    static void Main()
    {
        Perpustakaan perpus = new Perpustakaan();

        Novel novel = new Novel("Laskar Pelangi", 2005, "Andrea Hirata");
        Komik komik = new Komik("Doraemon", 1970, "Fujiko F. Fujio");
        Majalah majalah = new Majalah("Intisari", 2020, 15);
        MajalahAnak anak = new MajalahAnak("Bobo", 2023, 40);
        MajalahTeknologi tek = new MajalahTeknologi("PC Magazine", 2024, 12);

        perpus.TambahItem(novel);
        perpus.TambahItem(komik);
        perpus.TambahItem(majalah);
        perpus.TambahItem(anak);
        perpus.TambahItem(tek);

        Console.WriteLine("=== Daftar Item ===");
        perpus.DaftarItem();

        Console.WriteLine("\n=== Polymorphism ===");
        Item a = novel;
        Item b = majalah;
        a.Deskripsi();
        b.Deskripsi();

        Console.WriteLine("\n=== Method Khusus ===");
        novel.CekPenulis();
        komik.TampilkanIlustrasi();
        majalah.InfoEdisi();
        anak.KategoriAnak();

        // Console.WriteLine("\n=== Soal 1 ===");
        // novel.Deskripsi();
        // majalah.Deskripsi();

        // Console.WriteLine("\n=== Soal 2 ===");
        // novel.BacaSinopsis();

        // Console.WriteLine("\n=== Soal 3 ===");
        // Console.WriteLine(novel.Judul + ", " + novel.Tahun + ", " + novel.Penulis);
        // novel.InfoItem();
        // novel.CekPenulis();

        // Console.WriteLine("\n=== Soal 4 ===");
        // tek.TopikTeknologi();
        //
        Item item = new Komik("One Piece", 1997, "Eiichiro Oda");
        item.Deskripsi();
        // item.TampilkanIlustrasi();  // error: Item tidak punya method ini
        ((Komik)item).TampilkanIlustrasi();
    }
}
