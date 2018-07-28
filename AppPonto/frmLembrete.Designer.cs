namespace AppPonto
{
    partial class frmLembrete
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnConfirmar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.pnCorpo = new System.Windows.Forms.Panel();
            this.txtLembrete = new System.Windows.Forms.TextBox();
            this.lblLembrete = new System.Windows.Forms.Label();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 279);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(739, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.pnCorpo);
            this.pnPrincipal.Controls.Add(this.pnTop);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(739, 279);
            this.pnPrincipal.TabIndex = 3;
            // 
            // pnCorpo
            // 
            this.pnCorpo.Controls.Add(this.txtLembrete);
            this.pnCorpo.Controls.Add(this.lblLembrete);
            this.pnCorpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCorpo.Location = new System.Drawing.Point(0, 39);
            this.pnCorpo.Name = "pnCorpo";
            this.pnCorpo.Size = new System.Drawing.Size(739, 240);
            this.pnCorpo.TabIndex = 1;
            // 
            // txtLembrete
            // 
            this.txtLembrete.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtLembrete.Location = new System.Drawing.Point(6, 29);
            this.txtLembrete.Multiline = true;
            this.txtLembrete.Name = "txtLembrete";
            this.txtLembrete.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLembrete.Size = new System.Drawing.Size(727, 205);
            this.txtLembrete.TabIndex = 0;
            // 
            // lblLembrete
            // 
            this.lblLembrete.AutoSize = true;
            this.lblLembrete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLembrete.Location = new System.Drawing.Point(5, 13);
            this.lblLembrete.Name = "lblLembrete";
            this.lblLembrete.Size = new System.Drawing.Size(52, 13);
            this.lblLembrete.TabIndex = 4;
            this.lblLembrete.Text = "Lembrete";
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.LightGray;
            this.pnTop.Controls.Add(this.lblTitulo);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(739, 39);
            this.pnTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(739, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "label1";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLembrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(739, 304);
            this.ControlBox = false;
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLembrete";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lembrete";
            this.Load += new System.EventHandler(this.frmLembrete_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLembrete_KeyDown);
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
        private System.Windows.Forms.Label lblLembrete;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtLembrete;
    }
}