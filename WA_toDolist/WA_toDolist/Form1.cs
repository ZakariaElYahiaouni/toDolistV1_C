

using System.Data.SqlClient;


namespace WA_toDolist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        string connectionString = "Data Source=srvsql2022\\onboarding;Initial Catalog=ziko;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                CreateConnection(connectionString);

            }

            catch (Exception ex)
            {
                MessageBox.Show("error connection!" + " " + ex);
            }
        }
        SqlCommand command;
        SqlConnection connection;
        SqlDataReader reader;
        public void CreateConnection(string str)
        {
            string connStr = str;

            using (connection = new SqlConnection(connStr))
            {

                connection.Open();

                command = new SqlCommand("SELECT * from toDoList", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {

                    createLayoutView(reader["Id"].ToString(), reader["title"].ToString(), reader["descriptionDuty"].ToString());

                }
                reader.Close();

            }




        }

        int y = 116;
        int x = 57;

        List<Label> labels = new List<Label>();
        List<Button> buttons = new List<Button>();
        int i = 1;
        private object sender;

        public void createLayoutView(string id, string title, string descriptionDuty)
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
            btnTodo.Size = new Size(10, 10);



            btnTodo.Text = "^";

            buttons.Add(btnTodo);

            Button btnEdit = new Button();
            btnEdit.Location = new Point(x + 400, y);
            btnEdit.Name = "btn_edit" + i.ToString();
            btnEdit.Size = new Size(10, 10);

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
            y += 20;
            i++;
        }




        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (txt_search.Text != string.Empty)
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    string query = "SELECT Id, title, descriptionDuty FROM toDoList WHERE title='" + (txt_search.Text) + "'";
                    SqlCommand commandSearch = new SqlCommand(query, connection);
                    SqlDataReader readerSearch;
                    readerSearch = commandSearch.ExecuteReader();

                    CancelRows();


                    while (readerSearch.Read())
                    {
                        createLayoutView(readerSearch["Id"].ToString(), readerSearch["title"].ToString(), readerSearch["descriptionDuty"].ToString());


                    }
                    readerSearch.Close();
                }

            }
            else
            {
                MessageBox.Show("Error, string empty! enter a string...");
            }
        }
        public void CancelRows()
        {
            x = 57;
            y = 116;
            i = 1;
            foreach (var label in labels)
            {
                this.Controls.Remove(label);

            }

            foreach (var button in buttons)
            {
                Controls.Remove(button);

            }

        }

        private void RBtn_toDo_CheckedChanged(object sender, EventArgs e)
        {
            CancelRows();
            if (RBtn_toDo.Checked == true)
            {

                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM toDoList WHERE done='n'";
                    SqlCommand commandSearch = new SqlCommand(query, connection);
                    SqlDataReader readerSearch;
                    readerSearch = commandSearch.ExecuteReader();



                    while (readerSearch.Read())
                    {
                        createLayoutView(readerSearch["Id"].ToString(), readerSearch["title"].ToString(), readerSearch["descriptionDuty"].ToString());


                    }
                    readerSearch.Close();
                }

            }
        }

        private void RBtn_all_CheckedChanged(object sender, EventArgs e)
        {
            CancelRows();
            if (RBtn_all.Checked == true)
            {

                CreateConnection(connectionString);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show(); 

        }

        bool flag = false;
        private void button2_Click(object sender, EventArgs e)
        {


            Button button = sender as Button;

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query;
                int rowId = Convert.ToInt32(Convert.ToString(button.Name[button.Name.Length - 1]));

                
                if(flag == false)
                {
                    query = "Update toDoList set done = 'y' where Id = " + rowId + "";
                    button.BackColor = Color.Gray;
                    flag = true;
                    MessageBox.Show("done");
                }
                else
                {
                    query = "Update toDoList set done = 'n' where Id = " + rowId + "";
                    button.BackColor = Color.Transparent;
                    flag = false;
                    MessageBox.Show("undo");
                }

               


                SqlCommand commandUpdate = new SqlCommand(query, connection);
                SqlDataReader readerUpdate;
                readerUpdate = commandUpdate.ExecuteReader();


                readerUpdate.Close();
            }


        }

    }
}