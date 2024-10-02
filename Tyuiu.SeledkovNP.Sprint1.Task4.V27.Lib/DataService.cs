using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SeledkovNP.Sprint1.Task4.V27.Lib
{
    public class DataService : ISprint1Task4V27
    {
        public double Calculate(double x, double y)
        {
            var res = (1 + Math.Sin(x * Math.PI)) / (x - Math.Sqrt(Math.Abs(y)));
            res = Math.Round(res, 3);
            return res;



        }
    }
}
