using System;

namespace tpmodul6_103022300109
{
    class Program
    {
        static void Main()
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [Reza Indra Maulana]");

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);//buat mastiin dia nyampe 1000 aja
                video.IncreasePlayCount(10000000);
            }
            video.PrintVideoDetails();
        }
    }
}
