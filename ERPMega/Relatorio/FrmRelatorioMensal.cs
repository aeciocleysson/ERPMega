using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPMega.Relatorio
{
    public partial class FrmRelatorioMensal : Form
    {
        DataTable _data = new DataTable();
        public FrmRelatorioMensal(DataTable data)
        {
            InitializeComponent();
            _data = data;
        }

        private void FrmRelatorioMensal_Load(object sender, EventArgs e)
        {
            this.rvFechamentoMensal.LocalReport.DataSources.Clear();
            this.rvFechamentoMensal.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetFechamentoMensal", _data));
            this.rvFechamentoMensal.RefreshReport();
        }
    }
}
