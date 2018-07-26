namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CategoryBlogs", "Blog_BlogId", "dbo.Blogs");
            DropForeignKey("dbo.TagBlogs", "Blog_BlogId", "dbo.Blogs");
            DropForeignKey("dbo.Blogs", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.CategoryBlogs", "Category_CategoryId", "dbo.Categories");
            DropForeignKey("dbo.TagBlogs", "Tag_TagId", "dbo.Tags");
            DropPrimaryKey("dbo.Blogs");
            DropPrimaryKey("dbo.Authors");
            DropPrimaryKey("dbo.Categories");
            DropPrimaryKey("dbo.Tags");
            AlterColumn("dbo.Blogs", "BlogId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Authors", "AuthorId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Categories", "CategoryId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Tags", "TagId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Blogs", "BlogId");
            AddPrimaryKey("dbo.Authors", "AuthorId");
            AddPrimaryKey("dbo.Categories", "CategoryId");
            AddPrimaryKey("dbo.Tags", "TagId");
            AddForeignKey("dbo.CategoryBlogs", "Blog_BlogId", "dbo.Blogs", "BlogId", cascadeDelete: true);
            AddForeignKey("dbo.TagBlogs", "Blog_BlogId", "dbo.Blogs", "BlogId", cascadeDelete: true);
            AddForeignKey("dbo.Blogs", "AuthorId", "dbo.Authors", "AuthorId", cascadeDelete: true);
            AddForeignKey("dbo.CategoryBlogs", "Category_CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
            AddForeignKey("dbo.TagBlogs", "Tag_TagId", "dbo.Tags", "TagId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TagBlogs", "Tag_TagId", "dbo.Tags");
            DropForeignKey("dbo.CategoryBlogs", "Category_CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Blogs", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.TagBlogs", "Blog_BlogId", "dbo.Blogs");
            DropForeignKey("dbo.CategoryBlogs", "Blog_BlogId", "dbo.Blogs");
            DropPrimaryKey("dbo.Tags");
            DropPrimaryKey("dbo.Categories");
            DropPrimaryKey("dbo.Authors");
            DropPrimaryKey("dbo.Blogs");
            AlterColumn("dbo.Tags", "TagId", c => c.Int(nullable: false));
            AlterColumn("dbo.Categories", "CategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Authors", "AuthorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Blogs", "BlogId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Tags", "TagId");
            AddPrimaryKey("dbo.Categories", "CategoryId");
            AddPrimaryKey("dbo.Authors", "AuthorId");
            AddPrimaryKey("dbo.Blogs", "BlogId");
            AddForeignKey("dbo.TagBlogs", "Tag_TagId", "dbo.Tags", "TagId", cascadeDelete: true);
            AddForeignKey("dbo.CategoryBlogs", "Category_CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
            AddForeignKey("dbo.Blogs", "AuthorId", "dbo.Authors", "AuthorId", cascadeDelete: true);
            AddForeignKey("dbo.TagBlogs", "Blog_BlogId", "dbo.Blogs", "BlogId", cascadeDelete: true);
            AddForeignKey("dbo.CategoryBlogs", "Blog_BlogId", "dbo.Blogs", "BlogId", cascadeDelete: true);
        }
    }
}
