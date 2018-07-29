namespace DwGuitar
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.blogTabControl = new System.Windows.Forms.TabControl();
            this.categoriesTreeView = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // blogTabControl
            // 
            this.blogTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blogTabControl.Location = new System.Drawing.Point(177, 36);
            this.blogTabControl.Name = "blogTabControl";
            this.blogTabControl.SelectedIndex = 0;
            this.blogTabControl.Size = new System.Drawing.Size(423, 370);
            this.blogTabControl.TabIndex = 1;
            this.blogTabControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.blogTabControl_MouseDoubleClick);
            // 
            // categoriesTreeView
            // 
            this.categoriesTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoriesTreeView.FullRowSelect = true;
            this.categoriesTreeView.HotTracking = true;
            this.categoriesTreeView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.categoriesTreeView.Indent = 15;
            this.categoriesTreeView.ItemHeight = 20;
            this.categoriesTreeView.Location = new System.Drawing.Point(0, 0);
            this.categoriesTreeView.Name = "categoriesTreeView";
            this.categoriesTreeView.ShowLines = false;
            this.categoriesTreeView.Size = new System.Drawing.Size(177, 406);
            this.categoriesTreeView.TabIndex = 0;
            this.categoriesTreeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.categoriesTreeView_BeforeCollapse);
            this.categoriesTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.categoriesTreeView_BeforeExpand);
            this.categoriesTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.categoriesTreeView_NodeMouseDoubleClick);
            this.categoriesTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.categoriesTreeView_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(177, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 36);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(278, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "搜索";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 406);
            this.Controls.Add(this.blogTabControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.categoriesTreeView);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Main";
            this.Text = "kiao谱";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView categoriesTreeView;
        private System.Windows.Forms.TabControl blogTabControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}