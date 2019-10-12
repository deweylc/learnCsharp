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
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            form1 = new Form1();
           
            form1.MdiParent = this;
            form1.Height = this.Height;
            form1.Show();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                form1.Height = this.Height;
            }
            catch
            {

            }
        }
    }
}
