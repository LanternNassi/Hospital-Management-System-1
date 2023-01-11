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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }
        protected void Clear()
        {
            workers_id_txtbx.Text = " ";
            workers_category_txtbx.Text = " ";
            workers_info_txtbx.Text = " ";
        }

        protected void Patients_clear()
        {
            patients_id_txtbx.Text = " ";
            patients_category_txtbx.Text = " ";
            patients_info_txtbx.Text = " ";
        }
        protected void drugs_clear()
        {
            drugs_id_txtbx.Text = " ";
            drugs_category_txtbx.Text = " ";
            drugs_info_txtbx.Text = " ";
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            Categories_DAL category = new Categories_DAL();
            Patients_dgv.DataSource = category.Fill("Patients");
            workers_dgv.DataSource = category.Fill("Workers");
            Drugs_dgv.DataSource = category.Fill("Drugs");
            Transactions_dgv.DataSource = category.Fill("Transactions");

            
        }

        private void workers_add_btn_Click(object sender, EventArgs e)
        {
            Categories_DAL category = new Categories_DAL();
            category.type = "Workers";
            category.category = workers_category_txtbx.Text;
            category.information = workers_info_txtbx.Text;
            category.added_by = "Nassim";
            bool succeed = category.Insert();
            if (succeed)
            {
                MessageBox.Show("Worker successfully added");
            }
            else
            {
                MessageBox.Show("Problem encountered ");
            }
            workers_dgv.DataSource = category.Fill("Workers");
            Clear();
        }

        private void workers_dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rows = e.RowIndex;
            workers_id_txtbx.Text = workers_dgv[0, rows].Value.ToString();
            workers_category_txtbx.Text = workers_dgv[1, rows].Value.ToString();
            workers_info_txtbx.Text = workers_dgv[5, rows].Value.ToString();
        }

        private void workers_update_btn_Click(object sender, EventArgs e)
        {
            Categories_DAL category = new Categories_DAL();
            category.id = int.Parse(workers_id_txtbx.Text);
            category.category = workers_category_txtbx.Text;
            category.information = workers_info_txtbx.Text;
            bool success = category.Update(category.id);
            if (success)
            {
                MessageBox.Show("Worker successfully updated");
            }
            else
            {
                MessageBox.Show("A problem was encountered");
            }
            workers_dgv.DataSource = category.Fill("Workers");
            Clear();
        }

        private void workers_delete_btn_Click(object sender, EventArgs e)
        {
            Categories_DAL category = new Categories_DAL();
            category.id = int.Parse(workers_id_txtbx.Text);
            bool success = category.Delete(category.id);
            if (success)
            {
                MessageBox.Show("Worker deleted successfully");

            }
            else
            {
                MessageBox.Show("Problem encountered");

            }
            Clear();
            workers_dgv.DataSource = category.Fill("Workers");

        }

        private void workers_search_txtbx_TextChanged(object sender, EventArgs e)
        {
            Categories_DAL category = new Categories_DAL();
            if (workers_search_txtbx.Text != "")
            {
                workers_dgv.DataSource = category.Search(workers_search_txtbx.Text);

            }
            else
            {
                workers_dgv.DataSource = category.Fill("Workers");
            }
            
        }

        private void patients_add_btn_Click(object sender, EventArgs e)
        {
            Categories_DAL category = new Categories_DAL();
            category.type = "Patients";
            category.category = patients_category_txtbx.Text;
            category.information = patients_info_txtbx.Text;
            category.added_by = "Nassim";
            bool success = category.Insert();
            if (success)
            {
                MessageBox.Show("Patient category successfully added");

            }
            else
            {
                MessageBox.Show("An error occurred");
            }
            Patients_clear();
            Patients_dgv.DataSource = category.Fill("Patients");
        }

        private void Patients_dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            patients_id_txtbx.Text = Patients_dgv[0, row].Value.ToString();
            patients_category_txtbx.Text = Patients_dgv[1, row].Value.ToString();
            patients_info_txtbx.Text = Patients_dgv[5, row].Value.ToString();
        }

        private void patients_update_btn_Click(object sender, EventArgs e)
        {
            Categories_DAL category = new Categories_DAL();
            category.category = patients_category_txtbx.Text;
            category.information = patients_info_txtbx.Text;
            bool success = category.Update(int.Parse(patients_id_txtbx.Text));
            if (success)
            {
                MessageBox.Show("Patient category successfully updated");

            }
            else
            {
                MessageBox.Show("Failed to update patient category");
            }
            Patients_clear();
            Patients_dgv.DataSource = category.Fill("Patients");
        }

        private void patients_delete_btn_Click(object sender, EventArgs e)
        {
            Categories_DAL category = new Categories_DAL();
            category.id = int.Parse(patients_id_txtbx.Text);
            bool success = category.Delete(category.id);
            if (success)
            {
                MessageBox.Show("Patient category successfully deleted");
            }
            else
            {
                MessageBox.Show("Failed to delete patient category ");
            }
            Patients_clear();
            Patients_dgv.DataSource = category.Fill("Patients");
            
        }

        private void patients_search_txtbx_TextChanged(object sender, EventArgs e)
        {
            Categories_DAL category = new Categories_DAL();
            if (patients_search_txtbx.Text != "")
            {
                Patients_dgv.DataSource = category.Search(patients_search_txtbx.Text);
            }
            else
            {
                Patients_dgv.DataSource = category.Fill("Patients");
            }
            
        }

        private void drugs_add_btn_Click(object sender, EventArgs e)
        {
            Categories_DAL category = new Categories_DAL();
            category.type = "Drugs";
            category.category = drugs_category_txtbx.Text;
            category.information = drugs_info_txtbx.Text;
            category.added_by = "Nassim";
            bool success = category.Insert();
            if (success)
            {
                MessageBox.Show("Drug category successfully added");

            }
            else
            {
                MessageBox.Show("Failed to add drugs category");
            }
            drugs_clear();
            Drugs_dgv.DataSource = category.Fill("Drugs");

        }

        private void drugs_update_btn_Click(object sender, EventArgs e)
        {
            Categories_DAL category = new Categories_DAL();
            category.id = int.Parse(drugs_id_txtbx.Text);
            category.category = drugs_category_txtbx.Text;
            category.information = drugs_info_txtbx.Text;
            bool success = category.Update(category.id);
            if (success)
            {
                MessageBox.Show("Drug category successfully updated");
            }
            else
            {
                MessageBox.Show("Failed to update drug category");

            }
            drugs_clear();
            Drugs_dgv.DataSource = category.Fill("Drugs");

        }

        private void drugs_delete_btn_Click(object sender, EventArgs e)
        {
            Categories_DAL category = new Categories_DAL();
            category.id = int.Parse(drugs_id_txtbx.Text);
            bool success = category.Delete(category.id);
            if (success)
            {
                MessageBox.Show("drug category successfully deleted");
            }
            else
            {
                MessageBox.Show("Failed to delete drug category");
            }
            drugs_clear();
            Drugs_dgv.DataSource = category.Fill("Drugs");
        }

        private void Drugs_dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            drugs_id_txtbx.Text = Drugs_dgv[0, row].Value.ToString();
            drugs_category_txtbx.Text = Drugs_dgv[1, row].Value.ToString();
            drugs_info_txtbx.Text = Drugs_dgv[5, row].Value.ToString();
        }

        private void drugs_search_txtbx_TextChanged(object sender, EventArgs e)
        {
            Categories_DAL category = new Categories_DAL();
            if (drugs_search_txtbx.Text != "")
            {
                Drugs_dgv.DataSource = category.Search(drugs_search_txtbx.Text);

            }
            else
            {
                Drugs_dgv.DataSource = category.Fill("Drugs");
            }
        }
    }
}
