public class Mobil
{
    public string plat;
    public string merk;
    public bool tersedia;

    public Mobil(string p, string m)
    {
        plat = p;
        merk = m;
        tersedia = true;
    }

    public virtual int HitungBiaya(int hari)
    {
        return hari * 500000;
    }

    public void Sewa() => tersedia = false;
    public void Kembali() => tersedia = true;
}
