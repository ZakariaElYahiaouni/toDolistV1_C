

using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;


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
        SqlCommand commandDataGridView;
        SqlConnection connection;
        SqlDataReader reader;
        SqlDataReader readerDataGridView;

        DataTable dt = new DataTable();

        public void CreateConnection(string str)
        {
            string connStr = str;



            using (connection = new SqlConnection(connStr))
            {

                connection.Open();

                dt.Clear();
                commandDataGridView = new SqlCommand("SELECT * from toDoList", connection);
                readerDataGridView = commandDataGridView.ExecuteReader();
                dt.Load(readerDataGridView);
                dataGridView_layoutList.DataSource = dt;
               
                buttonsLoadingOnDataGridView();
              

                readerDataGridView.Close();

            }


        }

        int count = 0;
      
        private void dataGridView_layoutList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex >= 0 && dataGridView_layoutList.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView_layoutList.ColumnCount - 2)
                {
                    // Gestisci l'evento del pulsante 1
                    DataGridViewRow Id = dataGridView_layoutList.Rows[Convert.ToInt32(e.RowIndex)];
                    button2_Click(Convert.ToInt32(Id.Cells[0].Value));
                  

                }
                else if (e.ColumnIndex == dataGridView_layoutList.ColumnCount - 1)
                {
                    // Gestisci l'evento del pulsante 2
                    DataGridViewRow Id = dataGridView_layoutList.Rows[Convert.ToInt32(e.RowIndex)];
                    int lastElement = dataGridView_layoutList.Rows.Count - 1;
                   
                    button1_Click(Convert.ToInt32(Id.Cells[0].Value), lastElement); 
                }
            }
        }

        int y = 136;
        int x = 57;

        List<Label> labels = new List<Label>();
        List<Button> buttons = new List<Button>();
        int i = 1;
        private object sender;






        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (txt_search.Text != string.Empty)
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    string query = "SELECT Id, title, descriptionDuty FROM toDoList WHERE title='" + (txt_search.Text) + "'";
                    dt.Clear();
                    SqlCommand commandSearch = new SqlCommand(query, connection);
                    SqlDataReader readerSearch;
                    readerSearch = commandSearch.ExecuteReader();
                    dt.Load(readerSearch);
                    dataGridView_layoutList.DataSource = dt;

                }

            }
            else
            {
                MessageBox.Show("Error, string empty! enter a string...");
            }
        }

  

        private void RBtn_toDo_CheckedChanged(object sender, EventArgs e)
        {
         
            if (RBtn_toDo.Checked == true)
            {

                string query = "SELECT * FROM toDoList WHERE done='n'";
                loadingDataGridView(connection, query);

            }
        }

        private void loadingDataGridView(SqlConnection connection, string query)
        {

            dataGridView_layoutList.Columns.Remove("buttonToggle");
            dataGridView_layoutList.Columns.Remove("buttonEdit");
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                dt.Clear();
                dataGridView_layoutList.DataSource = null;
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
                dataGridView_layoutList.DataSource = dt;
                buttonsLoadingOnDataGridView();
               
                reader.Close();
            }
        }
        public void buttonsLoadingOnDataGridView()
        {
            // Verifica se le colonne dei bottoni sono già state aggiunte alla DataGridView
            if (!dataGridView_layoutList.Columns.Contains("buttonToggle"))
            {
                DataGridViewButtonColumn buttonToggle = new DataGridViewButtonColumn();
                {
                    buttonToggle.Name = "buttonToggle";
                    buttonToggle.HeaderText = "do";
                    buttonToggle.Text = "✔";
                    buttonToggle.Width = 50;
                    buttonToggle.DefaultCellStyle.Padding = new Padding(2);
                    buttonToggle.UseColumnTextForButtonValue = true; //dont forget this line
                    this.dataGridView_layoutList.Columns.Add(buttonToggle);
                }
            }

            if (!dataGridView_layoutList.Columns.Contains("buttonEdit"))
            {
                DataGridViewButtonColumn buttonEdit = new DataGridViewButtonColumn();
                {
                    buttonEdit.Name = "buttonEdit";
                    buttonEdit.HeaderText = "edit";

                    buttonEdit.Text = "-";
                    buttonEdit.Width = 50;
                    buttonEdit.DefaultCellStyle.Padding = new Padding(2);
                    buttonEdit.UseColumnTextForButtonValue = true; //dont forget this line

                    this.dataGridView_layoutList.Columns.Add(buttonEdit);
                }
            }
        }
        private void RBtn_all_CheckedChanged(object sender, EventArgs e)
        {
            
            if (RBtn_all.Checked == true)
            {

                CreateConnection(connectionString);
            }
        }





        private void button1_Click(int rowId, int i)
        {


            Form2 form = new Form2(rowId, i);

            form.Show();

        }


        private void button2_Click(int rowId)
        {


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                string query;


                query = "SELECT done FROM toDoList WHERE id = " + rowId;

                using (SqlCommand commandUpdate = new SqlCommand(query, connection))
                {
                    SqlDataReader readerUpdate = commandUpdate.ExecuteReader();

                    if (readerUpdate.Read())
                    {
                        if (readerUpdate["done"].ToString() == "y")
                        {
                            using (SqlCommand commandToggle = new SqlCommand("UPDATE toDoList SET done = 'n' WHERE Id = " + rowId, connection))
                            {

                                readerUpdate.Close();
                                commandToggle.ExecuteNonQuery();
                            }
                            MessageBox.Show("undo");
                        }
                        else if (readerUpdate["done"].ToString() == "n")
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog(); //
        }
    }
}