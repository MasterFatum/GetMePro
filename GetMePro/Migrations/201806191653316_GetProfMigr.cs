namespace GetMePro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GetProfMigr : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Area", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "CategoryWork", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "MiddleName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String());
            DropColumn("dbo.AspNetUsers", "Block");
            DropColumn("dbo.AspNetUsers", "NameWork");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "NameWork", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Block", c => c.String(nullable: false));
            DropColumn("dbo.AspNetUsers", "Phone");
            DropColumn("dbo.AspNetUsers", "MiddleName");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUsers", "CategoryWork");
            DropColumn("dbo.AspNetUsers", "Area");
        }
    }
}
