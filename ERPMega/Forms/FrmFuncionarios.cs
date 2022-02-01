using ERPMega.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ERPMega.Forms
{
    public partial class FrmFuncionarios : Form
    {
        private DataContext _context;

        public FrmFuncionarios()
        {
            InitializeComponent();
            _context = new DataContext();
            GetAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void GetAll()
        {
            dgvEmployees.DataSource = _context.Funcionario
                .Where(w => w.IsDelete == false)
                .Select(s => new
                {
                    s.Id,
                    s.Nome
                }).OrderBy(o => o.Nome)
                .ToList();
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployees.Rows.Count == 0)
                return;
            else
                DialogResult = DialogResult.OK;

            Close();
        }
    }
}
