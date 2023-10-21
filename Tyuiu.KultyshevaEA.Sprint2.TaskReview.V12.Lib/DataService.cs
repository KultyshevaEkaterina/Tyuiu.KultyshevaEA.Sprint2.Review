using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KultyshevaEA.Sprint2.TaskReview.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (((x<=0) && (y>=0) && ( y - Math.Pow(x,2) <=0) && (y+x>=2)) || ((x>=0) && (y-Math.Pow(x,2)<=0)&&(y+x<=2)&&((y>=0))))
            {
                res = true;

            }
            else
            {
                res = false;

            }
            return res;
        }
    }
}
