public class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine($"Halo user {nama}");
    }
}

public class Utama
{
    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();

        Console.Write("Masukkan nama Anda: ");
        string nama = Console.ReadLine();

        halo.SapaUser(nama);
    }
}