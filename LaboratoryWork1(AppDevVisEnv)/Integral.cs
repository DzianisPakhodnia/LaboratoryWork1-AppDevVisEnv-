
using static System.Math;

namespace LaboratoryWork1_AppDevVisEnv_
{
    public class Integral
    {
        private double x1 { set; get; }
        private double x2 { set; get; }
        private double h { set; get; }
        
        private double area { set; get; }

        
        public Integral(double x1, double x2, double h)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.h = h;
        }

        public Integral()
        {
            x1 = 1.0;
            x2 = 2.0;
            h = 0.05;
        }


        public static double mathFunction(double x)
        {
            return Sin(x) / Sqrt(x);
        }

        public double leftRectangleMethod ()
        {
            area = 0;
            for (double x = x1; x <= x2; x += h)
            {
                double y = mathFunction(x);
                area += y * h;
            }
            return area;
            
        }

        public double rightRectangleMethod()
        {
            area = 0;
            for (double x = x1; x <= x2; x += h)
            {
                double y = mathFunction(x + h);
                area += y * h;
            }
            return area;
        }

        public double middleRectangleMethod()
        {
            area = 0;
            for (double x = x1; x <= x2; x += h)
            {
                double y = mathFunction(x + h / 2);
                area += y * h;
            }
            return area;
        }

        public double TrapezoidMethod()
        {
            area = 0;
            for (double x = x1; x <= x2; x += h)
            {
                area += h * (mathFunction(x) + mathFunction(x + h)) / 2;
            }
            return area;
        }
    }
}
