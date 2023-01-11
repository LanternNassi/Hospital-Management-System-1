using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hospital_Management_System.Screens;
using Hospital_Management_System.Screens.Pharmaceutical_Management;

namespace Hospital_Management_System.Screens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dealersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDealers form = new frmDealers();
            form.Show();
        }

        private void manageCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory form = new frmCategory();
            form.Show();
        }

        private void addTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchasesAndSales form = new frmPurchasesAndSales("Sales");
            form.Show();
        }

        private void purchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchasesAndSales form = new frmPurchasesAndSales("Purchase");
            form.Show();
        }

        private void viewTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransactions form = new frmTransactions();
            form.Show();
        }

        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory form = new Inventory();
            form.Show();
        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWorker form = new frmWorker("Doctors");
            form.Show();

        }

        private void pharmaceuticalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWorker form = new frmWorker("Nurses");
            form.Show();
        }

        private void nonmedicalStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWorker form = new frmWorker("Non Medical Staff");
            form.Show();
        }
    }
}
