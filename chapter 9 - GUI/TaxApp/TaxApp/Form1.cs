﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string inValue;
            double purchaseAmt;
            while (double.TryParse(txtPurchase.Text, out purchaseAmt) == false)
            {
                MessageBox.Show("please enter a numeric value");
                txtPurchase.Text = "0.0";
                txtPurchase.Focus();
            }

            double percent;
            inValue = label5.Text;
            inValue = inValue.Remove(inValue.Length - 1, 1);
            percent = double.Parse(inValue) / 100;

            double ans;
            ans = (purchaseAmt * percent) + purchaseAmt;
            txtTotalDue.Text = string.Format("{0:C}", ans).ToString();
        }
    }
}
