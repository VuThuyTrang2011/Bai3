using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTapTH.Models
{
    public class GiaiPTB1
    {
        public double GiaiPT(double HesoA, double HesoB)
        {
            double x;
               x = -HesoA / HesoB;
                return x;
            
        }
    }
}