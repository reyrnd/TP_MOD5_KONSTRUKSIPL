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
        DataGeneric<string> dataString = new DataGeneric<string>("103022400125");
        dataString.printData();
    }
}