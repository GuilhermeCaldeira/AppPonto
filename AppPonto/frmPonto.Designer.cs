namespace AppPonto
{
    partial class frmPonto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPonto));
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.pnGrid = new System.Windows.Forms.Panel();
            this.grvPonto = new System.Windows.Forms.DataGridView();
            this.colDiaSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHrEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHrSaidaAlmoco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHrRetornoAlmoco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHrSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiferenca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.pnResumo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLegFolga = new System.Windows.Forms.Label();
            this.lblLegFerias = new System.Windows.Forms.Label();
            this.lblLegFeriado = new System.Windows.Forms.Label();
            this.imgLegFolga = new System.Windows.Forms.Panel();
            this.imgLegFerias = new System.Windows.Forms.Panel();
            this.imgLegFeriado = new System.Windows.Forms.Panel();
            this.lblLegLembrete = new System.Windows.Forms.Label();
            this.imgLegLembrete = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitHrsSabado = new System.Windows.Forms.Label();
            this.lblTitHrsMes = new System.Windows.Forms.Label();
            this.lblTitHrsDia = new System.Windows.Forms.Label();
            this.lblTitHrsSemanais = new System.Windows.Forms.Label();
            this.lblTitHorasTrabalhadas = new System.Windows.Forms.Label();
            this.lblDiferenca = new System.Windows.Forms.Label();
            this.lblTitDiferencaHoras = new System.Windows.Forms.Label();
            this.lblHrsTrabalhadas = new System.Windows.Forms.Label();
            this.lblHrsSemana = new System.Windows.Forms.Label();
            this.lblHrsMes = new System.Windows.Forms.Label();
            this.lblHrsDia = new System.Windows.Forms.Label();
            this.lblHrsSabado = new System.Windows.Forms.Label();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnMarcarPonto = new System.Windows.Forms.Button();
            this.pnPesquisa = new System.Windows.Forms.Panel();
            this.lblAno = new System.Windows.Forms.Label();
            this.cboAno = new System.Windows.Forms.ComboBox();
            this.lblMesAno = new System.Windows.Forms.Label();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.popMarcacao = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnFeriado = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFerias = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFolga = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFalta = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLembrete = new System.Windows.Forms.ToolStripMenuItem();
            this.pnPrincipal.SuspendLayout();
            this.pnGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPonto)).BeginInit();
            this.pnCabecalho.SuspendLayout();
            this.pnResumo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnPesquisa.SuspendLayout();
            this.popMarcacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.pnGrid);
            this.pnPrincipal.Controls.Add(this.pnCabecalho);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(1004, 641);
            this.pnPrincipal.TabIndex = 0;
            // 
            // pnGrid
            // 
            this.pnGrid.Controls.Add(this.grvPonto);
            this.pnGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGrid.Location = new System.Drawing.Point(206, 0);
            this.pnGrid.Name = "pnGrid";
            this.pnGrid.Size = new System.Drawing.Size(798, 641);
            this.pnGrid.TabIndex = 1;
            // 
            // grvPonto
            // 
            this.grvPonto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvPonto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grvPonto.BackgroundColor = System.Drawing.Color.White;
            this.grvPonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvPonto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvPonto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPonto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDiaSemana,
            this.colDia,
            this.colHrEntrada,
            this.colHrSaidaAlmoco,
            this.colHrRetornoAlmoco,
            this.colHrSaida,
            this.colTotalHora,
            this.colDiferenca});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvPonto.DefaultCellStyle = dataGridViewCellStyle9;
            this.grvPonto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvPonto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grvPonto.Location = new System.Drawing.Point(0, 0);
            this.grvPonto.MultiSelect = false;
            this.grvPonto.Name = "grvPonto";
            this.grvPonto.RowHeadersVisible = false;
            this.grvPonto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvPonto.Size = new System.Drawing.Size(798, 641);
            this.grvPonto.TabIndex = 1;
            this.grvPonto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvPonto_CellClick);
            this.grvPonto.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.grvPonto_CellContextMenuStripNeeded);
            this.grvPonto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvPonto_CellDoubleClick);
            this.grvPonto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grvPonto_CellFormatting);
            this.grvPonto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvPonto_KeyDown);
            this.grvPonto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grvPonto_MouseDown);
            // 
            // colDiaSemana
            // 
            this.colDiaSemana.DataPropertyName = "DiaSemana";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colDiaSemana.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDiaSemana.FillWeight = 85.15457F;
            this.colDiaSemana.HeaderText = "Dia Semana";
            this.colDiaSemana.Name = "colDiaSemana";
            this.colDiaSemana.ReadOnly = true;
            // 
            // colDia
            // 
            this.colDia.DataPropertyName = "Data";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.colDia.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDia.FillWeight = 101.5229F;
            this.colDia.HeaderText = "Dia";
            this.colDia.Name = "colDia";
            // 
            // colHrEntrada
            // 
            this.colHrEntrada.DataPropertyName = "HoraEntrada";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colHrEntrada.DefaultCellStyle = dataGridViewCellStyle4;
            this.colHrEntrada.FillWeight = 103.4926F;
            this.colHrEntrada.HeaderText = "Entrada";
            this.colHrEntrada.Name = "colHrEntrada";
            // 
            // colHrSaidaAlmoco
            // 
            this.colHrSaidaAlmoco.DataPropertyName = "HoraSaidaAlmoco";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colHrSaidaAlmoco.DefaultCellStyle = dataGridViewCellStyle5;
            this.colHrSaidaAlmoco.FillWeight = 103.4926F;
            this.colHrSaidaAlmoco.HeaderText = "Inicio Almoço";
            this.colHrSaidaAlmoco.Name = "colHrSaidaAlmoco";
            // 
            // colHrRetornoAlmoco
            // 
            this.colHrRetornoAlmoco.DataPropertyName = "HoraRetornoAlmoco";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colHrRetornoAlmoco.DefaultCellStyle = dataGridViewCellStyle6;
            this.colHrRetornoAlmoco.FillWeight = 103.4926F;
            this.colHrRetornoAlmoco.HeaderText = "Fim Almoço";
            this.colHrRetornoAlmoco.Name = "colHrRetornoAlmoco";
            // 
            // colHrSaida
            // 
            this.colHrSaida.DataPropertyName = "HoraSaida";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colHrSaida.DefaultCellStyle = dataGridViewCellStyle7;
            this.colHrSaida.FillWeight = 103.4926F;
            this.colHrSaida.HeaderText = "Saida";
            this.colHrSaida.Name = "colHrSaida";
            // 
            // colTotalHora
            // 
            this.colTotalHora.DataPropertyName = "TotalHora";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTotalHora.DefaultCellStyle = dataGridViewCellStyle8;
            this.colTotalHora.FillWeight = 103.4926F;
            this.colTotalHora.HeaderText = "Total Hora";
            this.colTotalHora.Name = "colTotalHora";
            // 
            // colDiferenca
            // 
            this.colDiferenca.DataPropertyName = "DiferencaTotalHora";
            this.colDiferenca.FillWeight = 95.85968F;
            this.colDiferenca.HeaderText = "Diferença";
            this.colDiferenca.Name = "colDiferenca";
            this.colDiferenca.ReadOnly = true;
            // 
            // pnCabecalho
            // 
            this.pnCabecalho.Controls.Add(this.pnResumo);
            this.pnCabecalho.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnCabecalho.Margin = new System.Windows.Forms.Padding(0);
            this.pnCabecalho.Name = "pnCabecalho";
            this.pnCabecalho.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnCabecalho.Size = new System.Drawing.Size(206, 641);
            this.pnCabecalho.TabIndex = 0;
            // 
            // pnResumo
            // 
            this.pnResumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.pnResumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnResumo.Controls.Add(this.panel2);
            this.pnResumo.Controls.Add(this.panel1);
            this.pnResumo.Controls.Add(this.btnRelatorio);
            this.pnResumo.Controls.Add(this.btnMarcarPonto);
            this.pnResumo.Controls.Add(this.pnPesquisa);
            this.pnResumo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnResumo.Location = new System.Drawing.Point(0, 0);
            this.pnResumo.Name = "pnResumo";
            this.pnResumo.Size = new System.Drawing.Size(201, 641);
            this.pnResumo.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblLegFolga);
            this.panel2.Controls.Add(this.lblLegFerias);
            this.panel2.Controls.Add(this.lblLegFeriado);
            this.panel2.Controls.Add(this.imgLegFolga);
            this.panel2.Controls.Add(this.imgLegFerias);
            this.panel2.Controls.Add(this.imgLegFeriado);
            this.panel2.Controls.Add(this.lblLegLembrete);
            this.panel2.Controls.Add(this.imgLegLembrete);
            this.panel2.Location = new System.Drawing.Point(6, 147);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(187, 50);
            this.panel2.TabIndex = 14;
            // 
            // lblLegFolga
            // 
            this.lblLegFolga.AutoSize = true;
            this.lblLegFolga.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegFolga.Location = new System.Drawing.Point(119, 27);
            this.lblLegFolga.Name = "lblLegFolga";
            this.lblLegFolga.Size = new System.Drawing.Size(33, 13);
            this.lblLegFolga.TabIndex = 21;
            this.lblLegFolga.Text = "Folga";
            this.lblLegFolga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLegFerias
            // 
            this.lblLegFerias.AutoSize = true;
            this.lblLegFerias.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegFerias.Location = new System.Drawing.Point(119, 8);
            this.lblLegFerias.Name = "lblLegFerias";
            this.lblLegFerias.Size = new System.Drawing.Size(36, 13);
            this.lblLegFerias.TabIndex = 20;
            this.lblLegFerias.Text = "Férias";
            this.lblLegFerias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLegFeriado
            // 
            this.lblLegFeriado.AutoSize = true;
            this.lblLegFeriado.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegFeriado.Location = new System.Drawing.Point(27, 27);
            this.lblLegFeriado.Name = "lblLegFeriado";
            this.lblLegFeriado.Size = new System.Drawing.Size(43, 13);
            this.lblLegFeriado.TabIndex = 19;
            this.lblLegFeriado.Text = "Feriado";
            this.lblLegFeriado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgLegFolga
            // 
            this.imgLegFolga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(237)))), ((int)(((byte)(112)))));
            this.imgLegFolga.Location = new System.Drawing.Point(100, 27);
            this.imgLegFolga.Name = "imgLegFolga";
            this.imgLegFolga.Size = new System.Drawing.Size(13, 13);
            this.imgLegFolga.TabIndex = 18;
            // 
            // imgLegFerias
            // 
            this.imgLegFerias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(227)))), ((int)(((byte)(239)))));
            this.imgLegFerias.Location = new System.Drawing.Point(100, 8);
            this.imgLegFerias.Name = "imgLegFerias";
            this.imgLegFerias.Size = new System.Drawing.Size(13, 13);
            this.imgLegFerias.TabIndex = 17;
            // 
            // imgLegFeriado
            // 
            this.imgLegFeriado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(220)))), ((int)(((byte)(111)))));
            this.imgLegFeriado.Location = new System.Drawing.Point(8, 27);
            this.imgLegFeriado.Name = "imgLegFeriado";
            this.imgLegFeriado.Size = new System.Drawing.Size(13, 13);
            this.imgLegFeriado.TabIndex = 16;
            // 
            // lblLegLembrete
            // 
            this.lblLegLembrete.AutoSize = true;
            this.lblLegLembrete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegLembrete.Location = new System.Drawing.Point(27, 8);
            this.lblLegLembrete.Name = "lblLegLembrete";
            this.lblLegLembrete.Size = new System.Drawing.Size(52, 13);
            this.lblLegLembrete.TabIndex = 15;
            this.lblLegLembrete.Text = "Lembrete";
            this.lblLegLembrete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgLegLembrete
            // 
            this.imgLegLembrete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(154)))), ((int)(((byte)(146)))));
            this.imgLegLembrete.Location = new System.Drawing.Point(8, 8);
            this.imgLegLembrete.Name = "imgLegLembrete";
            this.imgLegLembrete.Size = new System.Drawing.Size(13, 13);
            this.imgLegLembrete.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitHrsSabado);
            this.panel1.Controls.Add(this.lblTitHrsMes);
            this.panel1.Controls.Add(this.lblTitHrsDia);
            this.panel1.Controls.Add(this.lblTitHrsSemanais);
            this.panel1.Controls.Add(this.lblTitHorasTrabalhadas);
            this.panel1.Controls.Add(this.lblDiferenca);
            this.panel1.Controls.Add(this.lblTitDiferencaHoras);
            this.panel1.Controls.Add(this.lblHrsTrabalhadas);
            this.panel1.Controls.Add(this.lblHrsSemana);
            this.panel1.Controls.Add(this.lblHrsMes);
            this.panel1.Controls.Add(this.lblHrsDia);
            this.panel1.Controls.Add(this.lblHrsSabado);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 135);
            this.panel1.TabIndex = 13;
            // 
            // lblTitHrsSabado
            // 
            this.lblTitHrsSabado.AutoSize = true;
            this.lblTitHrsSabado.BackColor = System.Drawing.Color.Transparent;
            this.lblTitHrsSabado.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitHrsSabado.ForeColor = System.Drawing.Color.Black;
            this.lblTitHrsSabado.Location = new System.Drawing.Point(6, 27);
            this.lblTitHrsSabado.Name = "lblTitHrsSabado";
            this.lblTitHrsSabado.Size = new System.Drawing.Size(78, 13);
            this.lblTitHrsSabado.TabIndex = 5;
            this.lblTitHrsSabado.Text = "Horas Sábado:";
            this.lblTitHrsSabado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitHrsMes
            // 
            this.lblTitHrsMes.AutoSize = true;
            this.lblTitHrsMes.BackColor = System.Drawing.Color.Transparent;
            this.lblTitHrsMes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitHrsMes.ForeColor = System.Drawing.Color.Black;
            this.lblTitHrsMes.Location = new System.Drawing.Point(6, 71);
            this.lblTitHrsMes.Name = "lblTitHrsMes";
            this.lblTitHrsMes.Size = new System.Drawing.Size(61, 13);
            this.lblTitHrsMes.TabIndex = 0;
            this.lblTitHrsMes.Text = "Horas Mês:";
            this.lblTitHrsMes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitHrsDia
            // 
            this.lblTitHrsDia.AutoSize = true;
            this.lblTitHrsDia.BackColor = System.Drawing.Color.Transparent;
            this.lblTitHrsDia.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitHrsDia.ForeColor = System.Drawing.Color.Black;
            this.lblTitHrsDia.Location = new System.Drawing.Point(6, 6);
            this.lblTitHrsDia.Name = "lblTitHrsDia";
            this.lblTitHrsDia.Size = new System.Drawing.Size(62, 13);
            this.lblTitHrsDia.TabIndex = 3;
            this.lblTitHrsDia.Text = "Horas Dias:";
            this.lblTitHrsDia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitHrsSemanais
            // 
            this.lblTitHrsSemanais.AutoSize = true;
            this.lblTitHrsSemanais.BackColor = System.Drawing.Color.Transparent;
            this.lblTitHrsSemanais.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitHrsSemanais.ForeColor = System.Drawing.Color.Black;
            this.lblTitHrsSemanais.Location = new System.Drawing.Point(6, 49);
            this.lblTitHrsSemanais.Name = "lblTitHrsSemanais";
            this.lblTitHrsSemanais.Size = new System.Drawing.Size(87, 13);
            this.lblTitHrsSemanais.TabIndex = 4;
            this.lblTitHrsSemanais.Text = "Horas Semanais:";
            this.lblTitHrsSemanais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitHorasTrabalhadas
            // 
            this.lblTitHorasTrabalhadas.AutoSize = true;
            this.lblTitHorasTrabalhadas.BackColor = System.Drawing.Color.Transparent;
            this.lblTitHorasTrabalhadas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitHorasTrabalhadas.ForeColor = System.Drawing.Color.Black;
            this.lblTitHorasTrabalhadas.Location = new System.Drawing.Point(6, 93);
            this.lblTitHorasTrabalhadas.Name = "lblTitHorasTrabalhadas";
            this.lblTitHorasTrabalhadas.Size = new System.Drawing.Size(101, 13);
            this.lblTitHorasTrabalhadas.TabIndex = 1;
            this.lblTitHorasTrabalhadas.Text = "Horas Trabalhadas:";
            this.lblTitHorasTrabalhadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiferenca
            // 
            this.lblDiferenca.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiferenca.ForeColor = System.Drawing.Color.Black;
            this.lblDiferenca.Location = new System.Drawing.Point(119, 114);
            this.lblDiferenca.Name = "lblDiferenca";
            this.lblDiferenca.Size = new System.Drawing.Size(62, 13);
            this.lblDiferenca.TabIndex = 11;
            this.lblDiferenca.Text = "000:00:00";
            this.lblDiferenca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitDiferencaHoras
            // 
            this.lblTitDiferencaHoras.AutoSize = true;
            this.lblTitDiferencaHoras.BackColor = System.Drawing.Color.Transparent;
            this.lblTitDiferencaHoras.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitDiferencaHoras.ForeColor = System.Drawing.Color.Black;
            this.lblTitDiferencaHoras.Location = new System.Drawing.Point(6, 114);
            this.lblTitDiferencaHoras.Name = "lblTitDiferencaHoras";
            this.lblTitDiferencaHoras.Size = new System.Drawing.Size(103, 13);
            this.lblTitDiferencaHoras.TabIndex = 2;
            this.lblTitDiferencaHoras.Text = "Diferença de Horas:";
            this.lblTitDiferencaHoras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHrsTrabalhadas
            // 
            this.lblHrsTrabalhadas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHrsTrabalhadas.ForeColor = System.Drawing.Color.Black;
            this.lblHrsTrabalhadas.Location = new System.Drawing.Point(119, 93);
            this.lblHrsTrabalhadas.Name = "lblHrsTrabalhadas";
            this.lblHrsTrabalhadas.Size = new System.Drawing.Size(62, 13);
            this.lblHrsTrabalhadas.TabIndex = 10;
            this.lblHrsTrabalhadas.Text = "000:00:00";
            this.lblHrsTrabalhadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHrsSemana
            // 
            this.lblHrsSemana.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHrsSemana.ForeColor = System.Drawing.Color.Black;
            this.lblHrsSemana.Location = new System.Drawing.Point(124, 49);
            this.lblHrsSemana.Name = "lblHrsSemana";
            this.lblHrsSemana.Size = new System.Drawing.Size(57, 13);
            this.lblHrsSemana.TabIndex = 7;
            this.lblHrsSemana.Text = "000:00:00";
            this.lblHrsSemana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHrsMes
            // 
            this.lblHrsMes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHrsMes.ForeColor = System.Drawing.Color.Black;
            this.lblHrsMes.Location = new System.Drawing.Point(124, 71);
            this.lblHrsMes.Name = "lblHrsMes";
            this.lblHrsMes.Size = new System.Drawing.Size(57, 13);
            this.lblHrsMes.TabIndex = 9;
            this.lblHrsMes.Text = "000:00:00";
            this.lblHrsMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHrsDia
            // 
            this.lblHrsDia.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHrsDia.ForeColor = System.Drawing.Color.Black;
            this.lblHrsDia.Location = new System.Drawing.Point(124, 6);
            this.lblHrsDia.Name = "lblHrsDia";
            this.lblHrsDia.Size = new System.Drawing.Size(58, 13);
            this.lblHrsDia.TabIndex = 6;
            this.lblHrsDia.Text = "000:00:00";
            this.lblHrsDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHrsSabado
            // 
            this.lblHrsSabado.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHrsSabado.ForeColor = System.Drawing.Color.Black;
            this.lblHrsSabado.Location = new System.Drawing.Point(124, 28);
            this.lblHrsSabado.Name = "lblHrsSabado";
            this.lblHrsSabado.Size = new System.Drawing.Size(57, 13);
            this.lblHrsSabado.TabIndex = 8;
            this.lblHrsSabado.Text = "000:00:00";
            this.lblHrsSabado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Image = global::AppPonto.Properties.Resources.Print_24;
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.Location = new System.Drawing.Point(5, 307);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRelatorio.Size = new System.Drawing.Size(189, 39);
            this.btnRelatorio.TabIndex = 1;
            this.btnRelatorio.Text = "[F12] Relatório Mensal";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnMarcarPonto
            // 
            this.btnMarcarPonto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcarPonto.Image = global::AppPonto.Properties.Resources.Double_Tick_24;
            this.btnMarcarPonto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcarPonto.Location = new System.Drawing.Point(5, 264);
            this.btnMarcarPonto.Name = "btnMarcarPonto";
            this.btnMarcarPonto.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMarcarPonto.Size = new System.Drawing.Size(189, 39);
            this.btnMarcarPonto.TabIndex = 0;
            this.btnMarcarPonto.Text = "[ENTER] Marca Ponto";
            this.btnMarcarPonto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcarPonto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarcarPonto.UseVisualStyleBackColor = true;
            this.btnMarcarPonto.Click += new System.EventHandler(this.btnMarcarPonto_Click);
            // 
            // pnPesquisa
            // 
            this.pnPesquisa.BackColor = System.Drawing.Color.White;
            this.pnPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPesquisa.Controls.Add(this.lblAno);
            this.pnPesquisa.Controls.Add(this.cboAno);
            this.pnPesquisa.Controls.Add(this.lblMesAno);
            this.pnPesquisa.Controls.Add(this.cboMes);
            this.pnPesquisa.Location = new System.Drawing.Point(6, 205);
            this.pnPesquisa.Name = "pnPesquisa";
            this.pnPesquisa.Padding = new System.Windows.Forms.Padding(5);
            this.pnPesquisa.Size = new System.Drawing.Size(187, 53);
            this.pnPesquisa.TabIndex = 3;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(6, 5);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(30, 13);
            this.lblAno.TabIndex = 14;
            this.lblAno.Text = "Ano:";
            this.lblAno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboAno
            // 
            this.cboAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAno.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAno.FormattingEnabled = true;
            this.cboAno.Location = new System.Drawing.Point(8, 21);
            this.cboAno.Name = "cboAno";
            this.cboAno.Size = new System.Drawing.Size(67, 21);
            this.cboAno.TabIndex = 13;
            // 
            // lblMesAno
            // 
            this.lblMesAno.AutoSize = true;
            this.lblMesAno.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesAno.Location = new System.Drawing.Point(79, 5);
            this.lblMesAno.Name = "lblMesAno";
            this.lblMesAno.Size = new System.Drawing.Size(30, 13);
            this.lblMesAno.TabIndex = 12;
            this.lblMesAno.Text = "Mês:";
            this.lblMesAno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboMes
            // 
            this.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Location = new System.Drawing.Point(81, 21);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(96, 21);
            this.cboMes.TabIndex = 11;
            this.cboMes.SelectedIndexChanged += new System.EventHandler(this.cboMes_SelectedIndexChanged);
            // 
            // popMarcacao
            // 
            this.popMarcacao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFeriado,
            this.btnFerias,
            this.btnFolga,
            this.toolStripSeparator2,
            this.btnFalta,
            this.toolStripSeparator1,
            this.btnLembrete});
            this.popMarcacao.Name = "popMarcacao";
            this.popMarcacao.Size = new System.Drawing.Size(125, 126);
            // 
            // btnFeriado
            // 
            this.btnFeriado.Name = "btnFeriado";
            this.btnFeriado.Size = new System.Drawing.Size(124, 22);
            this.btnFeriado.Text = "Feriado";
            this.btnFeriado.Click += new System.EventHandler(this.btnFeriado_Click);
            // 
            // btnFerias
            // 
            this.btnFerias.Name = "btnFerias";
            this.btnFerias.Size = new System.Drawing.Size(124, 22);
            this.btnFerias.Text = "Férias";
            this.btnFerias.Click += new System.EventHandler(this.btnFerias_Click);
            // 
            // btnFolga
            // 
            this.btnFolga.Name = "btnFolga";
            this.btnFolga.Size = new System.Drawing.Size(124, 22);
            this.btnFolga.Text = "Folga";
            this.btnFolga.Click += new System.EventHandler(this.btnFolga_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // btnFalta
            // 
            this.btnFalta.Name = "btnFalta";
            this.btnFalta.Size = new System.Drawing.Size(124, 22);
            this.btnFalta.Text = "Falta";
            this.btnFalta.Click += new System.EventHandler(this.btnFalta_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // btnLembrete
            // 
            this.btnLembrete.Name = "btnLembrete";
            this.btnLembrete.Size = new System.Drawing.Size(124, 22);
            this.btnLembrete.Text = "Lembrete";
            this.btnLembrete.Click += new System.EventHandler(this.btnLembrete_Click);
            // 
            // frmPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 641);
            this.Controls.Add(this.pnPrincipal);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPonto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Ponto";
            this.Activated += new System.EventHandler(this.frmPonto_Activated);
            this.Load += new System.EventHandler(this.frmPonto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPonto_KeyDown);
            this.pnPrincipal.ResumeLayout(false);
            this.pnGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvPonto)).EndInit();
            this.pnCabecalho.ResumeLayout(false);
            this.pnResumo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnPesquisa.ResumeLayout(false);
            this.pnPesquisa.PerformLayout();
            this.popMarcacao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Panel pnGrid;
        private System.Windows.Forms.DataGridView grvPonto;
        private System.Windows.Forms.Panel pnCabecalho;
        private System.Windows.Forms.Panel pnResumo;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnMarcarPonto;
        private System.Windows.Forms.Label lblTitDiferencaHoras;
        private System.Windows.Forms.Label lblTitHorasTrabalhadas;
        private System.Windows.Forms.Label lblTitHrsMes;
        private System.Windows.Forms.Label lblTitHrsSabado;
        private System.Windows.Forms.Label lblTitHrsSemanais;
        private System.Windows.Forms.Label lblTitHrsDia;
        private System.Windows.Forms.Label lblDiferenca;
        private System.Windows.Forms.Label lblHrsTrabalhadas;
        private System.Windows.Forms.Label lblHrsMes;
        private System.Windows.Forms.Label lblHrsSabado;
        private System.Windows.Forms.Label lblHrsSemana;
        private System.Windows.Forms.Label lblHrsDia;
        private System.Windows.Forms.ContextMenuStrip popMarcacao;
        private System.Windows.Forms.ToolStripMenuItem btnFeriado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnFalta;
        private System.Windows.Forms.Panel pnPesquisa;
        private System.Windows.Forms.Label lblMesAno;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.ComboBox cboAno;
        private System.Windows.Forms.ToolStripMenuItem btnLembrete;
        private System.Windows.Forms.ToolStripMenuItem btnFerias;
        private System.Windows.Forms.ToolStripMenuItem btnFolga;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLegLembrete;
        private System.Windows.Forms.Panel imgLegLembrete;
        private System.Windows.Forms.Panel imgLegFeriado;
        private System.Windows.Forms.Panel imgLegFerias;
        private System.Windows.Forms.Panel imgLegFolga;
        private System.Windows.Forms.Label lblLegFolga;
        private System.Windows.Forms.Label lblLegFerias;
        private System.Windows.Forms.Label lblLegFeriado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHrEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHrSaidaAlmoco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHrRetornoAlmoco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHrSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiferenca;

    }
}

