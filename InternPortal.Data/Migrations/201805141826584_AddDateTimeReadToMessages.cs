namespace InternPortal.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateTimeReadToMessages : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Message", "UserIdFrom", "dbo.User");
            DropForeignKey("dbo.Message", "UserIdTo", "dbo.User");
            DropIndex("dbo.Message", new[] { "UserIdFrom" });
            DropIndex("dbo.Message", new[] { "UserIdTo" });
            AddColumn("dbo.Application", "ApplicationStatus", c => c.Int());
            AddColumn("dbo.Message", "DateTimeRead", c => c.DateTime());
            AlterColumn("dbo.Message", "UserIdFrom", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Message", "UserIdTo", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Message", "UserIdFrom");
            CreateIndex("dbo.Message", "UserIdTo");
            AddForeignKey("dbo.Message", "UserIdFrom", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Message", "UserIdTo", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Message", "UserIdTo", "dbo.AspNetUsers");
            DropForeignKey("dbo.Message", "UserIdFrom", "dbo.AspNetUsers");
            DropIndex("dbo.Message", new[] { "UserIdTo" });
            DropIndex("dbo.Message", new[] { "UserIdFrom" });
            AlterColumn("dbo.Message", "UserIdTo", c => c.Int(nullable: false));
            AlterColumn("dbo.Message", "UserIdFrom", c => c.Int(nullable: false));
            DropColumn("dbo.Message", "DateTimeRead");
            DropColumn("dbo.Application", "ApplicationStatus");
            CreateIndex("dbo.Message", "UserIdTo");
            CreateIndex("dbo.Message", "UserIdFrom");
            AddForeignKey("dbo.Message", "UserIdTo", "dbo.User", "UserId");
            AddForeignKey("dbo.Message", "UserIdFrom", "dbo.User", "UserId");
        }
    }
}
