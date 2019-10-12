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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("添加工种");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("浏览工种");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("工种设置", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("添加员工");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("浏览部门");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("部门管理", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("添加员工");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("浏览员工");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("员工管理", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("添加收入");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("浏览收入");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("收入管理", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
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
            treeNode13.Name = "添加工种";
            treeNode13.Text = "添加工种";
            treeNode14.Name = "浏览工种";
            treeNode14.Text = "浏览工种";
            treeNode15.Name = "节点0";
            treeNode15.Text = "工种设置";
            treeNode16.Name = "添加员工";
            treeNode16.Text = "添加员工";
            treeNode17.Name = "浏览部门";
            treeNode17.Text = "浏览部门";
            treeNode18.Name = "节点3";
            treeNode18.Text = "部门管理";
            treeNode19.Name = "添加员工";
            treeNode19.Text = "添加员工";
            treeNode20.Name = "浏览员工";
            treeNode20.Text = "浏览员工";
            treeNode21.Name = "节点6";
            treeNode21.Text = "员工管理";
            treeNode22.Name = "添加收入";
            treeNode22.Text = "添加收入";
            treeNode23.Name = "浏览收入";
            treeNode23.Text = "浏览收入";
            treeNode24.Name = "节点9";
            treeNode24.Text = "收入管理";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode18,
            treeNode21,
            treeNode24});
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

