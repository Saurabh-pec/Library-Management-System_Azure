using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Library_Management_System
{
    public partial class addBook : Form
    {
        public addBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //mainDashbboard M = new mainDashbboard();
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAURABH\Desktop\PT-Project\Data\New Data\MY_Book_Table.accdb;Persist Security Info=True";
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO All_Book_Table (author,price,bname,Published Date, Edition) Values ('"+ textBox3.Text+ "','" + textBox2.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + textBox5.Text + "')";
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Your Data in inserted sucessfully");
            //M.Show();
           // this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainDashbboard M = new mainDashbboard();
            M.Show();
            this.Hide();
         }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //mainDashbboard M = new mainDashbboard();
            
                try { 

                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAURABH\Desktop\PT-Project\Data\New Data\MY_Book_Table.accdb;Persist Security Info=True";
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO BookTableSK (author,price,bname,Published Date, Edition) VALUES ('" + textBox3.Text + "','" + textBox2.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + textBox5.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Your Data in inserted sucessfully");
                mainDashbboard M = new mainDashbboard();
                M.Show();
                this.Hide();

            }
                catch (Exception )
                {
                    MessageBox.Show("Your Data in inserted sucessfully ");
                }
            

        }
    }
}
