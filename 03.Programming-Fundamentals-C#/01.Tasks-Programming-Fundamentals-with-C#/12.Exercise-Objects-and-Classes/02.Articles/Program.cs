using System.Xml.Linq;

List<Article> article = new List<Article>();

string[] articleAdd = Console.ReadLine().Split(", ");

string title = articleAdd[0];
string content = articleAdd[1];
string author = articleAdd[2];

Article articleX = new Article();

articleX.Title = title;
articleX.Content = content;
articleX.Author = author;

int n = int.Parse(Console.ReadLine());


for (int i = 0; i < n; i++)
{
    string command = Console.ReadLine();
    string[] commandArray = command.Split(" ");

    if (commandArray[0] == "Edit:")
    {
        articleX.Content = string.Join(" ", commandArray, 1, commandArray.Length - 1);
    }
    else if (commandArray[0] == "ChangeAuthor:")
    {
        articleX.Author = string.Join(" ", commandArray, 1, commandArray.Length - 1);
    }
    else if (commandArray[0] == "Rename:")
    {
        articleX.Title = string.Join(" ", commandArray, 1, commandArray.Length - 1);
    }
}


Console.WriteLine($"{articleX.Title} - {articleX.Content}: {articleX.Author}");
class Article
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
}
