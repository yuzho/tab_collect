﻿
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.Entity;
using System.Linq;
using Data;
using Service;
using Data.Domain;
using System.Drawing;

namespace DwGuitar
{
    public partial class Main : Form
    {
        private ICategoryService _categoryService = new CategoryService();
        private ITagService _tagService = new TagService();
        private BlogService _blogService = new BlogService();

        private IList<Category> categories;
        private int categoryTreeViewMouseClicks = 0;

        public Main()
        {
            InitializeComponent();
            InitializeCategoryTree();
        }


        private void InitializeCategoryTree()
        {
            categoriesTreeView.Nodes.Clear();
            categories = _categoryService.GetAllCategories();
            TreeNode root = new TreeNode("分类") { Tag = 0};
            root.Expand();
            categoriesTreeView.Nodes.Add(root);
            CreateChildNode(root, 0);
        }

        private void CreateChildNode(TreeNode parentNode, int parentId)
        {
            //找到该节点下的子项（父节点值等于该节点编号）
            var nodes = from list in categories
                        where list.ParentCategoryId.Equals(parentId)
                        select list;
            //创建该节点子节点
            foreach (var item in nodes)
            {
                TreeNode node = new TreeNode();
                node.Text = item.Name;
                node.Tag = item.CategoryId;

                ////此处可根据节点的parentId来设置图标
                if (item.ParentCategoryId == 0)
                {
                    node.ImageIndex = 1;
                }
                else
                {
                    node.ImageIndex = 2;
                }
                //父节点添加子节点
                parentNode.Nodes.Add(node);
                //调用自身：递归
                CreateChildNode(node, item.CategoryId);
            }
        }

        private void categoriesTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            categoryTreeViewMouseClicks = e.Clicks;
        }

        private void categoriesTreeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (categoryTreeViewMouseClicks > 1)
            {
                //如果是鼠标双击则禁止结点折叠
                e.Cancel = true;
            }
            else
            {
                //如果是鼠标单击则允许结点折叠
                e.Cancel = false;
            }
        }

        private void categoriesTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (categoryTreeViewMouseClicks > 1)
            {
                //如果是鼠标双击则禁止结点展开
                e.Cancel = true;
            }
            else
            {
                //如果是鼠标单击则允许结点展开
                e.Cancel = false;
            }
        }

        private void categoriesTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bool isExist = false;
                foreach(TabPage item in blogTabControl.TabPages)
                {
                    if(item.Text == e.Node.Text)
                    {
                        isExist = true;
                        break;
                    }
                }

                if(isExist)
                {
                    blogTabControl.SelectTab(e.Node.Text);
                }
                else
                {
                    var blogs = _blogService.GetBlogsByCategoryId(Convert.ToInt32(e.Node.Tag));
                    var dataGridView = new BlogDataGridView(blogs);
                    
                    var tabPage = new TabPage(e.Node.Text);
                    tabPage.Name = e.Node.Text;
                    tabPage.Controls.Add(dataGridView);

                    blogTabControl.TabPages.Add(tabPage);
                    blogTabControl.SelectedTab = tabPage;
                }
            }
        }

        private void blogTabControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            blogTabControl.TabPages.RemoveAt(blogTabControl.SelectedIndex);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    toolTip1.Show("搜索内容不能为空", textBox1);
                }

                var searchText = textBox1.Text.Trim();
                var blogs = _blogService.GetBlogsBySearchText(searchText);
                var dataGridView = new BlogDataGridView(blogs);

                var tabPage = new TabPage(searchText);
                tabPage.Name = searchText;
                tabPage.Controls.Add(dataGridView);

                blogTabControl.TabPages.Add(tabPage);
                blogTabControl.SelectedTab = tabPage;
            }
        }
    }
}
