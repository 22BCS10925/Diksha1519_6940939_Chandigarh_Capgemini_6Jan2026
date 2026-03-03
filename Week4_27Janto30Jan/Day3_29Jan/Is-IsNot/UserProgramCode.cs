using System;
using System.Collections.Generic;
using System.Text;

namespace Is_IsNot
{
    internal class UserProgramCode
    {
        public static string check(string input)
        {
           
            bool found =false;
            string word = " not ";
            //string word1 = "is";
            if(input.Contains(" is not "))
            {
                return input;
            }
                if (input.Contains(" is "))
                {
                     found = true;
                    int index = input.IndexOf(" is ");
                    index = index + 4;
                    input=input.Insert(index, word);
                }
                
            
            return input;
        }
    }
}
