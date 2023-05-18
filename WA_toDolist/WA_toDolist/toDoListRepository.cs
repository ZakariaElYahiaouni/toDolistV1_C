using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA_toDolist
{
    internal class toDoListRepository : Form  
    {
        SqlCommand command;
        SqlConnection connection;
        SqlDataReader reader;
        string connectionString = "Data Source=srvsql2022\\onboarding;Initial Catalog=ziko;Integrated Security=True";
        public void CreateConnection(string str)
        {
            string connStr = str;

            using (connection = new SqlConnection(connStr))
            {

                connection.Open();

             

            }




        }

        int y = 116;
        int x = 57;
        public void createLayoutView(string id, string title, string descriptionDuty, List<Label> labels, List<Button> buttons, int i)
        {


            Label lblId = new Label();
            lblId.Location = new Point(x, y);
            lblId.Name = "lbl_ID";
            lblId.Text = id;

            labels.Add(lblId);


            Label lblTitle = new Label();
            lblTitle.Location = new Point(x + 150, y);
            lblTitle.Name = "lbl_title";
            lblTitle.Text = title;

            labels.Add(lblTitle);

            Label lbltextDescription = new Label();
            lbltextDescription.Location = new Point(x + 250, y);
            lbltextDescription.Name = "lbl_descriptionDuty";
            lbltextDescription.Text = descriptionDuty;

            labels.Add(lbltextDescription);

            Button btnTodo = new Button();
            btnTodo.Location = new Point(x + 380, y);
            btnTodo.Name = "btn_toDo" + i.ToString();
            btnTodo.Size = new Size(20, 20);



            btnTodo.Text = "^";

            buttons.Add(btnTodo);

            Button btnEdit = new Button();
            btnEdit.Location = new Point(x + 400, y);
            btnEdit.Name = "btn_edit" + i.ToString();
            btnEdit.Size = new Size(20, 20);

            btnEdit.Text = "-";
            buttons.Add(btnEdit);




            lblId.Visible = true;
            lblTitle.Visible = true;
            lbltextDescription.Visible = true;
            Controls.Add(lblId);
            Controls.Add(lblTitle);
            Controls.Add(lbltextDescription);
            Controls.Add(btnEdit);
            Controls.Add(btnTodo);

            btnEdit.Click += new EventHandler(button1_Click);
            btnTodo.Click += new EventHandler(button2_Click);
            y += 40;
            i++;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Button button = sender as Button;
            int rowId = Convert.ToInt32(Convert.ToString(button.Name[button.Name.Length - 1]));
            


        }


        private void button2_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                string query;
                int rowId = Convert.ToInt32(Convert.ToString(button.Name[button.Name.Length - 1]));

                query = "SELECT done FROM toDoList WHERE Id = " + rowId;

                using (SqlCommand commandUpdate = new SqlCommand(query, connection))
                {
                    SqlDataReader readerUpdate = commandUpdate.ExecuteReader();

                    if (readerUpdate.Read())
                    {
                        if (readerUpdate[0].ToString() == "y")
                        {
                            using (SqlCommand commandToggle = new SqlCommand("UPDATE toDoList SET done = 'n' WHERE Id = " + rowId, connection))
                            {
                                readerUpdate.Close();
                                commandToggle.ExecuteNonQuery();
                            }
                            MessageBox.Show("undo");
                        }
                        else if (readerUpdate[0].ToString() == "n")
                        {
                            using (SqlCommand commandToggle = new SqlCommand("UPDATE toDoList SET done = 'y' WHERE Id = " + rowId, connection))
                            {
                                readerUpdate.Close();
                                commandToggle.ExecuteNonQuery();
                            }
                            MessageBox.Show("done");
                        }
                    }

                    readerUpdate.Close();
                }
            }

        }

    }
}
