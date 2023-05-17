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
    public partial class Form2 : Form
    {
        int rowId;
        classConnection connectionInstance = new classConnection();
        string connectionString = "Data Source=srvsql2022\\onboarding;Initial Catalog=ziko;Integrated Security=True";
        public Form2(int rowId)
        {
            InitializeComponent();
            this.rowId = rowId;
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

            //
            try
            {
                connectionInstance.CreateConnection(connectionString, rowId, txt_title, txt_descriptionDuty, comboBoxDone);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error! " + ex);
            }




        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            connectionInstance.EditRow(connectionString, rowId, txt_title, txt_descriptionDuty, comboBoxDone);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            connectionInstance.DeleteRow(connectionString, rowId);
        }
    }
}
