namespace Vidly101.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0b9e11d7-b9be-4f3e-b797-91aa6ff160f4', N'admin@vidly.com', 0, N'AOGoogF2aIkhK5h1ljA3hjBPCUbF/tgQSUMz5zrf7W/WmUlvfVOt4eJOWflCywZaLA==', N'942d5618-22e0-48d9-855e-4d481df745a8', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0d3fbc24-ccfe-4a53-b241-9816db5b6d06', N'guest@vidly.com', 0, N'AA819WKv3I1V+WdzXoZ99cJRWxwOHDWO3ENSezgmnN5bU4Wa9mpMwN1MjfV/WR8JHA==', N'26a6ed1d-1b8b-4bf9-bbeb-488e278559be', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'28de4980-c38d-4156-a343-5debf5bad0d3', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0b9e11d7-b9be-4f3e-b797-91aa6ff160f4', N'28de4980-c38d-4156-a343-5debf5bad0d3')

            ");

        }
        
        public override void Down()
        {
        }
    }
}
