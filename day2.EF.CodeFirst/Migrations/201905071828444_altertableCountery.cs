namespace day2.EF.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altertableCountery : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Countries", newName: "Country");
            AlterColumn("dbo.Country", "Name", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Country", "Name", c => c.String());
            RenameTable(name: "dbo.Country", newName: "Countries");
        }
    }
}
