﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MedvedevDP.Sprint1.Task6.V1.Lib
{
    public class DataService : ISprint1Task6V1
    {
        public string SymbolCode(string value)
        {
            char c = value[0];
            int code = c;

            return code;
        }
    }
}
