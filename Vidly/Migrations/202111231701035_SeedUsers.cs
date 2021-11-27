namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5255b4b0-108b-4e0b-a0a7-e609ee6b7495', N'admin@vidly.com', 0, N'ALpkqIWPJoFS3df/jlAjZAefzqI1u23y+IXuGqLujslda0L+yTkoNaHTrsjbu+7HIQ==', N'6c6b14e6-9018-4591-b695-4af63ef9dd0b', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fba830bc-cf05-4c7c-b1b0-fa3b9187d4ce', N'guest@vidly.com', 0, N'ADmFbZC41vUlT4BOp+6y5+bEaNx5uzzoAz3QEJmLkz7Kh+tTb+hildkY3eOn2x7jCg==', N'0e65822a-ef88-4c48-a2e6-63ff3c223354', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'059c954c-bb26-4cc6-a810-1580eb16574b', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5255b4b0-108b-4e0b-a0a7-e609ee6b7495', N'059c954c-bb26-4cc6-a810-1580eb16574b')
");
        }
        
        public override void Down()
        {
        }
    }
}
