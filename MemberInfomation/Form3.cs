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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("please insert job name！");
            }
            else
            {
                InsertWork();
            }
         
        }
        private void InsertWork()
        {
            DataBase.DBOpen();
            string s_cmd = "select * from jobinfo where JobName = '" + textBox1.Text.Trim() +"'";
            SqlCommand cmd = new SqlCommand(s_cmd, DataBase.sqlc);
            cmd.Connection = DataBase.sqlc;
            if(cmd.ExecuteScalar()!=null)
            {
                MessageBox.Show("工种重复，请重新输入");
            }
            else
            {
                try
                {
                    string sqlcmd = "insert into jobinfo (JobName,Remark) values ('" + textBox1.Text.Trim() + "'" + ",'" + textBox2.Text.Trim() + "')";
                    cmd.CommandText = sqlcmd;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("添加成功");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                    return;
                }

            }
            DataBase.DBClose();
            
        }
    }
}
