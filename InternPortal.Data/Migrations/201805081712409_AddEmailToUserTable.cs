namespace InternPortal.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailToUserTable : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.UserUploads");
            AddColumn("dbo.User", "Email", c => c.String(maxLength: 100));
            AlterColumn("dbo.UserUploads", "UploadId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.UserUploads", "UploadId");
            CreateIndex("dbo.Application", "ApplicationStatus");
            AddForeignKey("dbo.Application", "ApplicationStatus", "dbo.ApplicationStatus", "ApplicationStatusId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Application", "ApplicationStatus", "dbo.ApplicationStatus");
            DropIndex("dbo.Application", new[] { "ApplicationStatus" });
            DropPrimaryKey("dbo.UserUploads");
            AlterColumn("dbo.UserUploads", "UploadId", c => c.Int(nullable: false));
            DropColumn("dbo.User", "Email");
            AddPrimaryKey("dbo.UserUploads", "UploadId");
        }
    }
}
