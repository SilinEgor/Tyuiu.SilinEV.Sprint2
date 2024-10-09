using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SilinEV.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (x < 0)
            {
                return ((2 - x <= y) && (y <= x * x)) ? true : false;
            }
            else
            {
                return ((0 <= y) && (y <= 2 - x) && (y <= x * x)) ? true : false;
            }
        }
    }
}
