﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolodchikovEE.Sprint3.Task7.V27.Lib
{
    public class DataService : ISprint3Task7V27
    {
        public object[] GetMassFunction(int startValue, int stopValue)
        {
            object[] result;
            int len = (stopValue - startValue) + 1;
            result = new object[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++) 
            {
                y = Math.Round( ( ((Math.Cos(x)/(x+1)) -((Math.Cos(x) *1.3) + (3*x)))), 2);
                result[count] = y;
                count++;
            }

            return result;

        } 
    }
}
