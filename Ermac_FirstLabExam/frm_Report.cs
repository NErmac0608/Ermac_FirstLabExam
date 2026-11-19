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
    public partial class frm_Report : Form
    {
        public frm_Report(double D, double E, double F)
        {
            InitializeComponent();

            lbl_Report.Text =
            "HOME SALES SUMMARY\n\n" +
            "Danielle Total Sales: " + D.ToString("C2") + "\n" +
            "Edward Total Sales: " + E.ToString("C2") + "\n" +
            "Fatima Total Sales: " + F.ToString("C2") + "\n\n" +
            "Total Sales: " + (D + E + F).ToString("C2");
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
