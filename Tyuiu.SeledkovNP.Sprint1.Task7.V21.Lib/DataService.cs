using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SeledkovNP.Sprint1.Task7.V21.Lib
{
    public class DataService : ISprint1Task7V21
    {
        public double Calculate(double x, double y)
        {

            //          x             2
            //         y         sin x  +   cos  y 
            //   z  = -------- + --------------------   * tg (x*y)
            //               x        
            //      cos x - ---    cos x  -  sin y
            //               3

            double z;
            double tra1 = (Math.Pow(y, x)) / (Math.Cos(x) - x / 3);
            double tra2 = (Math.Sin(x * x) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y));
            z = tra1 + (tra2 * Math.Tan(x * y));
            z = Math.Round(z, 3);
            return z;
        }
    }
}
