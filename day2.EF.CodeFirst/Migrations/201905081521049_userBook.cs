namespace day2.EF.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userBook : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        AuthorId = c.Int(nullable: false),
                        DesignerId = c.Int(nullable: false),
                        User_id = c.Int(),
                        User_id1 = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.User", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.DesignerId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.User_id)
                .ForeignKey("dbo.User", t => t.User_id1)
                .Index(t => t.AuthorId)
                .Index(t => t.DesignerId)
                .Index(t => t.User_id)
                .Index(t => t.User_id1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "User_id1", "dbo.User");
            DropForeignKey("dbo.Books", "User_id", "dbo.User");
            DropForeignKey("dbo.Books", "DesignerId", "dbo.User");
            DropForeignKey("dbo.Books", "AuthorId", "dbo.User");
            DropIndex("dbo.Books", new[] { "User_id1" });
            DropIndex("dbo.Books", new[] { "User_id" });
            DropIndex("dbo.Books", new[] { "DesignerId" });
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropTable("dbo.Books");
        }
    }
}
