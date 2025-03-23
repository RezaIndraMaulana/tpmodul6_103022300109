﻿using System;
using System.Collections.Generic;
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
            if (title == null || title == "")
            {
                throw new ArgumentException("Judul tidak boleh kosong");
            }

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0)
            {
                throw new ArgumentException("Play count tidak boleh negatif");
            }

            playCount += count;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video: " + id);
            Console.WriteLine("Judul: " + title);
            Console.WriteLine("Jumlah Play: " + playCount);
        }
    }
}