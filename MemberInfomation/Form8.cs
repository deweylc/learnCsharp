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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            ReadData();
        }
        private void ReadData()
        {
            dataGridView1.ReadOnly = true;
            button1.Text = "修改";
            SqlCommand cmd = new SqlCommand();
            string s_cmd = "select PID as 编号,Pname as 姓名,Dname as 部门,JobName as 工种,Psex as 性别,Pbirthday as 生日,PPlace as 籍贯,PLevel as 学历,Psecial as 专业,Pdate as 注册时间,Pbusi as 职称,Remark as 备注 from personinfo";
            try
            {
                DataBase.DBOpen();
                cmd.Connection = DataBase.sqlc;
                cmd.CommandText = s_cmd;
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ds.Clear();
                sa.Fill(ds, "personinfo");
                DataBase.DBClose();
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text=="修改")
            {
                dataGridView1.ReadOnly = false;
                dataGridView1.Columns[0].ReadOnly = true;
                button1.Text = "保存";
            }
            else if(button1.Text=="保存")
            {
                DataBase.DBOpen();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DataBase.sqlc;
                for (int i = 1; i < dataGridView1.Rows.Count; i++)
                {
       
                    string sqlcmd = "update personinfo set Pname= '" + dataGridView1[1, i].Value + "',Dname='" + dataGridView1[2, i].Value + "',JobName='"+dataGridView1[3,i].Value + "',Psex='"+dataGridView1[4,i].Value + "',Pbirthday='"+dataGridView1[5,i].Value + "',PPlace='"+dataGridView1[6,i].Value + "',PLevel='"+dataGridView1[7,i].Value + "',Psecial='"+dataGridView1[8,i].Value + "',Pdate='"+dataGridView1[9,i].Value + "',Pbusi='"+dataGridView1[10,i].Value + "',Remark='"+dataGridView1[11,i].Value + "' where PID='" + dataGridView1[0, i].Value + "'";

                    cmd.CommandText = sqlcmd;
                    cmd.ExecuteNonQuery();
                    button1.Text = "修改";
                }
                DataBase.DBClose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBase.DBOpen();
            if (dataGridView1.CurrentCell != null)
            {
                string sqlcmd;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DataBase.sqlc;
              
                
                if (true)
                {
                   
                    sqlcmd = "delete  from personinfo where PName = '" + dataGridView1.CurrentCell.Value + "'";
                    cmd.CommandText = sqlcmd;
                    cmd.ExecuteNonQuery();
                }
            }
            DataBase.DBClose();
            ReadData();
        }
    }
}
