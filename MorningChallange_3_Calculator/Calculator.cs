using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningChallange_3_Calculator
{
    public class Calculator
    {
       
        //Addition +
        public double Addition(double firstNum, double secondNum)
        {
            double sum = firstNum + secondNum;
            return sum;
        }
        //Subtract -
        public double Subtraction(double firstNum, double secondNum)
        {
            double difference = firstNum - secondNum;
            return difference;
        }
        //Multiply
        public double Multiply(double firstNum, double secondNum)
        {
            double multiply = firstNum * secondNum;
            return multiply;
        }
        //Division -
        public double Division(double firstNum, double secondNum)
        {
            double divide = firstNum / secondNum;
            return divide;
        }
    }
}
