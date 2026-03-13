using System;
using System.Collections.Generic;
using System.Text;

namespace NextConsonantsOrVowels
{
    using System;
        public class UserProgramCode
        {
            public static string nextString(string input1)
            {
                string vowelsLower = "aeiou";
                string vowelsUpper = "AEIOU";

                
                foreach (char ch in input1)
                {
                    if (!char.IsLetter(ch))
                        return "Invalid input";
                }

                char[] result = new char[input1.Length];

                for (int i = 0; i < input1.Length; i++)
                {
                    char ch = input1[i];

                    // If vowel → next consonant
                    if (vowelsLower.Contains(ch.ToString()))
                        result[i] = (char)(ch + 1);

                    else if (vowelsUpper.Contains(ch.ToString()))
                        result[i] = (char)(ch + 1);

                    // If consonant → next vowel
                    else
                    {
                        result[i] = GetNextVowel(ch);
                    }
                }

                return new string(result);
            }

            private static char GetNextVowel(char ch)
            {
                char[] vowelsLower = { 'a', 'e', 'i', 'o', 'u' };
                char[] vowelsUpper = { 'A', 'E', 'I', 'O', 'U' };

                if (char.IsUpper(ch))
                {
                    foreach (char v in vowelsUpper)
                    {
                        if (v > ch) return v;
                    }
                    return 'A'; // wrap around
                }
                else
                {
                    foreach (char v in vowelsLower)
                    {
                        if (v > ch) return v;
                    }
                    return 'a'; // wrap around
                }
            }
        }
    }


