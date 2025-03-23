using System;

namespace tpmodul6_103022300109
{
    class Program
    {
        static void Main()
        { 
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [Reza Indra Maulana]");
            video.IncreasePlayCount(10);
            video.PrintVideoDetails();
        }
    }
}
