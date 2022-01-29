using ERPMega.Data;
using ERPMega.Model;
using ERPMega.ViewModel;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ERPMega
{
    public partial class Principal : Form
    {
        private DataContext _context;
        public Principal()
        {
            InitializeComponent();
            _context = new DataContext();
            GetAllFuncao();
            GetAllSituacao();
        }

        private void GetAllSituacao()
        {
            cbSituacaoFunc.DataSource = _context.SituacaoFuncionario.OrderBy(o => o.Descricao).ToList();
            cbSituacaoFunc.DisplayMember = "DESCRICAO";
            cbSituacaoFunc.ValueMember = "ID";
        }
        private void InsertOrUpdateFuncao(FuncaoViewModel viewModel)
        {
            if (!string.IsNullOrEmpty(txtCadDescFuncao.Text.Trim()))
            {
                viewModel.Descricao = txtCadDescFuncao.Text;

                var model = new Funcao(descricao: viewModel.Descricao);

                _context.Add(model);
                _context.SaveChanges();

                GetAllFuncao();
            }
            else
            {
                MessageBox.Show("Digite a descrição da funcão!", "Alerta", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void GetAllFuncao()
        {
            dgvFuncao.DataSource = _context.Funcao.Select(s => new { s.Id, s.Descricao }).OrderBy(o => o.Descricao).ToList();
        }

        private void InsertOrUpdateFuncionario(FuncionarioViewModel viewModel)
        {
            Random randNum = new Random();
            var startCode = randNum.Next(10, 99);

            if (string.IsNullOrEmpty(txtCadCodFunc.Text))
            {
                viewModel.Nome = txtCadNomeFunc.Text;
                viewModel.DataNascimento = Convert.ToDateTime(dtCadNascFunc.Text);
                viewModel.Matricula = Convert.ToInt64($"{dtCadNascFunc.Text.Replace("/", "").Substring(0, 4)}{startCode}");
                viewModel.SituacaoFuncionarioId = Convert.ToInt32(cbSituacaoFunc.SelectedValue);
                viewModel.FuncaoId = Convert.ToInt32(txtCodeFuncao.Text);
            }
            else
            {

            }
        }

        private void btnSalvarFuncao_Click(object sender, EventArgs e)
        {
            var viewModel = new FuncaoViewModel();
            InsertOrUpdateFuncao(viewModel);
        }

        private void btnSalvarFunc_Click(object sender, EventArgs e)
        {
            var viewModel = new FuncionarioViewModel();
            InsertOrUpdateFuncionario(viewModel);
        }

        private void dgvFuncao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvFuncao.Rows[e.RowIndex];

                txtCodeFuncao.Text = row.Cells[0].Value.ToString();
                txtDescFuncao.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
