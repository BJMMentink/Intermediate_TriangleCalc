using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJM.TriangleCalc.UI
{
    public class AreaCalc
    {
        public double dblBase { get; set; }
        public double dblHeight { get; set; }

        public double AreaTotal 
        {
            get { return (dblBase * dblHeight) / 2; }
        }
        public double Perimeter()
        {
            double hyp = Math.Sqrt((dblBase * dblBase) + (dblHeight * dblHeight));
            return hyp + dblBase + dblHeight;
        }
    }
}
