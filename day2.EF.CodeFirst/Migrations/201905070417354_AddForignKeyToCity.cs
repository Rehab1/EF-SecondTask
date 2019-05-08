namespace day2.EF.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForignKeyToCity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cities", "country_id", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "country_id" });
            RenameColumn(table: "dbo.Cities", name: "country_id", newName: "CountryId");
            AlterColumn("dbo.Cities", "CountryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cities", "CountryId");
            AddForeignKey("dbo.Cities", "CountryId", "dbo.Countries", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "CountryId" });
            AlterColumn("dbo.Cities", "CountryId", c => c.Int());
            RenameColumn(table: "dbo.Cities", name: "CountryId", newName: "country_id");
            CreateIndex("dbo.Cities", "country_id");
            AddForeignKey("dbo.Cities", "country_id", "dbo.Countries", "id");
        }
    }
}
