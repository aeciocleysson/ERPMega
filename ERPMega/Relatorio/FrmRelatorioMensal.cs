using System;
using System.Data;
using System.Windows.Forms;

namespace ERPMega.Relatorio
{
    public partial class FrmRelatorioMensal : Form
    {
        DataTable _data = new DataTable();
        string _nomeFuncionario;
        long _matriculaFuncionario;
        DateTime _dtInicio, _dtFim;
        public FrmRelatorioMensal(DataTable data, string nomeFuncionario, long matricula, DateTime dtInicio, DateTime dtFim)
        {
            InitializeComponent();
            _data = data;
            _nomeFuncionario = nomeFuncionario;
            _matriculaFuncionario = matricula;
            _dtInicio = dtInicio;
            _dtFim = dtFim;
        }

        private void FrmRelatorioMensal_Load(object sender, EventArgs e)
        {
            this.rvFechamentoMensal.LocalReport.DataSources.Clear();
            this.rvFechamentoMensal.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetFechamentoMensal", _data));
            this.rvFechamentoMensal.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nomeFuncionario", _nomeFuncionario));
            this.rvFechamentoMensal.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("matriculaFuncionario", _matriculaFuncionario.ToString()));
            this.rvFechamentoMensal.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dtInicio", _dtInicio.ToString()));
            this.rvFechamentoMensal.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dtFim", _dtFim.ToString()));

            this.rvFechamentoMensal.RefreshReport();
        }
    }
}
