using System;
using System.Collections.Generic;


namespace BlockBusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(string title, enum genre, int runtime, List<string> scenes, int currentTime) : base(title, genre, runtime, scenes)
        {
            CurrentTime = currentTime;
        }

        public override void Play()
        {
            Console.WriteLine(Scenes[CurrentTime]);
            CurrentTime++;
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
