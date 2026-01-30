using Mailing_Utility.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mailing_Utility.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Cluster> Clusters { get; set; }

        public virtual DbSet<Country> Countries { get; set; }

        public virtual DbSet<Donor> Donors { get; set; }

        public virtual DbSet<EmailDirectory> EmailDirectories { get; set; }

        public virtual DbSet<EmailQueue> EmailQueues { get; set; }

        public virtual DbSet<Event> Events { get; set; }

        public virtual DbSet<EventType> EventTypes { get; set; }

        public virtual DbSet<NewsletterSubscription> NewsletterSubscriptions { get; set; }

        public virtual DbSet<Organization> Organizations { get; set; }

        public virtual DbSet<OrganizationUnit> OrganizationUnits { get; set; }

        public virtual DbSet<Participant> Participants { get; set; }

        public virtual DbSet<ParticipantType> ParticipantTypes { get; set; }

        public virtual DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().ToTable("AppUsers");
            builder.Entity<IdentityRole>().ToTable("AppRoles");
            builder.Entity<IdentityUserRole<string>>().ToTable("AppUserRoles");
        }
    }
}