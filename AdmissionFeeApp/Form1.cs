using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AdmissionFeeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int>  admissionFeeList = new List<int>();
        List<int>  monthlyList = new List<int>();
        private void onLoad(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                selectClassComboBox.Items.Add(@"Class " + i);
            }
            admissionFeeList.Add(10000);
            admissionFeeList.Add(10000);
            admissionFeeList.Add(10000);
            admissionFeeList.Add(10000);
            admissionFeeList.Add(10000);
            admissionFeeList.Add(12000);
            admissionFeeList.Add(12000);
            admissionFeeList.Add(12000);
            admissionFeeList.Add(15000);
            admissionFeeList.Add(15000);
            admissionFeeList.Add(15000);
            admissionFeeList.Add(15000);

            monthlyList.Add(500);
            monthlyList.Add(500);
            monthlyList.Add(1000);
            monthlyList.Add(1000);
            monthlyList.Add(1000);
            monthlyList.Add(1500);
            monthlyList.Add(1500);
            monthlyList.Add(1500);
            monthlyList.Add(2000);
            monthlyList.Add(2000);
            monthlyList.Add(2700);
            monthlyList.Add(2700);
            
        }

        private void calculateBbutton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <=13; i++)
            {
                if (@"Class "+i == selectClassComboBox.Text)
                {
                    double totalAmount = admissionFeeList[i-1] + (monthlyList[i-1]*12);
                    if (discountCheckBox.Checked)
                    {
                        MessageBox.Show(Convert.ToString(totalAmount-totalAmount*.05));
                    }
                    else
                    {
                        MessageBox.Show(Convert.ToString(totalAmount));
                    }
                    
                }
                
            }
            
        }
    }
}
