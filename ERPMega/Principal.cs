using ERPMega.Data;
using ERPMega.Forms;
using ERPMega.Model;
using ERPMega.ViewModel;
using System;
using System.Data;
using System.Globalization;
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


        #region Funcionário


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
        #endregion

        #region Correção de horários

        private void InsertOrUpdatePonto(PontoViewModel viewModel)
        {
            var model = new Ponto();
            var logViewModel = new LogViewModel();

            if (rbInserirHorario.Checked)
            {
                if (!string.IsNullOrEmpty(txtCodHoraFunc.Text))
                {
                    if (!txtData.Text.Equals("  /  /") && !txtEntrada.Text.Equals(":") && !txtSaidaAlmoco.Text.Equals(":") &&
                    !txtRetorno.Text.Equals(":") && !txtSaida.Text.Equals(":"))
                    {
                        var funcionario = _context.Funcionario.Find(Convert.ToInt32(txtCodHoraFunc.Text));

                        viewModel.Inserted = Convert.ToDateTime(txtData.Text);
                        viewModel.Entrada = TimeSpan.Parse(txtEntrada.Text);
                        viewModel.SaidaIntervalo = TimeSpan.Parse(txtSaidaAlmoco.Text);
                        viewModel.RetornoIntervalo = TimeSpan.Parse(txtRetorno.Text);
                        viewModel.TotalIntervalo = (viewModel.RetornoIntervalo - viewModel.SaidaIntervalo);
                        viewModel.Saida = TimeSpan.Parse(txtSaida.Text);
                        viewModel.TotalTrabalhado = (viewModel.Saida - viewModel.Entrada - viewModel.TotalIntervalo);
                        viewModel.Minutos = viewModel.TotalTrabalhado.TotalMinutes;
                        viewModel.FuncionarioId = funcionario.Id;
                        viewModel.Matricula = funcionario.Matricula;

                        if (cbMotivos.Text == "Trabalhado")
                            viewModel.Log = (int)LogPonto.ELog.Trabalhado;
                        else if (cbMotivos.Text == "Atestado médico")
                            viewModel.Log = (int)LogPonto.ELog.Atestado;

                        logViewModel.Log = (int)LogPonto.ELog.PontoManual;
                        logViewModel.Descricao = "Ponto Inserido manualmente";
                        logViewModel.Log = viewModel.Log;
                        logViewModel.Descricao = cbMotivos.Text;
                        logViewModel.FuncionarioId = funcionario.Id;

                        model.InsertUpdateHours(inserted: viewModel.Inserted,
                            entrada: viewModel.Entrada,
                            saidaIntervalo: viewModel.SaidaIntervalo,
                            retornoIntervalo: viewModel.RetornoIntervalo,
                            totalIntervalo: viewModel.TotalIntervalo,
                            saida: viewModel.Saida,
                            totalTrabalhado: viewModel.TotalTrabalhado,
                            minutos: viewModel.Minutos,
                            funcionarioId: viewModel.FuncionarioId,
                            matricula: viewModel.Matricula,
                            log: viewModel.Log);

                        var logModel = new LogPonto(log: logViewModel.Log, descricao: logViewModel.Descricao, logViewModel.FuncionarioId);

                        _context.Add(model);
                        _context.SaveChanges();

                        _context.Add(logModel);
                        _context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Preencha os campos obrigátorios.", "Alerta", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um funcionário.", "Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            else if (rbCorrigirHorario.Checked)
            {

            }
            else
            {
                MessageBox.Show("Escolha uma ação: Inserir Horário ou Corrigir Horário.", "Alerta", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        #endregion

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

        public void SelectFuncionarios()
        {
            var funcionarios = new FrmFuncionarios();
            funcionarios.ShowDialog();

            if (funcionarios.DialogResult == DialogResult.OK)
            {
                var dataGrid = funcionarios.dgvEmployees.Rows[funcionarios.dgvEmployees.CurrentRow.Index];

                txtCodHoraFunc.Text = dataGrid.Cells[0].Value.ToString();
                txtNomeHoraFunc.Text = dataGrid.Cells[1].Value.ToString();
            }
        }

        public void GetByIdHorario(int id, DateTime dtInicio, DateTime dtFim)
        {
            if (!string.IsNullOrEmpty(txtCodHoraFunc.Text))
            {
                id = Convert.ToInt32(txtCodHoraFunc.Text);
                dtInicio = Convert.ToDateTime(dpDtInicio.Value.ToString("dd/MM/yyyy"));
                dtFim = Convert.ToDateTime(dpDtFim.Value.ToString("dd/MM/yyyy"));

                var employee = _context.Ponto
                      .Where(w => w.FuncionarioId == id &&
                             w.Inserted >= dtInicio &&
                             w.Inserted <= dtFim)
                      .Select(s => new
                      {
                          Codigo = s.Id,
                          Data = s.Inserted,
                          Dia = s.Inserted.ToString("dddd", new CultureInfo("pt-BR")),
                          Entrada = s.Entrada,
                          Almoco = s.SaidaIntervalo,
                          Retorno = s.RetornoIntervalo,
                          TotalIntervalo = s.TotalIntervalo,
                          Saida = s.Saida,
                          Total = s.TotalTrabalhado
                      })
                      .OrderBy(o => o.Data)
                      .ToList();

                dgvHours.DataSource = employee;
            }
            else
            {
                MessageBox.Show("Selecione um Funcionário.", "Alerta", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void txtBuscarFuncionario_Click(object sender, EventArgs e)
        {
            SelectFuncionarios();

            GetByIdHorario(Convert.ToInt32(txtCodHoraFunc.Text), Convert.ToDateTime(dpDtInicio.Text), Convert.ToDateTime(dpDtFim.Text));
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCodHoraFunc.Text))
                GetByIdHorario(Convert.ToInt32(txtCodHoraFunc.Text), Convert.ToDateTime(dpDtInicio.Text), Convert.ToDateTime(dpDtFim.Text));
            else
                return;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var viewModel = new PontoViewModel();
            InsertOrUpdatePonto(viewModel);
        }
    }
}
