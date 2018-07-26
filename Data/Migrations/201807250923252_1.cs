namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogId = c.Int(nullable: false),
                        Code = c.String(nullable: false),
                        Title = c.String(nullable: false),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BlogId)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Avatar = c.String(),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false),
                        ParentCategoryId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        TagId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TagId);
            
            CreateTable(
                "dbo.CategoryBlogs",
                c => new
                    {
                        Category_CategoryId = c.Int(nullable: false),
                        Blog_BlogId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Category_CategoryId, t.Blog_BlogId })
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Blogs", t => t.Blog_BlogId, cascadeDelete: true)
                .Index(t => t.Category_CategoryId)
                .Index(t => t.Blog_BlogId);
            
            CreateTable(
                "dbo.TagBlogs",
                c => new
                    {
                        Tag_TagId = c.Int(nullable: false),
                        Blog_BlogId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_TagId, t.Blog_BlogId })
                .ForeignKey("dbo.Tags", t => t.Tag_TagId, cascadeDelete: true)
                .ForeignKey("dbo.Blogs", t => t.Blog_BlogId, cascadeDelete: true)
                .Index(t => t.Tag_TagId)
                .Index(t => t.Blog_BlogId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TagBlogs", "Blog_BlogId", "dbo.Blogs");
            DropForeignKey("dbo.TagBlogs", "Tag_TagId", "dbo.Tags");
            DropForeignKey("dbo.CategoryBlogs", "Blog_BlogId", "dbo.Blogs");
            DropForeignKey("dbo.CategoryBlogs", "Category_CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Blogs", "AuthorId", "dbo.Authors");
            DropIndex("dbo.TagBlogs", new[] { "Blog_BlogId" });
            DropIndex("dbo.TagBlogs", new[] { "Tag_TagId" });
            DropIndex("dbo.CategoryBlogs", new[] { "Blog_BlogId" });
            DropIndex("dbo.CategoryBlogs", new[] { "Category_CategoryId" });
            DropIndex("dbo.Blogs", new[] { "AuthorId" });
            DropTable("dbo.TagBlogs");
            DropTable("dbo.CategoryBlogs");
            DropTable("dbo.Tags");
            DropTable("dbo.Categories");
            DropTable("dbo.Authors");
            DropTable("dbo.Blogs");
        }
    }
}
