namespace GerenciadorVeiculos
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
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblParametro = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPrecoBase = new System.Windows.Forms.TextBox();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(488, 51);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 0;
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Location = new System.Drawing.Point(457, 131);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(41, 13);
            this.lblParametro.TabIndex = 1;
            this.lblParametro.Text = "Rótulo ";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(360, 51);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 2;
            // 
            // txtPrecoBase
            // 
            this.txtPrecoBase.Location = new System.Drawing.Point(360, 87);
            this.txtPrecoBase.Name = "txtPrecoBase";
            this.txtPrecoBase.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoBase.TabIndex = 3;
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(488, 87);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(121, 20);
            this.txtParametro.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(439, 162);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.txtPrecoBase);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblParametro);
            this.Controls.Add(this.cmbTipo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPrecoBase;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Button btnSalvar;
    }
}

