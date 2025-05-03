namespace _04.PasswordValidator
{
    // string test = "someString" --> test.Length --> (11) int how many symbols
    // foreach (char letter in password) --> for each char [name] in [string]
    // Environment.NewLine --> go to new line.
    // string += string2 ==> stringstring2 [ string = string + string2 ] ==> [string += string2]
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string result = ValdiatePassword(password);
            Console.WriteLine(result);
        }

        static string ValdiatePassword(string password)
        {
            string result = "";
            if (!IsValidLength(password))
            {
                result += $"Password must be between 6 and 10 characters" + Environment.NewLine;
            }

            if (!IsConsistsOfLettersAndDigits(password))
            {
                result += "Password must consist only of letters and digits" + Environment.NewLine;
            }

            if (!IsValidDigitsCount(password))
            {
                result += "Password must have at least 2 digits" + Environment.NewLine;
            }

            if (result == "")
            {
                result = "Password is valid";
            }

            return result;
        }

        private static bool IsConsistsOfLettersAndDigits(string password)
        {
            foreach (char letter in password)
            {
                if (!char.IsLetterOrDigit(letter))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsValidDigitsCount(string password)
        {
            int digits = 0;
            foreach (char letter in password)
            {
                if (char.IsDigit(letter))
                {
                    digits++;
                }

                if (digits == 2)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsValidLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
    }
}