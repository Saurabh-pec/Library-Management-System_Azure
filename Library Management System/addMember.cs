using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class addMember : Form
    {
        public addMember()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainDashbboard B = new mainDashbboard();
            B.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAURABH\Desktop\PT-Project\Data\New Data\MY_Book_Table.accdb;Persist Security Info=True";
                connection.Open();
                OleDbCommand command = new OleDbCommand();
               // command.Connection = connection;
               // command.CommandText = "INSERT INTO AddMember (Full name,Address,DOB,Gender,Phone Number,Email id) Values ('" + name.Text + "','" + address.Text + "','" + dob.Text + "','" + radio.text + "','" + phone.Text + "','" + email.Text + "')";
                //command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("New member added  sucessfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("New member added sucessfully ");
            }


        }
    }
}
