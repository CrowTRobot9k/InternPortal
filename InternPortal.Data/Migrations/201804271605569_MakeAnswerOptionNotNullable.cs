namespace InternPortal.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeAnswerOptionNotNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Answers", "OptionValue", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Answers", "OptionValue", c => c.Boolean());
        }
    }
}
