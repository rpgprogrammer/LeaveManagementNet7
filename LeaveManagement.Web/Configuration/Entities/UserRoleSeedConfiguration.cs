using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                    UserId = "82a4fa39-60b2-43b7-8598-bf794f2f17e7"
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "cac43a6e-f7cb-4448-baaf-ladd431ccbbf",
                     UserId = "82a4fa39-60b2-60b2-8598-bf794f2f17e7"
                 }
                ) ;
        }
    }
}