using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiring_DateNamespace
{
    public class  Hiring_Date
    {
        public int Day ;
        public int Month;
        public int Year;
        public Hiring_Date(int _day, int _month, int _year){
            Day = _day;
            Month = _month;
            Year = _year;
        }

        public int day{
            get {return Day;}
            set {Day = value;}
        }

        public int month{
            get; set;
        }

        public int year {
            get {return Year;}
            set{ Year= value;}
        }


    }
}