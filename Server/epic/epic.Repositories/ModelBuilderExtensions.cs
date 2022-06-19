using epic.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace epic.Repositories
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            byte[] passwordHash = new byte[255];
            byte[] passwordKey = new byte[255];
            using (var hmac = new HMACSHA512())
            {
                passwordKey = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("Pass@123"));
            }

            modelBuilder.Entity<Role>().HasData(
              new Role
              {
                  Id = 1,
                  Name = "Admin"
              },
               new Role
               {
                   Id = 2,
                   Name = "User"
               }
           );
            modelBuilder.Entity<User>()
                .HasData(
               new User
               {
                   Id = 1,
                   FirstName = "Super",
                   LastName = "Admin",
                   UserName = "Admin",
                   PasswordHash = passwordHash,
                   PasswordSalt = passwordKey,
                   Email = "admin@gmail.com",
                   RefreshToken = "VBj9IOAJtZwrMiHizKy2FkOmxM6PCJw9u9vepY4lbIg=",
                   RefreshTokenExpiryTime = DateTime.Now,
                   Created = DateTime.Now,
                   LastActive = DateTime.Now,
                   IsActive = true
               },
               new User
               {
                   Id = 2,
                   FirstName = "Super",
                   LastName = "User",
                   UserName = "User",
                   PasswordHash = passwordHash,
                   PasswordSalt = passwordKey,
                   Email = "user@gmail.com",
                   RefreshToken = "VBj9IOAJtZwrMiHizKy2FkOmxM6PCJw9u9vepY4lbIg=",
                   RefreshTokenExpiryTime = DateTime.Now,
                   Created = DateTime.Now,
                   LastActive = DateTime.Now,
                   IsActive = true
               }
            );
            modelBuilder.Entity<UserRole>().HasData(
              new UserRole
              {
                  Id = 1,
                  UserId = 1,
                  RoleId = 1
              },
              new UserRole
              {
                  Id = 2,
                  UserId = 2,
                  RoleId = 2
              }
           );
        }
    }
}
