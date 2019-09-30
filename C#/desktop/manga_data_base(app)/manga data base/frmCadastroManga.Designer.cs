namespace manga_data_base
{
    partial class frmCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.numVolume = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCadEditora = new System.Windows.Forms.Button();
            this.txtSobre = new System.Windows.Forms.TextBox();
            this.cmbEditora = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadGen2 = new System.Windows.Forms.Button();
            this.cmbGenero2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCadGen1 = new System.Windows.Forms.Button();
            this.cmbGenero1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCadMangaka = new System.Windows.Forms.Button();
            this.cmbMangaka = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numPagina = new System.Windows.Forms.NumericUpDown();
            this.btnCadManga = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNome2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radNao = new System.Windows.Forms.RadioButton();
            this.radSim = new System.Windows.Forms.RadioButton();
            this.picManga = new System.Windows.Forms.PictureBox();
            this.btnAddImagem = new System.Windows.Forms.Button();
            this.ofdLogo = new System.Windows.Forms.OpenFileDialog();
            this.txtLocalização = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numVolume)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPagina)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picManga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome 1:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.txtNome.Location = new System.Drawing.Point(86, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(346, 25);
            this.txtNome.TabIndex = 1;
            // 
            // numVolume
            // 
            this.numVolume.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.numVolume.Location = new System.Drawing.Point(519, 10);
            this.numVolume.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numVolume.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVolume.Name = "numVolume";
            this.numVolume.Size = new System.Drawing.Size(50, 25);
            this.numVolume.TabIndex = 2;
            this.numVolume.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Volumes:";
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.txtPreco.Location = new System.Drawing.Point(643, 9);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(89, 25);
            this.txtPreco.TabIndex = 20;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(581, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(647, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "R$:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnCadEditora);
            this.groupBox1.Controls.Add(this.txtSobre);
            this.groupBox1.Controls.Add(this.cmbEditora);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.btnCadGen2);
            this.groupBox1.Controls.Add(this.cmbGenero2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnCadGen1);
            this.groupBox1.Controls.Add(this.cmbGenero1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnCadMangaka);
            this.groupBox1.Controls.Add(this.cmbMangaka);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numPagina);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(27, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1231, 263);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(896, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 22);
            this.label14.TabIndex = 51;
            this.label14.Text = "Sobre:";
            // 
            // btnCadEditora
            // 
            this.btnCadEditora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadEditora.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnCadEditora.Location = new System.Drawing.Point(542, 184);
            this.btnCadEditora.Name = "btnCadEditora";
            this.btnCadEditora.Size = new System.Drawing.Size(96, 35);
            this.btnCadEditora.TabIndex = 22;
            this.btnCadEditora.Text = "Adicionar";
            this.btnCadEditora.UseVisualStyleBackColor = true;
            this.btnCadEditora.Click += new System.EventHandler(this.btnCadEditora_Click);
            // 
            // txtSobre
            // 
            this.txtSobre.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.txtSobre.Location = new System.Drawing.Point(644, 51);
            this.txtSobre.MaxLength = 730;
            this.txtSobre.Multiline = true;
            this.txtSobre.Name = "txtSobre";
            this.txtSobre.Size = new System.Drawing.Size(576, 206);
            this.txtSobre.TabIndex = 50;
            this.txtSobre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbEditora
            // 
            this.cmbEditora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEditora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditora.FormattingEnabled = true;
            this.cmbEditora.Location = new System.Drawing.Point(84, 192);
            this.cmbEditora.Name = "cmbEditora";
            this.cmbEditora.Size = new System.Drawing.Size(449, 25);
            this.cmbEditora.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Editora:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnAtualizar.Location = new System.Drawing.Point(542, 225);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(96, 25);
            this.btnAtualizar.TabIndex = 21;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click_1);
            // 
            // btnCadGen2
            // 
            this.btnCadGen2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadGen2.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnCadGen2.Location = new System.Drawing.Point(542, 143);
            this.btnCadGen2.Name = "btnCadGen2";
            this.btnCadGen2.Size = new System.Drawing.Size(96, 35);
            this.btnCadGen2.TabIndex = 18;
            this.btnCadGen2.Text = "Adicionar";
            this.btnCadGen2.UseVisualStyleBackColor = true;
            this.btnCadGen2.Click += new System.EventHandler(this.btnCadGen2_Click_1);
            // 
            // cmbGenero2
            // 
            this.cmbGenero2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbGenero2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero2.FormattingEnabled = true;
            this.cmbGenero2.Location = new System.Drawing.Point(84, 149);
            this.cmbGenero2.Name = "cmbGenero2";
            this.cmbGenero2.Size = new System.Drawing.Size(449, 25);
            this.cmbGenero2.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Genêro 2:";
            // 
            // btnCadGen1
            // 
            this.btnCadGen1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadGen1.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnCadGen1.Location = new System.Drawing.Point(542, 102);
            this.btnCadGen1.Name = "btnCadGen1";
            this.btnCadGen1.Size = new System.Drawing.Size(96, 35);
            this.btnCadGen1.TabIndex = 15;
            this.btnCadGen1.Text = "Adicionar";
            this.btnCadGen1.UseVisualStyleBackColor = true;
            this.btnCadGen1.Click += new System.EventHandler(this.btnCadGen1_Click_1);
            // 
            // cmbGenero1
            // 
            this.cmbGenero1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbGenero1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero1.FormattingEnabled = true;
            this.cmbGenero1.Location = new System.Drawing.Point(84, 108);
            this.cmbGenero1.Name = "cmbGenero1";
            this.cmbGenero1.Size = new System.Drawing.Size(449, 25);
            this.cmbGenero1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Genêro 1:";
            // 
            // btnCadMangaka
            // 
            this.btnCadMangaka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadMangaka.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnCadMangaka.Location = new System.Drawing.Point(542, 61);
            this.btnCadMangaka.Name = "btnCadMangaka";
            this.btnCadMangaka.Size = new System.Drawing.Size(96, 35);
            this.btnCadMangaka.TabIndex = 12;
            this.btnCadMangaka.Text = "Adicionar";
            this.btnCadMangaka.UseVisualStyleBackColor = true;
            this.btnCadMangaka.Click += new System.EventHandler(this.btnCadMangaka_Click);
            // 
            // cmbMangaka
            // 
            this.cmbMangaka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMangaka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMangaka.FormattingEnabled = true;
            this.cmbMangaka.Location = new System.Drawing.Point(84, 67);
            this.cmbMangaka.Name = "cmbMangaka";
            this.cmbMangaka.Size = new System.Drawing.Size(449, 25);
            this.cmbMangaka.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mangáka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Páginas:";
            // 
            // numPagina
            // 
            this.numPagina.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.numPagina.Location = new System.Drawing.Point(84, 25);
            this.numPagina.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPagina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPagina.Name = "numPagina";
            this.numPagina.Size = new System.Drawing.Size(73, 25);
            this.numPagina.TabIndex = 12;
            this.numPagina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCadManga
            // 
            this.btnCadManga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadManga.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnCadManga.Location = new System.Drawing.Point(42, 28);
            this.btnCadManga.Name = "btnCadManga";
            this.btnCadManga.Size = new System.Drawing.Size(157, 50);
            this.btnCadManga.TabIndex = 12;
            this.btnCadManga.Text = "Cadastrar";
            this.btnCadManga.UseVisualStyleBackColor = true;
            this.btnCadManga.Click += new System.EventHandler(this.btnCadManga_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.button1.Location = new System.Drawing.Point(369, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "Saír";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.button2.Location = new System.Drawing.Point(206, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 50);
            this.button2.TabIndex = 15;
            this.button2.Text = "Límpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNome2
            // 
            this.txtNome2.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.txtNome2.Location = new System.Drawing.Point(86, 41);
            this.txtNome2.Name = "txtNome2";
            this.txtNome2.Size = new System.Drawing.Size(346, 25);
            this.txtNome2.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nome 2:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnCadManga);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(374, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 99);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radNao);
            this.groupBox3.Controls.Add(this.radSim);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.groupBox3.Location = new System.Drawing.Point(757, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 67);
            this.groupBox3.TabIndex = 53;
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
            this.radSim.TabStop = true;
            this.radSim.Text = "Sim";
            this.radSim.UseVisualStyleBackColor = true;
            // 
            // picManga
            // 
            this.picManga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picManga.Location = new System.Drawing.Point(27, 344);
            this.picManga.Name = "picManga";
            this.picManga.Size = new System.Drawing.Size(173, 225);
            this.picManga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManga.TabIndex = 54;
            this.picManga.TabStop = false;
            // 
            // btnAddImagem
            // 
            this.btnAddImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddImagem.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnAddImagem.Location = new System.Drawing.Point(206, 501);
            this.btnAddImagem.Name = "btnAddImagem";
            this.btnAddImagem.Size = new System.Drawing.Size(142, 37);
            this.btnAddImagem.TabIndex = 16;
            this.btnAddImagem.Text = "Carregar Imagem";
            this.btnAddImagem.UseVisualStyleBackColor = true;
            this.btnAddImagem.Click += new System.EventHandler(this.btnAddImagem_Click);
            // 
            // ofdLogo
            // 
            this.ofdLogo.FileName = "openFileDialog1";
            this.ofdLogo.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdLogo_FileOk);
            // 
            // txtLocalização
            // 
            this.txtLocalização.Enabled = false;
            this.txtLocalização.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.txtLocalização.Location = new System.Drawing.Point(305, 544);
            this.txtLocalização.Name = "txtLocalização";
            this.txtLocalização.Size = new System.Drawing.Size(950, 25);
            this.txtLocalização.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(203, 547);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 55;
            this.label10.Text = "Localização:";
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 581);
            this.Controls.Add(this.txtLocalização);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAddImagem);
            this.Controls.Add(this.picManga);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtNome2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numVolume);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numVolume)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPagina)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picManga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.NumericUpDown numVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCadGen2;
        private System.Windows.Forms.ComboBox cmbGenero2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCadGen1;
        private System.Windows.Forms.ComboBox cmbGenero1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCadMangaka;
        private System.Windows.Forms.ComboBox cmbMangaka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numPagina;
        private System.Windows.Forms.Button btnCadManga;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNome2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCadEditora;
        private System.Windows.Forms.ComboBox cmbEditora;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSobre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radNao;
        private System.Windows.Forms.RadioButton radSim;
        private System.Windows.Forms.PictureBox picManga;
        private System.Windows.Forms.Button btnAddImagem;
        private System.Windows.Forms.OpenFileDialog ofdLogo;
        private System.Windows.Forms.TextBox txtLocalização;
        private System.Windows.Forms.Label label10;
    }
}

