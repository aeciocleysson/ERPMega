using ERPMega.Model;
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
        public DbSet<Ponto> Ponto { get; set; }
        public DbSet<LogPonto> Log { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<StatusLancamentoPonto> StatusLancamentoPonto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySql("Host=localhost;Database=dbmega;Username=root;Password=mega@3212");
            optionsBuilder.UseMySql("Host=localhost;Database=dberpmega;Username=root;Password=3103");
        }
    }
}
