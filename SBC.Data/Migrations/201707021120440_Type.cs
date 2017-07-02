namespace SBC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Type : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MstType",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        RawID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.RecordID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MstType");
        }
    }
}
