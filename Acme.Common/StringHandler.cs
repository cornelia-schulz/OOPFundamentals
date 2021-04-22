using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    // A static class can't be instantiated with the new keyword, it's sealed and cannot be extended by inheritance
    // every method in a static class must be static
    public static class StringHandler
    {
        // adding the this keyword in the parameters extends the actual string method,
        // so InsertSpaces will be a method in Intellisense on String
        /// <summary>
        /// Insert spaces before each capital letter in a string
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;
            if (!String.IsNullOrWhiteSpace(source))
            { 
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            return result.Trim();
        }
    }
}
