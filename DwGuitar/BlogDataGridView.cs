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
        private int categoryId;

        public BlogDataGridView(int categoryId)
        {
            InitializeComponent();

            this.categoryId = categoryId;
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            int count = 1; //自增序号
            var blogs = _blogService.GetBlogsByCategoryId(categoryId);
            
            //dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = blogs.Select(b => new {
                Num = count++,
                Title = b.Title,
                Tags = b.Tags.Select(t => t.Name)
            }).ToList();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("弹出图片浏览");
        }

        private void dataGridView1_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {

        }
    }
}
