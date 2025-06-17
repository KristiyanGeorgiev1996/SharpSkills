string[] fileName = Console.ReadLine().Split('\\');

int x = fileName.Length - 1;
int yy = 0;

string name = "";
string file = "";

for (int i = 0; i < fileName[x].Length; i++)
{
    if (fileName[x][i] == '.')
    {
        yy = i;
    }
}

for (int i = 0; i < yy; i++)
{
    name += fileName[x][i];
}
for (int i = yy + 1; i < fileName[x].Length; i++)
{
    file += fileName[x][i];
}

Console.WriteLine($"File name: {name}");
Console.WriteLine($"File extension: {file}");