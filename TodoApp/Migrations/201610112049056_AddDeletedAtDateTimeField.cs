namespace ConsoleApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDeletedAtDateTimeField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "deletedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "deletedAt");
        }
    }
}
