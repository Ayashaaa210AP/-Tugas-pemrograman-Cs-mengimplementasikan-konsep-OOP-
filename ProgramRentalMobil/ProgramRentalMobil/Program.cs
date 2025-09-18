using System;

class Program
{
    static void Main(string[] args)
    {
        Mobil mobil1 = new Mobil("B1234XYZ", "Toyota Avanza");
        MobilListrik mobil2 = new MobilListrik("B5678ABC", "Hyundai Ioniq");

        Pelanggan pelanggan1 = new Pelanggan("Argha", "SIM123456");

        Transaksi transaksi1 = new Transaksi(mobil2, pelanggan1, 3);
        transaksi1.CetakNota();

        mobil2.Kembali();
    }
}
