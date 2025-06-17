using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //string phoneString = Console.ReadLine();
            //Regex validPhonesPatter = new Regex(@"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b");

            //MatchCollection phoneCollection = validPhonesPatter.Matches(phoneString);
            //List<string> phoneList = new List<string>();

            //foreach (var phone in phoneCollection)
            //{
            //    phoneList.Add(phone.ToString());
            //}

            //Console.WriteLine(string.Join(", ", phoneList));



            // LINQ Решение:

            string pattern = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";
            string phones = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phones, pattern);

            string[] matchPhones = phoneMatches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", matchPhones));

        }
    }
}