using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StringCheckLibrary
{
    public class StringCheck
    {
        /// <summary>
        /// Проверка stringName на наличие символов: русские буквы, пробел и дефис.
        /// Строка stringName не должна превышать 50 символов.
        /// </summary>
        /// <param name="stringName"></param>
        /// <returns>
        ///     false/true
        /// </returns>
        public bool CheckName(string stringName) 
        {
            string regex = @"^([а-я]){1,50}(\s)|(\-)([а-я]){1,50}(\s)|(\-)([а-я]){1,50}$";
            string regexWhiteSpace = @"^((\s)|(\-))+$";


            if (Regex.Match(stringName, regexWhiteSpace, RegexOptions.IgnoreCase).Success) //проверка на пробел и дефис
            {
                return false;
            }
            else
            {
                if (Regex.Match(stringName, regex, RegexOptions.IgnoreCase).Success) //проверка на соответствие строки регулярному выражению (regex)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            
        }
    }
}
