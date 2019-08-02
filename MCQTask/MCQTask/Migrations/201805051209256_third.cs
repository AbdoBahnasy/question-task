namespace MCQTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Answers", "is_Correct", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Answers", "is_Correct", c => c.Boolean(nullable: false));
        }
    }
}
