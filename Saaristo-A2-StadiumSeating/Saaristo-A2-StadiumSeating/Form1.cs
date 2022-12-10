using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saaristo_A2_StadiumSeating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int A = 15;
            int B = 12;
            int C = 9;
            int boxSum1 = 0;
            int boxSum2 = 0;
            int boxSum3 = 0;
            try
            {
                boxSum1 = A * int.Parse(textBoxInput1.Text);
            }
            catch (Exception)
            {
                textBoxInput1.Text = ("Error: please enter an integer");
            }

            try
            {
                 boxSum2 = B * int.Parse(textBoxInput2.Text);
            }
            catch (Exception)
            {
                textBoxInput2.Text = ("Error: please enter an integer");
            }
            try
            {
                 boxSum3 = C * int.Parse(textBoxInput3.Text);
            }
            catch (Exception)
            {
                textBoxInput3.Text = ("Error: please enter an integer");
            }
            textBoxSum1.Text = boxSum1.ToString();
            textBoxSum2.Text = boxSum2.ToString();
            textBoxSum3.Text = boxSum3.ToString();

            int sumTotals = boxSum1 + boxSum2 + boxSum3;
            textBoxSumTotal.Text = sumTotals.ToString();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBoxInput1.Text = null;
            textBoxInput2.Text = null;
            textBoxInput3.Text = null;
            textBoxSum1.Text = null;
            textBoxSum2.Text = null;
            textBoxSum3.Text = null;
            textBoxSumTotal.Text = null;
        }
    }
}
