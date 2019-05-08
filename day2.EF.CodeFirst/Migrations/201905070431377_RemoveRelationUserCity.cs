namespace day2.EF.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveRelationUserCity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserCities", "User_id", "dbo.Users");
            DropForeignKey("dbo.UserCities", "City_id", "dbo.Cities");
            DropIndex("dbo.UserCities", new[] { "User_id" });
            DropIndex("dbo.UserCities", new[] { "City_id" });
            DropTable("dbo.UserCities");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserCities",
                c => new
                    {
                        User_id = c.Int(nullable: false),
                        City_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_id, t.City_id });
            
            CreateIndex("dbo.UserCities", "City_id");
            CreateIndex("dbo.UserCities", "User_id");
            AddForeignKey("dbo.UserCities", "City_id", "dbo.Cities", "id", cascadeDelete: true);
            AddForeignKey("dbo.UserCities", "User_id", "dbo.Users", "id", cascadeDelete: true);
        }
    }
}
