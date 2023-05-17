using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WA_toDolist
{
    internal class classConnection : Form
    {

        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader; 
       
        public void CreateConnection(string str, int idRow, TextBox txt_title, TextBox txt_descriptionDuty, ComboBox done)
        {
            string connStr = str;
            using (connection = new SqlConnection(connStr))
            {
                connection.Open();
                command = new SqlCommand("SELECT * FROM toDoList WHERE Id = " + idRow, connection);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    txt_title.Text = reader["title"].ToString();
                    txt_descriptionDuty.Text = reader["descriptionDuty"].ToString();
                    done.Text = reader["done"].ToString();
                 
                }
                else
                {
                    txt_title.Text = "";
                    txt_descriptionDuty.Text = "";
                    done.Text = "";
                    MessageBox.Show("No data found.");
                }
            }

        }
        public void EditRow(string str, int idRow, TextBox txt_title, TextBox txt_descriptionDuty, ComboBox done)
        {

            string connStr = str;
            
            using (connection = new SqlConnection(connStr))
            {
                connection.Open();
                string query = "UPDATE toDoList SET title = '" + txt_title.Text + "', descriptionDuty = '" + txt_descriptionDuty.Text + "', done ='" + done.Text + "' WHERE Id = " + idRow + "";
                SqlCommand commandEdit = new SqlCommand(query, connection);
                SqlDataReader readerEdit = commandEdit.ExecuteReader();
            }

        }
        public void newRow(string str, TextBox txt_title, TextBox txt_descriptionDuty)
        {
            string connStr = str;

            using (connection = new SqlConnection(connStr))
            {

                /*
                 INSERT INTO table_name (column1, column2, column3, ...)
                    VALUES (value1, value2, value3, ...);
                 */
                connection.Open();
                string query = "INSERT INTO toDoList (title, descriptionDuty, done) VALUES ('" + txt_title.Text + "', '" + txt_descriptionDuty.Text + "', 'n')";
                SqlCommand commandNew = new SqlCommand( query, connection);
                SqlDataReader rNew = commandNew.ExecuteReader();
            }
        }
        public void DeleteRow(string str, int idRow)
        {
            string connStr = str;

            using (connection = new SqlConnection(connStr))
            {
                //DELETE FROM table_name WHERE condition;
                connection.Open();

                string query = "DELETE FROM toDoList WHERE Id = " + idRow + "";
                SqlCommand commandDelete = new SqlCommand(query, connection);
                SqlDataReader rDelete = commandDelete.ExecuteReader(); 
                    


            }
        }

    }
}
