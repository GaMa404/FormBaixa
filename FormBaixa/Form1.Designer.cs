namespace FormBaixa
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.btnImportar = new System.Windows.Forms.Button();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAumento = new System.Windows.Forms.TextBox();
            this.btnAumentar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVenda
            // 
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(12, 81);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.Size = new System.Drawing.Size(857, 410);
            this.dgvVenda.TabIndex = 0;
            this.dgvVenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenda_CellClick);
            this.dgvVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenda_CellContentClick);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(12, 22);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(118, 43);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar Arquivo";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "ofdArquivo";
            // 
            // btnMarcar
            // 
            this.btnMarcar.Location = new System.Drawing.Point(611, 22);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(118, 43);
            this.btnMarcar.TabIndex = 2;
            this.btnMarcar.Text = "Marcar Todos";
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.Location = new System.Drawing.Point(751, 22);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(118, 43);
            this.btnDesmarcar.TabIndex = 3;
            this.btnDesmarcar.Text = "Desmarcar Todos";
            this.btnDesmarcar.UseVisualStyleBackColor = true;
            this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(580, 518);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(130, 55);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover Selecionados";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aumento (%) ao preço da venda: ";
            // 
            // txtAumento
            // 
            this.txtAumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAumento.Location = new System.Drawing.Point(309, 534);
            this.txtAumento.Name = "txtAumento";
            this.txtAumento.Size = new System.Drawing.Size(100, 29);
            this.txtAumento.TabIndex = 5;
            // 
            // btnAumentar
            // 
            this.btnAumentar.Location = new System.Drawing.Point(431, 521);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(75, 49);
            this.btnAumentar.TabIndex = 6;
            this.btnAumentar.Text = "Aumentar";
            this.btnAumentar.UseVisualStyleBackColor = true;
            this.btnAumentar.Click += new System.EventHandler(this.btnAumentar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(739, 518);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(130, 55);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 602);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAumentar);
            this.Controls.Add(this.txtAumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnDesmarcar);
            this.Controls.Add(this.btnMarcar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.dgvVenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Painel de Controle";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.Button btnDesmarcar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAumento;
        private System.Windows.Forms.Button btnAumentar;
        private System.Windows.Forms.Button btnSair;
    }
}

