namespace _01.Songs
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                //"favourite_DownTown_3:14"
                string[] songData = Console.ReadLine().Split('_');

                Song currentSong = new Song();
                currentSong.TypeList = songData[0];
                currentSong.Name = songData[1];
                currentSong.Time = songData[2];

                songs.Add(currentSong);
            }

            string typeListName = Console.ReadLine();

            if (typeListName == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs.Where(s => s.TypeList == typeListName))
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }

    public class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }


}