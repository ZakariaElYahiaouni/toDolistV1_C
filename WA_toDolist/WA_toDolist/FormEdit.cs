using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA_toDolist
{
    public partial class FormEdit : Form
    {
        int rowId;
        int lastElement;
        classConnection connectionInstance = new classConnection();
        string connectionString = "Data Source=srvsql2022\\onboarding;Initial Catalog=ziko;Integrated Security=True";
        public FormEdit(int rowId, int lastElement)
        {
            InitializeComponent();
            this.rowId = rowId;
            this.lastElement = lastElement;
        }


        private void btn_back_Click(object sender, EventArgs e)
        {

            this.Hide();


        }
        SqlConnection connection;
        SqlDataReader reader;
        SqlCommand command;

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_id.Text = rowId.ToString();
            comboBoxDone.Items.Add("y");
            comboBoxDone.Items.Add("n");


            try
            {
                //   connectionInstance.CreateConnection(connectionString, rowId, txt_title.Text, txt_descriptionDuty.Text, comboBoxDone.Text);

                connectionInstance.GetToDo(connectionString, rowId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error! " + ex);
            }




        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            connectionInstance.EditRow(connectionString, rowId, txt_title.Text, txt_descriptionDuty.Text, comboBoxDone.Text);


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (rowId == lastElement)
            {
                MessageBox.Show("Row deleted!");
                connectionInstance.DeleteRow(connectionString, rowId);
            }
            else
            {

                MessageBox.Show("Error, you can only delete the last element of the database");
            }

        }

        private void txt_title_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
