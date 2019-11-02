using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using GSD.Globalization;

namespace WebApplication19
{
    public class Datee
    {
      

        private void DateBtn_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            PersianCalendar jc = new PersianCalendar();
            string year = jc.GetYear(dt).ToString();
            string month = jc.GetMonth(dt).ToString();
            string day = jc.GetDayOfMonth(dt).ToString();
            string date = String.Format("{0}/{1}/{2}", year, month, day);
            txtDate2.Text = date;
        }
    }
}
