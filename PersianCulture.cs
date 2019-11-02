using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Reflection;

namespace GSD.Globalization
{
    public class PersianCulture
    {
        private void date2Btn_Click(object sender, EventArgs e)
        {
            PersianCalendar jc = new PersianCalendar();
            DateTime dt = jc.ToDateTime(1393, 3, 1, 0, 0, 0, 0);
            txtDate2.Text = dt.ToShortDateString();
        }
    }

    internal class txtDate2
    {
        public static string Text { get; internal set; }
    }
}
