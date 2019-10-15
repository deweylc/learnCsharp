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
            else if(e.Node.Name=="浏览工种")
            {
                BrowseJob();
            }
            else if(e.Node.Name=="添加部门")
            {
                AddDepart();
            }
            else if(e.Node.Name=="浏览部门")
            {
                BrowseDepart();
            }
            else if(e.Node.Name=="添加员工")
            {
                Addperson();
            }
            else if(e.Node.Name=="浏览员工")
            {
                Browseperson();
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
        private void BrowseJob()
        {
            Form2 mainform = new Form2();
            mainform = this.MdiParent as Form2;
            Form4 form4 = new Form4();
            form4.MdiParent = mainform;
            form4.Show();
        }
        private void AddDepart()
        {
            Form2 mainform = new Form2();
            mainform = this.MdiParent as Form2;
            Form6 form6 = new Form6();
            form6.MdiParent = mainform;
            form6.StartPosition = FormStartPosition.CenterScreen;
            form6.Show();
        }
        private void BrowseDepart()
        {
            Form2 mainform = new Form2();
            mainform = this.MdiParent as Form2;
            Form7 form7 = new Form7();
            form7.MdiParent = mainform;
            form7.StartPosition = FormStartPosition.CenterScreen;
            form7.Show();
        }
        private void Addperson()
        {
            Form2 mainform = new Form2();
            mainform = this.MdiParent as Form2;
            Form5 form5 = new Form5();
            form5.MdiParent = mainform;
            form5.StartPosition = FormStartPosition.CenterScreen;
            form5.Show();
        }
        private void Browseperson()
        {
            Form2 mainform = new Form2();
            mainform = this.MdiParent as Form2;
            Form8 form8 = new Form8();
            form8.MdiParent = mainform;
            form8.StartPosition = FormStartPosition.CenterScreen;
            form8.Show();
        }
    }
}
