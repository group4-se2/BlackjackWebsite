using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BlackjackWebsite.Models;

namespace BlackjackWebsite.DAL
{
    public class SurveyContext : DbContext
    {

        public SurveyContext() : base("SurveyContext")
        {

        }

        public DbSet<Survey> surveys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}