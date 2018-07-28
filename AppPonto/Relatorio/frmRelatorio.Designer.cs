namespace AppPonto
{
    partial class frmRelatorio
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ColecaoPontoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rtvRelatorio = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ColecaoPontoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ColecaoPontoBindingSource
            // 
            this.ColecaoPontoBindingSource.DataSource = typeof(AppPonto_ENT.ColecaoPonto);
            // 
            // rtvRelatorio
            // 
            this.rtvRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MarcacaoPonto";
            reportDataSource1.Value = this.ColecaoPontoBindingSource;
            this.rtvRelatorio.LocalReport.DataSources.Add(reportDataSource1);
            this.rtvRelatorio.LocalReport.ReportEmbeddedResource = "AppPonto.Relatorio.rptRelatorio.rdlc";
            this.rtvRelatorio.Location = new System.Drawing.Point(0, 0);
            this.rtvRelatorio.Name = "rtvRelatorio";
            this.rtvRelatorio.Size = new System.Drawing.Size(284, 261);
            this.rtvRelatorio.TabIndex = 0;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rtvRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Controle de Ponto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRelatorio_KeyDown);
            this.Resize += new System.EventHandler(this.frmRelatorio_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ColecaoPontoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rtvRelatorio;
        private System.Windows.Forms.BindingSource ColecaoPontoBindingSource;
    }
}