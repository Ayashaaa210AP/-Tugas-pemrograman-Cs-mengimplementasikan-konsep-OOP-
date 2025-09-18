public class Transaksi
{
    public Mobil mobil;
    public Pelanggan pelanggan;
    public int lama;

    public Transaksi(Mobil m, Pelanggan p, int l)
    {
        mobil = m;
        pelanggan = p;
        lama = l;
        mobil.Sewa();
    }

    public void CetakNota()
    {
        Console.WriteLine("=== NOTA SEWA ===");
        Console.WriteLine("Nama: " + pelanggan.nama);
        Console.WriteLine("Mobil: " + mobil.merk + " (" + mobil.plat + ")");
        Console.WriteLine("Lama sewa: " + lama + " hari");
        Console.WriteLine("Total biaya: Rp" + mobil.HitungBiaya(lama));
    }
}
