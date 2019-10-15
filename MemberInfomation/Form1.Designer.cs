namespace MemberInfomation
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("添加工种");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("浏览工种");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("工种设置", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("添加部门");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("浏览部门");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("部门管理", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("添加员工");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("浏览员工");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("员工管理", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("添加收入");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("浏览收入");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("收入管理", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "添加工种";
            treeNode1.Text = "添加工种";
            treeNode2.Name = "浏览工种";
            treeNode2.Text = "浏览工种";
            treeNode3.Name = "节点0";
            treeNode3.Text = "工种设置";
            treeNode4.Name = "添加部门";
            treeNode4.Text = "添加部门";
            treeNode5.Name = "浏览部门";
            treeNode5.Text = "浏览部门";
            treeNode6.Name = "节点3";
            treeNode6.Text = "部门管理";
            treeNode7.Name = "添加员工";
            treeNode7.Text = "添加员工";
            treeNode8.Name = "浏览员工";
            treeNode8.Text = "浏览员工";
            treeNode9.Name = "节点6";
            treeNode9.Text = "员工管理";
            treeNode10.Name = "添加收入";
            treeNode10.Text = "添加收入";
            treeNode11.Name = "浏览收入";
            treeNode11.Text = "浏览收入";
            treeNode12.Name = "节点9";
            treeNode12.Text = "收入管理";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(226, 586);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 610);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "员工信息管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}

