namespace GtaosSql
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            开始ToolStripMenuItem = new ToolStripMenuItem();
            新建ToolStripMenuItem = new ToolStripMenuItem();
            退出ToolStripMenuItem = new ToolStripMenuItem();
            关于ToolStripMenuItem = new ToolStripMenuItem();
            说明ToolStripMenuItem = new ToolStripMenuItem();
            treeView1 = new TreeView();
            dataGridView1 = new DataGridView();
            richTextBox_sql = new RichTextBox();
            richTextBox_output = new RichTextBox();
            label_list = new Label();
            label_tableinfo = new Label();
            label_sql = new Label();
            label_output = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 开始ToolStripMenuItem, 关于ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(927, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 开始ToolStripMenuItem
            // 
            开始ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 新建ToolStripMenuItem, 退出ToolStripMenuItem });
            开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            开始ToolStripMenuItem.Size = new Size(44, 21);
            开始ToolStripMenuItem.Text = "开始";
            // 
            // 新建ToolStripMenuItem
            // 
            新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            新建ToolStripMenuItem.Size = new Size(100, 22);
            新建ToolStripMenuItem.Text = "新建";
            新建ToolStripMenuItem.Click += 新建ToolStripMenuItem_Click;
            // 
            // 退出ToolStripMenuItem
            // 
            退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            退出ToolStripMenuItem.Size = new Size(100, 22);
            退出ToolStripMenuItem.Text = "退出";
            退出ToolStripMenuItem.Click += 退出ToolStripMenuItem_Click;
            // 
            // 关于ToolStripMenuItem
            // 
            关于ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 说明ToolStripMenuItem });
            关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            关于ToolStripMenuItem.Size = new Size(44, 21);
            关于ToolStripMenuItem.Text = "关于";
            // 
            // 说明ToolStripMenuItem
            // 
            说明ToolStripMenuItem.Name = "说明ToolStripMenuItem";
            说明ToolStripMenuItem.Size = new Size(100, 22);
            说明ToolStripMenuItem.Text = "说明";
            说明ToolStripMenuItem.Click += 说明ToolStripMenuItem_Click;
            // 
            // treeView1
            // 
            treeView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            treeView1.Location = new Point(12, 45);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(184, 327);
            treeView1.TabIndex = 1;
            treeView1.NodeMouseDoubleClick += TreeView1_NodeMouseDoubleClick;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(202, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(713, 327);
            dataGridView1.TabIndex = 2;
            // 
            // richTextBox_sql
            // 
            richTextBox_sql.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox_sql.Location = new Point(12, 396);
            richTextBox_sql.Name = "richTextBox_sql";
            richTextBox_sql.Size = new Size(903, 65);
            richTextBox_sql.TabIndex = 5;
            richTextBox_sql.Text = "";
            // 
            // richTextBox_output
            // 
            richTextBox_output.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox_output.Location = new Point(12, 484);
            richTextBox_output.Name = "richTextBox_output";
            richTextBox_output.ReadOnly = true;
            richTextBox_output.Size = new Size(903, 73);
            richTextBox_output.TabIndex = 6;
            richTextBox_output.Text = "";
            // 
            // label_list
            // 
            label_list.AutoSize = true;
            label_list.Location = new Point(12, 25);
            label_list.Name = "label_list";
            label_list.Size = new Size(91, 17);
            label_list.TabIndex = 7;
            label_list.Text = "Mysql连接列表";
            // 
            // label_tableinfo
            // 
            label_tableinfo.AutoSize = true;
            label_tableinfo.Location = new Point(202, 25);
            label_tableinfo.Name = "label_tableinfo";
            label_tableinfo.Size = new Size(56, 17);
            label_tableinfo.TabIndex = 8;
            label_tableinfo.Text = "表格信息";
            // 
            // label_sql
            // 
            label_sql.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_sql.AutoSize = true;
            label_sql.Location = new Point(12, 375);
            label_sql.Name = "label_sql";
            label_sql.Size = new Size(55, 17);
            label_sql.TabIndex = 9;
            label_sql.Text = "SQL语句";
            // 
            // label_output
            // 
            label_output.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_output.AutoSize = true;
            label_output.Location = new Point(12, 464);
            label_output.Name = "label_output";
            label_output.Size = new Size(32, 17);
            label_output.TabIndex = 10;
            label_output.Text = "输出";
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 569);
            Controls.Add(label_output);
            Controls.Add(label_sql);
            Controls.Add(label_tableinfo);
            Controls.Add(label_list);
            Controls.Add(richTextBox_output);
            Controls.Add(richTextBox_sql);
            Controls.Add(dataGridView1);
            Controls.Add(treeView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Window";
            Text = "GTAOS.COM简易数据库查询软件";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 开始ToolStripMenuItem;
        private ToolStripMenuItem 新建ToolStripMenuItem;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private ToolStripMenuItem 关于ToolStripMenuItem;
        private ToolStripMenuItem 说明ToolStripMenuItem;
        private TreeView treeView1;
        private DataGridView dataGridView1;
        private RichTextBox richTextBox_sql;
        private RichTextBox richTextBox_output;
        private Label label_list;
        private Label label_tableinfo;
        private Label label_sql;
        private Label label_output;
    }
}