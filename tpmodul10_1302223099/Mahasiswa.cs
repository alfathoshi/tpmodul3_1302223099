namespace tpmodul10_1302223099
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string NIM { get; set; }

        public Mahasiswa(string nama, string nim) 
        { 
            this.Nama = nama;
            this.NIM = nim;
        }
    }
}
