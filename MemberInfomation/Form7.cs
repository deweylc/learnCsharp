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
    public partial class Form7 : Form
    {
        DataSet ds;
        public Form7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ReadData()
        {
            dataGridView1.ReadOnly = true;
            button1.Text = "修改";

            DataBase.DBOpen();
            string s_cmd = "select DID as 编号,Dname as 名称,Dleader as 领导,Remark as 备注 from departinfo";
            SqlCommand cmd = new SqlCommand(s_cmd,DataBase.sqlc);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ds.Clear();
            sa.Fill(ds, "departinfo");
            DataBase.DBClose();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        private void button4_Click(object sender, EventArgs e)
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
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    int k = (int)dataGridView1[0, i].Value;

                    string sqlcmd = "update departinfo set DName= '" + dataGridView1[1, i].Value + "',Dleader='" + dataGridView1[2, i].Value + "',Remark='"+dataGridView1[3,i].Value+"' where DID='" + dataGridView1[0, i].Value + "'";

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
                string sqlcmd = "select DName from departinfo where DName  in (select DName from personinfo where DName = '" + dataGridView1.CurrentCell.Value + " ')";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DataBase.sqlc;
                cmd.CommandText = sqlcmd;
                SqlDataReader sr = cmd.ExecuteReader();
                if (!sr.Read())
                {
                    sr.Close();
                    sqlcmd = "delete  from departinfo where DName = '" + dataGridView1.CurrentCell.Value + "'";
                    cmd.CommandText = sqlcmd;
                    cmd.ExecuteNonQuery();
                }
            }
            DataBase.DBClose();
            ReadData();
        }
    }
}
