namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'11060752-1b5b-4548-a3e1-5dd101c83b9a', N'admin@vidly.com', 0, N'AFFjeNkC4tkw3qnQMOBc4XXd0CrX7YDfcoAqBlfwlUueEJW7RMddqY5bDGujrsMASQ==', N'0fdbbe6f-1acc-4c74-adb8-fff51a007e0c', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'db2b2de2-9a2b-46ad-91c7-2a8830dfdb01', N'guest@vidly.com', 0, N'ALykqT0q/IeySDu2BjPMkX0fT24SVa1kRp8QMqRQ7/+nXbmcTPCUj/HCvRWial4WzQ==', N'a2011313-f055-4a3c-8421-e7a62b3587b0', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            ");

            Sql("INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f5246c4d-532f-4b6a-a922-efc076641d0a', N'CanManageMovies')");

            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'11060752-1b5b-4548-a3e1-5dd101c83b9a', N'f5246c4d-532f-4b6a-a922-efc076641d0a')");
        }
        
        public override void Down()
        {
        }
    }
}
