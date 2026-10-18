using System;
using System.Collections.Generic;

class Perpustakaan
{
    List<Item> daftarItem = new List<Item>();

    public void TambahItem(Item item)
    {
        daftarItem.Add(item);
    }

    public void DaftarItem()
    {
        foreach (Item item in daftarItem)
        {
            item.Deskripsi();
        }
    }
}
