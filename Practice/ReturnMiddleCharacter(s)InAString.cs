using System;
using System.Text;

namespace Practice
{
    public class ReturnMiddleCharacter_s_InAString
    {
        public ReturnMiddleCharacter_s_InAString()
        {
           
        }

        public string GetMiddleCharacters(string stringToGetCharactersIn)
        {
            if (string.IsNullOrWhiteSpace(stringToGetCharactersIn))
                throw new ArgumentNullException(stringToGetCharactersIn);

            StringBuilder builder = new StringBuilder();

            int stringLength = stringToGetCharactersIn.Length;

            char[] charArray = stringToGetCharactersIn.ToCharArray();//

            if(stringLength%2 == 0)
            {
                char leftMiddle = charArray[((stringLength / 2) - 1)];
                char rightMiddle = charArray[((stringLength / 2))];

                builder.Append(leftMiddle);
                builder.Append(rightMiddle);
                return builder.ToString();
            }
            else
            {
                double middle = (stringLength / 2);
                return charArray[(int)middle].ToString();

            }
        }
    }
}
    