using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022300109
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        public SayaTubeVideo(string title)
        {
            Debug.Assert(title != null && title.Length <= 100, "Judul tidak boleh null dan maksimal 100 karakter");
            if (title == null || title.Length > 100)
            {
                throw new ArgumentException("Judul tidak boleh null atau lebih dari 100 karakter");
            }

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count > 0 && count <= 10000000, "Play count harus antara 1 hingga 10.000.000");
            if (count <= 0 || count > 10000000)
            {
                throw new ArgumentException("Play count harus antara 1 hingga 10.000.000");
            }

            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi overflow pada play count!");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video: " + id);
            Console.WriteLine("Judul: " + title);
            Console.WriteLine("Jumlah Play: " + playCount);
        }
    }
}