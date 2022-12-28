using Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using API_Diagnostic.Models.ResultModels;
using System.Threading.Tasks;

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


        //_________________________________________________________________ Вызовы хранимых процедур ________________________________________
        //_____________________________________Топливо__________________________
        /// <summary>
        /// Метод вызова хранимой процедуры SectionFuelNow(DS)
        /// </summary>
        /// <param name="id_section">id секции (diag_lcm)</param>
        /// <returns>Запись типа SectionFuelNowInfo</returns>
        public DbRawSqlQuery<SectionFuelNowInfo> GetSectionFuelNow(int id_section)
        {
            var sql = @"[App].[SectionFuelNow(DS)] {0}";
            return Database.SqlQuery<SectionFuelNowInfo>(sql, id_section);
        }
        /// <summary>
        /// Асинхронная версия метода вызова хранимой процедуры SectionFuelNow(DS)
        /// </summary>
        /// <param name="id_section">id секции (diag_lcm)</param>
        /// <returns>Запись типа SectionFuelNowInfo</returns>
        public async Task<DbRawSqlQuery<SectionFuelNowInfo>> GetSectionFuelNowAsync(int id_section)
        {
            return (await Task.Run(() => GetSectionFuelNow(id_section)));
        }
        //_____________________________________Дата-Время__________________________
        /// <summary>
        /// Метод вызова хранимой процедуры SectionGetMaxDateTime(DS)
        /// </summary>
        /// <param name="id_section">id секции (diag_lcm)</param>
        /// <returns></returns>
        public DbRawSqlQuery<SectionMaxDateTime> GetSectionMaxDateTime(int id_section)
        {
            var sql = @"[App].[SectionGetMaxDateTime(DS)] {0}";
            return Database.SqlQuery<SectionMaxDateTime>(sql, id_section);
        }
        /// <summary>
        /// Асинхронная версия метода вызова хранимой процедуры SectionGetMaxDateTime(DS)
        /// </summary>
        /// <param name="id_section"></param>
        /// <returns></returns>
        public async Task<DbRawSqlQuery<SectionMaxDateTime>> GetSectionMaxDateTimeAsync(int id_section)
        {
            return (await Task.Run(() => GetSectionMaxDateTime(id_section)));
        }
        //_____________________________________Координаты__________________________
        /// <summary>
        /// Метод вызова хранимой процедуры SectionCoordinatesMax(DS)
        /// </summary>
        /// <param name="id_section"></param>
        /// <returns></returns>
        public DbRawSqlQuery<Сoordinates> GetSectionСoordinates(int id_section)
        {
            var sql = @"[App].[SectionCoordinatesMax(DS)] {0}";
            return Database.SqlQuery<Сoordinates>(sql, id_section);
        }
        /// <summary>
        /// Асинхронная версия метода вызова хранимой процедуры SectionCoordinatesMax(DS)
        /// </summary>
        /// <param name="id_section"></param>
        /// <returns></returns>
        public async Task<DbRawSqlQuery<Сoordinates>> GetSectionСoordinatesAsync(int id_section)
        {
            return (await Task.Run(() => GetSectionСoordinates(id_section)));
        }
    }
}