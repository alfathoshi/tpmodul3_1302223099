internal class Program
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T x)
        {
            Console.WriteLine("Halo user " + x);
        }
    }
    private static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        string nama;
        Console.Write("Nama: ");
        nama = Console.ReadLine();
        halo.SapaUser(nama);
    }
}