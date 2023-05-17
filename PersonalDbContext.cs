using Microsoft.EntityFrameworkCore;
using MyResumeOfWPF.PDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MyResumeOfWPF
{
    public class PersonalDbContext:DbContext
    {
        public DbSet<EducationRow> Educations { get; set; }

        public DbSet<JobRow> Jobs { get; set; }

        public DbSet<SkillRow> Skills { get; set; }

        public DbSet<BasicinfoRow> BasicInfos { get; set; }

        public string DbPath { get; }

        public PersonalDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "PersonalInfo.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
