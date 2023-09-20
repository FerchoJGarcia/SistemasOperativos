namespace AdministradorDeTareas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvAdmon = new MetroFramework.Controls.MetroGrid();
            this.mtgProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtgMemFisica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtgMemVirtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtgCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new MetroFramework.Controls.MetroTile();
            this.btnDetener = new MetroFramework.Controls.MetroTile();
            this.btnSalir = new MetroFramework.Controls.MetroTile();
            this.LblContador = new System.Windows.Forms.Label();
            this.LblNombreProceso = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnGraficas = new MetroFramework.Controls.MetroTile();
            this.btnProcesos = new MetroFramework.Controls.MetroTile();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblporRAM = new System.Windows.Forms.Label();
            this.lblporCPU = new System.Windows.Forms.Label();
            this.pfcCPU = new System.Diagnostics.PerformanceCounter();
            this.pfcRAM = new System.Diagnostics.PerformanceCounter();
            this.mpbCPU = new MetroFramework.Controls.MetroProgressBar();
            this.mpbRAM = new MetroFramework.Controls.MetroProgressBar();
            this.GraficaCPURAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfcCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfcRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaCPURAM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdmon
            // 
            this.dgvAdmon.AllowUserToResizeRows = false;
            this.dgvAdmon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvAdmon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdmon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAdmon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mtgProceso,
            this.mtgID,
            this.mtgMemFisica,
            this.mtgMemVirtual,
            this.mtgCPU});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdmon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdmon.EnableHeadersVisualStyles = false;
            this.dgvAdmon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAdmon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvAdmon.Location = new System.Drawing.Point(22, 76);
            this.dgvAdmon.Name = "dgvAdmon";
            this.dgvAdmon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdmon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAdmon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmon.Size = new System.Drawing.Size(754, 335);
            this.dgvAdmon.Style = MetroFramework.MetroColorStyle.Orange;
            this.dgvAdmon.TabIndex = 0;
            this.dgvAdmon.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvAdmon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmon_CellContentClick);
            // 
            // mtgProceso
            // 
            this.mtgProceso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mtgProceso.HeaderText = "Proceso";
            this.mtgProceso.Name = "mtgProceso";
            // 
            // mtgID
            // 
            this.mtgID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mtgID.HeaderText = "ID";
            this.mtgID.Name = "mtgID";
            // 
            // mtgMemFisica
            // 
            this.mtgMemFisica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mtgMemFisica.HeaderText = "Memoria Fisica";
            this.mtgMemFisica.Name = "mtgMemFisica";
            // 
            // mtgMemVirtual
            // 
            this.mtgMemVirtual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mtgMemVirtual.HeaderText = "Memoria Virtual";
            this.mtgMemVirtual.Name = "mtgMemVirtual";
            // 
            // mtgCPU
            // 
            this.mtgCPU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mtgCPU.HeaderText = "CPU";
            this.mtgCPU.Name = "mtgCPU";
            // 
            // btnActualizar
            // 
            this.btnActualizar.ActiveControl = null;
            this.btnActualizar.Location = new System.Drawing.Point(50, 430);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 42);
            this.btnActualizar.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnActualizar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnActualizar.UseSelectable = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.ActiveControl = null;
            this.btnDetener.Location = new System.Drawing.Point(218, 430);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(110, 42);
            this.btnDetener.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnDetener.TabIndex = 2;
            this.btnDetener.Text = "Detener";
            this.btnDetener.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDetener.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnDetener.UseSelectable = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ActiveControl = null;
            this.btnSalir.Location = new System.Drawing.Point(637, 430);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 42);
            this.btnSalir.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSalir.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // LblContador
            // 
            this.LblContador.AutoSize = true;
            this.LblContador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblContador.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContador.Location = new System.Drawing.Point(45, 482);
            this.LblContador.Name = "LblContador";
            this.LblContador.Size = new System.Drawing.Size(49, 19);
            this.LblContador.TabIndex = 4;
            this.LblContador.Text = "label1";
            // 
            // LblNombreProceso
            // 
            this.LblNombreProceso.AutoSize = true;
            this.LblNombreProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblNombreProceso.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreProceso.Location = new System.Drawing.Point(520, 482);
            this.LblNombreProceso.Name = "LblNombreProceso";
            this.LblNombreProceso.Size = new System.Drawing.Size(140, 19);
            this.LblNombreProceso.TabIndex = 5;
            this.LblNombreProceso.Text = "Nombre del Proceso";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblNombre.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(681, 482);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(17, 19);
            this.LblNombre.TabIndex = 6;
            this.LblNombre.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnGraficas
            // 
            this.btnGraficas.ActiveControl = null;
            this.btnGraficas.Location = new System.Drawing.Point(383, 430);
            this.btnGraficas.Name = "btnGraficas";
            this.btnGraficas.Size = new System.Drawing.Size(110, 42);
            this.btnGraficas.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnGraficas.TabIndex = 7;
            this.btnGraficas.Text = "Rendimiento";
            this.btnGraficas.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnGraficas.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnGraficas.UseSelectable = true;
            this.btnGraficas.Click += new System.EventHandler(this.btnGraficas_Click);
            // 
            // btnProcesos
            // 
            this.btnProcesos.ActiveControl = null;
            this.btnProcesos.Location = new System.Drawing.Point(120, 430);
            this.btnProcesos.Name = "btnProcesos";
            this.btnProcesos.Size = new System.Drawing.Size(110, 42);
            this.btnProcesos.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnProcesos.TabIndex = 8;
            this.btnProcesos.Text = "Procesos";
            this.btnProcesos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnProcesos.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnProcesos.UseSelectable = true;
            this.btnProcesos.Click += new System.EventHandler(this.btnProcesos_Click);
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCPU.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(169, 76);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(36, 19);
            this.lblCPU.TabIndex = 11;
            this.lblCPU.Text = "CPU";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRAM.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.Location = new System.Drawing.Point(165, 127);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(40, 19);
            this.lblRAM.TabIndex = 12;
            this.lblRAM.Text = "RAM";
            // 
            // lblporRAM
            // 
            this.lblporRAM.AutoSize = true;
            this.lblporRAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblporRAM.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblporRAM.Location = new System.Drawing.Point(566, 131);
            this.lblporRAM.Name = "lblporRAM";
            this.lblporRAM.Size = new System.Drawing.Size(27, 19);
            this.lblporRAM.TabIndex = 13;
            this.lblporRAM.Text = "0%";
            // 
            // lblporCPU
            // 
            this.lblporCPU.AutoSize = true;
            this.lblporCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblporCPU.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblporCPU.Location = new System.Drawing.Point(566, 76);
            this.lblporCPU.Name = "lblporCPU";
            this.lblporCPU.Size = new System.Drawing.Size(27, 19);
            this.lblporCPU.TabIndex = 14;
            this.lblporCPU.Text = "0%";
            // 
            // pfcCPU
            // 
            this.pfcCPU.CategoryName = "Processor";
            this.pfcCPU.CounterName = "% Processor Time";
            this.pfcCPU.InstanceName = "_Total";
            // 
            // pfcRAM
            // 
            this.pfcRAM.CategoryName = "Memory";
            this.pfcRAM.CounterName = "% Committed Bytes In Use";
            // 
            // mpbCPU
            // 
            this.mpbCPU.Location = new System.Drawing.Point(228, 76);
            this.mpbCPU.Name = "mpbCPU";
            this.mpbCPU.Size = new System.Drawing.Size(320, 23);
            this.mpbCPU.TabIndex = 15;
            // 
            // mpbRAM
            // 
            this.mpbRAM.Location = new System.Drawing.Point(228, 127);
            this.mpbRAM.Name = "mpbRAM";
            this.mpbRAM.Size = new System.Drawing.Size(320, 23);
            this.mpbRAM.TabIndex = 16;
            // 
            // GraficaCPURAM
            // 
            this.GraficaCPURAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GraficaCPURAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GraficaCPURAM.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.GraficaCPURAM.BackSecondaryColor = System.Drawing.Color.Gray;
            this.GraficaCPURAM.BorderlineColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            this.GraficaCPURAM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraficaCPURAM.Legends.Add(legend1);
            this.GraficaCPURAM.Location = new System.Drawing.Point(173, 171);
            this.GraficaCPURAM.Name = "GraficaCPURAM";
            this.GraficaCPURAM.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.GraficaCPURAM.Series.Add(series1);
            this.GraficaCPURAM.Series.Add(series2);
            this.GraficaCPURAM.Size = new System.Drawing.Size(420, 240);
            this.GraficaCPURAM.TabIndex = 17;
            this.GraficaCPURAM.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.GraficaCPURAM);
            this.Controls.Add(this.mpbRAM);
            this.Controls.Add(this.mpbCPU);
            this.Controls.Add(this.lblporCPU);
            this.Controls.Add(this.lblporRAM);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.btnProcesos);
            this.Controls.Add(this.btnGraficas);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblNombreProceso);
            this.Controls.Add(this.LblContador);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvAdmon);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Administrador de Tareas";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FrmAdmon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfcCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfcRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaCPURAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvAdmon;
        private MetroFramework.Controls.MetroTile btnActualizar;
        private MetroFramework.Controls.MetroTile btnDetener;
        private MetroFramework.Controls.MetroTile btnSalir;
        private System.Windows.Forms.Label LblContador;
        private System.Windows.Forms.Label LblNombreProceso;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtgProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtgMemFisica;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtgMemVirtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtgCPU;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private MetroFramework.Controls.MetroTile btnGraficas;
        private MetroFramework.Controls.MetroTile btnProcesos;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblporRAM;
        private System.Windows.Forms.Label lblporCPU;
        private System.Diagnostics.PerformanceCounter pfcCPU;
        private System.Diagnostics.PerformanceCounter pfcRAM;
        private MetroFramework.Controls.MetroProgressBar mpbCPU;
        private MetroFramework.Controls.MetroProgressBar mpbRAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficaCPURAM;
    }
}

