using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SilinEV.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            switch (m)
            {
                case 1:
                    switch (n)
                    {
                        case 3:
                            m = 28;
                            break;
                        case 2:
                        case 4:
                        case 6:
                        case 8:
                        case 10:
                        case 12:
                            m = 31;
                            break;
                        default:
                            m = 30;
                            break;
                    }
                    m -= 1;
                    break;
                default:
                    m -= 1;
                    break;
            }
            string a = Convert.ToString(n).Length == 2 ? Convert.ToString(n) : "0" + n;
            string s = Convert.ToString(m).Length == 2 ? Convert.ToString(m) : "0" + m;
            return s + "." + a;
        }
    }
}
