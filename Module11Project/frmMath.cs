using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module11Project
{
    public partial class frmMath : Form
    {
        BeginningMathClass myClass = new BeginningMathClass();

        public frmMath()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMath_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                btnExit.PerformClick();
            }
        }

        

        private void btnByte_Click(object sender, EventArgs e)
        {
            byte leftOp = 0;
            byte rightOp = 0;
            try
            {
                leftOp = byte.Parse(txtLeftOp.Text);
                rightOp = byte.Parse(txtRightOp.Text);
            }
            catch (OverflowException)
            {
                lblMessage.Text = "Value is too large for data type";
            }
            

            if (validate(txtLeftOp) && validate(txtRightOp))
            {
                if (rBtnAdd.Checked == true)
                {
                    lblMessage.Text = myClass.addition(leftOp, rightOp);
                }
                else if (rBtnSubtract.Checked == true)
                {
                    lblMessage.Text = myClass.subtraction(leftOp, rightOp);
                }
                else if (rBtnMultiply.Checked == true)
                {
                    lblMessage.Text = myClass.multiply(leftOp, rightOp);
                }
                else if (rBtnDivision.Checked == true && isNegative(txtRightOp) && isZero(txtRightOp))
                {
                    lblMessage.Text = myClass.divide(leftOp, rightOp);
                }
                else if (rBtnModulus.Checked == true && isNegative(txtRightOp) && isZero(txtRightOp))
                {
                    lblMessage.Text = myClass.modulus(leftOp, rightOp);
                }
            }
        }
   

        private void btnLong_Click(object sender, EventArgs e)
        {
            long leftOp = 0;
            long rightOp = 0;
            try
            {
                leftOp = long.Parse(txtLeftOp.Text);
                rightOp = long.Parse(txtRightOp.Text);
            }
            catch (OverflowException)
            {
                lblMessage.Text = "Value is too large for data type";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message + ex.GetType().ToString();
            }

            if (validate(txtLeftOp) && validate(txtRightOp))
            {
                if (rBtnAdd.Checked == true)
                {
                    lblMessage.Text = myClass.addition(leftOp, rightOp);
                }
                else if (rBtnSubtract.Checked == true)
                {
                    lblMessage.Text = myClass.subtraction(leftOp, rightOp);
                }
                else if (rBtnMultiply.Checked == true)
                {
                    lblMessage.Text = myClass.multiply(leftOp, rightOp);
                }
                else if (rBtnDivision.Checked == true && isNegative(txtRightOp) && isZero(txtRightOp))
                {
                    lblMessage.Text = myClass.divide(leftOp, rightOp);
                }
                else if (rBtnModulus.Checked == true && isNegative(txtRightOp) && isZero(txtRightOp))
                {
                    lblMessage.Text = myClass.modulus(leftOp, rightOp);
                }
            }
        }

        private bool validate(TextBox textBox)
        {
            return
                ifBlank(textBox) &&
                isNumber(textBox);
        }
        private bool ifBlank(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                lblMessage.Text = "Operand box blank, please enter value(s)";
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool isZero(TextBox textBox)
        {
            if(textBox.Text == "0")
            {
                lblMessage.Text = "Operation can not be performed with a 0";
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool isNegative(TextBox textBox)
        {
            float testNum = float.Parse(textBox.Text);
            if (testNum < 0)
            {
                lblMessage.Text = "Operation can not be performed with a negative value";
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool isNumber(TextBox textBox)
        {
            string s = textBox.Text;
            byte bNum = 0;
            int iNum = 0;
            short sNum = 0;
            long lNum = 0;
            float fNum = 0.0f;
            double doNum = 0.0;
            decimal deNum = 0.0m;
            if (int.TryParse(s, out iNum) || short.TryParse(s, out sNum) || byte.TryParse(s, out bNum) || long.TryParse(s, out lNum) || float.TryParse(s, out fNum) || 
                double.TryParse(s, out doNum) || decimal.TryParse(s, out deNum))
            {
                return true;
            }
            else
            {
                lblMessage.Text = "Please enter a numeric value";
                return false;
            }
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            int leftOp = 0;
            int rightOp = 0;
            try
            {
                leftOp = int.Parse(txtLeftOp.Text);
                rightOp = int.Parse(txtRightOp.Text);
            }
            catch (OverflowException)
            {
                lblMessage.Text = "Value is too large for data type";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message + ex.GetType().ToString();
            }

            if (validate(txtLeftOp) && validate(txtRightOp))
            {
                if (rBtnAdd.Checked == true)
                {
                    lblMessage.Text = myClass.addition(leftOp, rightOp);
                }
                else if (rBtnSubtract.Checked == true)
                {
                    lblMessage.Text = myClass.subtraction(leftOp, rightOp);
                }
                else if (rBtnMultiply.Checked == true)
                {
                    lblMessage.Text = myClass.multiply(leftOp, rightOp);
                }
                else if (rBtnDivision.Checked == true && isNegative(txtRightOp) && isZero(txtRightOp))
                {
                    lblMessage.Text = myClass.divide(leftOp, rightOp);
                }
                else if (rBtnModulus.Checked == true && isNegative(txtRightOp) && isZero(txtRightOp))
                {
                    lblMessage.Text = myClass.modulus(leftOp, rightOp);
                }
            }
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            short leftOp = 0;
            short rightOp = 0;
            try
            {
                leftOp = short.Parse(txtLeftOp.Text);
                rightOp = short.Parse(txtRightOp.Text);
            }
            catch (OverflowException)
            {
                lblMessage.Text = "Value is too large for data type";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message + ex.GetType().ToString();
            }

            if (validate(txtLeftOp) && validate(txtRightOp))
            {
                if (rBtnAdd.Checked == true)
                {
                    lblMessage.Text = myClass.addition(leftOp, rightOp);
                }
                else if (rBtnSubtract.Checked == true)
                {
                    lblMessage.Text = myClass.subtraction(leftOp, rightOp);
                }
                else if (rBtnMultiply.Checked == true)
                {
                    lblMessage.Text = myClass.multiply(leftOp, rightOp);
                }
                else if (rBtnDivision.Checked == true && isNegative(txtRightOp) && isZero(txtRightOp))
                {
                    lblMessage.Text = myClass.divide(leftOp, rightOp);
                }
                else if (rBtnModulus.Checked == true && isNegative(txtRightOp) && isZero(txtRightOp))
                {
                    lblMessage.Text = myClass.modulus(leftOp, rightOp);
                }
            }
        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            float leftOp = 0.0f;
            float rightOp = 0.0f;
            try
            {
                leftOp = float.Parse(txtLeftOp.Text);
                rightOp = float.Parse(txtRightOp.Text);
            }
            catch (OverflowException)
            {
                lblMessage.Text = "Value is too large for data type";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message + ex.GetType().ToString();
            }

            if (validate(txtLeftOp) && validate(txtRightOp))
            {
                if (rBtnAdd.Checked == true)
                {
                    lblMessage.Text = myClass.addition(leftOp, rightOp);
                }
                else if (rBtnSubtract.Checked == true)
                {
                    lblMessage.Text = myClass.subtraction(leftOp, rightOp);
                }
                else if (rBtnMultiply.Checked == true)
                {
                    lblMessage.Text = myClass.multiply(leftOp, rightOp);
                }
                else if (rBtnDivision.Checked == true && isNegative(txtRightOp) && isZero(txtRightOp))
                {
                    lblMessage.Text = myClass.divide(leftOp, rightOp);
                }
                else if (rBtnModulus.Checked == true && isNegative(txtRightOp) && isZero(txtRightOp))
                {
                    lblMessage.Text = myClass.modulus(leftOp, rightOp);
                }
            }
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double leftOp = 0.0d;
            double rightOp = 0.0d;
            try
            {
                leftOp = double.Parse(txtLeftOp.Text);
                rightOp = double.Parse(txtRightOp.Text);
            }
            catch (OverflowException)
            {
                lblMessage.Text = "Value is too large for data type";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message + ex.GetType().ToString();
            }

            if (validate(txtLeftOp) && validate(txtRightOp))
            {
                if (rBtnAdd.Checked == true)
                {
                    lblMessage.Text = myClass.addition(leftOp, rightOp);
                }
                else if (rBtnSubtract.Checked == true)
                {
                    lblMessage.Text = myClass.subtraction(leftOp, rightOp);
                }
                else if (rBtnMultiply.Checked == true)
                {
                    lblMessage.Text = myClass.multiply(leftOp, rightOp);
                }
                else if (rBtnDivision.Checked == true && isNegative(txtRightOp) && isZero(txtRightOp))
                {
                    lblMessage.Text = myClass.divide(leftOp, rightOp);
                }
                else if (rBtnModulus.Checked == true && isNegative(txtRightOp) && isZero(txtRightOp))
                {
                    lblMessage.Text = myClass.modulus(leftOp, rightOp);
                }
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            decimal leftOp = 0.0m;
            decimal rightOp = 0.0m;
            try
            {
                leftOp = decimal.Parse(txtLeftOp.Text);
                rightOp = decimal.Parse(txtRightOp.Text);
            }
            catch (OverflowException)
            {
                lblMessage.Text = "Value is too large for data type";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message + ex.GetType().ToString();
            }

            if (validate(txtLeftOp) && validate(txtRightOp))
            {
                if (rBtnAdd.Checked == true)
                {
                    lblMessage.Text = myClass.addition(leftOp, rightOp);
                }
                else if (rBtnSubtract.Checked == true)
                {
                    lblMessage.Text = myClass.subtraction(leftOp, rightOp);
                }
                else if (rBtnMultiply.Checked == true)
                {
                    lblMessage.Text = myClass.multiply(leftOp, rightOp);
                }
                else if (rBtnDivision.Checked == true && isNegative(txtRightOp) && isZero(txtRightOp))
                {
                    lblMessage.Text = myClass.divide(leftOp, rightOp);
                }
                else if (rBtnModulus.Checked == true && isNegative(txtRightOp) && isZero(txtRightOp))
                {
                    lblMessage.Text = myClass.modulus(leftOp, rightOp);
                }
            }
        }
    }
}
