using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_9000
{
    public partial class frmCalculator : Form
    {
        //Project: Calculator - C01
        //Programmer: Brendan Bohlin
        //Date: 1/27/2019
        //Description: Simple calculator program

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string txtOp1String = txtOp1.Text;
            string txtOp2String = txtOp2.Text;

            decimal op1 = decimal.Parse(txtOp1String);
            decimal op2 = decimal.Parse(txtOp2String);

            decimal result = Math.Round(op1 + op2, 3, MidpointRounding.AwayFromZero);
            string resultString = result.ToString();
            txtResult.Text = resultString;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            string txtOp1String = txtOp1.Text;
            string txtOp2String = txtOp2.Text;

            decimal op1 = decimal.Parse(txtOp1String);
            decimal op2 = decimal.Parse(txtOp2String);

            decimal result = Math.Round(op1 - op2, 3, MidpointRounding.AwayFromZero);
            string resultString = result.ToString();
            txtResult.Text = resultString;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            string txtOp1String = txtOp1.Text;
            string txtOp2String = txtOp2.Text;

            decimal op1 = decimal.Parse(txtOp1String);
            decimal op2 = decimal.Parse(txtOp2String);
       
            decimal result = Math.Round(op1 * op2, 3, MidpointRounding.AwayFromZero);
            string resultString = result.ToString();
            txtResult.Text = resultString;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            string txtOp1String = txtOp1.Text;
            string txtOp2String = txtOp2.Text;

            decimal op1 = decimal.Parse(txtOp1String);
            decimal op2 = decimal.Parse(txtOp2String);

            decimal result = Math.Round(op1 / op2 , 3, MidpointRounding.AwayFromZero);
            string resultString = result.ToString();
            txtResult.Text = resultString;

        }
    }
}
