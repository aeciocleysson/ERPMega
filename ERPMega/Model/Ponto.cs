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
        public virtual Funcionario Funcionario { get; private set; }

        public Ponto() { }
            
        public void UpdateHours(TimeSpan entrada, TimeSpan saidaIntervalo, TimeSpan retornoIntervalo, TimeSpan totalIntervlo,
                                TimeSpan saida, TimeSpan totalTrabalhado, double minutos)
        {
            Entrada = entrada;
            SaidaIntervalo = saidaIntervalo;
            RetornoIntervalo = retornoIntervalo;
            TotalIntervalo = totalIntervlo;
            Saida = saida;
            TotalTrabalhado = totalTrabalhado;
            Minutos = minutos;
        }
    }
}
