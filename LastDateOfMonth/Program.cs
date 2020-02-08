using System;

namespace LastDateOfMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dtActual = DateTime.Today;
            Int32 iDay = DateTime.DaysInMonth(dtActual.Year, dtActual.Month);
            DateTime dtLastDayOfMonth = new DateTime(dtActual.Year, dtActual.Month, iDay);

            Console.WriteLine(dtLastDayOfMonth);
            Console.ReadKey();
        }
    }
}
