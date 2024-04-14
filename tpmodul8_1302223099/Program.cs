using tpmodul8_1302223099;

internal class Program
{
    private static void Main(string[] args)
    {
        CovidConfig config = new CovidConfig();

        Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {config.konfig.satuan_suhu}");
        double suhu = double.Parse(Console.ReadLine());

        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
        int hariDeman = int.Parse(Console.ReadLine());

        if ((config.konfig.satuan_suhu == "celcius" && suhu >= 36.5 && suhu <= 37.5) ||
            (config.konfig.satuan_suhu == "fahrenheit" && suhu >= 97.7 && suhu <= 99.5) &&
            hariDeman < config.konfig.batas_hari_demam)
        {
            Console.WriteLine(config.konfig.pesan_diterima);
        }
        else
        {
            Console.WriteLine(config.konfig.pesan_ditolak);
        }

        config.UbahSatuan();
        Console.WriteLine($"Selanjutnya, satuan diubah ke dalam {config.konfig.satuan_suhu}");
    }
}