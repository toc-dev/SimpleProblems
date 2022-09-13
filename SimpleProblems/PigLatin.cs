using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleProblems
{
    public class PigLatin
    {
        public static string PigLat(string str)
        {
            str = str.ToLower();
            string strs = "";
            foreach (string st in str.Split(" "))
            {
                if (char.IsLetter(st[st.Count() - 1]))
                {
                    string firstRemoved = st.Remove(0, 1);
                    string pigWords = firstRemoved + $"{st[0]}ay";
                    strs += pigWords + " ";
                }
                else
                {
                    string firstRemoved = st.Remove(0, 1);
                    string lastRemoved = firstRemoved.Remove(firstRemoved.Length - 1);
                    string pigWords = lastRemoved + $"{st[0]}ay" + st[st.Count() - 1];
                    strs += pigWords + " ";
                }
            }
            string finalString = char.ToUpper(strs[0]) + strs.Substring(1);
            return finalString;
        }
    }
}
