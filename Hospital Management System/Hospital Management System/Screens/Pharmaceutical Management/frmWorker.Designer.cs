namespace Hospital_Management_System.Screens.Pharmaceutical_Management
{
    partial class frmWorker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.genre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.address = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.residence = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.workers_dgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.workers_delete_btn = new System.Windows.Forms.Button();
            this.workers_update_btn = new System.Windows.Forms.Button();
            this.workers_add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workers_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.genre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 50);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_Management_System.Properties.Resources._215904_200;
            this.pictureBox1.Location = new System.Drawing.Point(1040, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.Location = new System.Drawing.Point(467, 9);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(102, 25);
            this.genre.TabIndex = 0;
            this.genre.Text = "WORKERS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(3, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 456);
            this.panel2.TabIndex = 3;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(9, 20);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 433);
            this.reportViewer1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Preview";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.address);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.email);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.contact);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.residence);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.age);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.name);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.type);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.id);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(414, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 456);
            this.panel3.TabIndex = 4;
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(92, 402);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(175, 51);
            this.address.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(15, 409);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Address";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(92, 359);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(175, 27);
            this.email.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(15, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Email";
            // 
            // contact
            // 
            this.contact.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(92, 302);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(175, 27);
            this.contact.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(15, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Contact";
            // 
            // residence
            // 
            this.residence.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.residence.Location = new System.Drawing.Point(92, 251);
            this.residence.Name = "residence";
            this.residence.Size = new System.Drawing.Size(175, 27);
            this.residence.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Residence";
            // 
            // age
            // 
            this.age.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(92, 196);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(175, 27);
            this.age.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Age";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(92, 143);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(175, 27);
            this.name.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Name";
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(92, 85);
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Size = new System.Drawing.Size(175, 27);
            this.type.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Type";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(92, 29);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(175, 27);
            this.id.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Details";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.workers_dgv);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(701, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(405, 456);
            this.panel4.TabIndex = 4;
            // 
            // workers_dgv
            // 
            this.workers_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workers_dgv.Location = new System.Drawing.Point(6, 20);
            this.workers_dgv.Name = "workers_dgv";
            this.workers_dgv.Size = new System.Drawing.Size(396, 433);
            this.workers_dgv.TabIndex = 2;
            this.workers_dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.workers_dgv_RowHeaderMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Workers";
            // 
            // workers_delete_btn
            // 
            this.workers_delete_btn.BackColor = System.Drawing.Color.Red;
            this.workers_delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workers_delete_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workers_delete_btn.ForeColor = System.Drawing.Color.White;
            this.workers_delete_btn.Location = new System.Drawing.Point(661, 552);
            this.workers_delete_btn.Name = "workers_delete_btn";
            this.workers_delete_btn.Size = new System.Drawing.Size(115, 46);
            this.workers_delete_btn.TabIndex = 23;
            this.workers_delete_btn.Text = "DELETE";
            this.workers_delete_btn.UseVisualStyleBackColor = false;
            this.workers_delete_btn.Click += new System.EventHandler(this.workers_delete_btn_Click);
            // 
            // workers_update_btn
            // 
            this.workers_update_btn.BackColor = System.Drawing.Color.Green;
            this.workers_update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workers_update_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workers_update_btn.ForeColor = System.Drawing.Color.White;
            this.workers_update_btn.Location = new System.Drawing.Point(506, 552);
            this.workers_update_btn.Name = "workers_update_btn";
            this.workers_update_btn.Size = new System.Drawing.Size(115, 46);
            this.workers_update_btn.TabIndex = 22;
            this.workers_update_btn.Text = "UPDATE";
            this.workers_update_btn.UseVisualStyleBackColor = false;
            this.workers_update_btn.Click += new System.EventHandler(this.workers_update_btn_Click);
            // 
            // workers_add
            // 
            this.workers_add.BackColor = System.Drawing.Color.Yellow;
            this.workers_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workers_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workers_add.ForeColor = System.Drawing.Color.Black;
            this.workers_add.Location = new System.Drawing.Point(359, 552);
            this.workers_add.Name = "workers_add";
            this.workers_add.Size = new System.Drawing.Size(115, 46);
            this.workers_add.TabIndex = 21;
            this.workers_add.Text = "ADD";
            this.workers_add.UseVisualStyleBackColor = false;
            this.workers_add.Click += new System.EventHandler(this.workers_add_Click);
            // 
            // frmWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1109, 610);
            this.Controls.Add(this.workers_delete_btn);
            this.Controls.Add(this.workers_update_btn);
            this.Controls.Add(this.workers_add);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWorker";
            this.Load += new System.EventHandler(this.frmWorker_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workers_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox residence;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView workers_dgv;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button workers_delete_btn;
        private System.Windows.Forms.Button workers_update_btn;
        private System.Windows.Forms.Button workers_add;
    }
}