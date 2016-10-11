namespace ConsoleApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        /// <summary>
        /// Migrate the database up.
        /// </summary>
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Todoes",
                c => new
                    {
                        TodoId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TodoId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
        }
        
        /// <summary>
        /// Roll the database back.
        /// </summary>
        public override void Down()
        {
            this.DropForeignKey("dbo.Todoes", "CategoryId", "dbo.Categories");
            this.DropIndex("dbo.Todoes", new[] { "CategoryId" });
            this.DropTable("dbo.Todoes");
            this.DropTable("dbo.Categories");
        }
    }
}
