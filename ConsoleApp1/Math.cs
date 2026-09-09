using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Class207
{
    public class Math
    {
        public int sum(int num1, int num2)
        {
            return num1 + num2;

        }
        internal protected int sum(double num1, int num2)
        {
            return Convert.ToInt32(num1) + num2;

        }
        public int sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }
}