using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ermac_FirstLabExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            double Danielle = 0;
            double Edward = 0;
            double Fatima = 0;
            
            private void getSalesPerson_Amount(String salesInitial, double salesAmount)
            {
                string salesPerson = "";

                if (salesInitial.ToUpper() == "D")
                {
                    Danielle += salesAmount;
                    salesPerson = "Danielle";
                }
                else if (salesInitial.ToUpper() == "E")
                {
                    Edward += salesAmount;
                    salesPerson = "Edward";
                }
                else if (salesInitial.ToUpper() == "F")
                {
                    Fatima += salesAmount;
                    salesPerson = "Fatima";
                }
                else
                {
                    lbl_Output.Text = "Invalid Salesperson Initial!";
                    return;
                }

                    lbl_Output.Text =
                    salesAmount.ToString("C2") +
                    " is successfully recorded under " + salesPerson + "!\n\n" +

                    "Running Sales Totals:\n" +
                    "Danielle: " + Danielle.ToString("C2") + "\n" +
                    "Edward: " + Edward.ToString("C2") + "\n" +
                    "Fatima: " + Fatima.ToString("C2");
        }
            private void clearEntry()
            {
                txtb_Initial.Clear();
                txtb_Amount.Clear();
                lbl_Output.Text = "";

                txtb_Initial.Focus();
            }
       
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string initial = txtb_Initial.Text.Trim();
            double amount;

            if (initial == "")
            {
                MessageBox.Show("Please enter salesperson initial.");
                return;
            }

            if (!double.TryParse(txtb_Amount.Text, out amount))
            {
                MessageBox.Show("Please enter a valid sale amount.");
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Sale amount must be greater than zero.");
                return;
            }

            if (initial.ToUpper() != "D" &&
                initial.ToUpper() != "E" &&
                initial.ToUpper() != "F")
            {
                MessageBox.Show("Invalid initial! Please enter D, E, or F.");
                return;
            }

            getSalesPerson_Amount(initial, amount);
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            frm_Report report = new frm_Report(Danielle, Edward, Fatima);
            report.ShowDialog();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }
    }
    }

    