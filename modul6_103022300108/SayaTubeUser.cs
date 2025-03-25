using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300108
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private String username;

        public SayaTubeUser(string username)
        {
            this.username = username;
            uploadedVideos = new List<SayaTubeVideo>();  
        }

        public int GetTotalVideoPlayCount() {
            int res = 0;
            for (int i = 0; i < uploadedVideos.Count; i++) {
                res += uploadedVideos[i].GetPlayCount();
            }
            return res;
        }

        public void AddVideo(SayaTubeVideo vid) {
            uploadedVideos.Add(vid);
        }

        public void PrintAllVideoPlayCount() {
            Console.WriteLine("User: " + username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + i+1 + " judul: " + uploadedVideos[i].GetTitle());
            }
        }
    }
}
