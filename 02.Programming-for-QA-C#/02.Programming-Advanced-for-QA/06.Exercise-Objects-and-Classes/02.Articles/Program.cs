namespace _02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleTokens = Console.ReadLine().Split(", ");
            string title = articleTokens[0];
            string content = articleTokens[1];
            string author = articleTokens[2];

            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //"Edit: better content"
                string[] cmdArg = Console.ReadLine().Split(": ");
                string command = cmdArg[0];
                string parameter = cmdArg[1];

                if (command == "Edit")
                {
                    article.Edit(parameter);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(parameter);
                }
                else if (command == "Rename")
                {
                    article.Rename(parameter);
                }
            }

            Console.WriteLine(article.ToString());
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; private set; }

        public string Content { get; private set; }

        public string Author { get; private set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}