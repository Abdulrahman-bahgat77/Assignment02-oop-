using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_oop_
{
    internal class HiringDate
    {
        #region Attrbute
        private int day;
        private int month;
        private int year;

        #endregion

        #region property
        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        public int Month
        {
            get { return month; }
            set { month = value > 0 && value <= 12 ? value : 1; }
        }


        public int Day
        {
            get { return day; }
            set { day = value > 0 && value <= 31 ? value : 1; }
        }

        #endregion

        #region constructor
        public HiringDate()
        {

        }
        public HiringDate(int _day, int _month, int _year)
        {
            Day = _day;
            Month = _month;
            Year = _year;
        }

        public override string ToString()
        {
            return $"Day={Day}\nMonth={Month}\nYear={Year}";
        }
        #endregion

    }
}
