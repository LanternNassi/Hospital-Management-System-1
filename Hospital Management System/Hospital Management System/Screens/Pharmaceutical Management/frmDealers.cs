using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hospital_Management_System.DAL;

namespace Hospital_Management_System.Screens.Pharmaceutical_Management
{
    public partial class frmDealers : Form
    {
        public frmDealers()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            suppliers_id_txtbx.Text = "";
            suppliers_name_txtbx.Text = "";
            suppliers_email_txtbx.Text = "";
            suppliers_address_txtbx.Text = "";
            suppliers_contact_txtbx.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDealers_Load(object sender, EventArgs e)
        {
            Suppliers_DAL suppliers = new Suppliers_DAL();
            suppliers_dgv.DataSource = suppliers.ShowAllSuppliers();

        }

        private void suppliers_add_Click(object sender, EventArgs e)
        {
            // Initialising the Dal for the logic to be carried out so as to add the supplier
            Suppliers_DAL suppliers = new Suppliers_DAL();

            // Assigning the properties with the fed in information from the user 
            suppliers.supplier = suppliers_name_txtbx.Text;
            suppliers.contact = suppliers_contact_txtbx.Text;
            suppliers.email = suppliers_email_txtbx.Text;
            suppliers.address = suppliers_address_txtbx.Text;
            suppliers.added_by = "Nassim";

            // Carrying out the addition 
            bool succeed = suppliers.Insert();

            if (succeed)
            {
                MessageBox.Show("Supplier added successfully");
            }
            else
            {
                MessageBox.Show("Supplier not added successfully");
            }
            Clear();
            suppliers_dgv.DataSource = suppliers.ShowAllSuppliers();

        }

        private void suppliers_dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            suppliers_id_txtbx.Text = suppliers_dgv[0, row].Value.ToString();
            suppliers_name_txtbx.Text = suppliers_dgv[1, row].Value.ToString();
            suppliers_contact_txtbx.Text = suppliers_dgv[2, row].Value.ToString();
            suppliers_email_txtbx.Text = suppliers_dgv[3, row].Value.ToString();
            suppliers_address_txtbx.Text = suppliers_dgv[4, row].Value.ToString();
            
        }

        private void suppliers_update_btn_Click(object sender, EventArgs e)
        {
            Suppliers_DAL suppliers = new Suppliers_DAL();
            suppliers.supplier = suppliers_name_txtbx.Text;
            suppliers.contact = suppliers_contact_txtbx.Text;
            suppliers.email = suppliers_email_txtbx.Text;
            suppliers.address = suppliers_address_txtbx.Text;
            suppliers.added_by = "Nassim";

            bool succeed = suppliers.Update(int.Parse(suppliers_id_txtbx.Text));

            if (succeed)
            {
                MessageBox.Show("Supplier successfully updated");
            }
            else
            {
                MessageBox.Show("Supplier not updated successfully");
            }
            Clear();
            suppliers_dgv.DataSource = suppliers.ShowAllSuppliers();
        }

        private void suppliers_delete_btn_Click(object sender, EventArgs e)
        {
            Suppliers_DAL suppliers = new Suppliers_DAL();
            int id_to_be_deleted = int.Parse(suppliers_id_txtbx.Text);
            bool succeed = suppliers.Delete(id_to_be_deleted);
            if (succeed)
            {
                MessageBox.Show("Supplier successfully deleted");
            }
            else
            {
                MessageBox.Show("Supplier not deleted successfully");
            }
            Clear();
            suppliers_dgv.DataSource = suppliers.ShowAllSuppliers();
        }

        private void suppliers_search_txtbx_TextChanged(object sender, EventArgs e)
        {
            Suppliers_DAL supplier = new Suppliers_DAL();
            DataTable dt = supplier.Search(suppliers_search_txtbx.Text);
            suppliers_dgv.DataSource = dt;
        }
    }
}
