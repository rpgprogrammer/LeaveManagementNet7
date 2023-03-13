using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    internal class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();

            builder.HasData(
                new Employee
                {
                    Id = "82a4fa39-60b2-43b7-8598-bf794f2f17e7",
                    Email = "paulgeorgecode@gmail.com",
                    NormalizedEmail = "PAULGEORGECODE@GMAIL.COM",
                    NormalizedUserName = "PAULGEORGECODE@GMAIL.COM",
                    UserName = "paulgeorgecode@gmail.com",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Qwerty1234!"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "82a4fa39-60b2-60b2-8598-bf794f2f17e7",
                    Email = "userpaulgeorgecode@gmail.com",
                    NormalizedEmail = "USERPAULGEORGECODE@GMAIL.COM",
                    NormalizedUserName = "USERPAULGEORGECODE@GMAIL.COM",
                    UserName = "userpaulgeorgecode@gmail.com",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "Qwerty1234!"),
                    EmailConfirmed = true
                }
                );
        }
    }
}