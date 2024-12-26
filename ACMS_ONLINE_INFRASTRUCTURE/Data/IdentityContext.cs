using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using OnlineClient = ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities.OnlineClient;
using OnlineUserClient = ACMS_ONLINE_INFRASTRUCTURE.Identity.Entities.OnlineUserClient;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data
{
    public class IdentityContext : IdentityDbContext<ApplicationUser, ApplicationRole,string>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options): base(options)
        {

        }
        public DbSet<OnlineClient> OnlineClients { get; set; }
        public DbSet<OnlineUserClient> OnlineUserClients { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Privilege> Privileges { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<OnlineUserClient>()
            .HasKey(u => new { u.UserId, u.ClientId });

            // Configure relationships
            builder.Entity<OnlineUserClient>()
                .HasOne(u => u.User)
                .WithMany()
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<OnlineUserClient>()
                .HasOne(u => u.OnlineClient)
                .WithMany(c => c.OnlineUserClients)
                .HasForeignKey(u => u.ClientId)
                .OnDelete(DeleteBehavior.Cascade);


           
            builder.Entity<Page>()
                 .HasOne(x=>x.ParentPage)
                 .WithMany(x=>x.SubPages)
                 .HasForeignKey(x=>x.PageParentId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Privilege>()
                .HasOne(p => p.Page)
                .WithMany()
                .HasForeignKey(p => p.PageId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Privilege>()
                .HasOne(p => p.Role)
                .WithMany()
                .HasForeignKey(p => p.RoleId)
                .OnDelete(DeleteBehavior.Cascade);

        }


    }
}
