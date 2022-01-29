using System;

namespace ERPMega.ViewModel
{
    public class FuncionarioViewModel : BaseViewModel
    {
        public string Nome { get;  set; }
        public long Matricula { get;  set; }
        public DateTime DataNascimento { get;  set; }
        public int SituacaoFuncionarioId { get;  set; }
        public int FuncaoId { get;  set; }
    }
}
