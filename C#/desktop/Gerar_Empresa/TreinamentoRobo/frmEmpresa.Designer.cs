namespace TreinamentoRobo
{
    partial class frmEmpresa
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstadoPesquisa = new System.Windows.Forms.ComboBox();
            this.radN = new System.Windows.Forms.RadioButton();
            this.radS = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInscricaoEstadual = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtDataAbertura = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.numAnos = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.btnGerarEmpresa = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Dados = new System.Windows.Forms.GroupBox();
            this.btnJson = new System.Windows.Forms.Button();
            this.btnCopiarJson = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Dados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Estado:";
            // 
            // cmbEstadoPesquisa
            // 
            this.cmbEstadoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoPesquisa.FormattingEnabled = true;
            this.cmbEstadoPesquisa.Location = new System.Drawing.Point(361, 39);
            this.cmbEstadoPesquisa.Name = "cmbEstadoPesquisa";
            this.cmbEstadoPesquisa.Size = new System.Drawing.Size(157, 26);
            this.cmbEstadoPesquisa.TabIndex = 5;
            // 
            // radN
            // 
            this.radN.AutoSize = true;
            this.radN.Location = new System.Drawing.Point(84, 18);
            this.radN.Name = "radN";
            this.radN.Size = new System.Drawing.Size(54, 22);
            this.radN.TabIndex = 12;
            this.radN.Text = "Não";
            this.radN.UseVisualStyleBackColor = true;
            // 
            // radS
            // 
            this.radS.AutoSize = true;
            this.radS.Checked = true;
            this.radS.Location = new System.Drawing.Point(26, 19);
            this.radS.Name = "radS";
            this.radS.Size = new System.Drawing.Size(52, 22);
            this.radS.TabIndex = 11;
            this.radS.TabStop = true;
            this.radS.Text = "Sim";
            this.radS.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radS);
            this.groupBox3.Controls.Add(this.radN);
            this.groupBox3.Location = new System.Drawing.Point(524, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(141, 45);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gerar Pontuação:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(148, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(286, 24);
            this.txtNome.TabIndex = 45;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJ.Location = new System.Drawing.Point(148, 63);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(286, 24);
            this.txtCNPJ.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "CNPJ:";
            // 
            // txtInscricaoEstadual
            // 
            this.txtInscricaoEstadual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscricaoEstadual.Location = new System.Drawing.Point(148, 93);
            this.txtInscricaoEstadual.Name = "txtInscricaoEstadual";
            this.txtInscricaoEstadual.Size = new System.Drawing.Size(286, 24);
            this.txtInscricaoEstadual.TabIndex = 49;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(9, 96);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(133, 18);
            this.label28.TabIndex = 48;
            this.label28.Text = "Inscrição Estadual:";
            // 
            // txtDataAbertura
            // 
            this.txtDataAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataAbertura.Location = new System.Drawing.Point(148, 123);
            this.txtDataAbertura.Name = "txtDataAbertura";
            this.txtDataAbertura.Size = new System.Drawing.Size(286, 24);
            this.txtDataAbertura.TabIndex = 51;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(19, 126);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(122, 18);
            this.label29.TabIndex = 50;
            this.label29.Text = "Data de Abertura:";
            // 
            // txtSite
            // 
            this.txtSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSite.Location = new System.Drawing.Point(86, 23);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(420, 24);
            this.txtSite.TabIndex = 53;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(45, 26);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(37, 18);
            this.label30.TabIndex = 52;
            this.label30.Text = "Site:";
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Location = new System.Drawing.Point(101, 178);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(286, 24);
            this.txtCEP.TabIndex = 55;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(48, 181);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(43, 18);
            this.label31.TabIndex = 54;
            this.label31.Text = "CEP:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(101, 23);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(320, 24);
            this.txtEndereco.TabIndex = 57;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(15, 26);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(76, 18);
            this.label32.TabIndex = 56;
            this.label32.Text = "Endereço:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(25, 53);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(66, 18);
            this.label33.TabIndex = 58;
            this.label33.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(101, 53);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(78, 24);
            this.txtNumero.TabIndex = 59;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(101, 83);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(286, 24);
            this.txtBairro.TabIndex = 61;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(43, 86);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(52, 18);
            this.label34.TabIndex = 60;
            this.label34.Text = "Bairro:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(101, 111);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(286, 24);
            this.txtCidade.TabIndex = 63;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(43, 114);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(58, 18);
            this.label35.TabIndex = 62;
            this.label35.Text = "Cidade:";
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(101, 144);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(78, 24);
            this.txtEstado.TabIndex = 65;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(43, 147);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(59, 18);
            this.label36.TabIndex = 64;
            this.label36.Text = "Estado:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(86, 83);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(168, 24);
            this.txtTelefone.TabIndex = 67;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(11, 86);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(69, 18);
            this.label37.TabIndex = 66;
            this.label37.Text = "Telefone:";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(86, 113);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(168, 24);
            this.txtCelular.TabIndex = 69;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(24, 116);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(58, 18);
            this.label38.TabIndex = 68;
            this.label38.Text = "Celular:";
            // 
            // numAnos
            // 
            this.numAnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAnos.Location = new System.Drawing.Point(225, 40);
            this.numAnos.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numAnos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAnos.Name = "numAnos";
            this.numAnos.Size = new System.Drawing.Size(65, 24);
            this.numAnos.TabIndex = 70;
            this.numAnos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(7, 42);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(212, 18);
            this.label39.TabIndex = 71;
            this.label39.Text = "Quantos Anos tem a Empresa:";
            // 
            // btnGerarEmpresa
            // 
            this.btnGerarEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarEmpresa.Location = new System.Drawing.Point(506, 123);
            this.btnGerarEmpresa.Name = "btnGerarEmpresa";
            this.btnGerarEmpresa.Size = new System.Drawing.Size(187, 38);
            this.btnGerarEmpresa.TabIndex = 72;
            this.btnGerarEmpresa.Text = "Gerar Empresa";
            this.btnGerarEmpresa.UseVisualStyleBackColor = true;
            this.btnGerarEmpresa.Click += new System.EventHandler(this.btnGerarEmpresa_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(86, 53);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(420, 24);
            this.txtEmail.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 73;
            this.label7.Text = "E-mail:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label39);
            this.groupBox1.Controls.Add(this.numAnos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbEstadoPesquisa);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 100);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSite);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtCelular);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Controls.Add(this.txtTelefone);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 535);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 156);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contato";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtEndereco);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.txtNumero);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.txtCEP);
            this.groupBox4.Controls.Add(this.txtEstado);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.txtBairro);
            this.groupBox4.Controls.Add(this.label36);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.txtCidade);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 307);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(537, 222);
            this.groupBox4.TabIndex = 77;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Localização";
            // 
            // Dados
            // 
            this.Dados.Controls.Add(this.txtNome);
            this.Dados.Controls.Add(this.label1);
            this.Dados.Controls.Add(this.label5);
            this.Dados.Controls.Add(this.txtCNPJ);
            this.Dados.Controls.Add(this.label28);
            this.Dados.Controls.Add(this.txtDataAbertura);
            this.Dados.Controls.Add(this.txtInscricaoEstadual);
            this.Dados.Controls.Add(this.label29);
            this.Dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dados.Location = new System.Drawing.Point(13, 118);
            this.Dados.Name = "Dados";
            this.Dados.Size = new System.Drawing.Size(456, 183);
            this.Dados.TabIndex = 78;
            this.Dados.TabStop = false;
            this.Dados.Text = "Dados";
            // 
            // btnJson
            // 
            this.btnJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJson.Location = new System.Drawing.Point(506, 164);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(187, 38);
            this.btnJson.TabIndex = 79;
            this.btnJson.Text = "Gravar Json";
            this.btnJson.UseVisualStyleBackColor = true;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click_1);
            // 
            // btnCopiarJson
            // 
            this.btnCopiarJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiarJson.Location = new System.Drawing.Point(506, 204);
            this.btnCopiarJson.Name = "btnCopiarJson";
            this.btnCopiarJson.Size = new System.Drawing.Size(187, 38);
            this.btnCopiarJson.TabIndex = 80;
            this.btnCopiarJson.Text = "Copiar Json";
            this.btnCopiarJson.UseVisualStyleBackColor = true;
            this.btnCopiarJson.Click += new System.EventHandler(this.btnCopiarJson_Click);
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 695);
            this.Controls.Add(this.btnCopiarJson);
            this.Controls.Add(this.btnJson);
            this.Controls.Add(this.Dados);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGerarEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Dados.ResumeLayout(false);
            this.Dados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEstadoPesquisa;
        private System.Windows.Forms.RadioButton radN;
        private System.Windows.Forms.RadioButton radS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInscricaoEstadual;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtDataAbertura;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.NumericUpDown numAnos;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button btnGerarEmpresa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox Dados;
        private System.Windows.Forms.Button btnJson;
        private System.Windows.Forms.Button btnCopiarJson;
    }
}

