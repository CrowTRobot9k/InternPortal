namespace InternPortal.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixApplicationStatus : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Note", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Note", new[] { "UserId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Note", "UserId");
            AddForeignKey("dbo.Note", "UserId", "dbo.AspNetUsers", "Id");
        }
    }
}
