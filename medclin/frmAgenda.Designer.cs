namespace medclin
{
    partial class frmCadastroAgenda
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeMLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.cmbEspecialidade = new System.Windows.Forms.ComboBox();
            this.dT_NASCDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtData = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAgendar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.rbCRM = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvAgendamento = new System.Windows.Forms.DataGridView();
            this.lbConsultarAgen = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            nomeMLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamento)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeMLabel
            // 
            nomeMLabel.AutoSize = true;
            nomeMLabel.Location = new System.Drawing.Point(159, 107);
            nomeMLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeMLabel.Name = "nomeMLabel";
            nomeMLabel.Size = new System.Drawing.Size(139, 17);
            nomeMLabel.TabIndex = 114;
            nomeMLabel.Text = "Numero da consulta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(483, 107);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(128, 17);
            label3.TabIndex = 115;
            label3.Text = "Nome do Paciente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(159, 183);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(118, 17);
            label4.TabIndex = 117;
            label4.Text = "Nome do Medico:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(162, 249);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(100, 17);
            label5.TabIndex = 119;
            label5.Text = "Especialidade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(561, 178);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(49, 17);
            label6.TabIndex = 121;
            label6.Text = "DATA:";
            label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(557, 244);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(52, 17);
            label7.TabIndex = 123;
            label7.Text = "HORA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 33);
            this.label2.TabIndex = 104;
            this.label2.Text = "Pacientes Cadastrados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 40);
            this.label1.TabIndex = 109;
            this.label1.Text = "Agendar Paciente";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(306, 107);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(169, 22);
            this.txtCodigo.TabIndex = 112;
            // 
            // cmbMedico
            // 
            this.cmbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Items.AddRange(new object[] {
            "Jefferson da Silva",
            "Rosely Januario",
            "Emilio Macedo"});
            this.cmbMedico.Location = new System.Drawing.Point(285, 179);
            this.cmbMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(240, 24);
            this.cmbMedico.TabIndex = 116;
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
            this.cmbEspecialidade.Location = new System.Drawing.Point(285, 242);
            this.cmbEspecialidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEspecialidade.Name = "cmbEspecialidade";
            this.cmbEspecialidade.Size = new System.Drawing.Size(240, 24);
            this.cmbEspecialidade.TabIndex = 118;
            this.cmbEspecialidade.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidade_SelectedIndexChanged);
            // 
            // dT_NASCDateTimePicker
            // 
            this.dT_NASCDateTimePicker.Enabled = false;
            this.dT_NASCDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dT_NASCDateTimePicker.Location = new System.Drawing.Point(618, 178);
            this.dT_NASCDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dT_NASCDateTimePicker.Name = "dT_NASCDateTimePicker";
            this.dT_NASCDateTimePicker.Size = new System.Drawing.Size(120, 22);
            this.dT_NASCDateTimePicker.TabIndex = 120;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(618, 244);
            this.txtData.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtData.MaxLength = 3;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(175, 22);
            this.txtData.TabIndex = 122;
            // 
            // btnAgendar
            // 
            this.btnAgendar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.btnAgendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgendar.BorderRadius = 0;
            this.btnAgendar.ButtonText = "Agendar";
            this.btnAgendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgendar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgendar.Iconimage = null;
            this.btnAgendar.Iconimage_right = null;
            this.btnAgendar.Iconimage_right_Selected = null;
            this.btnAgendar.Iconimage_Selected = null;
            this.btnAgendar.IconMarginLeft = 0;
            this.btnAgendar.IconMarginRight = 0;
            this.btnAgendar.IconRightVisible = true;
            this.btnAgendar.IconRightZoom = 0D;
            this.btnAgendar.IconVisible = true;
            this.btnAgendar.IconZoom = 90D;
            this.btnAgendar.IsTab = false;
            this.btnAgendar.Location = new System.Drawing.Point(849, 137);
            this.btnAgendar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgendar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnAgendar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgendar.selected = false;
            this.btnAgendar.Size = new System.Drawing.Size(171, 48);
            this.btnAgendar.TabIndex = 124;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendar.Textcolor = System.Drawing.Color.White;
            this.btnAgendar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // rbCRM
            // 
            this.rbCRM.AutoSize = true;
            this.rbCRM.Location = new System.Drawing.Point(165, 411);
            this.rbCRM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbCRM.Name = "rbCRM";
            this.rbCRM.Size = new System.Drawing.Size(115, 21);
            this.rbCRM.TabIndex = 130;
            this.rbCRM.TabStop = true;
            this.rbCRM.Text = "Nome Medico";
            this.rbCRM.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Location = new System.Drawing.Point(165, 383);
            this.rbNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(125, 21);
            this.rbNome.TabIndex = 129;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome Paciente";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(319, 397);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(508, 22);
            this.txtValor.TabIndex = 128;
            // 
            // btnConsultar
            // 
            this.btnConsultar.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.btnConsultar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.btnConsultar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultar.BorderRadius = 0;
            this.btnConsultar.ButtonText = "Consultar";
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.DisabledColor = System.Drawing.Color.Gray;
            this.btnConsultar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConsultar.Iconimage = null;
            this.btnConsultar.Iconimage_right = null;
            this.btnConsultar.Iconimage_right_Selected = null;
            this.btnConsultar.Iconimage_Selected = null;
            this.btnConsultar.IconMarginLeft = 0;
            this.btnConsultar.IconMarginRight = 0;
            this.btnConsultar.IconRightVisible = true;
            this.btnConsultar.IconRightZoom = 0D;
            this.btnConsultar.IconVisible = true;
            this.btnConsultar.IconZoom = 90D;
            this.btnConsultar.IsTab = false;
            this.btnConsultar.Location = new System.Drawing.Point(849, 383);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Normalcolor = System.Drawing.SystemColors.Highlight;
            this.btnConsultar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnConsultar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConsultar.selected = false;
            this.btnConsultar.Size = new System.Drawing.Size(171, 52);
            this.btnConsultar.TabIndex = 127;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Textcolor = System.Drawing.Color.White;
            this.btnConsultar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvAgendamento
            // 
            this.dgvAgendamento.AllowUserToAddRows = false;
            this.dgvAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendamento.Location = new System.Drawing.Point(165, 459);
            this.dgvAgendamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAgendamento.Name = "dgvAgendamento";
            this.dgvAgendamento.RowHeadersVisible = false;
            this.dgvAgendamento.Size = new System.Drawing.Size(855, 271);
            this.dgvAgendamento.TabIndex = 126;
            // 
            // lbConsultarAgen
            // 
            this.lbConsultarAgen.AutoSize = true;
            this.lbConsultarAgen.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultarAgen.Location = new System.Drawing.Point(384, 328);
            this.lbConsultarAgen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConsultarAgen.Name = "lbConsultarAgen";
            this.lbConsultarAgen.Size = new System.Drawing.Size(424, 40);
            this.lbConsultarAgen.TabIndex = 125;
            this.lbConsultarAgen.Text = "Consultar Agendamento";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(618, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 22);
            this.textBox1.TabIndex = 131;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Editar";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(849, 328);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.Highlight;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(171, 48);
            this.bunifuFlatButton1.TabIndex = 132;
            this.bunifuFlatButton1.Text = "Editar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Cancelar";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(849, 195);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.SystemColors.Highlight;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(171, 48);
            this.bunifuFlatButton2.TabIndex = 133;
            this.bunifuFlatButton2.Text = "Cancelar";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.SystemColors.Highlight;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Novo";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(849, 253);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.SystemColors.Highlight;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(171, 48);
            this.bunifuFlatButton3.TabIndex = 134;
            this.bunifuFlatButton3.Text = "Novo";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmCadastroAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 779);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbCRM);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvAgendamento);
            this.Controls.Add(this.lbConsultarAgen);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(label7);
            this.Controls.Add(this.txtData);
            this.Controls.Add(label6);
            this.Controls.Add(this.dT_NASCDateTimePicker);
            this.Controls.Add(label5);
            this.Controls.Add(this.cmbEspecialidade);
            this.Controls.Add(label4);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(label3);
            this.Controls.Add(nomeMLabel);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(308, 66);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCadastroAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaP";
            this.Load += new System.EventHandler(this.frmCadastroAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.ComboBox cmbEspecialidade;
        private System.Windows.Forms.DateTimePicker dT_NASCDateTimePicker;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgendar;
        private System.Windows.Forms.RadioButton rbCRM;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.TextBox txtValor;
        private Bunifu.Framework.UI.BunifuFlatButton btnConsultar;
        private System.Windows.Forms.DataGridView dgvAgendamento;
        private System.Windows.Forms.Label lbConsultarAgen;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
    }
}