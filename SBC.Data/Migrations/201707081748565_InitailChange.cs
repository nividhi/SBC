namespace SBC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitailChange : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MstAccount",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        Address1 = c.String(nullable: false),
                        Address2 = c.String(),
                        CountryID = c.Int(nullable: false),
                        StateID = c.Int(nullable: false),
                        CityID = c.Int(nullable: false),
                        PinCode = c.Int(nullable: false),
                        AccountTypeID = c.Int(nullable: false),
                        GSTIN = c.String(),
                        RegistrationDate = c.DateTime(nullable: false),
                        RawID = c.Guid(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedBy = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RecordID)
                .ForeignKey("dbo.MstAccountType", t => t.AccountTypeID, cascadeDelete: true)
                .ForeignKey("dbo.MstCity", t => t.CityID, cascadeDelete: true)
                .ForeignKey("dbo.MstCountry", t => t.CountryID, cascadeDelete: true)
                .ForeignKey("dbo.MstState", t => t.StateID, cascadeDelete: true)
                .Index(t => t.CountryID)
                .Index(t => t.StateID)
                .Index(t => t.CityID)
                .Index(t => t.AccountTypeID);
            
            CreateTable(
                "dbo.MstAccountType",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        RawID = c.Guid(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedBy = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RecordID);
            
            CreateTable(
                "dbo.MstCity",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CityCode = c.Int(nullable: false),
                        CountryID = c.Int(nullable: false),
                        StateID = c.Int(nullable: false),
                        RawID = c.Guid(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedBy = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RecordID)
                .ForeignKey("dbo.MstCountry", t => t.CountryID, cascadeDelete: false)
                .ForeignKey("dbo.MstState", t => t.StateID, cascadeDelete: false)
                .Index(t => t.CountryID)
                .Index(t => t.StateID);
            
            CreateTable(
                "dbo.MstCountry",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        RawID = c.Guid(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedBy = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RecordID);
            
            CreateTable(
                "dbo.MstState",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        StateCode = c.Int(nullable: false),
                        CountryID = c.Int(nullable: false),
                        RawID = c.Guid(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedBy = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RecordID)
                .ForeignKey("dbo.MstCountry", t => t.CountryID, cascadeDelete: false)
                .Index(t => t.CountryID);
            
            CreateTable(
                "dbo.MstItem",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        ItemCode = c.String(nullable: false),
                        Gram = c.Single(nullable: false),
                        RawID = c.Guid(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedBy = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RecordID)
                .ForeignKey("dbo.MstProduct", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.MstProduct",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        ProductCode = c.String(nullable: false),
                        HSNCODE = c.Int(nullable: false),
                        TypeID = c.Int(nullable: false),
                        PurityID = c.Int(nullable: false),
                        RawID = c.Guid(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedBy = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RecordID)
                .ForeignKey("dbo.MstPurity", t => t.PurityID, cascadeDelete: false)
                .ForeignKey("dbo.MstType", t => t.TypeID, cascadeDelete: true)
                .Index(t => t.TypeID)
                .Index(t => t.PurityID);
            
            CreateTable(
                "dbo.MstPurity",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        PurityValue = c.Single(nullable: false),
                        TypeID = c.Int(nullable: false),
                        RawID = c.Guid(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedBy = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RecordID)
                .ForeignKey("dbo.MstType", t => t.TypeID, cascadeDelete: true)
                .Index(t => t.TypeID);
            
            AddColumn("dbo.MstType", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.MstType", "CreatedBy", c => c.Guid(nullable: false));
            AddColumn("dbo.MstType", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.MstType", "ModifiedBy", c => c.Guid(nullable: false));
            AddColumn("dbo.MstType", "ModifiedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MstItem", "ProductID", "dbo.MstProduct");
            DropForeignKey("dbo.MstProduct", "TypeID", "dbo.MstType");
            DropForeignKey("dbo.MstProduct", "PurityID", "dbo.MstPurity");
            DropForeignKey("dbo.MstPurity", "TypeID", "dbo.MstType");
            DropForeignKey("dbo.MstAccount", "StateID", "dbo.MstState");
            DropForeignKey("dbo.MstAccount", "CountryID", "dbo.MstCountry");
            DropForeignKey("dbo.MstAccount", "CityID", "dbo.MstCity");
            DropForeignKey("dbo.MstCity", "StateID", "dbo.MstState");
            DropForeignKey("dbo.MstState", "CountryID", "dbo.MstCountry");
            DropForeignKey("dbo.MstCity", "CountryID", "dbo.MstCountry");
            DropForeignKey("dbo.MstAccount", "AccountTypeID", "dbo.MstAccountType");
            DropIndex("dbo.MstPurity", new[] { "TypeID" });
            DropIndex("dbo.MstProduct", new[] { "PurityID" });
            DropIndex("dbo.MstProduct", new[] { "TypeID" });
            DropIndex("dbo.MstItem", new[] { "ProductID" });
            DropIndex("dbo.MstState", new[] { "CountryID" });
            DropIndex("dbo.MstCity", new[] { "StateID" });
            DropIndex("dbo.MstCity", new[] { "CountryID" });
            DropIndex("dbo.MstAccount", new[] { "AccountTypeID" });
            DropIndex("dbo.MstAccount", new[] { "CityID" });
            DropIndex("dbo.MstAccount", new[] { "StateID" });
            DropIndex("dbo.MstAccount", new[] { "CountryID" });
            DropColumn("dbo.MstType", "ModifiedDate");
            DropColumn("dbo.MstType", "ModifiedBy");
            DropColumn("dbo.MstType", "CreatedDate");
            DropColumn("dbo.MstType", "CreatedBy");
            DropColumn("dbo.MstType", "IsActive");
            DropTable("dbo.MstPurity");
            DropTable("dbo.MstProduct");
            DropTable("dbo.MstItem");
            DropTable("dbo.MstState");
            DropTable("dbo.MstCountry");
            DropTable("dbo.MstCity");
            DropTable("dbo.MstAccountType");
            DropTable("dbo.MstAccount");
        }
    }
}
