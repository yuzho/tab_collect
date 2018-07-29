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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.blogTabControl = new System.Windows.Forms.TabControl();
            this.categoriesTreeView = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tagTreeView = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(938, 406);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.blogTabControl);
            this.tabPage1.Controls.Add(this.categoriesTreeView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(930, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "按分类";
            // 
            // blogTabControl
            // 
            this.blogTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blogTabControl.Location = new System.Drawing.Point(205, 2);
            this.blogTabControl.Name = "blogTabControl";
            this.blogTabControl.SelectedIndex = 0;
            this.blogTabControl.Size = new System.Drawing.Size(723, 376);
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
            this.categoriesTreeView.Location = new System.Drawing.Point(2, 2);
            this.categoriesTreeView.Name = "categoriesTreeView";
            this.categoriesTreeView.ShowLines = false;
            this.categoriesTreeView.Size = new System.Drawing.Size(203, 376);
            this.categoriesTreeView.TabIndex = 0;
            this.categoriesTreeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.categoriesTreeView_BeforeCollapse);
            this.categoriesTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.categoriesTreeView_BeforeExpand);
            this.categoriesTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.categoriesTreeView_NodeMouseDoubleClick);
            this.categoriesTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.categoriesTreeView_MouseDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tagTreeView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(930, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "按标签";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tagTreeView
            // 
            this.tagTreeView.Location = new System.Drawing.Point(50, 49);
            this.tagTreeView.Name = "tagTreeView";
            this.tagTreeView.Size = new System.Drawing.Size(177, 266);
            this.tagTreeView.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 406);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView categoriesTreeView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView tagTreeView;
        private System.Windows.Forms.TabControl blogTabControl;
    }
}