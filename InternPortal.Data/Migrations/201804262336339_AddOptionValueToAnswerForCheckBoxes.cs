namespace InternPortal.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOptionValueToAnswerForCheckBoxes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Answers", "OptionValue", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Answers", "OptionValue");
        }
    }
}
