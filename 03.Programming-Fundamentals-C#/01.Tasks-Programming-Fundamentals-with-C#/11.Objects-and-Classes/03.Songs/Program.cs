int n = int.Parse(Console.ReadLine());

List<Song> songs = new List<Song>();

for (int i = 0; i < n; i++)
{
    string[] data = Console.ReadLine().Split("_");

    Song song = new Song();

    string type = data[0];
    string name = data[1];
    string date = data[2];

    song.Data = date;
    song.TypeList = type;
    song.Name = name;

    songs.Add(song);
}

string typeList = Console.ReadLine();

if (typeList == "all")
{
    foreach (Song song in songs)
    {
        Console.WriteLine(song.Name);
    }
}
else
{
    foreach (Song song in songs)
    {
        if (song.TypeList == typeList)
        {
            Console.WriteLine(song.Name);
        }
    }
}


class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Data { get; set; }

}
