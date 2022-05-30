using System;

namespace ERPMega.ViewModel
{
    public class LogViewModel : BaseViewModel
    {
        public int StatusLogId { get; set; }
        public int FuncionarioId { get; set; }
        public DateTime InsertedLog { get; set; }
    }
}
