namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(maxLength: 255));
            Sql("Update MembershipTypes Set Name = 'Pay as You Go' WHERE Id = 1");
            Sql("Update MembershipTypes Set Name = 'Monthly' WHERE Id = 2");
            Sql("Update MembershipTypes Set Name = 'Quarterly' WHERE Id = 3");
            Sql("Update MembershipTypes Set Name = 'Annual' WHERE Id = 4");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
