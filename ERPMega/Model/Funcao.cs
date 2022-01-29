namespace ERPMega.Model
{
    public class Funcao : BaseModel
    {
        public string Descricao { get; private set; }

        public Funcao(string descricao)
        {
            Descricao = descricao;
        }
    }
}
