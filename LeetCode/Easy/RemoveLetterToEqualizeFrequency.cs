using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class RemoveLetterToEqualizeFrequency
    {
        // https://leetcode.com/problems/remove-letter-to-equalize-frequency/description/

        public bool EqualFrequency(string word)
        {
            Dictionary<char, int> Frequencias = new();

            for (int i = 0; i < word.Length; i++)
            {
                if (Frequencias.ContainsKey(word[i]))
                {
                    Frequencias[word[i]]++;
                }
                else
                {
                    Frequencias.Add(word[i], 1);
                }
            }

            List<int> lstFrequencias = new(Frequencias.Values);

            if (lstFrequencias.Count == 1) return true;

            for (int i = 0; i < lstFrequencias.Count; i++)
            {
                int Auxiliar = lstFrequencias[i] - 1;
                bool Valido = false;

                for (int j = 0; j < lstFrequencias.Count; j++)
                {
                    if (Auxiliar == 0 && i != lstFrequencias.Count - 1)
                    {
                        Auxiliar = lstFrequencias[j + 1];
                    }
                    else if (Auxiliar == 0)
                    {
                        Auxiliar = lstFrequencias[0];
                    }

                    if (i != j)
                    {
                        if (lstFrequencias[j] != Auxiliar)
                        {
                            Valido = false;
                            break;
                        }
                        else
                        {
                            Valido = true;
                        }
                    }
                }

                if (Valido)
                {
                    return Valido;
                }
            }

            return false;
        }
    }
}
