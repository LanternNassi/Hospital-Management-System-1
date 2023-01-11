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
    public partial class frmWorker : Form
    {
        public frmWorker(String type)
        {

            InitializeComponent();
            genre.Text = type;
        }
        private void clean_up()
        {
            id.Text = " ";
            name.Text = "";
            residence.Text = "";
            type.Text = "";
            age.Text = "";
            contact.Text = "";
            email.Text = "";
            address.Text = "";

        }

        private void frmWorker_Load(object sender, EventArgs e)
        {
            Workers worker = new Workers();
            DataTable dt = worker.Select();
            workers_dgv.DataSource = dt;
            this.reportViewer1.RefreshReport();
        }

        private void workers_add_Click(object sender, EventArgs e)
        {
            Workers worker = new Workers();
            worker.Name = name.Text;
            worker.Residence = residence.Text;
            worker.Type = genre.Text;
            worker.Age = int.Parse(age.Text);
            worker.Classification = "full time";
            worker.Contact = contact.Text;
            worker.Email = email.Text;
            worker.Address = address.Text;
            bool isSuccess = worker.Insert();
            if (isSuccess)
            {
                MessageBox.Show(worker.Name + " added successfully.");
                workers_dgv.DataSource = worker.Select();
            }
            else
            {
                MessageBox.Show("User addition not successful");

            }
            clean_up();

            
        }

        private void workers_update_btn_Click(object sender, EventArgs e)
        {
            Workers worker = new Workers();
            
                worker.Id = int.Parse(id.Text);
                worker.Name = name.Text;
                worker.Residence = residence.Text;
                worker.Type = genre.Text;
                worker.Age = int.Parse(age.Text);
                worker.Classification = "full time";
                worker.Contact = contact.Text;
                worker.Email = email.Text;
                worker.Address = address.Text;

            
            bool isSuccess = worker.Update(int.Parse(id.Text));
                if (isSuccess)
                {
                    MessageBox.Show("Update successful");
                    workers_dgv.DataSource = worker.Select();
                }else {
                    MessageBox.Show("Update not successful");
                }
                clean_up();

        }

        private void workers_delete_btn_Click(object sender, EventArgs e)
        {
            Workers worker = new Workers();
            
            worker.Id = int.Parse(id.Text);
            
            bool isSuccess = worker.delete(int.Parse(id.Text));
            if (isSuccess)
            {
                MessageBox.Show("Worker successfully deleted");
                workers_dgv.DataSource = worker.Select();

            }
            else
            {
                MessageBox.Show("Deletion not successful");
            }
            clean_up();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void workers_dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;

            id.Text = workers_dgv[0,row].Value.ToString()  ;
            name.Text = workers_dgv[2,row].Value.ToString();
            residence.Text = workers_dgv[4,row].Value.ToString() ;
            type.Text = workers_dgv[1,row].Value.ToString();
            age.Text = workers_dgv[3, row].Value.ToString();
            contact.Text = workers_dgv[7, row].Value.ToString() ;
            email.Text = workers_dgv[6, row].Value.ToString();
            address.Text = workers_dgv[8, row].Value.ToString();

        }
    }
}
