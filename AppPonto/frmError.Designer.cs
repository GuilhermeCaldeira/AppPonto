namespace AppPonto
{
    partial class frmError
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
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.pnMsgError = new System.Windows.Forms.Panel();
            this.pnSeparador = new System.Windows.Forms.Panel();
            this.imgError = new System.Windows.Forms.PictureBox();
            this.lblMsgLog = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMsgError = new System.Windows.Forms.Label();
            this.pnPrincipal.SuspendLayout();
            this.pnMsgError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgError)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPrincipal.Controls.Add(this.pnMsgError);
            this.pnPrincipal.Controls.Add(this.pnSeparador);
            this.pnPrincipal.Controls.Add(this.imgError);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Padding = new System.Windows.Forms.Padding(5);
            this.pnPrincipal.Size = new System.Drawing.Size(717, 362);
            this.pnPrincipal.TabIndex = 0;
            // 
            // pnMsgError
            // 
            this.pnMsgError.Controls.Add(this.lblMsgError);
            this.pnMsgError.Controls.Add(this.panel1);
            this.pnMsgError.Controls.Add(this.lblMsgLog);
            this.pnMsgError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMsgError.Location = new System.Drawing.Point(360, 5);
            this.pnMsgError.Name = "pnMsgError";
            this.pnMsgError.Size = new System.Drawing.Size(350, 350);
            this.pnMsgError.TabIndex = 2;
            // 
            // pnSeparador
            // 
            this.pnSeparador.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSeparador.Location = new System.Drawing.Point(355, 5);
            this.pnSeparador.Name = "pnSeparador";
            this.pnSeparador.Size = new System.Drawing.Size(5, 350);
            this.pnSeparador.TabIndex = 1;
            // 
            // imgError
            // 
            this.imgError.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgError.Image = global::AppPonto.Properties.Resources.imgERRO_01;
            this.imgError.Location = new System.Drawing.Point(5, 5);
            this.imgError.Name = "imgError";
            this.imgError.Size = new System.Drawing.Size(350, 350);
            this.imgError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgError.TabIndex = 0;
            this.imgError.TabStop = false;
            // 
            // lblMsgLog
            // 
            this.lblMsgLog.BackColor = System.Drawing.Color.Transparent;
            this.lblMsgLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMsgLog.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgLog.Location = new System.Drawing.Point(0, 327);
            this.lblMsgLog.Name = "lblMsgLog";
            this.lblMsgLog.Size = new System.Drawing.Size(350, 23);
            this.lblMsgLog.TabIndex = 1;
            this.lblMsgLog.Text = "Para maiores informações verifique o log de erros.";
            this.lblMsgLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 5);
            this.panel1.TabIndex = 2;
            // 
            // lblMsgError
            // 
            this.lblMsgError.BackColor = System.Drawing.Color.Transparent;
            this.lblMsgError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMsgError.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgError.ForeColor = System.Drawing.Color.Black;
            this.lblMsgError.Location = new System.Drawing.Point(0, 0);
            this.lblMsgError.Name = "lblMsgError";
            this.lblMsgError.Size = new System.Drawing.Size(350, 322);
            this.lblMsgError.TabIndex = 3;
            this.lblMsgError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 362);
            this.ControlBox = false;
            this.Controls.Add(this.pnPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmError";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmError";
            this.Load += new System.EventHandler(this.frmError_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmError_KeyDown);
            this.pnPrincipal.ResumeLayout(false);
            this.pnMsgError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Panel pnMsgError;
        private System.Windows.Forms.Panel pnSeparador;
        private System.Windows.Forms.PictureBox imgError;
        private System.Windows.Forms.Label lblMsgError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMsgLog;
    }
}