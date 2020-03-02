using System;

namespace StringUtliity
{
    public class StringChecker
    {


        public int CountOccurrences(char testChar, string testString)
        {

            if (testString == null)
            {
                return -1;
            }

            string toLowerValue = testChar.ToString().ToLower();

            char[] chararray = testString.ToLower().ToCharArray();

            int result = 0;

            foreach (char c in chararray)
            {
                if (c == toLowerValue.ToCharArray()[0])
                {
                    result++;
                }
            }

            return result;
        }
    }
}
