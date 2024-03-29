﻿using System;

namespace ERPMega.ViewModel
{
    public class PontoViewModel : BaseViewModel
    {
        public int FuncionarioId { get; set; }
        public long Matricula { get; set; }
        public TimeSpan Entrada { get; set; }
        public TimeSpan SaidaIntervalo { get; set; }
        public TimeSpan RetornoIntervalo { get; set; }
        public TimeSpan TotalIntervalo { get; set; }
        public TimeSpan Saida { get; set; }
        public TimeSpan TotalTrabalhado { get; set; }
        public double Minutos { get;  set; }
        public int LogPontoId { get; set; }
        public string DescricaoLog { get; set; }
    }
}
