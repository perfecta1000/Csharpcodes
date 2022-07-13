using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    internal class message
    {
        public static string GetMessage(string language)
        {
            if (language.Equals("hausa"))
            {
                return "zo";
            }
            else if (language.Equals("yoruba"))
            {
                return "wa";
            }
            else if (language.Equals("igbo"))
            {
                return "bia";
            }

            else if (language == "English")
            {
                return "come";
            }
            else
            {
                return "...";
            }
        }
    }
}
