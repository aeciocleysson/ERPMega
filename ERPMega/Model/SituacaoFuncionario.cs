using System.Collections.Generic;

namespace ERPMega.Model
{
    public class SituacaoFuncionario
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<Funcionario> Funcionario { get; set; } = new List<Funcionario>();
    }
}
