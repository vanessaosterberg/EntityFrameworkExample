namespace EntityFrameworkExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Box : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boxes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Width = c.Double(nullable: false),
                        Height = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Barrels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Barrels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Radius = c.Double(nullable: false),
                        Height = c.Double(nullable: false),
                        ConstructionMaterial = c.String(),
                        Contents = c.String(),
                        CurrentLocation = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Boxes");
        }
    }
}
