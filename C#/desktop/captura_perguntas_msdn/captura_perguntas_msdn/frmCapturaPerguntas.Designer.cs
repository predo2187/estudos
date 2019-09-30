namespace captura_perguntas_msdn
{
    partial class frmCapturaPerguntas
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
            this.dgvMSDN = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exibiçao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Respostas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnAtualizarLista = new System.Windows.Forms.Button();
            this.btnProx = new System.Windows.Forms.Button();
            this.btnVolt = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProximo5 = new System.Windows.Forms.Button();
            this.btnVoltar5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPag = new System.Windows.Forms.Label();
            this.btnIrPag = new System.Windows.Forms.Button();
            this.dgvdados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMSDN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMSDN
            // 
            this.dgvMSDN.AllowUserToAddRows = false;
            this.dgvMSDN.AllowUserToDeleteRows = false;
            this.dgvMSDN.AllowUserToResizeColumns = false;
            this.dgvMSDN.AllowUserToResizeRows = false;
            this.dgvMSDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMSDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Postagem,
            this.Exibiçao,
            this.Respostas,
            this.Link});
            this.dgvMSDN.Location = new System.Drawing.Point(12, 64);
            this.dgvMSDN.MultiSelect = false;
            this.dgvMSDN.Name = "dgvMSDN";
            this.dgvMSDN.ReadOnly = true;
            this.dgvMSDN.Size = new System.Drawing.Size(1198, 317);
            this.dgvMSDN.TabIndex = 0;
            this.dgvMSDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMSDN_CellClick);
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 330;
            // 
            // Postagem
            // 
            this.Postagem.HeaderText = "Postagem";
            this.Postagem.Name = "Postagem";
            this.Postagem.ReadOnly = true;
            this.Postagem.Width = 350;
            // 
            // Exibiçao
            // 
            this.Exibiçao.HeaderText = "Exibição";
            this.Exibiçao.Name = "Exibiçao";
            this.Exibiçao.ReadOnly = true;
            // 
            // Respostas
            // 
            this.Respostas.HeaderText = "Respostas";
            this.Respostas.Name = "Respostas";
            this.Respostas.ReadOnly = true;
            // 
            // Link
            // 
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            this.Link.ReadOnly = true;
            this.Link.Width = 250;
            // 
            // btnAtualizarLista
            // 
            this.btnAtualizarLista.Location = new System.Drawing.Point(6, 12);
            this.btnAtualizarLista.Name = "btnAtualizarLista";
            this.btnAtualizarLista.Size = new System.Drawing.Size(116, 36);
            this.btnAtualizarLista.TabIndex = 1;
            this.btnAtualizarLista.Text = "Atualizar";
            this.btnAtualizarLista.UseVisualStyleBackColor = true;
            this.btnAtualizarLista.Click += new System.EventHandler(this.btnAtualizarLista_Click);
            // 
            // btnProx
            // 
            this.btnProx.Location = new System.Drawing.Point(250, 10);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(116, 36);
            this.btnProx.TabIndex = 2;
            this.btnProx.Text = "Próximo (1)";
            this.btnProx.UseVisualStyleBackColor = true;
            this.btnProx.Click += new System.EventHandler(this.btnProx_Click);
            // 
            // btnVolt
            // 
            this.btnVolt.Location = new System.Drawing.Point(128, 10);
            this.btnVolt.Name = "btnVolt";
            this.btnVolt.Size = new System.Drawing.Size(116, 36);
            this.btnVolt.TabIndex = 3;
            this.btnVolt.Text = "Voltar (1)";
            this.btnVolt.UseVisualStyleBackColor = true;
            this.btnVolt.Click += new System.EventHandler(this.btnVolt_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(128, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(116, 36);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Límpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProximo5);
            this.groupBox1.Controls.Add(this.btnProx);
            this.groupBox1.Controls.Add(this.btnVolt);
            this.groupBox1.Controls.Add(this.btnVoltar5);
            this.groupBox1.Location = new System.Drawing.Point(649, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 52);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnProximo5
            // 
            this.btnProximo5.Location = new System.Drawing.Point(372, 10);
            this.btnProximo5.Name = "btnProximo5";
            this.btnProximo5.Size = new System.Drawing.Size(116, 36);
            this.btnProximo5.TabIndex = 8;
            this.btnProximo5.Text = "Próximo (5)";
            this.btnProximo5.UseVisualStyleBackColor = true;
            this.btnProximo5.Click += new System.EventHandler(this.btnProximo5_Click);
            // 
            // btnVoltar5
            // 
            this.btnVoltar5.Location = new System.Drawing.Point(6, 10);
            this.btnVoltar5.Name = "btnVoltar5";
            this.btnVoltar5.Size = new System.Drawing.Size(116, 36);
            this.btnVoltar5.TabIndex = 8;
            this.btnVoltar5.Text = "Voltar (5)";
            this.btnVoltar5.UseVisualStyleBackColor = true;
            this.btnVoltar5.Click += new System.EventHandler(this.btnVoltar5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.btnAtualizarLista);
            this.groupBox2.Location = new System.Drawing.Point(8, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 54);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1089, 518);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(116, 36);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Saír";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1003, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Página";
            // 
            // lblPag
            // 
            this.lblPag.AutoSize = true;
            this.lblPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPag.Location = new System.Drawing.Point(1064, 28);
            this.lblPag.Name = "lblPag";
            this.lblPag.Size = new System.Drawing.Size(20, 24);
            this.lblPag.TabIndex = 9;
            this.lblPag.Text = "0";
            // 
            // btnIrPag
            // 
            this.btnIrPag.Location = new System.Drawing.Point(1094, 22);
            this.btnIrPag.Name = "btnIrPag";
            this.btnIrPag.Size = new System.Drawing.Size(116, 36);
            this.btnIrPag.TabIndex = 9;
            this.btnIrPag.Text = "Ir para Página";
            this.btnIrPag.UseVisualStyleBackColor = true;
            this.btnIrPag.Click += new System.EventHandler(this.btnIrPag_Click_1);
            // 
            // dgvdados
            // 
            this.dgvdados.AllowUserToAddRows = false;
            this.dgvdados.AllowUserToDeleteRows = false;
            this.dgvdados.AllowUserToResizeColumns = false;
            this.dgvdados.AllowUserToResizeRows = false;
            this.dgvdados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvdados.Location = new System.Drawing.Point(12, 392);
            this.dgvdados.MultiSelect = false;
            this.dgvdados.Name = "dgvdados";
            this.dgvdados.ReadOnly = true;
            this.dgvdados.Size = new System.Drawing.Size(585, 162);
            this.dgvdados.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 170;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Data";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 350;
            // 
            // frmCapturaPerguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 565);
            this.Controls.Add(this.btnIrPag);
            this.Controls.Add(this.lblPag);
            this.Controls.Add(this.dgvdados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvMSDN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCapturaPerguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perguntas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMSDN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMSDN;
        private System.Windows.Forms.Button btnAtualizarLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exibiçao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Respostas;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Button btnVolt;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnProximo5;
        private System.Windows.Forms.Button btnVoltar5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPag;
        private System.Windows.Forms.Button btnIrPag;
        private System.Windows.Forms.DataGridView dgvdados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

