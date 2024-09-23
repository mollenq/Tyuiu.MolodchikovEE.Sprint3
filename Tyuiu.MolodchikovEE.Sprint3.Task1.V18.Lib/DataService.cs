using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolodchikovEE.Sprint3.Task1.V18.Lib
{
    public class DataService : ISprint3Task1V18
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double res = 0;

            while (startValue <= stopValue) 
            {
                res = res + (Math.Sin(startValue) * (Math.Pow((1 / 4), 2)));

                startValue++;

            } return res;
        }
    }
}
