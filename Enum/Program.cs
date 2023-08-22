using System;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number =Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case (int)MonthOfYear.January:
                    Console.WriteLine(MonthOfYear.January);
                    break;
                case (int)MonthOfYear.February:
                    Console.WriteLine(MonthOfYear.February);

                    break;
                case (int)MonthOfYear.March:
                    Console.WriteLine(MonthOfYear.March);

                    break;
                case (int)MonthOfYear.April:
                    Console.WriteLine(MonthOfYear.April);

                    break;
                case (int)MonthOfYear.May:
                    Console.WriteLine(MonthOfYear.May);

                    break;
                case (int)MonthOfYear.June:
                    Console.WriteLine(MonthOfYear.June);

                    break;
                case (int)MonthOfYear.July:
                    Console.WriteLine(MonthOfYear.July);

                    break;
                case (int)MonthOfYear.August:
                    Console.WriteLine(MonthOfYear.August);

                    break;
                case (int)MonthOfYear.September:
                    Console.WriteLine(MonthOfYear.September);

                    break;
                case (int)MonthOfYear.October:
                    Console.WriteLine(MonthOfYear.October);

                    break;
                case (int)MonthOfYear.November:
                    Console.WriteLine(MonthOfYear.November);

                    break;
                case (int)MonthOfYear.December:
                    Console.WriteLine(MonthOfYear.December);

                    break;

                default:
                    Console.WriteLine("Duzgun reqemi daxil edin");
                    break;
            }
            Console.WriteLine(number);
        }

    }

}
public enum MonthOfYear
{
    
    January = 1,
    February ,
    March ,
    April ,
    May ,
    June ,
    July ,
    August,
    September ,
    October ,
    November ,
    December,
}


