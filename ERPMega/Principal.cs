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
            GetAllFuncionario();
            ClearFuncionario();
        }

        private void ClearFuncionario()
        {
            txtCadCodFunc.Clear();
            txtCadNomeFunc.Clear();
            dtCadNascFunc.Clear();
            txtCodeFuncao.Clear();
            txtDescFuncao.Clear();
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

        private void GetAllFuncionario()
        {
            dgvFuncionarios.DataSource = _context.Funcionario.Where(w => w.IsDelete == false)
                                                             .Select(s => new
                                                             {
                                                                 Codigo = s.Id,
                                                                 DataCadastro = s.Inserted,
                                                                 Nome = s.Nome,
                                                                 DataNascimento = s.DataNascimento,
                                                                 Matricula = s.Matricula,
                                                                 Situacao = s.SituacaoFuncionario.Descricao,
                                                                 CodFuncao = s.FuncaoId,
                                                                 Funcao = s.Funcao.Descricao
                                                             }).OrderBy(o => o.Nome)
                                                             .ToList();
        }

        private void InsertOrUpdateFuncionario(FuncionarioViewModel viewModel)
        {
            Random randNum = new Random();
            var startCode = randNum.Next(10, 99);

            if (string.IsNullOrEmpty(txtCadCodFunc.Text))
            {
                if (!string.IsNullOrEmpty(txtCadNomeFunc.Text) && !string.IsNullOrEmpty(dtCadNascFunc.Text) && !string.IsNullOrEmpty(txtCodeFuncao.Text))
                {
                    viewModel.Nome = txtCadNomeFunc.Text;
                    viewModel.DataNascimento = Convert.ToDateTime(dtCadNascFunc.Text);
                    viewModel.Matricula = Convert.ToInt64($"{dtCadNascFunc.Text.Replace("/", "").Substring(0, 4)}{startCode}");
                    viewModel.SituacaoFuncionarioId = Convert.ToInt32(cbSituacaoFunc.SelectedValue);
                    viewModel.FuncaoId = Convert.ToInt32(txtCodeFuncao.Text);

                    var model = new Funcionario(nome: viewModel.Nome,
                                                matricula: viewModel.Matricula,
                                                dataNascimento: viewModel.DataNascimento,
                                                situacaoFuncionarioId: viewModel.SituacaoFuncionarioId,
                                                funcaoId: viewModel.FuncaoId);
                    _context.Add(model);
                    _context.SaveChanges();
                    ClearFuncionario();
                    GetAllFuncionario();
                }
                else
                {
                    MessageBox.Show("Digite os campos obrigátórios!", "Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtCadNomeFunc.Text) && !string.IsNullOrEmpty(dtCadNascFunc.Text) && !string.IsNullOrEmpty(txtCodeFuncao.Text))
                {
                    viewModel.Id = Convert.ToInt32(txtCadCodFunc.Text);
                    viewModel.Nome = txtCadNomeFunc.Text;
                    viewModel.DataNascimento = Convert.ToDateTime(dtCadNascFunc.Text);
                    viewModel.SituacaoFuncionarioId = Convert.ToInt32(cbSituacaoFunc.SelectedValue);
                    viewModel.FuncaoId = Convert.ToInt32(txtCodeFuncao.Text);

                    var model = _context.Funcionario.Find(viewModel.Id);

                    model.Update(nome: viewModel.Nome,
                                  dataNascimento: viewModel.DataNascimento,
                                  situacaoFuncionarioId: viewModel.SituacaoFuncionarioId,
                                  funcaoId: viewModel.FuncaoId);

                    _context.Funcionario.Update(model);
                    _context.SaveChanges();
                    ClearFuncionario();
                    GetAllFuncionario();
                }
                else
                {
                    MessageBox.Show("Digite os campos obrigátórios!", "Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteFuncionario(FuncionarioViewModel viewModel)
        {
            if (!string.IsNullOrEmpty(txtCadCodFunc.Text))
            {
                    viewModel.Id = Convert.ToInt16(txtCadCodFunc.Text);
                    viewModel.IsDelete = true;

                    var model = _context.Funcionario.Find(viewModel.Id);

                    model.Delete(isDelete: viewModel.IsDelete);

                    _context.Funcionario.Update(model);
                    _context.SaveChanges();

                    ClearFuncionario();
                    GetAllFuncionario();
            }
            else
            {
                MessageBox.Show("Selecione um funcionário!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvFuncionarios.Rows[e.RowIndex];

                txtCadCodFunc.Text = row.Cells[0].Value.ToString();
                txtCadNomeFunc.Text = row.Cells[2].Value.ToString();
                dtCadNascFunc.Text = row.Cells[3].Value.ToString();
                txtCodeFuncao.Text = row.Cells[6].Value.ToString();
                txtDescFuncao.Text = row.Cells[7].Value.ToString();
                cbSituacaoFunc.Text = row.Cells[5].Value.ToString();
            }
        }

        private void brnCancelarFunc_Click(object sender, EventArgs e)
        {
            txtCadCodFuncao.Clear();
            ClearFuncionario();
        }

        private void btnDeleteFunc_Click(object sender, EventArgs e)
        {
            var viewModel = new FuncionarioViewModel();
            DeleteFuncionario(viewModel);
        }
    }
}
