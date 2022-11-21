using Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API_Diagnostic.Database
{
    public class DiagServiceContext: DbContext
    {

        public string connectionString;
        //readonly StreamWriter logStream = new StreamWriter("mylog.txt", true);

        //Datasets_______________________________________________________
        //public DbSet<Sections> Sections { get; set; };
        //public DbSet<Sections> Sections { get; set; } = null!;
        public DbSet<Section> Sections => Set<Section>();
        public DbSet<Incident> Incidents => Set<Incident>();
        public DbSet<Algoritm> Algoritms => Set<Algoritm>();
        public DbSet<TypeAlgorithm> TypeAlgorithms => Set<TypeAlgorithm>();
        public DbSet<TimeTable> TimeTables => Set<TimeTable>();

        //public DiagServiceContext() //<add name="DiagServiceContext"
        public DiagServiceContext():base("DiagServiceConnection")//из web.config
        {
            
        }
        

    }
}