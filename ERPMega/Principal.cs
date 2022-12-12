using ERPMega.Data;
using ERPMega.Forms;
using ERPMega.Model;
using ERPMega.Relatorio;
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
        private const double totalHorasMes = 220;
        public Principal()
        {
            InitializeComponent();
            _context = new DataContext();
            GetAllFuncao();
            GetAllSituacao();
            GetAllFuncionario();
            GetStatusLancamentoPonto();
            ClearFuncionario();
            dpDtInicio.Text = DateTime.Today.AddDays(-30).ToString();
        }

        #region Funcionário
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
        #endregion

        #region Correção de horários

        private void GetStatusLancamentoPonto()
        {
            var status = _context.StatusLancamentoPonto
                            .Where(w => w.IsDelete == false)
                            .Select(s => new
                            {
                                Codigo = s.Id,
                                Descricao = s.Descricao
                            }).OrderBy(o => o.Descricao).ToList();

            cbMotivos.DataSource = status;
            cbMotivos.DisplayMember = "DESCRICAO";
            cbMotivos.ValueMember = "CODIGO";

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
                          Almoço = s.SaidaIntervalo,
                          RetornoAlmoço = s.RetornoIntervalo,
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

        private void CleanFields()
        {
            txtId.Clear();
            txtData.Clear();
            txtEntrada.Clear();
            txtSaidaAlmoco.Clear();
            txtRetorno.Clear();
            txtSaida.Clear();
            dgvHours.DataSource = null;
            cbMotivos.SelectedIndex = -1;
        }

        private void InsertOrUpdatePonto(PontoViewModel viewModel)
        {
            var model = new Ponto();
            var logViewModel = new LogViewModel();

            if (rbInserirHorario.Checked && string.IsNullOrEmpty(txtId.Text))
            {
                if (!string.IsNullOrEmpty(txtCodHoraFunc.Text))
                {
                    if (!txtData.Text.Equals("  /  /") && !txtEntrada.Text.Equals(":") && !txtSaidaAlmoco.Text.Equals(":") &&
                    !txtRetorno.Text.Equals(":") && !txtSaida.Text.Equals(":") && !string.IsNullOrEmpty(cbMotivos.Text))
                    {
                        var funcionario = _context.Funcionario.Find(Convert.ToInt32(txtCodHoraFunc.Text));

                        var ponto = _context.Ponto.Any(a => a.FuncionarioId == funcionario.Id && a.Matricula == funcionario.Matricula &&
                                                       a.Inserted == Convert.ToDateTime(txtData.Text) && a.IsDelete == false);

                        if (!ponto)
                        {
                            viewModel.Inserted = Convert.ToDateTime(txtData.Text);
                            viewModel.FuncionarioId = funcionario.Id;
                            viewModel.Matricula = funcionario.Matricula;
                            viewModel.Entrada = TimeSpan.Parse(txtEntrada.Text);
                            viewModel.SaidaIntervalo = TimeSpan.Parse(txtSaidaAlmoco.Text);
                            viewModel.RetornoIntervalo = TimeSpan.Parse(txtRetorno.Text);
                            viewModel.TotalIntervalo = (viewModel.RetornoIntervalo - viewModel.SaidaIntervalo);
                            viewModel.Saida = TimeSpan.Parse(txtSaida.Text);
                            viewModel.TotalTrabalhado = Convert.ToInt32(cbMotivos.SelectedValue) == 4 ? TimeSpan.Parse("09:00") : (viewModel.Saida - viewModel.Entrada - viewModel.TotalIntervalo);
                            viewModel.Minutos = viewModel.TotalTrabalhado.TotalMinutes;
                            viewModel.LogPontoId = (int)LogPonto.ELog.PontoManual;

                            logViewModel.StatusLogId = viewModel.LogPontoId;
                            logViewModel.FuncionarioId = funcionario.Id;
                            logViewModel.Inserted = viewModel.Inserted;

                            model.InsertHours(inserted: viewModel.Inserted,
                                entrada: viewModel.Entrada,
                                saidaIntervalo: viewModel.SaidaIntervalo,
                                retornoIntervalo: viewModel.RetornoIntervalo,
                                totalIntervalo: viewModel.TotalIntervalo,
                                saida: viewModel.Saida,
                                totalTrabalhado: viewModel.TotalTrabalhado,
                                minutos: viewModel.Minutos,
                                funcionarioId: viewModel.FuncionarioId,
                                matricula: viewModel.Matricula,
                                logPontoId: viewModel.LogPontoId);

                            var logModel = new LogPonto(statusLogId: logViewModel.StatusLogId, logViewModel.FuncionarioId, logViewModel.Inserted);

                            _context.Add(model);
                            _context.SaveChanges();

                            _context.Add(logModel);
                            _context.SaveChanges();

                            CleanFields();
                            GetByIdHorario(Convert.ToInt32(txtCodHoraFunc.Text), Convert.ToDateTime(dpDtInicio.Text), Convert.ToDateTime(dpDtFim.Text));
                            txtData.Focus();
                            txtData.Select();
                        }
                        else
                        {
                            MessageBox.Show($"Já existe registro de ponto para {funcionario.Nome} no dia {txtData.Text}.", "Alerta", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        }
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
            else if (rbCorrigirHorario.Checked && !string.IsNullOrEmpty(txtId.Text))
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    if (!txtData.Text.Equals("  /  /") && !txtEntrada.Text.Equals(":") && !txtSaidaAlmoco.Text.Equals(":") &&
                        !txtRetorno.Text.Equals(":") && !txtSaida.Text.Equals(":") && !string.IsNullOrEmpty(cbMotivos.Text))
                    {
                        viewModel.Id = Convert.ToInt32(txtId.Text);
                        viewModel.Inserted = Convert.ToDateTime(txtData.Text);
                        viewModel.FuncionarioId = Convert.ToInt32(txtCodHoraFunc.Text);
                        viewModel.Entrada = TimeSpan.Parse(txtEntrada.Text);
                        viewModel.SaidaIntervalo = TimeSpan.Parse(txtSaidaAlmoco.Text);
                        viewModel.RetornoIntervalo = TimeSpan.Parse(txtRetorno.Text);
                        viewModel.TotalIntervalo = (viewModel.RetornoIntervalo - viewModel.SaidaIntervalo);
                        viewModel.Saida = TimeSpan.Parse(txtSaida.Text);
                        viewModel.TotalTrabalhado = Convert.ToInt32(cbMotivos.SelectedValue) == 4 ? TimeSpan.Parse("09:00") : (viewModel.Saida - viewModel.Entrada - viewModel.TotalIntervalo);
                        viewModel.Minutos = viewModel.TotalTrabalhado.TotalMinutes;
                        viewModel.LogPontoId = (int)LogPonto.ELog.PontoManual;

                        logViewModel.StatusLogId = viewModel.LogPontoId;
                        logViewModel.FuncionarioId = viewModel.FuncionarioId;
                        logViewModel.Inserted = viewModel.Inserted;

                        var updatePonto = _context.Ponto.Find(viewModel.Id);

                        updatePonto.UpdateHours(entrada: viewModel.Entrada,
                            saidaIntervalo: viewModel.SaidaIntervalo,
                            retornoIntervalo: viewModel.RetornoIntervalo,
                            totalIntervalo: viewModel.TotalIntervalo,
                            saida: viewModel.Saida,
                            totalTrabalhado: viewModel.TotalTrabalhado,
                            minutos: viewModel.Minutos,
                            logPontoId: viewModel.LogPontoId);

                        var logModel = new LogPonto(statusLogId: logViewModel.StatusLogId, logViewModel.FuncionarioId, logViewModel.Inserted);

                        _context.Ponto.Update(updatePonto);
                        _context.SaveChanges();

                        _context.Add(logModel);
                        _context.SaveChanges();

                        CleanFields();
                        GetByIdHorario(Convert.ToInt32(txtCodHoraFunc.Text), Convert.ToDateTime(dpDtInicio.Text), Convert.ToDateTime(dpDtFim.Text));
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
            else
            {
                MessageBox.Show("Escolha uma ação: Inserir Horário ou Corrigir Horário.", "Alerta", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Fechamento Mensal

        public void GetByIdFechamentoMensal(int id, DateTime dtInicio, DateTime dtFim)
        {

            if (!string.IsNullOrEmpty(txtCodFuncFechamento.Text))
            {
                id = Convert.ToInt32(txtCodFuncFechamento.Text);
                //dtInicio = Convert.ToDateTime(dpDtInicio.Value.ToString("dd/MM/yyyy"));
                //dtFim = Convert.ToDateTime(dpDtFim.Value.ToString("dd/MM/yyyy"));

                var funcionario = _context.Ponto
                      .Where(w => w.FuncionarioId == id &&
                             w.Inserted >= dtInicio &&
                             w.Inserted <= dtFim)
                      .Select(s => new
                      {
                          Codigo = s.Id,
                          Data = s.Inserted,
                          Dia = s.Inserted.ToString("dddd", new CultureInfo("pt-BR")),
                          Entrada = s.Entrada,
                          Almoço = s.SaidaIntervalo,
                          RetornoAlmoço = s.RetornoIntervalo,
                          TotalIntervalo = s.TotalIntervalo,
                          Saida = s.Saida,
                          Total = s.TotalTrabalhado
                      })
                      .OrderBy(o => o.Data)
                      .ToList();

                var totalHours = _context.Ponto
                    .Where(w => w.FuncionarioId == id &&
                           w.Inserted >= dtInicio &&
                           w.Inserted <= dtFim)
                    .Sum(w => w.Minutos / 60);

                dgvFechamentoPonto.DataSource = funcionario;

                txtSaldoMes.Text = totalHours.ToString("#.##");

                if (string.IsNullOrEmpty(txtSaldoMes.Text))
                {
                    txtSaldoMes.Text = "0.00";
                    txtSaldoPositivo.Text = "0.00";
                    txtSaldoNegativo.Text = "0.00";
                }
                else
                {
                    var total = Convert.ToDouble(txtSaldoMes.Text) - totalHorasMes;

                    if (total > totalHorasMes)
                        txtSaldoPositivo.Text = total.ToString();
                    else
                        txtSaldoNegativo.Text = total.ToString();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Funcionário.", "Alerta", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void SelectFuncionariosFechamento()
        {
            var funcionarios = new FrmFuncionarios();
            funcionarios.ShowDialog();

            if (funcionarios.DialogResult == DialogResult.OK)
            {
                var dataGrid = funcionarios.dgvEmployees.Rows[funcionarios.dgvEmployees.CurrentRow.Index];

                txtCodFuncFechamento.Text = dataGrid.Cells[0].Value.ToString();
                txtNomeFuncFechamento.Text = dataGrid.Cells[1].Value.ToString();
                txtMatriculaFechamento.Text = dataGrid.Cells[2].Value.ToString();
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

        private void txtBuscarFuncionario_Click(object sender, EventArgs e)
        {
            SelectFuncionarios();

            if (!string.IsNullOrEmpty(txtCodHoraFunc.Text))
                GetByIdHorario(Convert.ToInt32(txtCodHoraFunc.Text), Convert.ToDateTime(dpDtInicio.Text), Convert.ToDateTime(dpDtFim.Text));
            else
                return;
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

        private void dgvHours_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvHours.Rows[e.RowIndex];

                txtId.Text = row.Cells["Codigo"].Value.ToString();
                txtData.Text = row.Cells["Data"].Value.ToString();
                txtEntrada.Text = row.Cells["Entrada"].Value.ToString();
                txtSaidaAlmoco.Text = row.Cells["Almoço"].Value.ToString();
                txtRetorno.Text = row.Cells["RetornoAlmoço"].Value.ToString();
                txtSaida.Text = row.Cells["Saida"].Value.ToString();
            }
        }

        private void btnFuncFechamento_Click(object sender, EventArgs e)
        {
            SelectFuncionariosFechamento();

            if (!string.IsNullOrEmpty(txtCodFuncFechamento.Text))
                GetByIdFechamentoMensal(Convert.ToInt32(txtCodFuncFechamento.Text), Convert.ToDateTime(dtInicioFechamento.Text), Convert.ToDateTime(dtFimFechamento.Text));
            else
                return;
        }

        private void btnSairFunc_Click(object sender, EventArgs e)
        {
            tabPrincipal.SelectedTab = tpHome;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tabPrincipal.SelectedTab = tpHome;
        }

        private void btnCancelarHorarios_Click(object sender, EventArgs e)
        {
            rbInserirHorario.Checked = false;
            rbCorrigirHorario.Checked = false;
            txtCodHoraFunc.Clear();
            cbMotivos.SelectedIndex = -1;
            txtNomeHoraFunc.Clear();
            txtId.Clear();
            txtData.Clear();
            txtEntrada.Clear();
            txtSaidaAlmoco.Clear();
            txtRetorno.Clear();
            txtSaida.Clear();
            dgvHours.DataSource = null;
        }

        private void btnSairFechamento_Click(object sender, EventArgs e)
        {
            tabPrincipal.SelectedTab = tpHome;
        }

        private void btnCancelFechamento_Click(object sender, EventArgs e)
        {
            txtCodFuncFechamento.Clear();
            txtNomeFuncFechamento.Clear();
            txtSaldoMes.Clear();
            txtSaldoPositivo.Clear();
            txtSaldoNegativo.Clear();
            txtMatriculaFechamento.Clear();
            dgvFechamentoPonto.DataSource = null;
        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            var data = GerarDadosRelatorio();

            if (dgvFechamentoPonto.DataSource != null)
            {
                var relatorio = new FrmRelatorioMensal(data, txtNomeFuncFechamento.Text, Convert.ToInt32(txtMatriculaFechamento.Text),
                                                    dtInicioFechamento.Value, dtFimFechamento.Value);
                relatorio.Show();
            }
            else
            {
                return;
            }
        }

        private DataTable GerarDadosRelatorio()
        {
            var data = new DataTable();

            data.Columns.Add("Inserted");
            data.Columns.Add("Entrada");
            data.Columns.Add("SaidaIntervalo");
            data.Columns.Add("RetornoIntervalo");
            data.Columns.Add("Saida");
            data.Columns.Add("TotalTrabalhado");

            foreach (DataGridViewRow item in dgvFechamentoPonto.Rows)
            {
                data.Rows.Add(
                    item.Cells["Data"].Value.ToString(),
                    item.Cells["Entrada"].Value.ToString(),
                    item.Cells["Almoço"].Value.ToString(),
                    item.Cells["RetornoAlmoço"].Value.ToString(),
                    item.Cells["Saida"].Value.ToString(),
                    item.Cells["Total"].Value.ToString());
            }
            return data;

        }

        private void cbMotivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMotivos.SelectedIndex == 1)
            {
                txtEntrada.Enabled = false;
                txtSaidaAlmoco.Enabled = false;
                txtRetorno.Enabled = false;
                txtSaida.Enabled = false;
                txtEntrada.Text = "00:00";
                txtSaidaAlmoco.Text = "00:00";
                txtRetorno.Text = "00:00";
                txtSaida.Text = "00:00";
            }
            else
            {
                txtEntrada.Enabled = true;
                txtSaidaAlmoco.Enabled = true;
                txtRetorno.Enabled = true;
                txtSaida.Enabled = true;
                txtEntrada.Clear();
                txtSaidaAlmoco.Clear();
                txtRetorno.Clear();
                txtSaida.Clear();
            }
        }

        private void btnPesqFuncFechamento_Click(object sender, EventArgs e)
        {
            SelectFuncionarios();
        }
    }
}
