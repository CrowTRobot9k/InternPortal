namespace InternPortal.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeAnswerValueAndOptionValueOptional : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Answers", "AnswerValue", c => c.String(unicode: false));
            AlterColumn("dbo.Answers", "OptionValue", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Answers", "OptionValue", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Answers", "AnswerValue", c => c.String(nullable: false, unicode: false));
        }
    }
}
