using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace Hospital_Management_System.DAL
{
    class Workers
    {
        //Fields 
        private int id;
        private string type;
        private string name;
        private int age;
        private string residence;
        private string classification;
        private string email;
        private string contact;
        private string address;


        // Properties 
        public int Id { get {return id ;} set {id = value;} }
        public string Type { get { return type; } set { type = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Residence { get { return residence; } set { residence = value; } }
        public string Classification { get { return classification; } set { classification = value; } }
        public string  Email { get { return email; } set{ email = value;  } }
        public string Contact { get { return contact; } set { contact = value; } }
        public string Address { get { return address; } set { address = value; } }

        public const string ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hospital Management System.accdb;";
        OleDbConnection conn = new OleDbConnection(ConnString);


        #region Inserting
        public bool Insert()
        {
            bool issuccess = false;
            const string command = "INSERT INTO Workers(Type , Name , Age , Residence , Classification , Email , Contact , Address) VALUES (@Type , @Name , @Age , @Residence , @Classification, @Email , @Contact , @Address)";
            OleDbCommand cmd = new OleDbCommand(command, conn);
            cmd.Parameters.AddWithValue("@Type", type);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Age", age);
            cmd.Parameters.AddWithValue("@Residence", residence);
            cmd.Parameters.AddWithValue("@classification", classification);
            cmd.Parameters.AddWithValue("@Email" , email);
            cmd.Parameters.AddWithValue("@Contact" , contact);
            cmd.Parameters.AddWithValue("@Address" , address);
            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    issuccess = true;
                }
                else
                {
                    issuccess = false;
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
            
            
            return issuccess;
        }

        #endregion

        #region Updating
        public bool Update(int Id)
        {
            bool isSuccess = false;

            const string command = "UPDATE WORKERS SET Type = @type , Age = @age , Name = @name , Residence = @residence , Classification = @classification , Email = @Email , Contact = @contact , Address = @Address WHERE ID = @id";
            OleDbCommand cmd = new OleDbCommand(command,conn);
            cmd.Parameters.AddWithValue("@type" , type);
            cmd.Parameters.AddWithValue("@age" , age );
            cmd.Parameters.AddWithValue("@name" , name );
            cmd.Parameters.AddWithValue("@Residence" , residence);
            cmd.Parameters.AddWithValue("@classification" , classification);
            cmd.Parameters.AddWithValue("@Email" , email);
            cmd.Parameters.AddWithValue("@Contact" , contact);
            cmd.Parameters.AddWithValue("@Address" , address);
            cmd.Parameters.AddWithValue("@id", Id);
            try{
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows>0){
                    isSuccess = true;
                }else {
                    isSuccess = false;
                }
            
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            
            }
            finally 
            {
                conn.Close();
            
            }

            return isSuccess;

        }
        #endregion

        #region Deleting 
        public bool delete(int id)
        {
            bool isSuccess = false;
            const string command = " DELETE * FROM Workers WHERE ID = @id ";
            OleDbCommand cmd = new OleDbCommand( command,conn);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows>0){
                    isSuccess = true;

                } else {
                    isSuccess = false;
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

            return isSuccess;
        }
        #endregion

        #region Select
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            const string command = "SELECT * FROM Workers";
            OleDbCommand cmd = new OleDbCommand(command, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            try
            {
                conn.Open();
                adapter.Fill(dt);


            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            return dt;

        }
        #endregion


    }
}
