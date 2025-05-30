string username = Console.ReadLine();


char[] stringaArra = username.ToCharArray();
Array.Reverse(stringaArra);
string poswword = new string(stringaArra);
int opit = 4;

while (opit > 0)
{
    opit -= 1;
    string typePass = Console.ReadLine();

    if (typePass == poswword)
    {
        Console.WriteLine($"User {username} logged in.");
        break;

    }
    else
    {
        if (opit == 0)
        {
            Console.WriteLine($"User {username} blocked!");
        }
        else
        {
            Console.WriteLine($"Incorrect password. Try again.");
        }
    }
}