using System;

namespace Consonants
{
    public class Check
    {
        public void Checks(string word1, string word2)
        {
            int n = word1.Length;
            int m = word2.Length;

            char[] result = new char[n];
            int k = 0;

          
            for (int i = 0; i < n; i++)
            {
                char c1 = char.ToLower(word1[i]);
                bool isVowel = (c1 == 'a' || c1 == 'e' || c1 == 'i' || c1 == 'o' || c1 == 'u');
                bool removeChar = false;

                if (!isVowel) 
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (c1 == char.ToLower(word2[j]))
                        {
                            removeChar = true;
                            break;
                        }
                    }
                }

                if (!removeChar)
                {
                    result[k++] = word1[i]; 
                }
            }

            char[] finalArr = new char[k];
            int f = 0;

            for (int i = 0; i < k; i++)
            {
                if (i == 0 || result[i] != result[i - 1])
                {
                    finalArr[f++] = result[i];
                }
            }

            
            for (int i = 0; i < f; i++)
            {
                Console.Write(finalArr[i]);
            }
        }
    }
}
