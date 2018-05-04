namespace InternPortal.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeAnswerIdIdentityColumn : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Answers");
            AlterColumn("dbo.Answers", "AnswerId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Answers", "AnswerId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Answers");
            AlterColumn("dbo.Answers", "AnswerId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Answers", "AnswerId");
        }
    }
}
