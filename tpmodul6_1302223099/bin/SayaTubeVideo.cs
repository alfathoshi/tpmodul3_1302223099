using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302223099.bin
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            var rand = new Random();

            Debug.Assert(title.Length < 100 && title != null, "Judul tidak boleh kosong dan maksimal 100 karakter");

            this.title = title;
            id = rand.Next(10000,99999);
            playCount = 0;
        }
        public int getId() 
        { 
            return id; 
        }
        public void IncreasePlayCount(int play)
        {
            Debug.Assert(play < 10000000, "Input terlalu banyak");
            playCount += play;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Video Details");
            Console.WriteLine($"ID         : {id}");
            Console.WriteLine($"Title      : {title}");
            Console.WriteLine($"Play Count : {playCount}");
        }
    }
}
