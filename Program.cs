using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timespan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime matchDate = new DateTime(day: 12, month: 8, year: 2023);
            DateTime currentDate=DateTime.Now;
            TimeSpan ts=matchDate.Subtract(currentDate);    
            Console.WriteLine("Days remain "+ts.Days);
            Console.WriteLine("Days reamin" + ts.Hours);
            Console.WriteLine(ts.ToString());
            Console.ReadKey();

        
        
        
        }
    }
}
