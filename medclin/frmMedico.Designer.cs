namespace medclin
{
    partial class frmCadastroMedico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            System.Windows.Forms.Label idmedicoLabel;
            System.Windows.Forms.Label nomeMLabel;
            System.Windows.Forms.Label cRMLabel;
            System.Windows.Forms.Label cBOLabel;
            System.Windows.Forms.Label formacaoLabel;
            System.Windows.Forms.Label especialidadeLabel;
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCRM = new System.Windows.Forms.MaskedTextBox();
            this.txtCbo = new System.Windows.Forms.MaskedTextBox();
            this.txtFormacao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEspecialidade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNovo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.rbCRM = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dgvMedico = new System.Windows.Forms.DataGridView();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            idmedicoLabel = new System.Windows.Forms.Label();
            nomeMLabel = new System.Windows.Forms.Label();
            cRMLabel = new System.Windows.Forms.Label();
            cBOLabel = new System.Windows.Forms.Label();
            formacaoLabel = new System.Windows.Forms.Label();
            especialidadeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // idmedicoLabel
            // 
            idmedicoLabel.AutoSize = true;
            idmedicoLabel.Location = new System.Drawing.Point(18, 31);
            idmedicoLabel.Name = "idmedicoLabel";
            idmedicoLabel.Size = new System.Drawing.Size(59, 13);
            idmedicoLabel.TabIndex = 1;
            idmedicoLabel.Text = "ID Médico:";
            // 
            // nomeMLabel
            // 
            nomeMLabel.AutoSize = true;
            nomeMLabel.Location = new System.Drawing.Point(13, 75);
            nomeMLabel.Name = "nomeMLabel";
            nomeMLabel.Size = new System.Drawing.Size(91, 13);
            nomeMLabel.TabIndex = 3;
            nomeMLabel.Text = "Nome do Médico:";
            // 
            // cRMLabel
            // 
            cRMLabel.AutoSize = true;
            cRMLabel.Location = new System.Drawing.Point(13, 114);
            cRMLabel.Name = "cRMLabel";
            cRMLabel.Size = new System.Drawing.Size(34, 13);
            cRMLabel.TabIndex = 5;
            cRMLabel.Text = "CRM:";
            // 
            // cBOLabel
            // 
            cBOLabel.AutoSize = true;
            cBOLabel.Location = new System.Drawing.Point(154, 114);
            cBOLabel.Name = "cBOLabel";
            cBOLabel.Size = new System.Drawing.Size(32, 13);
            cBOLabel.TabIndex = 7;
            cBOLabel.Text = "CBO:";
            // 
            // formacaoLabel
            // 
            formacaoLabel.AutoSize = true;
            formacaoLabel.Location = new System.Drawing.Point(13, 154);
            formacaoLabel.Name = "formacaoLabel";
            formacaoLabel.Size = new System.Drawing.Size(57, 13);
            formacaoLabel.TabIndex = 9;
            formacaoLabel.Text = "Formacao:";
            // 
            // especialidadeLabel
            // 
            especialidadeLabel.AutoSize = true;
            especialidadeLabel.Location = new System.Drawing.Point(154, 154);
            especialidadeLabel.Name = "especialidadeLabel";
            especialidadeLabel.Size = new System.Drawing.Size(76, 13);
            especialidadeLabel.TabIndex = 11;
            especialidadeLabel.Text = "Especialidade:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(16, 52);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(16, 91);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(260, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtCRM
            // 
            this.txtCRM.Enabled = false;
            this.txtCRM.Location = new System.Drawing.Point(16, 130);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(119, 20);
            this.txtCRM.TabIndex = 6;
            // 
            // txtCbo
            // 
            this.txtCbo.Enabled = false;
            this.txtCbo.Location = new System.Drawing.Point(157, 130);
            this.txtCbo.Name = "txtCbo";
            this.txtCbo.Size = new System.Drawing.Size(119, 20);
            this.txtCbo.TabIndex = 8;
            // 
            // txtFormacao
            // 
            this.txtFormacao.Enabled = false;
            this.txtFormacao.Location = new System.Drawing.Point(16, 170);
            this.txtFormacao.Name = "txtFormacao";
            this.txtFormacao.Size = new System.Drawing.Size(119, 20);
            this.txtFormacao.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEspecialidade);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(nomeMLabel);
            this.groupBox1.Controls.Add(cRMLabel);
            this.groupBox1.Controls.Add(this.txtCbo);
            this.groupBox1.Controls.Add(this.txtCRM);
            this.groupBox1.Controls.Add(cBOLabel);
            this.groupBox1.Controls.Add(this.txtFormacao);
            this.groupBox1.Controls.Add(formacaoLabel);
            this.groupBox1.Controls.Add(idmedicoLabel);
            this.groupBox1.Controls.Add(especialidadeLabel);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Location = new System.Drawing.Point(45, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 202);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Médico";
            // 
            // cmbEspecialidade
            // 
            this.cmbEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidade.FormattingEnabled = true;
            this.cmbEspecialidade.Items.AddRange(new object[] {
            "Cardiologista",
            "Clinico geral",
            "Neurologista",
            "Psiquiatra",
            "Ortomolecular",
            "Geriatria",
            "Ginicologista"});
            this.cmbEspecialidade.Location = new System.Drawing.Point(156, 169);
            this.cmbEspecialidade.Name = "cmbEspecialidade";
            this.cmbEspecialidade.Size = new System.Drawing.Size(120, 21);
            this.cmbEspecialidade.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 33);
            this.label2.TabIndex = 103;
            this.label2.Text = "Cadastro de Médico";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrar.BorderRadius = 0;
            this.btnCadastrar.ButtonText = "          Cadastrar";
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Iconimage = null;
            this.btnCadastrar.Iconimage_right = null;
            this.btnCadastrar.Iconimage_right_Selected = null;
            this.btnCadastrar.Iconimage_Selected = null;
            this.btnCadastrar.IconMarginLeft = 0;
            this.btnCadastrar.IconMarginRight = 0;
            this.btnCadastrar.IconRightVisible = true;
            this.btnCadastrar.IconRightZoom = 0D;
            this.btnCadastrar.IconVisible = true;
            this.btnCadastrar.IconZoom = 90D;
            this.btnCadastrar.IsTab = false;
            this.btnCadastrar.Location = new System.Drawing.Point(123, 381);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Normalcolor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnCadastrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCadastrar.selected = false;
            this.btnCadastrar.Size = new System.Drawing.Size(70, 45);
            this.btnCadastrar.TabIndex = 105;
            this.btnCadastrar.Text = "          Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrar.Textcolor = System.Drawing.Color.White;
            this.btnCadastrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.BorderRadius = 0;
            this.btnNovo.ButtonText = "Novo";
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.DisabledColor = System.Drawing.Color.Gray;
            this.btnNovo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNovo.Iconimage = null;
            this.btnNovo.Iconimage_right = null;
            this.btnNovo.Iconimage_right_Selected = null;
            this.btnNovo.Iconimage_Selected = null;
            this.btnNovo.IconMarginLeft = 0;
            this.btnNovo.IconMarginRight = 0;
            this.btnNovo.IconRightVisible = true;
            this.btnNovo.IconRightZoom = 0D;
            this.btnNovo.IconVisible = true;
            this.btnNovo.IconZoom = 90D;
            this.btnNovo.IsTab = false;
            this.btnNovo.Location = new System.Drawing.Point(45, 381);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNovo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnNovo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNovo.selected = false;
            this.btnNovo.Size = new System.Drawing.Size(70, 45);
            this.btnNovo.TabIndex = 106;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Textcolor = System.Drawing.Color.White;
            this.btnNovo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // rbCRM
            // 
            this.rbCRM.AutoSize = true;
            this.rbCRM.Location = new System.Drawing.Point(463, 157);
            this.rbCRM.Name = "rbCRM";
            this.rbCRM.Size = new System.Drawing.Size(49, 17);
            this.rbCRM.TabIndex = 117;
            this.rbCRM.TabStop = true;
            this.rbCRM.Text = "CRM";
            this.rbCRM.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Location = new System.Drawing.Point(385, 157);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(53, 17);
            this.rbNome.TabIndex = 116;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(385, 180);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(513, 20);
            this.txtValor.TabIndex = 115;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // dgvMedico
            // 
            this.dgvMedico.AllowUserToAddRows = false;
            this.dgvMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedico.Location = new System.Drawing.Point(385, 206);
            this.dgvMedico.Name = "dgvMedico";
            this.dgvMedico.RowHeadersVisible = false;
            this.dgvMedico.Size = new System.Drawing.Size(513, 220);
            this.dgvMedico.TabIndex = 113;
            this.dgvMedico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedico_CellDoubleClick);
            // 
            // btnEditar
            // 
            this.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.btnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.BorderRadius = 0;
            this.btnEditar.ButtonText = "Editar";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditar.Iconimage = null;
            this.btnEditar.Iconimage_right = null;
            this.btnEditar.Iconimage_right_Selected = null;
            this.btnEditar.Iconimage_Selected = null;
            this.btnEditar.IconMarginLeft = 0;
            this.btnEditar.IconMarginRight = 0;
            this.btnEditar.IconRightVisible = true;
            this.btnEditar.IconRightZoom = 0D;
            this.btnEditar.IconVisible = true;
            this.btnEditar.IconZoom = 90D;
            this.btnEditar.IsTab = false;
            this.btnEditar.Location = new System.Drawing.Point(201, 381);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(70, 45);
            this.btnEditar.TabIndex = 118;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Textcolor = System.Drawing.Color.White;
            this.btnEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BorderRadius = 0;
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelar.Iconimage = null;
            this.btnCancelar.Iconimage_right = null;
            this.btnCancelar.Iconimage_right_Selected = null;
            this.btnCancelar.Iconimage_Selected = null;
            this.btnCancelar.IconMarginLeft = 0;
            this.btnCancelar.IconMarginRight = 0;
            this.btnCancelar.IconRightVisible = true;
            this.btnCancelar.IconRightZoom = 0D;
            this.btnCancelar.IconVisible = true;
            this.btnCancelar.IconZoom = 90D;
            this.btnCancelar.IsTab = false;
            this.btnCancelar.Location = new System.Drawing.Point(279, 381);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(70, 45);
            this.btnCancelar.TabIndex = 119;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Textcolor = System.Drawing.Color.White;
            this.btnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmCadastroMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 633);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.rbCRM);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.dgvMedico);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(308, 66);
            this.Name = "frmCadastroMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarM";
            this.Load += new System.EventHandler(this.CadastrarM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtCRM;
        private System.Windows.Forms.MaskedTextBox txtCbo;
        private System.Windows.Forms.TextBox txtFormacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnCadastrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnNovo;
        private System.Windows.Forms.RadioButton rbCRM;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridView dgvMedico;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private System.Windows.Forms.ComboBox cmbEspecialidade;
    }
}