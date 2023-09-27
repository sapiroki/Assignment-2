using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Metadata;
using System.Windows.Forms;
using System;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int classA = int.Parse(txtClassA.Text);
                int classB = int.Parse(txtClassB.Text);
                int classC = int.Parse(txtClassC.Text);

                double incomeA = classA * 15.0;
                double incomeB = classB * 12.0;
                double incomeC = classC * 9.0;

                lblIncomeA.Text = $"{incomeA.ToString("F2")} $";
                lblIncomeB.Text = $"{incomeB.ToString("F2")} $";
                lblIncomeC.Text = $"{incomeC.ToString("F2")} $";

                lblIncomeA.Visible = true;
                lblIncomeB.Visible = true;
                lblIncomeC.Visible = true;

                double totalRevenue = incomeA + incomeB + incomeC;

                lblTotalRevenue.Text = $"{totalRevenue.ToString("F2")} $";

                lblTotalRevenue.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for ticket quantities.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClassA.Text = "";
            txtClassB.Text = "";
            txtClassC.Text = "";

            lblIncomeA.Text = "";
            lblIncomeB.Text = "";
            lblIncomeC.Text = "";
            lblTotalRevenue.Text = "";

            lblIncomeA.Visible = false;
            lblIncomeB.Visible = false;
            lblIncomeC.Visible = false;
        }
    }
}