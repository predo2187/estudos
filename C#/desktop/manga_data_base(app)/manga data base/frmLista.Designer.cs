namespace manga_data_base
{
    partial class frmLista
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
            this.dgvMangas = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radNao = new System.Windows.Forms.RadioButton();
            this.radSim = new System.Windows.Forms.RadioButton();
            this.cmbGenero1 = new System.Windows.Forms.ComboBox();
            this.btnAddEditora = new System.Windows.Forms.Button();
            this.cmbEditora = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSobre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNome2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddGenero2 = new System.Windows.Forms.Button();
            this.btnAddGenero = new System.Windows.Forms.Button();
            this.btnaddMangaka = new System.Windows.Forms.Button();
            this.numPaginas = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numVolumes = new System.Windows.Forms.NumericUpDown();
            this.cmbMangaka = new System.Windows.Forms.ComboBox();
            this.cmbGenero2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radId = new System.Windows.Forms.RadioButton();
            this.radPreco = new System.Windows.Forms.RadioButton();
            this.radVolume = new System.Windows.Forms.RadioButton();
            this.radNome = new System.Windows.Forms.RadioButton();
            this.btnRefreshOrdem = new System.Windows.Forms.Button();
            this.picManga = new System.Windows.Forms.PictureBox();
            this.txtLocalização = new System.Windows.Forms.TextBox();
            this.btnImagem = new System.Windows.Forms.Button();
            this.ofdLogo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolumes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picManga)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMangas
            // 
            this.dgvMangas.AllowUserToAddRows = false;
            this.dgvMangas.AllowUserToDeleteRows = false;
            this.dgvMangas.AllowUserToResizeColumns = false;
            this.dgvMangas.AllowUserToResizeRows = false;
            this.dgvMangas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMangas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMangas.Location = new System.Drawing.Point(15, 76);
            this.dgvMangas.Name = "dgvMangas";
            this.dgvMangas.ReadOnly = true;
            this.dgvMangas.ShowEditingIcon = false;
            this.dgvMangas.Size = new System.Drawing.Size(608, 436);
            this.dgvMangas.TabIndex = 21;
            this.dgvMangas.SelectionChanged += new System.EventHandler(this.dgvMangas_SelectionChanged);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.txtNome.Location = new System.Drawing.Point(106, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(494, 25);
            this.txtNome.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mangáka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Genêro 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Genêro 2:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImagem);
            this.groupBox1.Controls.Add(this.txtLocalização);
            this.groupBox1.Controls.Add(this.picManga);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cmbGenero1);
            this.groupBox1.Controls.Add(this.btnAddEditora);
            this.groupBox1.Controls.Add(this.cmbEditora);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtSobre);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtNome2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnAddGenero2);
            this.groupBox1.Controls.Add(this.btnAddGenero);
            this.groupBox1.Controls.Add(this.btnaddMangaka);
            this.groupBox1.Controls.Add(this.numPaginas);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numVolumes);
            this.groupBox1.Controls.Add(this.cmbMangaka);
            this.groupBox1.Controls.Add(this.cmbGenero2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(629, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 642);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radNao);
            this.groupBox3.Controls.Add(this.radSim);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.groupBox3.Location = new System.Drawing.Point(201, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 67);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Completo";
            // 
            // radNao
            // 
            this.radNao.AutoSize = true;
            this.radNao.Checked = true;
            this.radNao.Location = new System.Drawing.Point(79, 30);
            this.radNao.Name = "radNao";
            this.radNao.Size = new System.Drawing.Size(56, 21);
            this.radNao.TabIndex = 54;
            this.radNao.TabStop = true;
            this.radNao.Text = "Não";
            this.radNao.UseVisualStyleBackColor = true;
            // 
            // radSim
            // 
            this.radSim.AutoSize = true;
            this.radSim.Location = new System.Drawing.Point(20, 30);
            this.radSim.Name = "radSim";
            this.radSim.Size = new System.Drawing.Size(53, 21);
            this.radSim.TabIndex = 55;
            this.radSim.Text = "Sim";
            this.radSim.UseVisualStyleBackColor = true;
            // 
            // cmbGenero1
            // 
            this.cmbGenero1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbGenero1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero1.FormattingEnabled = true;
            this.cmbGenero1.Location = new System.Drawing.Point(105, 122);
            this.cmbGenero1.Name = "cmbGenero1";
            this.cmbGenero1.Size = new System.Drawing.Size(381, 25);
            this.cmbGenero1.TabIndex = 53;
            // 
            // btnAddEditora
            // 
            this.btnAddEditora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEditora.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnAddEditora.Location = new System.Drawing.Point(493, 184);
            this.btnAddEditora.Name = "btnAddEditora";
            this.btnAddEditora.Size = new System.Drawing.Size(107, 25);
            this.btnAddEditora.TabIndex = 52;
            this.btnAddEditora.Text = "Adicionar";
            this.btnAddEditora.UseVisualStyleBackColor = true;
            this.btnAddEditora.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbEditora
            // 
            this.cmbEditora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEditora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditora.FormattingEnabled = true;
            this.cmbEditora.Location = new System.Drawing.Point(106, 184);
            this.cmbEditora.Name = "cmbEditora";
            this.cmbEditora.Size = new System.Drawing.Size(381, 25);
            this.cmbEditora.TabIndex = 51;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(33, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 17);
            this.label15.TabIndex = 50;
            this.label15.Text = "Editora:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(285, 411);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 22);
            this.label14.TabIndex = 49;
            this.label14.Text = "Sobre:";
            // 
            // txtSobre
            // 
            this.txtSobre.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.txtSobre.Location = new System.Drawing.Point(27, 436);
            this.txtSobre.MaxLength = 730;
            this.txtSobre.Multiline = true;
            this.txtSobre.Name = "txtSobre";
            this.txtSobre.Size = new System.Drawing.Size(576, 206);
            this.txtSobre.TabIndex = 48;
            this.txtSobre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 17);
            this.label13.TabIndex = 46;
            this.label13.Text = "Nome 2:";
            // 
            // txtNome2
            // 
            this.txtNome2.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.txtNome2.Location = new System.Drawing.Point(106, 59);
            this.txtNome2.Name = "txtNome2";
            this.txtNome2.Size = new System.Drawing.Size(494, 25);
            this.txtNome2.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(109, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 45;
            this.label11.Text = "R$:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.txtTotal.Location = new System.Drawing.Point(105, 306);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(89, 25);
            this.txtTotal.TabIndex = 44;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(50, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 43;
            this.label12.Text = "Total:";
            // 
            // btnAddGenero2
            // 
            this.btnAddGenero2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGenero2.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnAddGenero2.Location = new System.Drawing.Point(493, 153);
            this.btnAddGenero2.Name = "btnAddGenero2";
            this.btnAddGenero2.Size = new System.Drawing.Size(107, 25);
            this.btnAddGenero2.TabIndex = 42;
            this.btnAddGenero2.Text = "Adicionar";
            this.btnAddGenero2.UseVisualStyleBackColor = true;
            this.btnAddGenero2.Click += new System.EventHandler(this.btnAddGenero2_Click);
            // 
            // btnAddGenero
            // 
            this.btnAddGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGenero.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnAddGenero.Location = new System.Drawing.Point(493, 121);
            this.btnAddGenero.Name = "btnAddGenero";
            this.btnAddGenero.Size = new System.Drawing.Size(107, 25);
            this.btnAddGenero.TabIndex = 41;
            this.btnAddGenero.Text = "Adicionar";
            this.btnAddGenero.UseVisualStyleBackColor = true;
            this.btnAddGenero.Click += new System.EventHandler(this.btnAddGenero_Click);
            // 
            // btnaddMangaka
            // 
            this.btnaddMangaka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddMangaka.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnaddMangaka.Location = new System.Drawing.Point(493, 91);
            this.btnaddMangaka.Name = "btnaddMangaka";
            this.btnaddMangaka.Size = new System.Drawing.Size(107, 25);
            this.btnaddMangaka.TabIndex = 27;
            this.btnaddMangaka.Text = "Adicionar";
            this.btnaddMangaka.UseVisualStyleBackColor = true;
            this.btnaddMangaka.Click += new System.EventHandler(this.btnaddMangaka_Click);
            // 
            // numPaginas
            // 
            this.numPaginas.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.numPaginas.Location = new System.Drawing.Point(106, 247);
            this.numPaginas.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPaginas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPaginas.Name = "numPaginas";
            this.numPaginas.Size = new System.Drawing.Size(56, 25);
            this.numPaginas.TabIndex = 40;
            this.numPaginas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Páginas:";
            // 
            // numVolumes
            // 
            this.numVolumes.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.numVolumes.Location = new System.Drawing.Point(106, 216);
            this.numVolumes.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numVolumes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVolumes.Name = "numVolumes";
            this.numVolumes.Size = new System.Drawing.Size(56, 25);
            this.numVolumes.TabIndex = 38;
            this.numVolumes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbMangaka
            // 
            this.cmbMangaka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMangaka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMangaka.FormattingEnabled = true;
            this.cmbMangaka.Location = new System.Drawing.Point(106, 91);
            this.cmbMangaka.Name = "cmbMangaka";
            this.cmbMangaka.Size = new System.Drawing.Size(381, 25);
            this.cmbMangaka.TabIndex = 37;
            // 
            // cmbGenero2
            // 
            this.cmbGenero2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbGenero2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero2.FormattingEnabled = true;
            this.cmbGenero2.Location = new System.Drawing.Point(106, 153);
            this.cmbGenero2.Name = "cmbGenero2";
            this.cmbGenero2.Size = new System.Drawing.Size(381, 25);
            this.cmbGenero2.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "R$:";
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.txtPreco.Location = new System.Drawing.Point(105, 275);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(89, 25);
            this.txtPreco.TabIndex = 33;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Preço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Volumes:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnDeletar);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(26, 529);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 125);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ações";
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnClear.Location = new System.Drawing.Point(289, 54);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 51);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Límpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnDeletar.Location = new System.Drawing.Point(149, 54);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(134, 51);
            this.btnDeletar.TabIndex = 26;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.button1.Location = new System.Drawing.Point(429, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 51);
            this.button1.TabIndex = 25;
            this.button1.Text = "Saír";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnEditar.Location = new System.Drawing.Point(9, 54);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(134, 51);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(411, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Id:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnRefresh.Location = new System.Drawing.Point(511, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 25);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Atualizar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.txtId.Location = new System.Drawing.Point(443, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(58, 25);
            this.txtId.TabIndex = 37;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radId);
            this.groupBox4.Controls.Add(this.radPreco);
            this.groupBox4.Controls.Add(this.radVolume);
            this.groupBox4.Controls.Add(this.radNome);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.groupBox4.Location = new System.Drawing.Point(15, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 67);
            this.groupBox4.TabIndex = 56;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ordem";
            // 
            // radId
            // 
            this.radId.AutoSize = true;
            this.radId.Checked = true;
            this.radId.Location = new System.Drawing.Point(239, 30);
            this.radId.Name = "radId";
            this.radId.Size = new System.Drawing.Size(40, 21);
            this.radId.TabIndex = 57;
            this.radId.TabStop = true;
            this.radId.Text = "Id";
            this.radId.UseVisualStyleBackColor = true;
            // 
            // radPreco
            // 
            this.radPreco.AutoSize = true;
            this.radPreco.Location = new System.Drawing.Point(166, 30);
            this.radPreco.Name = "radPreco";
            this.radPreco.Size = new System.Drawing.Size(67, 21);
            this.radPreco.TabIndex = 56;
            this.radPreco.Text = "Preço";
            this.radPreco.UseVisualStyleBackColor = true;
            // 
            // radVolume
            // 
            this.radVolume.AutoSize = true;
            this.radVolume.Location = new System.Drawing.Point(72, 30);
            this.radVolume.Name = "radVolume";
            this.radVolume.Size = new System.Drawing.Size(90, 21);
            this.radVolume.TabIndex = 54;
            this.radVolume.Text = "Volumes";
            this.radVolume.UseVisualStyleBackColor = true;
            // 
            // radNome
            // 
            this.radNome.AutoSize = true;
            this.radNome.Location = new System.Drawing.Point(6, 30);
            this.radNome.Name = "radNome";
            this.radNome.Size = new System.Drawing.Size(70, 21);
            this.radNome.TabIndex = 55;
            this.radNome.Text = "Nome";
            this.radNome.UseVisualStyleBackColor = true;
            // 
            // btnRefreshOrdem
            // 
            this.btnRefreshOrdem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshOrdem.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnRefreshOrdem.Location = new System.Drawing.Point(304, 31);
            this.btnRefreshOrdem.Name = "btnRefreshOrdem";
            this.btnRefreshOrdem.Size = new System.Drawing.Size(101, 25);
            this.btnRefreshOrdem.TabIndex = 57;
            this.btnRefreshOrdem.Text = "Atualizar";
            this.btnRefreshOrdem.UseVisualStyleBackColor = true;
            this.btnRefreshOrdem.Click += new System.EventHandler(this.btnRefreshOrdem_Click);
            // 
            // picManga
            // 
            this.picManga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picManga.Location = new System.Drawing.Point(473, 216);
            this.picManga.Name = "picManga";
            this.picManga.Size = new System.Drawing.Size(127, 152);
            this.picManga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManga.TabIndex = 54;
            this.picManga.TabStop = false;
            // 
            // txtLocalização
            // 
            this.txtLocalização.Enabled = false;
            this.txtLocalização.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.txtLocalização.Location = new System.Drawing.Point(27, 374);
            this.txtLocalização.Name = "txtLocalização";
            this.txtLocalização.Size = new System.Drawing.Size(576, 25);
            this.txtLocalização.TabIndex = 55;
            // 
            // btnImagem
            // 
            this.btnImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImagem.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnImagem.Location = new System.Drawing.Point(316, 332);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(151, 36);
            this.btnImagem.TabIndex = 56;
            this.btnImagem.Text = "Carregar Imagem";
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.btnImagem_Click);
            // 
            // ofdLogo
            // 
            this.ofdLogo.FileName = "openFileDialog1";
            this.ofdLogo.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdLogo_FileOk);
            // 
            // frmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 666);
            this.Controls.Add(this.btnRefreshOrdem);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMangas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.frmLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolumes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picManga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMangas;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.NumericUpDown txtId;
        private System.Windows.Forms.ComboBox cmbGenero2;
        private System.Windows.Forms.ComboBox cmbMangaka;
        private System.Windows.Forms.NumericUpDown numVolumes;
        private System.Windows.Forms.NumericUpDown numPaginas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddGenero2;
        private System.Windows.Forms.Button btnAddGenero;
        private System.Windows.Forms.Button btnaddMangaka;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNome2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSobre;
        private System.Windows.Forms.Button btnAddEditora;
        private System.Windows.Forms.ComboBox cmbEditora;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbGenero1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radSim;
        private System.Windows.Forms.RadioButton radNao;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radId;
        private System.Windows.Forms.RadioButton radPreco;
        private System.Windows.Forms.RadioButton radVolume;
        private System.Windows.Forms.RadioButton radNome;
        private System.Windows.Forms.Button btnRefreshOrdem;
        private System.Windows.Forms.PictureBox picManga;
        private System.Windows.Forms.TextBox txtLocalização;
        private System.Windows.Forms.Button btnImagem;
        private System.Windows.Forms.OpenFileDialog ofdLogo;
    }
}