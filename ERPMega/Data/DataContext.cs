﻿using ERPMega.Model;
using Microsoft.EntityFrameworkCore;

namespace ERPMega.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DbContext> options) : base(options) { }

        public DataContext() { }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Funcao> Funcao { get; set; }
        public DbSet<SituacaoFuncionario> SituacaoFuncionario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySql("Host=192.168.0.60;Database=DbErpMega;Username=mega;Password=mega@3212");
            //optionsBuilder.UseMySql("Host=192.168.0.19;Database=DbErpMega;Username=mega;Password=mega@3212");
            optionsBuilder.UseMySql("Host=localhost;Database=DbErpMega;Username=root;Password=3103");
        }
    }
}