namespace day2.EF.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationsCityCountry : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "country_id", c => c.Int());
            CreateIndex("dbo.Cities", "country_id");
            AddForeignKey("dbo.Cities", "country_id", "dbo.Countries", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "country_id", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "country_id" });
            DropColumn("dbo.Cities", "country_id");
        }
    }
}
