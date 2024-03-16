internal class Program
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T x)
        {
            Console.WriteLine("Halo user " + x);
        }
    }

    public class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data) 
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }
    private static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        string nama;
        Console.Write("Nama: ");
        nama = Console.ReadLine();
        halo.SapaUser(nama);

        Console.Write("NIM: ");
        string nim = Console.ReadLine();
        DataGeneric<string> data = new DataGeneric<string>(nim); 
        data.PrintData();
    }
}