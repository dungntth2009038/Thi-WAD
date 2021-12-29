namespace WAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateExam : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Exams", "tipo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Exams", "tipo", c => c.String());
        }
    }
}
