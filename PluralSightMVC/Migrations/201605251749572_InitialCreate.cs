namespace PluralSightMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Resturants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ResturantReviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rating = c.Int(nullable: false),
                        Body = c.String(),
                        RestaurantId = c.Int(nullable: false),
                        Resturant_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Resturants", t => t.Resturant_Id)
                .Index(t => t.Resturant_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ResturantReviews", "Resturant_Id", "dbo.Resturants");
            DropIndex("dbo.ResturantReviews", new[] { "Resturant_Id" });
            DropTable("dbo.ResturantReviews");
            DropTable("dbo.Resturants");
        }
    }
}
