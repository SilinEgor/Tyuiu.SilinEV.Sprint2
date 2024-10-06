using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SilinEV.Sprint2.Task1.V11.Lib
{
    public class DataService : ISprint2Task1V11
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] q = new bool[6];
            q[0] = a == b | c == d;
            q[1] = q[0] & a == b;
            q[2] = q[1] == q[0] || a < b;
            q[3] = q[1] && q[0];
            q[4] = !q[1];
            q[5] = q[2] ^ q[1];

            return q;
        }
    }
}
