using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;



namespace Hospital_Management_System.DAL
{
    class Categories_DAL
    {
        // fields
        private int ID;
        private string Type;
        private string Category;
        private string Added_by;
        private DateTime Added_date;
        private string Information;

        // properties
        public int id { get { return ID; } set { ID = value; } }
        public string type { get { return Type; } set { Type = value; } }
        public string category { get { return Category; } set { Category = value; } }
        public DateTime added_date { get { return Added_date; } set { Added_date = value; } }
        public string information { get { return Information; } set { Information = value; } }
        public string added_by { get { return Added_by; } set { Added_by = value; } }


        // ConnectionString 
        public const string ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hospital Management System.accdb;";
        OleDbConnection conn = new OleDbConnection(ConnString);

        #region Insert
        public bool Insert()
        {
            bool test = false;

            try
            {
                string cmds = " INSERT INTO Categories(Category,Type,Added_by,Information)VALUES(@Category,@Type,@Added_by,@Information)";
                OleDbCommand cmd = new OleDbCommand(cmds, conn);
                cmd.Parameters.AddWithValue("@Category", Category);
                cmd.Parameters.AddWithValue("@Type", Type);
                cmd.Parameters.AddWithValue("@Added_by", Added_by);
                cmd.Parameters.AddWithValue("@Information", Information);
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

        #region Update 
        public bool Update(int id)
        {
            bool test = false;
            try
            {
                string cmds = "UPDATE Categories SET Category = @Category , Information = @Information WHERE ID = @ID ";
                OleDbCommand cmd = new OleDbCommand(cmds, conn);
                cmd.Parameters.AddWithValue("@Category", Category);
                cmd.Parameters.AddWithValue("@Information", Information);
                cmd.Parameters.AddWithValue("@ID", id);
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

        #region delete
        public bool Delete(int Id)
        {
            bool test = false;
            try
            {
                string cmds = "DELETE * FROM Categories WHERE ID = @ID";
                OleDbCommand cmd = new OleDbCommand(cmds,conn);
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

        #region Search
        public DataTable Search(string keywords)
        {
            DataTable dt = new DataTable();
            try
            {
                string cmds = "SELECT * FROM Categories WHERE ID LIKE '%" + keywords + "%' OR Category LIKE '%" + keywords + "%' ";
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmds, conn);
                conn.Open();
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

        #region Fill in appropriate data in datagridview
        public DataTable Fill(string CategoryType)
        {
            DataTable dt = new DataTable();
            try
            {
                string cmds = "SELECT * FROM Categories WHERE Type = @Type";
                OleDbCommand cmd = new OleDbCommand(cmds, conn);
                cmd.Parameters.AddWithValue("@Type", CategoryType);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = cmd;
                conn.Open();
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
