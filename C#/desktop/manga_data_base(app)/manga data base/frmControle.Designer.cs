namespace manga_data_base
{
    partial class frmControle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numVolumes = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btndicionar = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numAtual = new System.Windows.Forms.NumericUpDown();
            this.btnRefreshOrdem = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radId = new System.Windows.Forms.RadioButton();
            this.radPreco = new System.Windows.Forms.RadioButton();
            this.radVolume = new System.Windows.Forms.RadioButton();
            this.radNome = new System.Windows.Forms.RadioButton();
            this.picManga = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolumes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAtual)).BeginInit();
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
            this.dgvMangas.Location = new System.Drawing.Point(12, 85);
            this.dgvMangas.Name = "dgvMangas";
            this.dgvMangas.ReadOnly = true;
            this.dgvMangas.Size = new System.Drawing.Size(544, 352);
            this.dgvMangas.TabIndex = 22;
            this.dgvMangas.SelectionChanged += new System.EventHandler(this.dgvMangas_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.txtNome.Location = new System.Drawing.Point(83, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(432, 25);
            this.txtNome.TabIndex = 40;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.txtId.Location = new System.Drawing.Point(650, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(58, 25);
            this.txtId.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(618, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Id:";
            // 
            // numVolumes
            // 
            this.numVolumes.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.numVolumes.Location = new System.Drawing.Point(83, 72);
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
            this.numVolumes.TabIndex = 45;
            this.numVolumes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Volumes:";
            // 
            // btndicionar
            // 
            this.btndicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndicionar.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btndicionar.Location = new System.Drawing.Point(34, 52);
            this.btndicionar.Name = "btndicionar";
            this.btndicionar.Size = new System.Drawing.Size(97, 35);
            this.btndicionar.TabIndex = 41;
            this.btndicionar.Text = "Adicionar";
            this.btndicionar.UseVisualStyleBackColor = true;
            this.btndicionar.Click += new System.EventHandler(this.btndicionar_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnRefresh.Location = new System.Drawing.Point(714, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 25);
            this.btnRefresh.TabIndex = 46;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnSair.Location = new System.Drawing.Point(240, 52);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 35);
            this.btnSair.TabIndex = 47;
            this.btnSair.Text = "Saír";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemover);
            this.groupBox2.Controls.Add(this.btndicionar);
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(562, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 125);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ações";
            // 
            // btnRemover
            // 
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnRemover.Location = new System.Drawing.Point(137, 52);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(97, 35);
            this.btnRemover.TabIndex = 48;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numAtual);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numVolumes);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(562, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 125);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Volumes Atualmente:";
            // 
            // numAtual
            // 
            this.numAtual.Enabled = false;
            this.numAtual.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.numAtual.Location = new System.Drawing.Point(309, 72);
            this.numAtual.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numAtual.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAtual.Name = "numAtual";
            this.numAtual.Size = new System.Drawing.Size(56, 25);
            this.numAtual.TabIndex = 47;
            this.numAtual.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRefreshOrdem
            // 
            this.btnRefreshOrdem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshOrdem.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.btnRefreshOrdem.Location = new System.Drawing.Point(410, 38);
            this.btnRefreshOrdem.Name = "btnRefreshOrdem";
            this.btnRefreshOrdem.Size = new System.Drawing.Size(101, 25);
            this.btnRefreshOrdem.TabIndex = 59;
            this.btnRefreshOrdem.Text = "Atualizar";
            this.btnRefreshOrdem.UseVisualStyleBackColor = true;
            this.btnRefreshOrdem.Click += new System.EventHandler(this.btnRefreshOrdem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radId);
            this.groupBox4.Controls.Add(this.radPreco);
            this.groupBox4.Controls.Add(this.radVolume);
            this.groupBox4.Controls.Add(this.radNome);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.groupBox4.Location = new System.Drawing.Point(99, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 67);
            this.groupBox4.TabIndex = 58;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ordem";
            // 
            // radId
            // 
            this.radId.AutoSize = true;
            this.radId.Checked = true;
            this.radId.Location = new System.Drawing.Point(253, 30);
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
            this.radPreco.Location = new System.Drawing.Point(180, 30);
            this.radPreco.Name = "radPreco";
            this.radPreco.Size = new System.Drawing.Size(67, 21);
            this.radPreco.TabIndex = 56;
            this.radPreco.Text = "Preço";
            this.radPreco.UseVisualStyleBackColor = true;
            // 
            // radVolume
            // 
            this.radVolume.AutoSize = true;
            this.radVolume.Location = new System.Drawing.Point(86, 30);
            this.radVolume.Name = "radVolume";
            this.radVolume.Size = new System.Drawing.Size(90, 21);
            this.radVolume.TabIndex = 54;
            this.radVolume.Text = "Volumes";
            this.radVolume.UseVisualStyleBackColor = true;
            // 
            // radNome
            // 
            this.radNome.AutoSize = true;
            this.radNome.Location = new System.Drawing.Point(20, 30);
            this.radNome.Name = "radNome";
            this.radNome.Size = new System.Drawing.Size(70, 21);
            this.radNome.TabIndex = 55;
            this.radNome.Text = "Nome";
            this.radNome.UseVisualStyleBackColor = true;
            // 
            // picManga
            // 
            this.picManga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picManga.Location = new System.Drawing.Point(926, 206);
            this.picManga.Name = "picManga";
            this.picManga.Size = new System.Drawing.Size(157, 231);
            this.picManga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManga.TabIndex = 60;
            this.picManga.TabStop = false;
            // 
            // frmControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 449);
            this.Controls.Add(this.picManga);
            this.Controls.Add(this.btnRefreshOrdem);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvMangas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmControle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle";
            this.Load += new System.EventHandler(this.frmAdicionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolumes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAtual)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picManga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMangas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.NumericUpDown txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numVolumes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndicionar;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numAtual;
        private System.Windows.Forms.Button btnRefreshOrdem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radId;
        private System.Windows.Forms.RadioButton radPreco;
        private System.Windows.Forms.RadioButton radVolume;
        private System.Windows.Forms.RadioButton radNome;
        private System.Windows.Forms.PictureBox picManga;
    }
}