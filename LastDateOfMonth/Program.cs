using System;

namespace LastDateOfMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dtActual = DateTime.Today;
            Int32 iDay = DateTime.DaysInMonth(dtActual.Year, dtActual.Month);
        }
    }
}
