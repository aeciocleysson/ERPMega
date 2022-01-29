
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPrincipal.SuspendLayout();
            this.tpFuncionario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPrincipal.Controls.Add(this.tabPage1);
            this.tabPrincipal.Controls.Add(this.tpFuncionario);
            this.tabPrincipal.Controls.Add(this.tabPage3);
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
            this.tabPage1.Text = "tabPage1";
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
            this.dgvFuncionarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(6, 195);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(946, 257);
            this.dgvFuncionarios.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(958, 458);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpFuncionario;
        private System.Windows.Forms.TabPage tabPage3;
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
    }
}

