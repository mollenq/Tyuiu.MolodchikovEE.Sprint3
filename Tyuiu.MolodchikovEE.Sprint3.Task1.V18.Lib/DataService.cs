using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolodchikovEE.Sprint3.Task1.V18.Lib
{
    public class DataService : ISprint3Task1V18
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double S = 0;

            while (startValue <= stopValue) 
            {
                S = S + ((Math.Sin(startValue) * (Math.Pow((1.0 / 4), 2))));

                startValue++;

            } 
            return Math.Round(S,3);
        }
    }
}
