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

namespace labproject
{
    public partial class Form1 : Form
    {
        DataTable vt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            ConnectButton.Enabled = false;
        }
        string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\prg455\\labproject\\Project Database.accdb;Persist Security Info=False";
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int toggle = 0;
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (toggle == 0)
            {
                OleDbConnection conn = new OleDbConnection(constr);         // establishes connection to the database
                ConnectButton.BackColor = Color.Green;
                ConnectButton.Text = "Connected";
                toggle++;
            } else
            {
                ConnectButton.BackColor = Color.Silver;
                ConnectButton.Text = "Disconnected";
                toggle--;
                OleDbConnection conn = new OleDbConnection(constr);
                conn.Close();
            }
            
        }
        private void button3_Click(object sender, EventArgs e)
        {   
            if (ConnectButton.Text == "Connected")
            {
                FormInsert forminsert = new FormInsert();
                forminsert.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Please connect to the database first!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ConnectButton.Text == "Connected")
            {
                FormUpdate formupdate = new FormUpdate();
                formupdate.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Please connect to the database first!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ConnectButton.Text == "Connected")
            {
                FormDelete formdelete = new FormDelete();
                formdelete.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Please connect to the database first!");
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "41sca")
            {
                ConnectButton.Enabled = true;
            } else
            {
                ConnectButton.Enabled = false;
            }
        }
    }
}
