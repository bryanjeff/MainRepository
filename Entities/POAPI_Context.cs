using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PO_API.Entities
{
    public class POAPI_Context: DbContext
    {
        public POAPI_Context(DbContextOptions<POAPI_Context> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Mock Plant data creation
            modelBuilder.Entity<Plant>().HasData(new Plant
            {
                PlantId = 1,
                PlantName = "Plant Columbia",
                Description = "Plant for Region Columbia"

            }, new Plant
            {
                PlantId = 2,
                PlantName = "Plant Asia-Pacific",
                Description = "Plant for Region Asia-Pacific"
            });
            #endregion

            #region Mock Division data creation
            modelBuilder.Entity<Division>().HasData(new Division
            {
                DivId = 1,
                DivName = "PEC",
                DivDescription = "PEC Description"

            }, new Division
            {
                DivId = 2,
                DivName = "CSD",
                DivDescription = "CSD Description"
            }, new Division
            {
                DivId = 3,
                DivName = "ZLC",
                DivDescription = "ZLC Description"
            }, new Division
            {
                DivId = 4,
                DivName = "WPO",
                DivDescription = "WPO Description"
            }, new Division
            {
                DivId = 5,
                DivName = "DEC",
                DivDescription = "DEC Description"
            }, new Division
            {
                DivId = 6,
                DivName = "RE",
                DivDescription = "RE Description"
            }, new Division
            {
                DivId = 7,
                DivName = "FI",
                DivDescription = "FI Description"
            }, new Division
            {
                DivId = 8,
                DivName = "QP",
                DivDescription = "QP Description"
            }, new Division
            {
                DivId = 9,
                DivName = "OGW",
                DivDescription = "OGW Description"
            }, new Division
            {
                DivId = 10,
                DivName = "PF",
                DivDescription = "PF Description"
            }, new Division
            {
                DivId = 11,
                DivName = "EEM",
                DivDescription = "EEM Description"
            }, new Division
            {
                DivId = 12,
                DivName = "NPI",
                DivDescription = "NPI Description"
            }
            );
            #endregion

            #region Mock Target setting data creation
            modelBuilder.Entity<TargetSetting>().HasData(new TargetSetting
            {
                TSettingId = 1,
                TSettingName = "Current Pillar Score",
                TSettingDesc = "Description 1"

            }, new TargetSetting
            {
                TSettingId = 2,
                TSettingName = "Current Maturity Level",
                TSettingDesc = "Description 2"
            }, new TargetSetting
            {
                TSettingId = 3,
                TSettingName = "# Actions to Next Level",
                TSettingDesc = "Description 3"
            }, new TargetSetting
            {
                TSettingId = 4,
                TSettingName = "Overall # Target Actions 2021",
                TSettingDesc = "Description 4"
            }, new TargetSetting
            {
                TSettingId = 5,
                TSettingName = "# Commited Actions",
                TSettingDesc = "Description 5"
            }
            );
            #endregion

            #region Mock Target setting summary data creation
            modelBuilder.Entity<TargetSettingSumary>().HasData(new TargetSettingSumary
            {
                Id = 1,
                CompDate = Convert.ToDateTime("8/26/2021"),
                PlantId = 1,
                TSettingId = 1,
                DivId = 1,
                ActionVal = 1.2
            }, new TargetSettingSumary
            {
                Id = 2,
                CompDate = Convert.ToDateTime("8/26/2021"),
                PlantId = 1,
                TSettingId = 1,
                DivId = 2,
                ActionVal = 2.2
            }, new TargetSettingSumary
            {
                Id = 3,
                CompDate = Convert.ToDateTime("8/26/2021"),
                PlantId = 1,
                TSettingId = 1,
                DivId = 3,
                ActionVal = 1.2
            }, new TargetSettingSumary
            {
                Id = 4,
                CompDate = Convert.ToDateTime("8/26/2021"),
                PlantId = 1,
                TSettingId = 1,
                DivId = 4,
                ActionVal = 1.2
            }, new TargetSettingSumary
            {
                Id = 5,
                CompDate = Convert.ToDateTime("8/26/2021"),
                PlantId = 1,
                TSettingId = 1,
                DivId = 5,
                ActionVal = 1.2
            }, new TargetSettingSumary
            {
                Id = 6,
                CompDate = Convert.ToDateTime("8/26/2021"),
                PlantId = 1,
                TSettingId = 1,
                DivId = 6,
                ActionVal = 1.2
            }, new TargetSettingSumary
            {
                Id = 7,
                CompDate = Convert.ToDateTime("8/26/2021"),
                PlantId = 1,
                TSettingId = 1,
                DivId = 7,
                ActionVal = 1.2
            }, new TargetSettingSumary
            {
                Id = 8,
                CompDate = Convert.ToDateTime("8/26/2021"),
                PlantId = 1,
                TSettingId = 1,
                DivId = 8,
                ActionVal = 1.2
            }, new TargetSettingSumary
            {
                Id = 9,
                CompDate = Convert.ToDateTime("8/26/2021"),
                PlantId = 1,
                TSettingId = 1,
                DivId = 2,
                ActionVal = 1
            }, new TargetSettingSumary
            {
                Id = 10,
                CompDate = Convert.ToDateTime("8/26/2021"),
                PlantId = 1,
                TSettingId = 2,
                DivId = 2,
                ActionVal = 2
            }, new TargetSettingSumary
            {
                Id = 11,
                CompDate = Convert.ToDateTime("8/26/2021"),
                PlantId = 1,
                TSettingId = 2,
                DivId = 3,
                ActionVal = 1
            }, new TargetSettingSumary
            {
                Id = 12,
                CompDate = Convert.ToDateTime("8/26/2021"),
                PlantId = 1,
                TSettingId = 2,
                DivId = 4,
                ActionVal = 1
            }

            );

            #endregion
        }

        public DbSet<Plant> Plants { get; set; }
        public DbSet<TargetSetting> TargetSettings { get; set; }
        public DbSet<TargetSettingSumary> TargetSettingSumaries{ get; set; }
        public DbSet<Division> Divisions { get; set; }
    }
}
