namespace InternPortal.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixApplicationForeignKeyName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Answers", newName: "Answer");
            RenameTable(name: "dbo.Messages", newName: "Message");
            RenameTable(name: "dbo.UserUploads", newName: "UserUpload");
            RenameTable(name: "dbo.QuestionOptions", newName: "QuestionOption");
            RenameTable(name: "dbo.QuestionTypes", newName: "QuestionType");
            RenameColumn(table: "dbo.Application", name: "ApplicationStatus", newName: "ApplicationStatusId");
            RenameIndex(table: "dbo.Application", name: "IX_ApplicationStatus", newName: "IX_ApplicationStatusId");
            CreateTable(
                "dbo.Note",
                c => new
                    {
                        NoteId = c.Int(nullable: false, identity: true),
                        ApplicationId = c.Int(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 128),
                        Note = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.NoteId)
                .ForeignKey("dbo.Application", t => t.ApplicationId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.ApplicationId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Note", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Note", "ApplicationId", "dbo.Application");
            DropIndex("dbo.Note", new[] { "UserId" });
            DropIndex("dbo.Note", new[] { "ApplicationId" });
            DropTable("dbo.Note");
            RenameIndex(table: "dbo.Application", name: "IX_ApplicationStatusId", newName: "IX_ApplicationStatus");
            RenameColumn(table: "dbo.Application", name: "ApplicationStatusId", newName: "ApplicationStatus");
            RenameTable(name: "dbo.QuestionType", newName: "QuestionTypes");
            RenameTable(name: "dbo.QuestionOption", newName: "QuestionOptions");
            RenameTable(name: "dbo.UserUpload", newName: "UserUploads");
            RenameTable(name: "dbo.Message", newName: "Messages");
            RenameTable(name: "dbo.Answer", newName: "Answers");
        }
    }
}
