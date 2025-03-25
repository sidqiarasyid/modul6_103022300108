using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300108
{
    class SayaTubeVideo
    {
        private int id, playCount;
        private String title;


        public SayaTubeVideo(String title) {
            Random rand = new Random();
            this.title = title;
            this.id = rand.Next(10000,99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count) {
            playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine(id);
            Console.WriteLine(title);
            Console.WriteLine("View: " + playCount);
        }

        public int GetPlayCount() {
            return this.playCount;
        }

        public String GetTitle()
        {
            return this.title;
        }
    }
}
