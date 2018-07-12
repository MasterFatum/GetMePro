namespace GetMePro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GetMeProf2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CreateDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "CreateDate");
        }
    }
}
