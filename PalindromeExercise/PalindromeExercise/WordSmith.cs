using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {

            string reverse = new string(word.Reverse().ToArray());
            bool result = (word ==  reverse) ? true : false;
            return result;
           
        }

    }



}
