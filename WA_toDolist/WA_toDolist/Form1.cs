

using System.Data.SqlClient;



namespace WA_toDolist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=srvsql2022\\onboarding;Initial Catalog=ziko;Integrated Security=True";
            CreateConnection(connectionString);
            label2.Visible = false;
        }
        SqlCommand command;
        SqlConnection connection;
        SqlDataReader reader;
        public void CreateConnection(string str)
        {
            string connStr = str;


            connection = new SqlConnection(connStr);

            try
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
            catch (Exception ex)
            {
                MessageBox.Show("error connection!" + " " + ex);
            }



        }

        int y = 116;
        int x = 57;

        List<Label> labels = new List<Label>();
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
            lbltextDescription.Location = new Point(x + 350, y);
            lbltextDescription.Name = "lbl_descriptionDuty";
            lbltextDescription.Text = descriptionDuty;

            labels.Add(lbltextDescription);



            


            lblId.Visible = true;
            lblTitle.Visible = true;
            lbltextDescription.Visible = true;
            this.Controls.Add(lblId);
            this.Controls.Add(lblTitle);
            this.Controls.Add(lbltextDescription);
            y += 20;

        }




        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (txt_search.Text != string.Empty)
            {
                string query = "SELECT Id, title, descriptionDuty FROM toDoList WHERE title='" + (txt_search.Text) + "'";
                SqlCommand commandSearch = new SqlCommand(query, connection);
                SqlDataReader readerSearch;
                readerSearch = commandSearch.ExecuteReader();

                CancelRows();


                while (readerSearch.Read())
                {
                    Label lblId = new Label();
                    lblId.Location = new Point(x, y);
                    lblId.Name = "lbl_ID";
                    lblId.Text = readerSearch["Id"].ToString();
                    labels.Add(lblId);


                    Label lblTitle = new Label();
                    lblTitle.Location = new Point(x + 150, y);
                    lblTitle.Name = "lbl_title";
                    lblTitle.Text = readerSearch["title"].ToString();
                    labels.Add(lblTitle);
                    Label lbltextDescription = new Label();
                    lbltextDescription.Location = new Point(x + 350, y);
                    lbltextDescription.Name = "lbl_descriptionDuty";
                    lbltextDescription.Text = readerSearch["descriptionDuty"].ToString();
                    labels.Add(lbltextDescription);
                    lblId.Visible = true;
                    lblTitle.Visible = true;
                    lbltextDescription.Visible = true;
                    labels.Add(lblId);
                    this.Controls.Add(lblId);
                    this.Controls.Add(lblTitle);
                    this.Controls.Add(lbltextDescription);
                    y += 20;


                }
                readerSearch.Close();

            }
            else
            {
                MessageBox.Show("Error, string empty! insert a string...");
            }
        }
        public void CancelRows()
        {
            x = 57;
            y = 116;
            foreach (var label in labels)
            {
                this.Controls.Remove(label);

            }

        }

        private void RBtn_toDo_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtn_toDo.Checked == true)
            {
                
            }
        }

        private void RBtn_all_CheckedChanged(object sender, EventArgs e)
        {
            CancelRows(); 
            if (RBtn_all.Checked == true)
            {
                
                try
                {
                   
                    command = new SqlCommand("SELECT * from toDoList", connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        createLayoutView(reader["Id"].ToString(), reader["title"].ToString(), reader["descriptionDuty"].ToString());

                    }
                    reader.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("error connection!" + " " + ex);
                }
            }
        }
    }
}