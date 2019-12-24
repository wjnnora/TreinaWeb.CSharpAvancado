namespace GerenciadorLatidos
{
    partial class frmGerenciadorDeLatidos
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
            this.btnLatir = new System.Windows.Forms.Button();
            this.pgbIntensidadeLatido = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnLatir
            // 
            this.btnLatir.Location = new System.Drawing.Point(12, 12);
            this.btnLatir.Name = "btnLatir";
            this.btnLatir.Size = new System.Drawing.Size(213, 54);
            this.btnLatir.TabIndex = 0;
            this.btnLatir.Text = "Latir";
            this.btnLatir.UseVisualStyleBackColor = true;
            this.btnLatir.Click += new System.EventHandler(this.btnLatir_Click);
            // 
            // pgbIntensidadeLatido
            // 
            this.pgbIntensidadeLatido.Location = new System.Drawing.Point(12, 92);
            this.pgbIntensidadeLatido.Name = "pgbIntensidadeLatido";
            this.pgbIntensidadeLatido.Size = new System.Drawing.Size(1021, 47);
            this.pgbIntensidadeLatido.TabIndex = 1;
            // 
            // frmGerenciadorDeLatidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 176);
            this.Controls.Add(this.pgbIntensidadeLatido);
            this.Controls.Add(this.btnLatir);
            this.Name = "frmGerenciadorDeLatidos";
            this.Text = "Gerenciador de Latidos";
            this.Load += new System.EventHandler(this.frmGerenciadorDeLatidos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLatir;
        private System.Windows.Forms.ProgressBar pgbIntensidadeLatido;
    }
}

