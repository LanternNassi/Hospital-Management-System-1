namespace Hospital_Management_System.Screens.Pharmaceutical_Management
{
    partial class frmDealers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.suppliers_id_txtbx = new System.Windows.Forms.TextBox();
            this.suppliers_name_txtbx = new System.Windows.Forms.TextBox();
            this.suppliers_contact_txtbx = new System.Windows.Forms.TextBox();
            this.suppliers_email_txtbx = new System.Windows.Forms.TextBox();
            this.suppliers_address_txtbx = new System.Windows.Forms.TextBox();
            this.suppliers_dgv = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.suppliers_search_txtbx = new System.Windows.Forms.TextBox();
            this.suppliers_add = new System.Windows.Forms.Button();
            this.suppliers_update_btn = new System.Windows.Forms.Button();
            this.suppliers_delete_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliers_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 50);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_Management_System.Properties.Resources._215904_200;
            this.pictureBox1.Location = new System.Drawing.Point(720, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUPPLIERS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "CONTACT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "EMAIL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "ADDRESS";
            // 
            // suppliers_id_txtbx
            // 
            this.suppliers_id_txtbx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliers_id_txtbx.Location = new System.Drawing.Point(125, 82);
            this.suppliers_id_txtbx.Name = "suppliers_id_txtbx";
            this.suppliers_id_txtbx.ReadOnly = true;
            this.suppliers_id_txtbx.Size = new System.Drawing.Size(177, 27);
            this.suppliers_id_txtbx.TabIndex = 10;
            // 
            // suppliers_name_txtbx
            // 
            this.suppliers_name_txtbx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliers_name_txtbx.Location = new System.Drawing.Point(125, 129);
            this.suppliers_name_txtbx.Name = "suppliers_name_txtbx";
            this.suppliers_name_txtbx.Size = new System.Drawing.Size(177, 27);
            this.suppliers_name_txtbx.TabIndex = 11;
            // 
            // suppliers_contact_txtbx
            // 
            this.suppliers_contact_txtbx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliers_contact_txtbx.Location = new System.Drawing.Point(125, 184);
            this.suppliers_contact_txtbx.Name = "suppliers_contact_txtbx";
            this.suppliers_contact_txtbx.Size = new System.Drawing.Size(177, 27);
            this.suppliers_contact_txtbx.TabIndex = 12;
            // 
            // suppliers_email_txtbx
            // 
            this.suppliers_email_txtbx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliers_email_txtbx.Location = new System.Drawing.Point(125, 239);
            this.suppliers_email_txtbx.Name = "suppliers_email_txtbx";
            this.suppliers_email_txtbx.Size = new System.Drawing.Size(177, 27);
            this.suppliers_email_txtbx.TabIndex = 13;
            // 
            // suppliers_address_txtbx
            // 
            this.suppliers_address_txtbx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliers_address_txtbx.Location = new System.Drawing.Point(125, 297);
            this.suppliers_address_txtbx.Multiline = true;
            this.suppliers_address_txtbx.Name = "suppliers_address_txtbx";
            this.suppliers_address_txtbx.Size = new System.Drawing.Size(177, 102);
            this.suppliers_address_txtbx.TabIndex = 14;
            // 
            // suppliers_dgv
            // 
            this.suppliers_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliers_dgv.Location = new System.Drawing.Point(331, 129);
            this.suppliers_dgv.Name = "suppliers_dgv";
            this.suppliers_dgv.Size = new System.Drawing.Size(436, 270);
            this.suppliers_dgv.TabIndex = 15;
            this.suppliers_dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.suppliers_dgv_RowHeaderMouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(352, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Search Supplier";
            // 
            // suppliers_search_txtbx
            // 
            this.suppliers_search_txtbx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliers_search_txtbx.Location = new System.Drawing.Point(473, 80);
            this.suppliers_search_txtbx.Name = "suppliers_search_txtbx";
            this.suppliers_search_txtbx.Size = new System.Drawing.Size(294, 27);
            this.suppliers_search_txtbx.TabIndex = 17;
            this.suppliers_search_txtbx.TextChanged += new System.EventHandler(this.suppliers_search_txtbx_TextChanged);
            // 
            // suppliers_add
            // 
            this.suppliers_add.BackColor = System.Drawing.Color.Yellow;
            this.suppliers_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppliers_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliers_add.ForeColor = System.Drawing.Color.Black;
            this.suppliers_add.Location = new System.Drawing.Point(209, 411);
            this.suppliers_add.Name = "suppliers_add";
            this.suppliers_add.Size = new System.Drawing.Size(115, 46);
            this.suppliers_add.TabIndex = 18;
            this.suppliers_add.Text = "ADD";
            this.suppliers_add.UseVisualStyleBackColor = false;
            this.suppliers_add.Click += new System.EventHandler(this.suppliers_add_Click);
            // 
            // suppliers_update_btn
            // 
            this.suppliers_update_btn.BackColor = System.Drawing.Color.Green;
            this.suppliers_update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppliers_update_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliers_update_btn.ForeColor = System.Drawing.Color.White;
            this.suppliers_update_btn.Location = new System.Drawing.Point(356, 411);
            this.suppliers_update_btn.Name = "suppliers_update_btn";
            this.suppliers_update_btn.Size = new System.Drawing.Size(115, 46);
            this.suppliers_update_btn.TabIndex = 19;
            this.suppliers_update_btn.Text = "UPDATE";
            this.suppliers_update_btn.UseVisualStyleBackColor = false;
            this.suppliers_update_btn.Click += new System.EventHandler(this.suppliers_update_btn_Click);
            // 
            // suppliers_delete_btn
            // 
            this.suppliers_delete_btn.BackColor = System.Drawing.Color.Red;
            this.suppliers_delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppliers_delete_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliers_delete_btn.ForeColor = System.Drawing.Color.White;
            this.suppliers_delete_btn.Location = new System.Drawing.Point(500, 411);
            this.suppliers_delete_btn.Name = "suppliers_delete_btn";
            this.suppliers_delete_btn.Size = new System.Drawing.Size(115, 46);
            this.suppliers_delete_btn.TabIndex = 20;
            this.suppliers_delete_btn.Text = "DELETE";
            this.suppliers_delete_btn.UseVisualStyleBackColor = false;
            this.suppliers_delete_btn.Click += new System.EventHandler(this.suppliers_delete_btn_Click);
            // 
            // frmDealers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(779, 469);
            this.Controls.Add(this.suppliers_delete_btn);
            this.Controls.Add(this.suppliers_update_btn);
            this.Controls.Add(this.suppliers_add);
            this.Controls.Add(this.suppliers_search_txtbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.suppliers_dgv);
            this.Controls.Add(this.suppliers_address_txtbx);
            this.Controls.Add(this.suppliers_email_txtbx);
            this.Controls.Add(this.suppliers_contact_txtbx);
            this.Controls.Add(this.suppliers_name_txtbx);
            this.Controls.Add(this.suppliers_id_txtbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDealers";
            this.Text = "frmDealers";
            this.Load += new System.EventHandler(this.frmDealers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliers_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox suppliers_id_txtbx;
        private System.Windows.Forms.TextBox suppliers_name_txtbx;
        private System.Windows.Forms.TextBox suppliers_contact_txtbx;
        private System.Windows.Forms.TextBox suppliers_email_txtbx;
        private System.Windows.Forms.TextBox suppliers_address_txtbx;
        private System.Windows.Forms.DataGridView suppliers_dgv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox suppliers_search_txtbx;
        private System.Windows.Forms.Button suppliers_add;
        private System.Windows.Forms.Button suppliers_update_btn;
        private System.Windows.Forms.Button suppliers_delete_btn;
    }
}