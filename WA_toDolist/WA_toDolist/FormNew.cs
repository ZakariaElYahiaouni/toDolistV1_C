using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA_toDolist
{
    public partial class FormNew : Form
    {

        classConnection connectionInstance = new classConnection();
        string connectionString = "Data Source=srvsql2022\\onboarding;Initial Catalog=ziko;Integrated Security=True";
        public FormNew()
        {
            InitializeComponent();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            connectionInstance.NewRow(connectionString, txt_title2.Text, txt_descriptionDuty.Text);
            MessageBox.Show("Row added!"); 
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
