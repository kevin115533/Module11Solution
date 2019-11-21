using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11Project
{
    class BeginningMathClass
    {
        public string addition(long leftOp, long rightOp)
        {
            long answer = leftOp + rightOp;
            string result = Convert.ToString(leftOp) + " + " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string addition(double leftOp, double rightOp)
        {
            double answer = leftOp + rightOp;
            string result = Convert.ToString(leftOp) + " + " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string addition(int leftOp, int rightOp)
        {
            int answer = leftOp + rightOp;
            string result = Convert.ToString(leftOp) + " + " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string addition(short leftOp, short rightOp)
        {
            short answer = (short)(leftOp + rightOp);
            string result = Convert.ToString(leftOp) + " + " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string addition(decimal leftOp, decimal rightOp)
        {
            decimal answer = leftOp + rightOp;
            string result = Convert.ToString(leftOp) + " + " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string addition(float leftOp, float rightOp)
        {
            float answer = leftOp + rightOp;
            string result = Convert.ToString(leftOp) + " + " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string addition(byte leftOp, byte rightOp)
        {
            byte answer = (byte)(leftOp + rightOp);
            string result = Convert.ToString(leftOp) + " + " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string subtraction(byte leftOp, byte rightOp)
        {
            byte answer = (byte)(leftOp - rightOp);
            string result = Convert.ToString(leftOp) + " - " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string subtraction(int leftOp, int rightOp)
        {
            int answer = leftOp - rightOp;
            string result = Convert.ToString(leftOp) + " - " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string subtraction(short leftOp, short rightOp)
        {
            short answer = (short)(leftOp - rightOp);
            string result = Convert.ToString(leftOp) + " - " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string subtraction(long leftOp, long rightOp)
        {
            long answer = leftOp - rightOp;
            string result = Convert.ToString(leftOp) + " - " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string subtraction(float leftOp, float rightOp)
        {
            float answer = leftOp - rightOp;
            string result = Convert.ToString(leftOp) + " - " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string subtraction(double leftOp, double rightOp)
        {
            double answer = leftOp - rightOp;
            string result = Convert.ToString(leftOp) + " - " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string subtraction(decimal leftOp, decimal rightOp)
        {
            decimal answer = leftOp - rightOp;
            string result = Convert.ToString(leftOp) + " - " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string multiply(byte leftOp, byte rightOp)
        {
            byte answer = (byte)(leftOp * rightOp);
            string result = Convert.ToString(leftOp) + " * " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string multiply(int leftOp, int rightOp)
        {
            int answer = leftOp * rightOp;
            string result = Convert.ToString(leftOp) + " * " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string multiply(short leftOp, short rightOp)
        {
            short answer = (short)(leftOp * rightOp);
            string result = Convert.ToString(leftOp) + " * " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string multiply(long leftOp, long rightOp)
        {
            long answer = leftOp * rightOp;
            string result = Convert.ToString(leftOp) + " * " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string multiply(float leftOp, float rightOp)
        {
            float answer = leftOp * rightOp;
            string result = Convert.ToString(leftOp) + " * " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string multiply(double leftOp, double rightOp)
        {
            double answer = leftOp * rightOp;
            string result = Convert.ToString(leftOp) + " * " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string multiply(decimal leftOp, decimal rightOp)
        {
            decimal answer = leftOp * rightOp;
            string result = Convert.ToString(leftOp) + " * " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string divide(byte leftOp, byte rightOp)
        {
            byte answer = (byte)(leftOp / rightOp);
            string result = Convert.ToString(leftOp) + " / " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }
        public string divide(int leftOp, int rightOp)
        {
            int answer = leftOp / rightOp;
            string result = Convert.ToString(leftOp) + " / " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }
        public string divide(short leftOp, short rightOp)
        {
            short answer = (short)(leftOp / rightOp);
            string result = Convert.ToString(leftOp) + " / " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string divide(long leftOp, long rightOp)
        {
            long answer = leftOp / rightOp;
            string result = Convert.ToString(leftOp) + " / " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string divide(float leftOp, float rightOp)
        {
            float answer = leftOp / rightOp;
            string result = Convert.ToString(leftOp) + " / " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }
        public string divide(double leftOp, double rightOp)
        {
            double answer = leftOp / rightOp;
            string result = Convert.ToString(leftOp) + " / " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }
        public string divide(decimal leftOp, decimal rightOp)
        {
            decimal answer = leftOp / rightOp;
            string result = Convert.ToString(leftOp) + " / " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string modulus(byte leftOp, byte rightOp)
        {
            byte answer = (byte)(leftOp % rightOp);
            string result = Convert.ToString(leftOp) + " % " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string modulus(int leftOp, int rightOp)
        {
            int answer = leftOp % rightOp;
            string result = Convert.ToString(leftOp) + " % " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string modulus(short leftOp, short rightOp)
        {
            short answer = (short)(leftOp % rightOp);
            string result = Convert.ToString(leftOp) + " % " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string modulus(long leftOp, long rightOp)
        {
            long answer = leftOp % rightOp;
            string result = Convert.ToString(leftOp) + " % " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string modulus(float leftOp, float rightOp)
        {
            float answer = leftOp % rightOp;
            string result = Convert.ToString(leftOp) + " % " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string modulus(double leftOp, double rightOp)
        {
            double answer = leftOp % rightOp;
            string result = Convert.ToString(leftOp) + " % " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }

        public string modulus(decimal leftOp, decimal rightOp)
        {
            decimal answer = leftOp % rightOp;
            string result = Convert.ToString(leftOp) + " % " + Convert.ToString(rightOp) + " = " + Convert.ToString(answer);
            return result;
        }
    }
}
