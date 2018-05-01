using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PalandromeCodeChallenge
{
    public static class Program
    {
        public static bool IsPalindrome(string Word)
        {
            string s, revs = "";
            Console.WriteLine("Please Enter Word");
            s = Console.ReadLine().ToLower();
            string r = Regex.Replace(s, @"(\s|-)", "");

            for (int i = r.Length - 1; i >= 0; i--)
            {
                revs += r[i].ToString();
            }

            if (revs == r)
            {
                
                return true;
            }
            else
            {
                
                return false;
            }
            
        }

    }
}
