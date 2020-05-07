using System;
using System.Collections.Generic;


namespace BlockBusterLab
{
    public  enum Genre { Drama, Comedy, Horror, Romance, Action}
    abstract class Movie
    {
        public string Title { get; set; }
        public enum Genre { get; set; }
        public int Runtime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string title, Genre genre, int runtime, List<string> scenes)
        {
            Title = title;
            Genre = genre;
            Runtime = runtime;
            Scenes = scenes;
        }

        public Movie()
        {
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"\n\t Title: {Title}\nGenre: {Genre}\nRuntime: {Runtime} ");
        }

        public void PrintScenes()
        {
            int sceneIndex = 0;
            foreach (string scene in Scenes)
            {
                sceneIndex++;
                Console.WriteLine(scene);
                Console.WriteLine(sceneIndex);
            }
        }

        public abstract void Play();
    }
}
