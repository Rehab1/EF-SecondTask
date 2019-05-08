namespace day2.EF.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uservistupdateu : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cities", newName: "City");
            CreateTable(
                "dbo.UserVist",
                c => new
                    {
                        FK_UserId = c.Int(nullable: false),
                        FK_CityId = c.Int(nullable: false),
                        when = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.FK_UserId, t.FK_CityId })
                .ForeignKey("dbo.City", t => t.FK_CityId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.FK_UserId, cascadeDelete: true)
                .Index(t => t.FK_UserId)
                .Index(t => t.FK_CityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserVist", "FK_UserId", "dbo.User");
            DropForeignKey("dbo.UserVist", "FK_CityId", "dbo.City");
            DropIndex("dbo.UserVist", new[] { "FK_CityId" });
            DropIndex("dbo.UserVist", new[] { "FK_UserId" });
            DropTable("dbo.UserVist");
            RenameTable(name: "dbo.City", newName: "Cities");
        }
    }
}
