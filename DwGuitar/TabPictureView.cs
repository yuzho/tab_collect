using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DwGuitar
{
    public partial class TabPictureView : Form
    {
        private IBlogService _blogService = new BlogService();

        private string blogTitle;
        private List<Image> tabs = new List<Image>();
        private int currentPage;
        private int totalPage;

        public TabPictureView(string blogCode, string title)
        {
            InitializeComponent();
            InitializeTabs(blogCode, title);
        }

        private void InitializeTabs(string blogCode, string title)
        {
            this.blogTitle = title;

            var files =
                new DirectoryInfo(Path.Combine(Application.StartupPath, "tab"))
                ?.GetDirectories()
                ?.Where(item => item.Name == blogCode)
                ?.FirstOrDefault()
                ?.GetFiles()
                ?.Select(item => item.FullName);

            
            foreach (var file in files)
            {
                var image = Image.FromFile(file);
                tabs.Add(image);
            }

            this.Text = title;
            if (tabs.Count != 0)
            {
                totalPage = tabs.Count;
                currentPage = 0;
                this.Text = $"{blogTitle}（ {currentPage + 1} / {totalPage} ）";
                pictureBox1.Image = tabs[currentPage];
            }
        }

        private void TabPictureView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                currentPage--;
                if(currentPage <= 0)
                {
                    currentPage = totalPage - 1;
                }
                this.Text = $"{blogTitle}（ {currentPage + 1} / {totalPage} ）";
                pictureBox1.Image = tabs[currentPage];
            }
            else if(e.KeyCode == Keys.Right)
            {
                currentPage++;
                if (currentPage >= totalPage)
                {
                    currentPage = 0;
                }
                this.Text = $"{blogTitle}（ {currentPage + 1} / {totalPage} ）";
                pictureBox1.Image = tabs[currentPage];
            }
        }
    }
}
