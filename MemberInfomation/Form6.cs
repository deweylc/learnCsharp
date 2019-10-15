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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s_cmd="select * from departinfo where Dname= '"+ textBox1.Text +"'";
            SqlCommand cmd = new SqlCommand();
            try
            {
                DataBase.DBOpen();
                cmd.Connection = DataBase.sqlc;
                cmd.CommandText = s_cmd;
                if(cmd.ExecuteScalar()!=null)
                {
                    MessageBox.Show("已存在该部门");
                }
                else
                {
                    s_cmd = "insert into departinfo (Dname,Dleader,Remark) values ('"+textBox1.Text +" ' ,'"+textBox3.Text +" ' ,'"+ textBox2.Text+" ' )";
                    cmd.CommandText = s_cmd;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("添加成功");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                DataBase.DBClose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
