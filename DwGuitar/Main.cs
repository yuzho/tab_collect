
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.Entity;
using System.Linq;
using Data;
using Service;
using Data.Domain;

namespace DwGuitar
{
    public partial class Main : Form
    {
        private ICategoryService _categoryService = new CategoryService();
        private ITagService _tagService = new TagService();
        private IList<Category> categories;

        public Main()
        {
            InitializeComponent();
            InitializeCategoryTree();
            InitializeTagPanel();
        }

        
        public void InitializeCategoryTree()
        {
            categoriesTreeView.Nodes.Clear();
            categories = _categoryService.GetAllCategories();
            TreeNode root = new TreeNode("全部") { Tag = 0 };
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

        public void InitializeTagPanel()
        {
            tagTreeView.Nodes.Clear();
            foreach (var item in _tagService.GetAllTags())
            {
                TreeNode tn = new TreeNode(item.Name);
                tn.Tag = item.TagId;
                tagTreeView.Nodes.Add(item.Name);
            }
        }
    }
}
