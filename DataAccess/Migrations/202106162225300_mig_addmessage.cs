namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_addmessage : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Messages", "IsDraft");
            DropColumn("dbo.Messages", "IsRead");
            DropColumn("dbo.Messages", "Trash");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "Trash", c => c.Boolean(nullable: false));
            AddColumn("dbo.Messages", "IsRead", c => c.Boolean(nullable: false));
            AddColumn("dbo.Messages", "IsDraft", c => c.Boolean(nullable: false));
        }
    }
}
