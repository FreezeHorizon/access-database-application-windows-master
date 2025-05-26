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
    public partial class FormUpdate : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public FormUpdate()
        {
            InitializeComponent();
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Project Database.accdb;Persist Security Info=False";
            conn.ConnectionString = constr;
            textBox1Update.Enabled = false;
            textBox2Update.Enabled = false;
            textBox3Update.Enabled = false;
            textBox4Update.Enabled = false;
            textBox5Update.Enabled = false;
            textBox6Update.Enabled = false;
            buttonCancel.Enabled = false;
            buttonClear.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonRefresh.Enabled = true;
        }

        public void clearfunc()
        {
            textBox1Update.Clear();
            textBox2Update.Clear();
            textBox3Update.Clear();
            textBox4Update.Clear();
            textBox5Update.Clear();
            textBox6Update.Clear();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 formc = new Form1();
            formc.Show();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearfunc();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string queryStringEmployeeAccessCodeDB = "SELECT `Employee ID`, `Employee Name`, `Access Code` FROM EmployeeAccessCodeDB WHERE `Employee ID Number`='" + textBox1Update.Text + "'";
            string queryStringEmployeeDataDB = "SELECT `Employee ID`, `Employee Name`, `Employee Department`, `HoursThisWeek`, `PayPerHour` FROM EmployeeDataDB WHERE `Employee ID Number`='" + textBox1Update.Text + "'";
            if (ActiveTicked.Checked == true)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand(queryStringEmployeeAccessCodeDB, conn);
                    conn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            textBox2Update.Text = reader.GetString(0);
                            textBox3Update.Text = reader.GetString(1);
                            textBox4Update.Text = reader.GetString(2);
                            textBox5Update.Text = reader.GetString(3);
                        }
                    }
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                conn.Close();
            }
            if (ActiveTicked.Checked == true)
            {
                try
                {
                    OleDbCommand cmdn = new OleDbCommand(queryStringEmployeeDataDB, conn);
                    conn.Open();
                    using (OleDbDataReader reader = cmdn.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            textBox2Update.Text = reader.GetString(0);
                            textBox3Update.Text = reader.GetString(1);
                            textBox4Update.Text = reader.GetString(2);
                            textBox5Update.Text = reader.GetString(3);
                        }
                    }
                    cmdn.ExecuteNonQuery();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                conn.Close();
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                if (ActiveTicked.Checked == true)
                {
                    cmd.CommandText = "UPDATE School SET `School Name`=@schoolName, `School Address`=@schoolAdr, `School Phone`=@schoolPhone, `Course`=@courseID WHERE `School ID Number`=" + textBox1Update.Text + "";
                    cmd.Parameters.AddWithValue("@schoolName", textBox2Update.Text);
                    cmd.Parameters.AddWithValue("@schoolAdr", textBox3Update.Text);
                    cmd.Parameters.AddWithValue("@schoolPhone", textBox4Update.Text);
                    cmd.Parameters.AddWithValue("@courseID", textBox5Update.Text);
                    MessageBox.Show("School Information successfully updated!");
                }
                if (ActiveTicked.Checked == true)
                {
                    cmd.CommandText = "UPDATE Course SET `Course name`=@courseName, `Course code`=@courseCode, `Course fee`=@courseFee, `Course location`=@courseLocation WHERE `Course ID`=" + textBox1Update.Text + "";
                    cmd.Parameters.AddWithValue("@courseName", textBox2Update.Text);
                    cmd.Parameters.AddWithValue("@courseCode", textBox3Update.Text);
                    cmd.Parameters.AddWithValue("@courseFee", textBox4Update.Text);
                    cmd.Parameters.AddWithValue("@courseLocation", textBox5Update.Text);
                    MessageBox.Show("Course Information successfully updated!");
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void RBSchool_CheckedChanged(object sender, EventArgs e)
        {

        }

        public string AccessCode = "41sca";
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != AccessCode)
            {
                textBox1Update.Enabled = false;
                textBox2Update.Enabled = false;
                textBox3Update.Enabled = false;
                textBox4Update.Enabled = false;
                textBox5Update.Enabled = false;
                textBox6Update.Enabled = false;
                buttonCancel.Enabled = false;
                buttonClear.Enabled = false;
                buttonUpdate.Enabled = false;
                buttonRefresh.Enabled = true;
            }
            else
            {
                textBox1Update.Enabled = true;
                textBox2Update.Enabled = true;
                textBox3Update.Enabled = true;
                textBox4Update.Enabled = true;
                textBox5Update.Enabled = true;
                textBox6Update.Enabled = true;
                buttonRefresh.Enabled = true;
                buttonCancel.Enabled = true;
                buttonClear.Enabled = true;
                buttonUpdate.Enabled = true;
            }
        }
    }
}
