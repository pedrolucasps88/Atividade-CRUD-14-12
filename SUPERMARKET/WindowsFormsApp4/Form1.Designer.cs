﻿namespace WindowsFormsApp4
{
    partial class frmPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.ddlInteiro = new System.Windows.Forms.NumericUpDown();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblInteiro = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtString = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblString = new System.Windows.Forms.Label();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAte = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlInteiro)).BeginInit();
            this.pnlPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(330, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(120, 13);
            this.lblTitulo.TabIndex = 99;
            this.lblTitulo.Text = "XP SUPERMARKET";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.ddlInteiro);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.lblInteiro);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.txtString);
            this.panel1.Controls.Add(this.dtpData);
            this.panel1.Controls.Add(this.lblString);
            this.panel1.Location = new System.Drawing.Point(5, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 218);
            this.panel1.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLimpar.Location = new System.Drawing.Point(280, 100);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 100);
            this.btnLimpar.TabIndex = 100;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // ddlInteiro
            // 
            this.ddlInteiro.Location = new System.Drawing.Point(85, 65);
            this.ddlInteiro.Name = "ddlInteiro";
            this.ddlInteiro.Size = new System.Drawing.Size(283, 20);
            this.ddlInteiro.TabIndex = 3;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Cyan;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(188, 100);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 100);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblInteiro
            // 
            this.lblInteiro.AutoSize = true;
            this.lblInteiro.Location = new System.Drawing.Point(10, 68);
            this.lblInteiro.Name = "lblInteiro";
            this.lblInteiro.Size = new System.Drawing.Size(33, 13);
            this.lblInteiro.TabIndex = 99;
            this.lblInteiro.Text = "QNT:";
            this.lblInteiro.Click += new System.EventHandler(this.lblInteiro_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(95, 100);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 100);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtData
            // 
            this.txtData.AutoSize = true;
            this.txtData.Location = new System.Drawing.Point(10, 41);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(39, 13);
            this.txtData.TabIndex = 99;
            this.txtData.Text = "DATA:";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.LightCyan;
            this.btnNovo.Location = new System.Drawing.Point(3, 100);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 100);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(85, 13);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(283, 20);
            this.txtString.TabIndex = 1;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(85, 39);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(283, 20);
            this.dtpData.TabIndex = 2;
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(10, 13);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(42, 13);
            this.lblString.TabIndex = 99;
            this.lblString.Text = "NOME:";
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.BackColor = System.Drawing.Color.LightBlue;
            this.pnlPesquisa.Controls.Add(this.button2);
            this.pnlPesquisa.Controls.Add(this.dataGridView1);
            this.pnlPesquisa.Controls.Add(this.lblAte);
            this.pnlPesquisa.Controls.Add(this.lblDe);
            this.pnlPesquisa.Controls.Add(this.dtpAte);
            this.pnlPesquisa.Controls.Add(this.dtpDe);
            this.pnlPesquisa.Controls.Add(this.lblPesquisa);
            this.pnlPesquisa.Controls.Add(this.txtPesquisa);
            this.pnlPesquisa.Controls.Add(this.btnPesquisar);
            this.pnlPesquisa.Location = new System.Drawing.Point(390, 43);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(407, 239);
            this.pnlPesquisa.TabIndex = 5;
            this.pnlPesquisa.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(391, 145);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Location = new System.Drawing.Point(178, 33);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(31, 13);
            this.lblAte.TabIndex = 99;
            this.lblAte.Text = "ATÉ:";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(6, 33);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(57, 13);
            this.lblDe.TabIndex = 99;
            this.lblDe.Text = "DATA DE:";
            // 
            // dtpAte
            // 
            this.dtpAte.Location = new System.Drawing.Point(215, 29);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(102, 20);
            this.dtpAte.TabIndex = 7;
            // 
            // dtpDe
            // 
            this.dtpDe.Location = new System.Drawing.Point(69, 29);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(103, 20);
            this.dtpDe.TabIndex = 6;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(6, 8);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(42, 13);
            this.lblPesquisa.TabIndex = 99;
            this.lblPesquisa.Text = "NOME:";
            this.lblPesquisa.Click += new System.EventHandler(this.lblPesquisa_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(69, 5);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(248, 20);
            this.txtPesquisa.TabIndex = 5;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Plum;
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPesquisar.Location = new System.Drawing.Point(323, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(77, 48);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(352, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "ESTOQUE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Plum;
            this.button2.Location = new System.Drawing.Point(19, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(363, 28);
            this.button2.TabIndex = 101;
            this.button2.Text = "<<< OCULTAR ESTOQUE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.Location = new System.Drawing.Point(382, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 59);
            this.button1.TabIndex = 103;
            this.button1.Text = "Verificar Estoque >>>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(814, 294);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPrincipal";
            this.Text = "Products supermarket";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlInteiro)).EndInit();
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.NumericUpDown ddlInteiro;
        private System.Windows.Forms.Label lblInteiro;
        private System.Windows.Forms.Label txtData;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

