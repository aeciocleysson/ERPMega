﻿
namespace ERPMega
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tpFuncionario = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCadCodFuncao = new System.Windows.Forms.TextBox();
            this.txtCadDescFuncao = new System.Windows.Forms.TextBox();
            this.btnSalvarFuncao = new System.Windows.Forms.Button();
            this.dgvFuncao = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSituacaoFunc = new System.Windows.Forms.ComboBox();
            this.btnDeleteFunc = new System.Windows.Forms.Button();
            this.btnSalvarFunc = new System.Windows.Forms.Button();
            this.brnCancelarFunc = new System.Windows.Forms.Button();
            this.btnSairFunc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescFuncao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodeFuncao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtCadNascFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtCadNomeFunc = new System.Windows.Forms.TextBox();
            this.txtCadCodFunc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.tpHorarios = new System.Windows.Forms.TabPage();
            this.rbCorrigirHorario = new System.Windows.Forms.RadioButton();
            this.rbInserirHorario = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtBuscarFuncionario = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtSaida = new System.Windows.Forms.MaskedTextBox();
            this.txtRetorno = new System.Windows.Forms.MaskedTextBox();
            this.txtSaidaAlmoco = new System.Windows.Forms.MaskedTextBox();
            this.txtEntrada = new System.Windows.Forms.MaskedTextBox();
            this.Data = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNomeHoraFunc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodHoraFunc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dpDtFim = new System.Windows.Forms.DateTimePicker();
            this.dpDtInicio = new System.Windows.Forms.DateTimePicker();
            this.dgvHours = new System.Windows.Forms.DataGridView();
            this.cbMotivos = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPrincipal.SuspendLayout();
            this.tpFuncionario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.tpHorarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHours)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPrincipal.Controls.Add(this.tabPage1);
            this.tabPrincipal.Controls.Add(this.tpFuncionario);
            this.tabPrincipal.Controls.Add(this.tpHorarios);
            this.tabPrincipal.Location = new System.Drawing.Point(3, 12);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(966, 484);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(958, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tpFuncionario
            // 
            this.tpFuncionario.Controls.Add(this.groupBox1);
            this.tpFuncionario.Controls.Add(this.label6);
            this.tpFuncionario.Controls.Add(this.cbSituacaoFunc);
            this.tpFuncionario.Controls.Add(this.btnDeleteFunc);
            this.tpFuncionario.Controls.Add(this.btnSalvarFunc);
            this.tpFuncionario.Controls.Add(this.brnCancelarFunc);
            this.tpFuncionario.Controls.Add(this.btnSairFunc);
            this.tpFuncionario.Controls.Add(this.label3);
            this.tpFuncionario.Controls.Add(this.txtDescFuncao);
            this.tpFuncionario.Controls.Add(this.label4);
            this.tpFuncionario.Controls.Add(this.txtCodeFuncao);
            this.tpFuncionario.Controls.Add(this.label1);
            this.tpFuncionario.Controls.Add(this.label5);
            this.tpFuncionario.Controls.Add(this.dtCadNascFunc);
            this.tpFuncionario.Controls.Add(this.txtCadNomeFunc);
            this.tpFuncionario.Controls.Add(this.txtCadCodFunc);
            this.tpFuncionario.Controls.Add(this.label2);
            this.tpFuncionario.Controls.Add(this.dgvFuncionarios);
            this.tpFuncionario.Location = new System.Drawing.Point(4, 22);
            this.tpFuncionario.Name = "tpFuncionario";
            this.tpFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tpFuncionario.Size = new System.Drawing.Size(958, 458);
            this.tpFuncionario.TabIndex = 1;
            this.tpFuncionario.Text = "Funcionário";
            this.tpFuncionario.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtCadCodFuncao);
            this.groupBox1.Controls.Add(this.txtCadDescFuncao);
            this.groupBox1.Controls.Add(this.btnSalvarFuncao);
            this.groupBox1.Controls.Add(this.dgvFuncao);
            this.groupBox1.Location = new System.Drawing.Point(565, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 122);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Função";
            // 
            // txtCadCodFuncao
            // 
            this.txtCadCodFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadCodFuncao.Location = new System.Drawing.Point(7, 21);
            this.txtCadCodFuncao.Name = "txtCadCodFuncao";
            this.txtCadCodFuncao.ReadOnly = true;
            this.txtCadCodFuncao.Size = new System.Drawing.Size(61, 22);
            this.txtCadCodFuncao.TabIndex = 20;
            this.txtCadCodFuncao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCadDescFuncao
            // 
            this.txtCadDescFuncao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCadDescFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadDescFuncao.Location = new System.Drawing.Point(74, 21);
            this.txtCadDescFuncao.Name = "txtCadDescFuncao";
            this.txtCadDescFuncao.Size = new System.Drawing.Size(217, 22);
            this.txtCadDescFuncao.TabIndex = 20;
            // 
            // btnSalvarFuncao
            // 
            this.btnSalvarFuncao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFuncao.Location = new System.Drawing.Point(297, 21);
            this.btnSalvarFuncao.Name = "btnSalvarFuncao";
            this.btnSalvarFuncao.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarFuncao.TabIndex = 20;
            this.btnSalvarFuncao.Text = "Salvar";
            this.btnSalvarFuncao.UseVisualStyleBackColor = true;
            this.btnSalvarFuncao.Click += new System.EventHandler(this.btnSalvarFuncao_Click);
            // 
            // dgvFuncao
            // 
            this.dgvFuncao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFuncao.BackgroundColor = System.Drawing.Color.White;
            this.dgvFuncao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncao.Location = new System.Drawing.Point(6, 48);
            this.dgvFuncao.Name = "dgvFuncao";
            this.dgvFuncao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncao.Size = new System.Drawing.Size(366, 68);
            this.dgvFuncao.TabIndex = 18;
            this.dgvFuncao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncao_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Situação";
            // 
            // cbSituacaoFunc
            // 
            this.cbSituacaoFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacaoFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSituacaoFunc.FormattingEnabled = true;
            this.cbSituacaoFunc.Location = new System.Drawing.Point(120, 168);
            this.cbSituacaoFunc.Name = "cbSituacaoFunc";
            this.cbSituacaoFunc.Size = new System.Drawing.Size(156, 24);
            this.cbSituacaoFunc.TabIndex = 16;
            // 
            // btnDeleteFunc
            // 
            this.btnDeleteFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFunc.Location = new System.Drawing.Point(787, 166);
            this.btnDeleteFunc.Name = "btnDeleteFunc";
            this.btnDeleteFunc.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFunc.TabIndex = 14;
            this.btnDeleteFunc.Text = "Excluir";
            this.btnDeleteFunc.UseVisualStyleBackColor = true;
            this.btnDeleteFunc.Click += new System.EventHandler(this.btnDeleteFunc_Click);
            // 
            // btnSalvarFunc
            // 
            this.btnSalvarFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFunc.Location = new System.Drawing.Point(625, 166);
            this.btnSalvarFunc.Name = "btnSalvarFunc";
            this.btnSalvarFunc.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarFunc.TabIndex = 12;
            this.btnSalvarFunc.Text = "Salvar";
            this.btnSalvarFunc.UseVisualStyleBackColor = true;
            this.btnSalvarFunc.Click += new System.EventHandler(this.btnSalvarFunc_Click);
            // 
            // brnCancelarFunc
            // 
            this.brnCancelarFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brnCancelarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnCancelarFunc.Location = new System.Drawing.Point(706, 166);
            this.brnCancelarFunc.Name = "brnCancelarFunc";
            this.brnCancelarFunc.Size = new System.Drawing.Size(75, 23);
            this.brnCancelarFunc.TabIndex = 13;
            this.brnCancelarFunc.Text = "Cancelar";
            this.brnCancelarFunc.UseVisualStyleBackColor = true;
            this.brnCancelarFunc.Click += new System.EventHandler(this.brnCancelarFunc_Click);
            // 
            // btnSairFunc
            // 
            this.btnSairFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSairFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairFunc.Location = new System.Drawing.Point(868, 166);
            this.btnSairFunc.Name = "btnSairFunc";
            this.btnSairFunc.Size = new System.Drawing.Size(75, 23);
            this.btnSairFunc.TabIndex = 15;
            this.btnSairFunc.Text = "Sair";
            this.btnSairFunc.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Função";
            // 
            // txtDescFuncao
            // 
            this.txtDescFuncao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescFuncao.Location = new System.Drawing.Point(120, 137);
            this.txtDescFuncao.Name = "txtDescFuncao";
            this.txtDescFuncao.ReadOnly = true;
            this.txtDescFuncao.Size = new System.Drawing.Size(156, 22);
            this.txtDescFuncao.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cód. Função";
            // 
            // txtCodeFuncao
            // 
            this.txtCodeFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeFuncao.Location = new System.Drawing.Point(120, 109);
            this.txtCodeFuncao.Name = "txtCodeFuncao";
            this.txtCodeFuncao.ReadOnly = true;
            this.txtCodeFuncao.Size = new System.Drawing.Size(98, 22);
            this.txtCodeFuncao.TabIndex = 8;
            this.txtCodeFuncao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Data Nascimento";
            // 
            // dtCadNascFunc
            // 
            this.dtCadNascFunc.Location = new System.Drawing.Point(120, 83);
            this.dtCadNascFunc.Mask = "00/00/0000";
            this.dtCadNascFunc.Name = "dtCadNascFunc";
            this.dtCadNascFunc.Size = new System.Drawing.Size(100, 20);
            this.dtCadNascFunc.TabIndex = 5;
            this.dtCadNascFunc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtCadNascFunc.ValidatingType = typeof(System.DateTime);
            // 
            // txtCadNomeFunc
            // 
            this.txtCadNomeFunc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCadNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadNomeFunc.Location = new System.Drawing.Point(120, 55);
            this.txtCadNomeFunc.Name = "txtCadNomeFunc";
            this.txtCadNomeFunc.Size = new System.Drawing.Size(316, 22);
            this.txtCadNomeFunc.TabIndex = 4;
            // 
            // txtCadCodFunc
            // 
            this.txtCadCodFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadCodFunc.Location = new System.Drawing.Point(120, 27);
            this.txtCadCodFunc.Name = "txtCadCodFunc";
            this.txtCadCodFunc.ReadOnly = true;
            this.txtCadCodFunc.Size = new System.Drawing.Size(98, 22);
            this.txtCadCodFunc.TabIndex = 3;
            this.txtCadCodFunc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código";
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFuncionarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(6, 195);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(946, 260);
            this.dgvFuncionarios.TabIndex = 1;
            this.dgvFuncionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellDoubleClick);
            // 
            // tpHorarios
            // 
            this.tpHorarios.Controls.Add(this.label16);
            this.tpHorarios.Controls.Add(this.cbMotivos);
            this.tpHorarios.Controls.Add(this.rbCorrigirHorario);
            this.tpHorarios.Controls.Add(this.rbInserirHorario);
            this.tpHorarios.Controls.Add(this.btnClose);
            this.tpHorarios.Controls.Add(this.btnCancel);
            this.tpHorarios.Controls.Add(this.btnSave);
            this.tpHorarios.Controls.Add(this.label12);
            this.tpHorarios.Controls.Add(this.label13);
            this.tpHorarios.Controls.Add(this.label14);
            this.tpHorarios.Controls.Add(this.label15);
            this.tpHorarios.Controls.Add(this.btnPesquisar);
            this.tpHorarios.Controls.Add(this.txtBuscarFuncionario);
            this.tpHorarios.Controls.Add(this.label11);
            this.tpHorarios.Controls.Add(this.txtData);
            this.tpHorarios.Controls.Add(this.txtSaida);
            this.tpHorarios.Controls.Add(this.txtRetorno);
            this.tpHorarios.Controls.Add(this.txtSaidaAlmoco);
            this.tpHorarios.Controls.Add(this.txtEntrada);
            this.tpHorarios.Controls.Add(this.Data);
            this.tpHorarios.Controls.Add(this.txtId);
            this.tpHorarios.Controls.Add(this.txtNomeHoraFunc);
            this.tpHorarios.Controls.Add(this.label9);
            this.tpHorarios.Controls.Add(this.label10);
            this.tpHorarios.Controls.Add(this.txtCodHoraFunc);
            this.tpHorarios.Controls.Add(this.label7);
            this.tpHorarios.Controls.Add(this.label8);
            this.tpHorarios.Controls.Add(this.dpDtFim);
            this.tpHorarios.Controls.Add(this.dpDtInicio);
            this.tpHorarios.Controls.Add(this.dgvHours);
            this.tpHorarios.Location = new System.Drawing.Point(4, 22);
            this.tpHorarios.Name = "tpHorarios";
            this.tpHorarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpHorarios.Size = new System.Drawing.Size(958, 458);
            this.tpHorarios.TabIndex = 2;
            this.tpHorarios.Text = "Horários";
            this.tpHorarios.UseVisualStyleBackColor = true;
            // 
            // rbCorrigirHorario
            // 
            this.rbCorrigirHorario.AutoSize = true;
            this.rbCorrigirHorario.Location = new System.Drawing.Point(284, 52);
            this.rbCorrigirHorario.Name = "rbCorrigirHorario";
            this.rbCorrigirHorario.Size = new System.Drawing.Size(94, 17);
            this.rbCorrigirHorario.TabIndex = 34;
            this.rbCorrigirHorario.TabStop = true;
            this.rbCorrigirHorario.Text = "Corrigir Horário";
            this.rbCorrigirHorario.UseVisualStyleBackColor = true;
            // 
            // rbInserirHorario
            // 
            this.rbInserirHorario.AutoSize = true;
            this.rbInserirHorario.Location = new System.Drawing.Point(284, 30);
            this.rbInserirHorario.Name = "rbInserirHorario";
            this.rbInserirHorario.Size = new System.Drawing.Size(90, 17);
            this.rbInserirHorario.TabIndex = 33;
            this.rbInserirHorario.TabStop = true;
            this.rbInserirHorario.Text = "Inserir Horário";
            this.rbInserirHorario.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(868, 166);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Sair";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(787, 166);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(706, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(553, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Saida";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(447, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "Ret. Almoço";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(341, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Saida Almoço";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(235, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "Entrada";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(493, 104);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 25;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtBuscarFuncionario
            // 
            this.txtBuscarFuncionario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarFuncionario.Location = new System.Drawing.Point(412, 104);
            this.txtBuscarFuncionario.Name = "txtBuscarFuncionario";
            this.txtBuscarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.txtBuscarFuncionario.TabIndex = 24;
            this.txtBuscarFuncionario.Text = "Buscar";
            this.txtBuscarFuncionario.UseVisualStyleBackColor = true;
            this.txtBuscarFuncionario.Click += new System.EventHandler(this.txtBuscarFuncionario_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Data";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(120, 157);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 18;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtSaida
            // 
            this.txtSaida.Location = new System.Drawing.Point(553, 157);
            this.txtSaida.Mask = "00:00";
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(100, 20);
            this.txtSaida.TabIndex = 22;
            this.txtSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSaida.ValidatingType = typeof(System.DateTime);
            // 
            // txtRetorno
            // 
            this.txtRetorno.Location = new System.Drawing.Point(447, 157);
            this.txtRetorno.Mask = "00:00";
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.Size = new System.Drawing.Size(100, 20);
            this.txtRetorno.TabIndex = 21;
            this.txtRetorno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRetorno.ValidatingType = typeof(System.DateTime);
            // 
            // txtSaidaAlmoco
            // 
            this.txtSaidaAlmoco.Location = new System.Drawing.Point(341, 157);
            this.txtSaidaAlmoco.Mask = "00:00";
            this.txtSaidaAlmoco.Name = "txtSaidaAlmoco";
            this.txtSaidaAlmoco.Size = new System.Drawing.Size(100, 20);
            this.txtSaidaAlmoco.TabIndex = 20;
            this.txtSaidaAlmoco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSaidaAlmoco.ValidatingType = typeof(System.DateTime);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(235, 157);
            this.txtEntrada.Mask = "00:00";
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada.TabIndex = 19;
            this.txtEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.Location = new System.Drawing.Point(6, 132);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(19, 16);
            this.Data.TabIndex = 17;
            this.Data.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(120, 131);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 16;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeHoraFunc
            // 
            this.txtNomeHoraFunc.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeHoraFunc.Location = new System.Drawing.Point(120, 105);
            this.txtNomeHoraFunc.Name = "txtNomeHoraFunc";
            this.txtNomeHoraFunc.ReadOnly = true;
            this.txtNomeHoraFunc.Size = new System.Drawing.Size(285, 20);
            this.txtNomeHoraFunc.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nome";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Código";
            // 
            // txtCodHoraFunc
            // 
            this.txtCodHoraFunc.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodHoraFunc.Location = new System.Drawing.Point(120, 79);
            this.txtCodHoraFunc.Name = "txtCodHoraFunc";
            this.txtCodHoraFunc.ReadOnly = true;
            this.txtCodHoraFunc.Size = new System.Drawing.Size(100, 20);
            this.txtCodHoraFunc.TabIndex = 12;
            this.txtCodHoraFunc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Dt. Fim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Dt. Inicio";
            // 
            // dpDtFim
            // 
            this.dpDtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDtFim.Location = new System.Drawing.Point(120, 53);
            this.dpDtFim.Name = "dpDtFim";
            this.dpDtFim.Size = new System.Drawing.Size(100, 20);
            this.dpDtFim.TabIndex = 9;
            // 
            // dpDtInicio
            // 
            this.dpDtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDtInicio.Location = new System.Drawing.Point(120, 27);
            this.dpDtInicio.Name = "dpDtInicio";
            this.dpDtInicio.Size = new System.Drawing.Size(100, 20);
            this.dpDtInicio.TabIndex = 8;
            // 
            // dgvHours
            // 
            this.dgvHours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHours.BackgroundColor = System.Drawing.Color.White;
            this.dgvHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHours.Location = new System.Drawing.Point(6, 195);
            this.dgvHours.Name = "dgvHours";
            this.dgvHours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHours.Size = new System.Drawing.Size(946, 257);
            this.dgvHours.TabIndex = 1;
            // 
            // cbMotivos
            // 
            this.cbMotivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotivos.FormattingEnabled = true;
            this.cbMotivos.Items.AddRange(new object[] {
            "Atestado médico",
            "Trabalhado"});
            this.cbMotivos.Location = new System.Drawing.Point(284, 79);
            this.cbMotivos.Name = "cbMotivos";
            this.cbMotivos.Size = new System.Drawing.Size(121, 21);
            this.cbMotivos.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(230, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 16);
            this.label16.TabIndex = 36;
            this.label16.Text = "Motivo";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 498);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ERP-Mega";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabPrincipal.ResumeLayout(false);
            this.tpFuncionario.ResumeLayout(false);
            this.tpFuncionario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.tpHorarios.ResumeLayout(false);
            this.tpHorarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpFuncionario;
        private System.Windows.Forms.TabPage tpHorarios;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDescFuncao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodeFuncao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox dtCadNascFunc;
        private System.Windows.Forms.TextBox txtCadNomeFunc;
        private System.Windows.Forms.TextBox txtCadCodFunc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFuncao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSituacaoFunc;
        private System.Windows.Forms.Button btnDeleteFunc;
        private System.Windows.Forms.Button btnSalvarFunc;
        private System.Windows.Forms.Button brnCancelarFunc;
        private System.Windows.Forms.Button btnSairFunc;
        private System.Windows.Forms.TextBox txtCadCodFuncao;
        private System.Windows.Forms.TextBox txtCadDescFuncao;
        private System.Windows.Forms.Button btnSalvarFuncao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button txtBuscarFuncionario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.MaskedTextBox txtSaida;
        private System.Windows.Forms.MaskedTextBox txtRetorno;
        private System.Windows.Forms.MaskedTextBox txtSaidaAlmoco;
        private System.Windows.Forms.MaskedTextBox txtEntrada;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNomeHoraFunc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodHoraFunc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dpDtFim;
        private System.Windows.Forms.DateTimePicker dpDtInicio;
        private System.Windows.Forms.DataGridView dgvHours;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbCorrigirHorario;
        private System.Windows.Forms.RadioButton rbInserirHorario;
        private System.Windows.Forms.ComboBox cbMotivos;
        private System.Windows.Forms.Label label16;
    }
}

