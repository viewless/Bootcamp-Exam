using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheRecrutmentTool.DataAccess.Entities;


namespace TheRecrutmentTool.DataAccess
{
    public class TheRecrutmentToolContext : DbContext
    {
        public DbSet<CandidateEntity> Candidates { get; set; }

        public DbSet<JobEntity> Jobs { get; set; }

        public DbSet<RecruiterEntity> Recruiters { get; set; }

        public DbSet<SkillEntity> Skills{ get; set; }

        public DbSet<InterviewEntity> Interviews { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CandidateEntity>(entity =>
            {
                entity
                    .HasOne(x => x.Recruiter)
                    .WithMany(x => x.Candidates)
                    .HasForeignKey(x => x.RecruiterId);

                entity
                    .HasOne(x => x.Interview)
                    .WithMany(x => x.Candidates)
                    .HasForeignKey(x => x.InterviewId);
                      
            });

            builder.Entity<SkillEntity>(entity =>
            {
                entity
                    .HasMany(x => x.Jobs)
                    .WithMany(x => x.Skills);

                entity
                    .HasMany(x => x.Candidates)
                    .WithMany(x => x.Skills);

            });

            builder.Entity<JobEntity>(entity =>
            {
                entity
                    .HasMany(x => x.Interviews)
                    .WithMany(x => x.Jobs);
            });

            builder.Entity<RecruiterEntity>(entity =>
            {
                entity
                    .HasMany(x => x.Interviews)
                    .WithMany(x => x.Recruiters);
            });


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=TheRecruitmentTool;Integrated Security=True;");
            }
        }
    }
}
