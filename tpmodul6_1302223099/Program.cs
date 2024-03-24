using tpmodul6_1302223099.bin;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Bintang");
        video.PrintVideoDetails();

        for (int i = 0; i < 9999999; i++)
        {
            video.IncreasePlayCount(i);
            video.PrintVideoDetails();
        }

    }
}