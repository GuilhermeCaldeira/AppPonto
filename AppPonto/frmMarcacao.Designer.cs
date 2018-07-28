namespace AppPonto
{
    partial class frmMarcacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarcacao));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.pnCorpo = new System.Windows.Forms.Panel();
            this.lblTitHrSaida = new System.Windows.Forms.Label();
            this.lblTitHrRetornoAlmoco = new System.Windows.Forms.Label();
            this.lblTitHrSaidaAlmoco = new System.Windows.Forms.Label();
            this.lblTitHrEntrada = new System.Windows.Forms.Label();
            this.txtHrSaida = new System.Windows.Forms.MaskedTextBox();
            this.txtHrRetornoAlmoco = new System.Windows.Forms.MaskedTextBox();
            this.txtHrSaidaAlmoco = new System.Windows.Forms.MaskedTextBox();
            this.txtHrEntrada = new System.Windows.Forms.MaskedTextBox();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.pnPrincipal.SuspendLayout();
            this.pnCorpo.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfirmar,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 93);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(426, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.pnCorpo);
            this.pnPrincipal.Controls.Add(this.pnTop);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(426, 93);
            this.pnPrincipal.TabIndex = 2;
            // 
            // pnCorpo
            // 
            this.pnCorpo.Controls.Add(this.lblTitHrSaida);
            this.pnCorpo.Controls.Add(this.lblTitHrRetornoAlmoco);
            this.pnCorpo.Controls.Add(this.lblTitHrSaidaAlmoco);
            this.pnCorpo.Controls.Add(this.lblTitHrEntrada);
            this.pnCorpo.Controls.Add(this.txtHrSaida);
            this.pnCorpo.Controls.Add(this.txtHrRetornoAlmoco);
            this.pnCorpo.Controls.Add(this.txtHrSaidaAlmoco);
            this.pnCorpo.Controls.Add(this.txtHrEntrada);
            this.pnCorpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCorpo.Location = new System.Drawing.Point(0, 39);
            this.pnCorpo.Name = "pnCorpo";
            this.pnCorpo.Size = new System.Drawing.Size(426, 54);
            this.pnCorpo.TabIndex = 1;
            // 
            // lblTitHrSaida
            // 
            this.lblTitHrSaida.AutoSize = true;
            this.lblTitHrSaida.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitHrSaida.Location = new System.Drawing.Point(323, 13);
            this.lblTitHrSaida.Name = "lblTitHrSaida";
            this.lblTitHrSaida.Size = new System.Drawing.Size(51, 13);
            this.lblTitHrSaida.TabIndex = 7;
            this.lblTitHrSaida.Text = "Hr. Saída";
            // 
            // lblTitHrRetornoAlmoco
            // 
            this.lblTitHrRetornoAlmoco.AutoSize = true;
            this.lblTitHrRetornoAlmoco.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitHrRetornoAlmoco.Location = new System.Drawing.Point(216, 13);
            this.lblTitHrRetornoAlmoco.Name = "lblTitHrRetornoAlmoco";
            this.lblTitHrRetornoAlmoco.Size = new System.Drawing.Size(101, 13);
            this.lblTitHrRetornoAlmoco.TabIndex = 6;
            this.lblTitHrRetornoAlmoco.Text = "Hr. Retorno Almoço";
            // 
            // lblTitHrSaidaAlmoco
            // 
            this.lblTitHrSaidaAlmoco.AutoSize = true;
            this.lblTitHrSaidaAlmoco.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitHrSaidaAlmoco.Location = new System.Drawing.Point(111, 13);
            this.lblTitHrSaidaAlmoco.Name = "lblTitHrSaidaAlmoco";
            this.lblTitHrSaidaAlmoco.Size = new System.Drawing.Size(88, 13);
            this.lblTitHrSaidaAlmoco.TabIndex = 5;
            this.lblTitHrSaidaAlmoco.Text = "Hr. Saída Almoço";
            // 
            // lblTitHrEntrada
            // 
            this.lblTitHrEntrada.AutoSize = true;
            this.lblTitHrEntrada.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitHrEntrada.Location = new System.Drawing.Point(5, 13);
            this.lblTitHrEntrada.Name = "lblTitHrEntrada";
            this.lblTitHrEntrada.Size = new System.Drawing.Size(63, 13);
            this.lblTitHrEntrada.TabIndex = 4;
            this.lblTitHrEntrada.Text = "Hr. Entrada";
            // 
            // txtHrSaida
            // 
            this.txtHrSaida.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHrSaida.Location = new System.Drawing.Point(324, 29);
            this.txtHrSaida.Mask = "##:##";
            this.txtHrSaida.Name = "txtHrSaida";
            this.txtHrSaida.Size = new System.Drawing.Size(100, 23);
            this.txtHrSaida.TabIndex = 3;
            // 
            // txtHrRetornoAlmoco
            // 
            this.txtHrRetornoAlmoco.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHrRetornoAlmoco.Location = new System.Drawing.Point(218, 29);
            this.txtHrRetornoAlmoco.Mask = "##:##";
            this.txtHrRetornoAlmoco.Name = "txtHrRetornoAlmoco";
            this.txtHrRetornoAlmoco.Size = new System.Drawing.Size(100, 23);
            this.txtHrRetornoAlmoco.TabIndex = 2;
            // 
            // txtHrSaidaAlmoco
            // 
            this.txtHrSaidaAlmoco.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHrSaidaAlmoco.Location = new System.Drawing.Point(112, 29);
            this.txtHrSaidaAlmoco.Mask = "##:##";
            this.txtHrSaidaAlmoco.Name = "txtHrSaidaAlmoco";
            this.txtHrSaidaAlmoco.Size = new System.Drawing.Size(100, 23);
            this.txtHrSaidaAlmoco.TabIndex = 1;
            // 
            // txtHrEntrada
            // 
            this.txtHrEntrada.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHrEntrada.Location = new System.Drawing.Point(6, 29);
            this.txtHrEntrada.Mask = "##:##";
            this.txtHrEntrada.Name = "txtHrEntrada";
            this.txtHrEntrada.Size = new System.Drawing.Size(100, 23);
            this.txtHrEntrada.TabIndex = 0;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.LightGray;
            this.pnTop.Controls.Add(this.lblTitulo);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(426, 39);
            this.pnTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(426, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "label1";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::AppPonto.Properties.Resources.Checkmark_24;
            this.btnConfirmar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(104, 22);
            this.btnConfirmar.Text = "[F7] Confirmar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::AppPonto.Properties.Resources.Delete_24;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 22);
            this.btnCancelar.Text = "[ESC] Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmMarcacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 118);
            this.ControlBox = false;
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMarcacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcação de Ponto";
            this.Load += new System.EventHandler(this.frmMarcacao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMarcacao_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnPrincipal.ResumeLayout(false);
            this.pnCorpo.ResumeLayout(false);
            this.pnCorpo.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnConfirmar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Panel pnCorpo;
        private System.Windows.Forms.Label lblTitHrSaida;
        private System.Windows.Forms.Label lblTitHrRetornoAlmoco;
        private System.Windows.Forms.Label lblTitHrSaidaAlmoco;
        private System.Windows.Forms.Label lblTitHrEntrada;
        private System.Windows.Forms.MaskedTextBox txtHrSaida;
        private System.Windows.Forms.MaskedTextBox txtHrRetornoAlmoco;
        private System.Windows.Forms.MaskedTextBox txtHrSaidaAlmoco;
        private System.Windows.Forms.MaskedTextBox txtHrEntrada;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lblTitulo;

    }
}