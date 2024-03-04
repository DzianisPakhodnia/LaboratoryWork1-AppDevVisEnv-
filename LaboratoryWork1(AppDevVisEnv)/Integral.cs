using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Math;

namespace LaboratoryWork1_AppDevVisEnv_
{
    public static class Integral
    { 

        public static double mathFunction(double x)
        {
            return Sin(x) / Sqrt(x);
        }


        public static double leftRectangleMethod (ref Chart chart1, double x1, double x2, double h, double area)
        {
            for (double x = x1; x <= x2; x += h)
            {
                double y = mathFunction(x);
                chart1.Series[1].Points.AddXY(x, y);
                chart1.Series[0].Points.AddXY(x, y);
                if (x + h <= x2)
                {
                    chart1.Series[0].Points.AddXY(x + h, y);
                }

                area += y * h;

            }
            return area;
            
        }

        public static double rightRectangleMethod(ref Chart chart1, double x1, double x2, double h, double area)
        {
            for (double x = x1; x <= x2; x += h)
            {
                double y = mathFunction(x + h);

                chart1.Series[0].Points.AddXY(x, y);
                chart1.Series[1].Points.AddXY(x, mathFunction(x));
                if (x + h <= x2)
                {
                    chart1.Series[0].Points.AddXY(x + h, y);
                }

                area += y * h;

            }
            return area;
        }

        public static double middleRectangleMethod(ref Chart chart1, double x1, double x2, double h, double area)
        {
            for (double x = x1; x <= x2; x += h)
            {
                double y = mathFunction(x + h / 2);

                chart1.Series[0].Points.AddXY(x, y);
                chart1.Series[1].Points.AddXY(x, mathFunction(x));

                if (x + h <= x2)

                {
                    chart1.Series[0].Points.AddXY(x + h, y);
                }

                area += y * h;

            }
            return area;
        }

        public static double TrapezoidMethod(ref Chart chart1,double x1,double x2,double h,double area)
        {
            for (double x = x1; x <= x2; x += h)
            {
                double y = mathFunction(x);
                chart1.Series[1].Points.AddXY(x, y);
                chart1.Series[0].Points.AddXY(x, y);
                area += h * (mathFunction(x) + mathFunction(x + h)) / 2;
            }
            return area;
        }
    }
}
