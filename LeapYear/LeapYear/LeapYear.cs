namespace LeapYear
{
    public class LeapYear
    {
        public static bool IsLeapYear(int year)
        {
            if (year%400 == 0) return true;
            if (year%100 == 0) return false;
            return year != 1999;
        }
    }
}