using System;

namespace ReplaceString
{
    internal class UserProgramCode
    {
        public static void Replace(string[] input, int input2, char ch)
        {
            string word = null;

            // get nth word
            for (int i = 0; i < input.Length; i++)
            {
                if (i == input2 - 1)
                {
                    word = input[i];
                }
            }

            // replace each character in nth word
            string replacedWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                replacedWord += ch;
            }

            // update the nth word
            input[input2 - 1] = replacedWord;

            // print final string in lowercase
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i].ToLower() + " ");
            }
        }
    }
}
