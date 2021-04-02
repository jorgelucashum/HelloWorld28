using System;

namespace HelloWorld28.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valueP, int hours)
        {
            Date = date;
            ValuePerHour = valueP;
            Hours = hours;

        }

        public double TotalValue()
        {

            return Hours * ValuePerHour;
        }
    }
}
