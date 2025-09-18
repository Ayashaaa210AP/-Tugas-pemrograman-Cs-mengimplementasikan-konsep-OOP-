public class MobilListrik : Mobil
{
    public MobilListrik(string p, string m) : base(p, m) { }

    public override int HitungBiaya(int hari)
    {
        return hari * 450000;
    }
}
