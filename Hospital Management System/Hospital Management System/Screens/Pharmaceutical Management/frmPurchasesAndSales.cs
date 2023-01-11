using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Management_System.Screens.Pharmaceutical_Management
{
    public partial class frmPurchasesAndSales : Form
    {
        public frmPurchasesAndSales(string type)
        {

            InitializeComponent();
            lbl_top.Text = type;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmPurchasesAndSales_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
