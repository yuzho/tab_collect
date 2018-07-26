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

namespace DwGuitar
{
    public partial class BlogDataGridView : UserControl
    {
        private IBlogService _blogService = new BlogService();

        public BlogDataGridView(int categoryId)
        {
            InitializeComponent();
            InitializeDataGridView(categoryId);
        }

        private void InitializeDataGridView(int categoryId)
        {
            int count = 1; //自增序号
            var blogs = _blogService.GetBlogsByCategoryId(categoryId);
            
            blogGridView.AutoGenerateColumns = false;
            blogGridView.DataSource = blogs.Select(b => new {
                Num = count++,
                Title = b.Title,
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
            string tags = ((dynamic)blogGridView.Rows[e.RowIndex].DataBoundItem).Tags;
            if (!string.IsNullOrWhiteSpace(tags))
            {
                var tagContextMenuStrip = new ContextMenuStrip();
                tagContextMenuStrip.Items.Add(new ToolStripMenuItem("标签") { Enabled = false });
                tagContextMenuStrip.Items.Add(new ToolStripSeparator());
                foreach (var tag in tags.Split(','))
                {
                    ToolStripMenuItem item = new ToolStripMenuItem(tag);
                    tagContextMenuStrip.Items.Add(item);
                }
                e.ContextMenuStrip = tagContextMenuStrip;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("弹出图片浏览");
        }
    }
}
