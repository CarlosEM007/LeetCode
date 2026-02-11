using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class FindSmallestLetterGreaterThanTarget
    {
        public static char NextGreatestLetter(char[] letters, char target)
        {
            char[] chars = letters.Where(x => x > target).ToArray();

            return chars.Length > 0 ? chars[0] : letters[0];
        }
    }
}
