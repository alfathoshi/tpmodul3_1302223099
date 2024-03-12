public class Program
{
    public class KodePos
    {
        public enum Kelurahan { Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja }
        public static string getKodePos(Kelurahan namaKelurahan)
        {
            string[] kodePos = { "40266", "40287", "40267", "40256", "40287", "40286", "40286", "40286", "40272", "40274", "40273" };
            return kodePos[(int)namaKelurahan];
        }
        public static void Main(string[] args)
        {
            Kelurahan kelurahan = Kelurahan.Batununggal;
            string kodePos = getKodePos((kelurahan));
            Console.WriteLine("Kelurahan " + kelurahan.ToString() + " memiliki kode pos: " + kodePos);
        }
    }
}