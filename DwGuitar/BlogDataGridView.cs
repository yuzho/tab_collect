using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using Data.Domain;

namespace DwGuitar
{
    public partial class BlogDataGridView : UserControl
    {
        private IBlogService _blogService = new BlogService();

        public BlogDataGridView(IList<Blog> blogs)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            InitializeDataGridView(blogs);
        }

        private void InitializeDataGridView(IList<Blog> blogs)
        {
            int count = 1; //自增序号
            blogGridView.AutoGenerateColumns = false;
            blogGridView.DataSource = blogs.Select(b => new {
                Num = count++,
                Title = b.Title,
                Code = b.Code,
                Tags = string.Join(",", b.Tags.Select(t => t.Name))
            }).ToList();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    blogGridView.ClearSelection();
                    blogGridView.Rows[e.RowIndex].Selected = true;
                    blogGridView.CurrentCell = blogGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                }
            }
        }

        private void dataGridView1_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            //string tags = ((dynamic)blogGridView.Rows[e.RowIndex].DataBoundItem).Tags;
            //if (!string.IsNullOrWhiteSpace(tags))
            //{
            //    var tagContextMenuStrip = new ContextMenuStrip();
            //    tagContextMenuStrip.Items.Add(new ToolStripMenuItem("标签") { Enabled = false });
            //    tagContextMenuStrip.Items.Add(new ToolStripSeparator());
            //    foreach (var tag in tags.Split(','))
            //    {
            //        ToolStripMenuItem item = new ToolStripMenuItem(tag);
            //        tagContextMenuStrip.Items.Add(item);
            //    }
               
            //    e.ContextMenuStrip = tagContextMenuStrip;
            //}
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string blogCode = ((dynamic)blogGridView.Rows[e.RowIndex].DataBoundItem).Code;
            string title = ((dynamic)blogGridView.Rows[e.RowIndex].DataBoundItem).Title;
            new TabPictureView(blogCode, title).Show();
        }
    }
}
