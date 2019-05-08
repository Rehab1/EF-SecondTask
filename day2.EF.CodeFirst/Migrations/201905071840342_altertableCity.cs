namespace day2.EF.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altertableCity : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Cities", name: "CountryId", newName: "FK_CountryId");
            RenameIndex(table: "dbo.Cities", name: "IX_CountryId", newName: "IX_FK_CountryId");
            AlterColumn("dbo.Cities", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cities", "Name", c => c.String());
            RenameIndex(table: "dbo.Cities", name: "IX_FK_CountryId", newName: "IX_CountryId");
            RenameColumn(table: "dbo.Cities", name: "FK_CountryId", newName: "CountryId");
        }
    }
}
