using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MemberInfomation
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            string s_cmd = "select * from jobinfo";
            try
            {
                DataBase.DBOpen();
                cmd.Connection = DataBase.sqlc;
                cmd.CommandText = s_cmd;
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ds.Clear();
                sa.Fill(ds, "jobinfo");
                DataBase.DBClose();
                comboBox2.DataSource = ds.Tables[0];
                comboBox2.DisplayMember = "JobName";
                comboBox2.ValueMember = "JobName";

                DataBase.DBOpen();
                s_cmd = "select * from departinfo";
                cmd.CommandText = s_cmd;
                sa = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ds.Clear();
                sa.Fill(ds, "departinfo");
                DataBase.DBClose();
                comboBox3.DataSource = ds.Tables[0];
                comboBox3.DisplayMember = "Dname";
                comboBox3.ValueMember="Dname";
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s_cmd = "select * from personinfo where PID= '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand();
            try
            {
                DataBase.DBOpen();
                cmd.Connection = DataBase.sqlc;
                cmd.CommandText = s_cmd;
                if (cmd.ExecuteScalar() != null)
                {
                    MessageBox.Show("已存在该员工");
                }
                else
                {
                    DateTime dt = DateTime.Now;
                    s_cmd = "insert into personinfo (PID,Pname,Dname,JobName,Psex,Pbirthday,PPlace,PLevel,Psecial,Pdate,Pbusi,Remark) values ('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + comboBox3.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + textBox8.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + " ','" + dt.ToString() + "','" + textBox7.Text + "','" + textBox4.Text + "')";
                    cmd.CommandText = s_cmd;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("添加成功");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                DataBase.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
