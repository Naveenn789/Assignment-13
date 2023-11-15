using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConAppRegex
{
    public class Method
    {
        string email;
        int count;
        string mobile;
        string customregex;

        public void Count() 
        {
            Console.WriteLine("Enter a sentence or paragraph to count the number of words in it");
            string l = Console.ReadLine();
            count = Regex.Matches(l, @"\b\w+\b").Count;
            Console.WriteLine("Total words in the sentence/paragraph which you entered is : "+count);
        }

        
        public bool Email()
        {
            Console.WriteLine("Enter Email");
            email = Console.ReadLine();
            string pattern = @"[a-z0-9._%+-]+@[a-z0-9]+\.[a-z]{2,4}$";
            Regex r = new Regex(pattern);
            if (r.IsMatch(email))
            {
                Console.WriteLine(email + " is s valid email");
            }
            else
            {
                Console.WriteLine(email + " is a invaild email");
            }
            return true;

        }

        public void Mobile()
        {
            Console.WriteLine("enter mobile number");
            mobile = Console.ReadLine();
            string pattern1 = @"^\d{3}-\d{3}-\d{4}$";
            Regex regex1 = new Regex(pattern1);
            if (regex1.IsMatch(mobile))
            {
                Console.WriteLine("valid phone number");
            }
            else
            {
                Console.WriteLine("invalid number");
            }

        }

        public void CustomRegexSearch()
        {
            Console.WriteLine("enter your custom regex:");
            customregex = Console.ReadLine();
            string pattern3 = @"\d+";
            Regex regex = new Regex(pattern3);
            if (regex.IsMatch(customregex))
            {
                Console.WriteLine($"Found:{customregex}");
            }
            else
            {
                Console.WriteLine($"not found:{customregex}");
            }
        }
        public void Display()
        {
            Console.WriteLine($"Total {count} words in the sentence/paragraph which you entered is ");
            Console.WriteLine($"You entered '{email}' this as your email");
            Console.WriteLine($"You entered this '{mobile}' as your mobile number");
            Console.WriteLine($"You entered '{customregex}'");


        }





    }
}
