using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delete
{
    public class StringAbbreviation
    {
        public string Abbreviate(string input)
        {
            string retval = input;
            if (string.IsNullOrWhiteSpace(input)) return input;

            else
            {
                var enumerableOfWords = input.Split(' ', '-', ',', ';', '.', '\'', ':');

                foreach (var word in enumerableOfWords)
                {
                    StringBuilder builder = new StringBuilder();
                    if (word.Length > 3)
                    {
                        builder.Append(word.Substring(0, 1));
                        builder.Append((word.Length - 2).ToString());
                        builder.Append(word.Substring(word.Length -1, 1));
                        retval = retval.Replace(word, builder.ToString());
                    }
                }
            }
            return retval;
        }

    }
}
