namespace day2.EF.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationUserCity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserCities",
                c => new
                    {
                        User_id = c.Int(nullable: false),
                        City_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_id, t.City_id })
                .ForeignKey("dbo.Users", t => t.User_id, cascadeDelete: true)
                .ForeignKey("dbo.Cities", t => t.City_id, cascadeDelete: true)
                .Index(t => t.User_id)
                .Index(t => t.City_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserCities", "City_id", "dbo.Cities");
            DropForeignKey("dbo.UserCities", "User_id", "dbo.Users");
            DropIndex("dbo.UserCities", new[] { "City_id" });
            DropIndex("dbo.UserCities", new[] { "User_id" });
            DropTable("dbo.UserCities");
        }
    }
}
