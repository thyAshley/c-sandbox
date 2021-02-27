using System;
using System.Collections.Generic;


namespace Classes
{
    public class StringUtils
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }
            else
            {
                var words = text.Split(' ');
                var totalChar = 0;
                var summary = new List<string>();

                foreach (var word in words)
                {
                    totalChar += word.Length + 1;
                    summary.Add(word);
                    if (totalChar > maxLength)
                    {
                        break;
                    }
                }
                return String.Join(" ", summary) + "...";

            }

        }
    }
}
