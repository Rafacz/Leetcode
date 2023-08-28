﻿using System.Text;

namespace LC.Problems
{
    //12. Integer to Roman
    public class IntegerToRoman
    {
        public static string IntToRoman(int num)
        {
            var sb = new StringBuilder();
            var sV = new StringBuilder();

            var numerals = new Dictionary<string, string>
            {
                { "1", "I" },
                { "2", "II" },
                { "3", "III" },
                { "4", "IV" },
                { "5", "V" },
                { "6", "VI" },
                { "7", "VII" },
                { "8", "VIII" },
                { "9", "IX" },
                { "10", "X" },
                { "20", "XX" },
                { "30", "XXX"},
                { "40", "XL" },
                { "50", "L" },
                { "60", "LX" },
                { "70", "LXX" },
                { "80", "LXXX" },
                { "90", "XC" },
                { "100", "C" },
                { "200", "CC" },
                { "300", "CCC" },
                { "400", "CD" },
                { "500", "D" },
                { "600", "DC" },
                { "700", "DCC" },
                { "800", "DCCC" },
                { "900", "CM" },
                { "1000", "M" },
                { "2000", "MM" },
                { "3000", "MMM" }
            };

            while (num > 0)
            {
                string n = num.ToString();

                for (int i = n.Length - 1; i > -1; i--)
                {
                    sV.Insert(0, n[i]);
                    if (n[i] != '0')
                    {
                        break;
                    }
                }

                sb.Insert(0, numerals.Single(x => x.Key == sV.ToString()).Value);

                num -= Convert.ToInt32(sV.ToString());
                sV.Clear();
            }

            return sb.ToString();
        }
    }
}