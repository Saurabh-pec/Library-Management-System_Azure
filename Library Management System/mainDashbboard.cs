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
    public partial class mainDashbboard : Form
    {
        public mainDashbboard()
        {
            InitializeComponent();
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addMember A = new addMember();
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAURABH\Desktop\PT-Project\Data\New Data\MY_Book_Table.accdb;Persist Security Info=True";
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            //command.Connection = connection;
            //command.CommandText = "INSERT INTO BookTableSK (author,price,bname,Published Date, Edition) VALUES ('" + textBox3.Text + "','" + textBox2.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + textBox5.Text + "')";
            //command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Your Data in inserted sucessfully");
            mainDashbboard M = new mainDashbboard();
            M.Show();
            this.Hide();

            A.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reserveBook r = new reserveBook();
            r.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addBook D = new addBook();
            D.Show();
            this.Hide();
        }

        private void mainDashbboard_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            payment P = new payment();
            P.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            issueBook i = new issueBook();
            i.Show();
            this.Hide();
            //try
            //{

               mainDashbboard M = new mainDashbboard();
                M.Show();
                this.Hide();

            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Your Data in inserted sucessfully ");
           // }

           
        }
    //}
}

