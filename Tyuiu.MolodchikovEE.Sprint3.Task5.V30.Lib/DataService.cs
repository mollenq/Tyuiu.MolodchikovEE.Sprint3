﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolodchikovEE.Sprint3.Task5.V30.Lib
{
    public class DataService : ISprint3Task5V30
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double result = 0;
            int i, j;

            for (i = startValue1; i <= stopValue1; i++) 
            {
                for (j = startValue2; j <= stopValue2; j++) 
                {
                    result = result + ((Math.Pow(x, 3) - j) + x);
                }
            
            }

            return result;
        }
    }
}
