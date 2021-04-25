namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBasket1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BasketItems", "Quanity", c => c.Int(nullable: false));
            DropColumn("dbo.BasketItems", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BasketItems", "Quantity", c => c.Int(nullable: false));
            DropColumn("dbo.BasketItems", "Quanity");
        }
    }
}
