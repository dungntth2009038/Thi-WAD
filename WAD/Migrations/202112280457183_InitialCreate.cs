namespace WAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subject = c.String(),
                        tipo = c.String(),
                        StartTime = c.DateTime(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Duration = c.Int(nullable: false),
                        ClassRoom = c.String(),
                        Faculty = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Exams");
        }
    }
}
