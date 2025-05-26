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
    public partial class FormInsert : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public FormInsert()
        {
            InitializeComponent();
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Project Database.accdb;Persist Security Info=False";
            conn.ConnectionString = constr;
            textBox1Insert.Enabled = false;
            textBox2Insert.Enabled = false;
            textBox3Insert.Enabled = false;
            buttonCancel.Enabled = false;
            buttonClear.Enabled = false;
            buttonSave.Enabled = false;
        }

        public void clearfunc()
        {
            textBox1Insert.Text = "";
            textBox2Insert.Text = "";
            textBox3Insert.Text = "";
        }

        private void RBCourse_CheckedChanged(object sender, EventArgs e)
        {
            clearfunc();
            label1Insert.Text = "New Employee ID";
            label2Insert.Text = "New Employee Name";
            label3Insert.Text = "New Employee AccessCode";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearfunc();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                if (ActiveTicked.Checked == true)
                {
                    cmd.CommandText = "INSERT INTO School (`School Name`, `School Address`, `School Phone`, `Course`) VALUES (@schoolName,@schoolAdr, @schoolPhone, @courseID)";
                    cmd.Parameters.AddWithValue("@schoolName", textBox1Insert.Text);
                    cmd.Parameters.AddWithValue("@schoolAdr", textBox2Insert.Text);
                    cmd.Parameters.AddWithValue("@schoolPhone", textBox3Insert.Text);
                    MessageBox.Show("School Information successfully saved!");
                }
                if (ActiveTicked.Checked == true)
                {
                    cmd.CommandText = "INSERT INTO Course (`Course name`, `Course code`, `Course fee`, `Course location`) VALUES (@courseName, @courseCode, @courseFee, @courseLocation)";
                    cmd.Parameters.AddWithValue("@courseName", textBox1Insert.Text);
                    cmd.Parameters.AddWithValue("@courseCode", textBox2Insert.Text);
                    cmd.Parameters.AddWithValue("@courseFee", textBox3Insert.Text);
                    MessageBox.Show("Course Information successfully saved!");
                }
                cmd.ExecuteNonQuery();
                this.Close();
                Form1 form = new Form1();
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
        }

        private void RBSchool_CheckedChanged(object sender, EventArgs e)
        {
            if (ActiveTicked.Checked == true)
            {
                clearfunc();
                label1Insert.Text = "Employee ID";
                label2Insert.Text = "Employee Name";
                label3Insert.Text = "Employee AccessCode";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 formc = new Form1();
            formc.Show();
        }
        public string AccessCode = "41sca";
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != AccessCode)
            {
                textBox1Insert.Enabled = false;
                textBox2Insert.Enabled = false;
                textBox3Insert.Enabled = false;
                buttonCancel.Enabled = false;
                buttonClear.Enabled = false;
                buttonSave.Enabled = false;
            }
            else
            {
                textBox1Insert.Enabled = true;
                textBox2Insert.Enabled = true;
                textBox3Insert.Enabled = true;
                buttonCancel.Enabled = true;
                buttonClear.Enabled = true;
                buttonSave.Enabled = true;
            }
        }
    }
}
