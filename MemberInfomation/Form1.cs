using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberInfomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Name=="添加工种")
            {
                AddWork();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            treeView1.ExpandAll();
        }
        private void AddWork()
        {
            Form2 mainform = new Form2();
            mainform = this.MdiParent as Form2;
            Form3 form3 = new Form3();
            form3.MdiParent = mainform;
            form3.Show();
        }
    }
}
