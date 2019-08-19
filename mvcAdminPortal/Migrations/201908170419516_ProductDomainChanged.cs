namespace mvcAdminPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductDomainChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductPrice", c => c.Single(nullable: false));
            AddColumn("dbo.Products", "ProductDescription", c => c.String());
            AddColumn("dbo.Products", "ProductImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProductImage");
            DropColumn("dbo.Products", "ProductDescription");
            DropColumn("dbo.Products", "ProductPrice");
        }
    }
}
