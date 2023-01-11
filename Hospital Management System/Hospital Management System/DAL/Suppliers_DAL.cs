using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using Hospital_Management_System.Screens;
using System.Windows.Forms;

namespace Hospital_Management_System.DAL
{
    class Suppliers_DAL
    {
        // Fields 
        private int ID;
        private string Supplier;
        private string Contact;
        private string Email;
        private string Address;
        private string Added_by;
        private DateTime Added_date;

        // Properties
        public int id { get { return ID; } set { ID = value; } }
        public string supplier {get{return Supplier;} set{ Supplier = value;}}
        public string contact {get{return Contact;} set{Contact = value;}}
        public string email { get { return Email; } set { Email = value; } }
        public string address { set { Address = value; } get { return Address; } }
        public string added_by { set { Added_by = value; } get { return Added_by; } }
        public DateTime added_date { set { Added_date = value; } get { return Added_date; } }

        // ConnectionString 
        public const string ConnString  = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hospital Management System.accdb;";
        OleDbConnection conn = new OleDbConnection(ConnString);

        


        #region Inserting 
        public bool Insert()
        {
            bool added = false;

            try
            {
                string cmds = "INSERT INTO Suppliers(Supplier,Contact,Email,Address,Added_by)VALUES(@Supplier,@Contact,@Email,@Address,@Added_by)";
                OleDbCommand cmd = new OleDbCommand(cmds, conn);
                cmd.Parameters.AddWithValue("@Supplier",Supplier);
                cmd.Parameters.AddWithValue("@Contact", Contact);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Added_by", Added_by);
                //cmd.Parameters.AddWithValue("@Added_date", Added_date);
                conn.Open();
                int rows_affected = cmd.ExecuteNonQuery();
                if (rows_affected > 0)
                {
                    added = true;
                }
                else
                {
                    added = false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();

            }


            return added;
        }
        #endregion

        # region show all 
        public DataTable ShowAllSuppliers()
        {
            DataTable dt = new DataTable();
            try
            {
                string cmds = "SELECT * FROM Suppliers";
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmds, conn);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        
        #endregion

        #region Updating 
        public bool Update(int Id)
        {
            bool test = false;
            try
            {

                string cmds = "UPDATE Suppliers SET Supplier = @Supplier , Contact = @Contact , Email = @Email , Address = @Address , Added_by = @Added_by  WHERE ID = @ID";
                OleDbCommand cmd = new OleDbCommand(cmds, conn);
                
                cmd.Parameters.AddWithValue("@Supplier", Supplier);
                cmd.Parameters.AddWithValue("@Contact", Contact);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Added_by", Added_by);
                cmd.Parameters.AddWithValue("@ID", Id);
                conn.Open();
                int rows_affected = cmd.ExecuteNonQuery();
                if (rows_affected > 0)
                {
                    test = true;
                }
                else
                {
                    test = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return test;
        }
        #endregion

        #region Delete
        public bool Delete(int Id)
        {
            bool test = false;
            try
            {

                string cmds = "DELETE * FROM Suppliers WHERE ID = @ID";
                OleDbCommand cmd = new OleDbCommand(cmds, conn);
                cmd.Parameters.AddWithValue("@ID", Id);
                conn.Open();
                int rows_affected = cmd.ExecuteNonQuery();
                if (rows_affected > 0)
                {
                    test = true;
                }
                else
                {
                    test = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return test;

        }
        #endregion

        # region Search
        public DataTable Search(string keywords)
        {
            DataTable dt = new DataTable();
            try
            {
                string cmds = "SELECT * FROM Suppliers WHERE ID LIKE '%"+keywords+"%' OR Supplier LIKE '%"+keywords+"%'";
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmds, conn);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }
        #endregion


    }
}
