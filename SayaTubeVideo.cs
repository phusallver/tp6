using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYAYOUTUBEVIDEO
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        Random rendem = new Random();

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title != null && title.Length <= 100, "Judul tidak sesuai syarat");
            this.id = rendem.Next();
            this.title = title;
            this.playCount = 0;
        }
        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount <= 10000000, "Jumlah penayangan tidak sesuai syarat");
            this.playCount = checked(this.playCount + playCount);
        }
        public void PrintVideoDetails()
        {
            System.Console.WriteLine("Judul video            : " + this.title);
            System.Console.WriteLine("ID video               : " + this.id);
            System.Console.WriteLine("Sudah diputar sebanyak : " + this.playCount);
        }
    }
}
