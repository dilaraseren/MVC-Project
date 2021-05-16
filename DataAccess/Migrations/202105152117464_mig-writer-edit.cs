namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migwriteredit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterName", c => c.String(maxLength: 50));
            AddColumn("dbo.Writers", "About", c => c.String(maxLength: 100));
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 200));
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 200));
            DropColumn("dbo.Writers", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Writers", "UserName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 20));
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 50));
            DropColumn("dbo.Writers", "About");
            DropColumn("dbo.Writers", "WriterName");
        }
    }
}
