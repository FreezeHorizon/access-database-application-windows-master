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
    public partial class FormDelete : Form
    {
        OleDbConnection conn = new OleDbConnection();
        
        public FormDelete()
        {
            InitializeComponent();
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Project Database.accdb;Persist Security Info=False";
            conn.ConnectionString = constr;
            textBox1Delete.Enabled = false;
            textBox2Delete.Enabled = false;
            textBox3Delete.Enabled = false;
            textBox4Delete.Enabled = false;
            textBox5Delete.Enabled = false;
            textBox6Delete.Enabled = false;
            buttonRefresh.Enabled = false;
            buttonCancel.Enabled = false;
            buttonClear.Enabled = false;
            buttonDelete.Enabled = false;
        }
        public void clearfunc()
        {
            textBox1Delete.Clear();
            textBox2Delete.Clear();
            textBox3Delete.Clear();
            textBox4Delete.Clear();
            textBox5Delete.Clear();
        }
        private void RBSchoolDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (ActiveTicked.Checked == true)
            {
                clearfunc();
                label1Delete.Text = "Employee ID";
                label2Delete.Text = "Employee Name";
                label3Delete.Text = "Employee Department";
                label4Delete.Text = "HoursThisWeek";
                label5Delete.Text = "PayPerHour";
                label6Delete.Text = "PhoneNumber";
            }
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
            string queryStringSchool = "SELECT `School Name`, `School Address`, `School Phone`, `Course` FROM School WHERE `School ID Number`=" + textBox1Delete.Text + "";
            string queryStringCourse = "SELECT `Course name`, `Course code`, `Course fee`, `Course location` FROM Course WHERE `Course ID`=" + textBox1Delete.Text + "";
            if (ActiveTicked.Checked == true)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand(queryStringSchool, conn);
                    conn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            textBox2Delete.Text = reader.GetString(0);
                            textBox3Delete.Text = reader.GetString(1);
                            textBox4Delete.Text = reader.GetString(2);
                            textBox5Delete.Text = reader.GetString(3);
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
                    OleDbCommand cmdn = new OleDbCommand(queryStringCourse, conn);
                    conn.Open();
                    using (OleDbDataReader reader = cmdn.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            textBox2Delete.Text = reader.GetString(0);
                            textBox3Delete.Text = reader.GetString(1);
                            textBox4Delete.Text = reader.GetString(2);
                            textBox5Delete.Text = reader.GetString(3);
                        }
                    }
                    cmdn.ExecuteNonQuery();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                conn.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                if (ActiveTicked.Checked == true)
                {
                    cmd.CommandText = "DELETE * FROM School WHERE `School ID Number`=" + textBox1Delete.Text + "";
                }
                if (ActiveTicked.Checked == true)
                {
                    cmd.CommandText = "DELETE * FROM Course WHERE `Course ID`=" + textBox1Delete.Text + "";
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }
        public string AccessCode = "41sca";
        private void textBox2_TextChanged(object sender, EventArgs e)
        {   
            if (textBox2.Text != AccessCode)
            {
                textBox1Delete.Enabled = false;
                textBox2Delete.Enabled = false;
                textBox3Delete.Enabled = false;
                textBox4Delete.Enabled = false;
                textBox5Delete.Enabled = false;
                textBox6Delete.Enabled = false;
                buttonRefresh.Enabled = false;
                buttonCancel.Enabled = false;
                buttonClear.Enabled = false;
                buttonDelete.Enabled = false;
            } else
            {
                textBox1Delete.Enabled = true;
                textBox2Delete.Enabled = true;
                textBox3Delete.Enabled = true;
                textBox4Delete.Enabled = true;
                textBox5Delete.Enabled = true;
                textBox6Delete.Enabled = true;
                buttonRefresh.Enabled = true;
                buttonCancel.Enabled = true;
                buttonClear.Enabled = true;
                buttonDelete.Enabled = true;
            }
        }
    }
}
