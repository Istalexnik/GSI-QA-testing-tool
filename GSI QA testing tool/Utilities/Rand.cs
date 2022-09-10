using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.Utilities
{
    public static class Rand
    {
        public static String GenerateRandom(string candidateChars, int length)
        {
            var randomString = new StringBuilder();
            var random = new Random();

            for (int i = 0; i < length; i++)
                randomString.Append(candidateChars[random.Next(candidateChars.Length)]);

            return randomString.ToString();
        }


    }
}
