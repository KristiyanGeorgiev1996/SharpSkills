int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string command = Console.ReadLine();
    string[] commandArray = command.Split(", ");

    List<Article> article = new List<Article>();

    string title = commandArray[0];
    string content = commandArray[1];
    string author = commandArray[2];

    Article articleX = new Article();

    articleX.Title = title;
    articleX.Content = content;
    articleX.Author = author;


    Console.WriteLine($"{articleX.Title} - {articleX.Content}: {articleX.Author}");

}


class Article
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
}
