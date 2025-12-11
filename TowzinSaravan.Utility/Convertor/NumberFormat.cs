using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowzinSaravan.Utility.Convertor
{
    public static class NumberFormat
    {
        public static void ThousandSeparator(TextBox txt)
        {
            if (txt.Text == "" || txt.Text == "0") return;
            decimal number;
            number = decimal.Parse(txt.Text, System.Globalization.NumberStyles.Currency);
            txt.Text = number.ToString("#,#");
            txt.SelectionStart = txt.Text.Length;
        }


    }
}
