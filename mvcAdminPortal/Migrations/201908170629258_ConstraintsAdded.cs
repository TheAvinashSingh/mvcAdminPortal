namespace mvcAdminPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConstraintsAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "ProductDescription", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ProductDescription", c => c.String(nullable: false));
        }
    }
}
