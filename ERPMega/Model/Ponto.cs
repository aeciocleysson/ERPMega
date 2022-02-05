using System;

namespace ERPMega.Model
{
    public class Ponto : BaseModel
    {
        public int FuncionarioId { get; private set; }
        public long Matricula { get; private set; }
        public TimeSpan Entrada { get; private set; }
        public TimeSpan SaidaIntervalo { get; private set; }
        public TimeSpan RetornoIntervalo { get; private set; }
        public TimeSpan TotalIntervalo { get; private set; }
        public TimeSpan Saida { get; private set; }
        public TimeSpan TotalTrabalhado { get; private set; }
        public double Minutos { get; private set; }
        public int LogPontoId { get; private set; }
        public LogPonto LogPonto { get; set; }
        public virtual Funcionario Funcionario { get; private set; }

        public Ponto() { }

        public void InsertHours(DateTime inserted, TimeSpan entrada, TimeSpan saidaIntervalo, TimeSpan retornoIntervalo, TimeSpan totalIntervalo,
                                TimeSpan saida, TimeSpan totalTrabalhado, double minutos, int funcionarioId, long matricula, int logPontoId)
        {
            Inserted = inserted;
            Entrada = entrada;
            SaidaIntervalo = saidaIntervalo;
            RetornoIntervalo = retornoIntervalo;
            TotalIntervalo = totalIntervalo;
            Saida = saida;
            TotalTrabalhado = totalTrabalhado;
            Minutos = minutos;
            FuncionarioId = funcionarioId;
            Matricula = matricula;
            LogPontoId = logPontoId;
        }

        public void UpdateHours(TimeSpan entrada, TimeSpan saidaIntervalo, TimeSpan retornoIntervalo, TimeSpan totalIntervalo,
                              TimeSpan saida, TimeSpan totalTrabalhado, double minutos, int logPontoId)
        {
            Entrada = entrada;
            SaidaIntervalo = saidaIntervalo;
            RetornoIntervalo = retornoIntervalo;
            TotalIntervalo = totalIntervalo;
            Saida = saida;
            TotalTrabalhado = totalTrabalhado;
            Minutos = minutos;
            LogPontoId = logPontoId;
            UpdateAt = DateTime.Now;
        }
    }
}
