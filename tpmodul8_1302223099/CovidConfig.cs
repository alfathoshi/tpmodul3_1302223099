using System.Text.Json;

namespace tpmodul8_1302223099
{
    public class CovidConfig
    {
        public class Konfig
        {
            public string pesan_ditolak { get; set; }
            public string pesan_diterima { get; set; }
            public string satuan_suhu { get; set; }
            public double batas_hari_demam { get; set; }
        }

        public Konfig konfig;

        public CovidConfig()
        {
            try
            {
                ReadKonfigFile();
            }
            catch
            {
                SetDefault();
                WriteKonfigFile();
            }
        }

        public void SetDefault()
        {
            konfig = new Konfig();
            konfig.pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
            konfig.pesan_diterima = "Anda dipersilakan masuk ke dalam gedung ini";
            konfig.batas_hari_demam = 14;
            konfig.satuan_suhu = "celcius";
        }

        private const string filePath = "covid_config.json";

        public void ReadKonfigFile()
        {
            String configJsonData = File.ReadAllText(filePath);
            konfig = JsonSerializer.Deserialize<Konfig>(configJsonData);
        }

        public void WriteKonfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            String json = JsonSerializer.Serialize(konfig);
            File.WriteAllText(filePath, json);
        }
        
        public void UbahSatuan()
        {
            konfig.satuan_suhu = konfig.satuan_suhu == "celcius" ? "fahrenheit" : "celcius";
            WriteKonfigFile();
        }

    }
}

