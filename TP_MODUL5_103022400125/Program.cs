public class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine($"Halo user {nama}");
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void printData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}

public class Utama{
    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();

        Console.Write("Masukkan nama Anda: ");
        string nama = Console.ReadLine();

        halo.SapaUser(nama);

        DataGeneric<string> dataString = new DataGeneric<string>("103022400125");
        dataString.printData();
    }
}