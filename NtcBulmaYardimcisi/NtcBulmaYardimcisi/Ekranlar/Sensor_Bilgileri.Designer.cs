namespace NtcBulmaYardimcisi
{
    partial class Sensör_Bilgileri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sutun_R_normal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sutun_R_min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sutun_R_mak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Girdi_ÜreticiKodu = new System.Windows.Forms.TextBox();
            this.Girdi_Üretici = new System.Windows.Forms.TextBox();
            this.Notlar_Butonu = new System.Windows.Forms.CheckBox();
            this.Yüzde = new System.Windows.Forms.NumericUpDown();
            this.Ntc_Arama = new System.Windows.Forms.TextBox();
            this.Girdi_Pdf = new System.Windows.Forms.LinkLabel();
            this.Girdi_Notlar = new System.Windows.Forms.TextBox();
            this.Ntc_ler = new System.Windows.Forms.ListBox();
            this.Araştır = new System.Windows.Forms.Button();
            this.Grafik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yüzde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.AllowUserToAddRows = false;
            this.Liste.AllowUserToDeleteRows = false;
            this.Liste.AllowUserToResizeColumns = false;
            this.Liste.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Liste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Liste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Liste.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Liste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sutun_R_normal,
            this.Sutun_R_min,
            this.Sutun_R_mak});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Liste.DefaultCellStyle = dataGridViewCellStyle3;
            this.Liste.Location = new System.Drawing.Point(11, 90);
            this.Liste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Liste.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Liste.RowHeadersVisible = false;
            this.Liste.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Liste.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Liste.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Liste.RowTemplate.Height = 28;
            this.Liste.ShowCellErrors = false;
            this.Liste.ShowEditingIcon = false;
            this.Liste.ShowRowErrors = false;
            this.Liste.Size = new System.Drawing.Size(289, 214);
            this.Liste.TabIndex = 29;
            // 
            // Sutun_R_normal
            // 
            this.Sutun_R_normal.HeaderText = "Sıcaklık (°C)";
            this.Sutun_R_normal.MinimumWidth = 8;
            this.Sutun_R_normal.Name = "Sutun_R_normal";
            this.Sutun_R_normal.ReadOnly = true;
            this.Sutun_R_normal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Sutun_R_min
            // 
            this.Sutun_R_min.HeaderText = "R min (Ω)";
            this.Sutun_R_min.MinimumWidth = 8;
            this.Sutun_R_min.Name = "Sutun_R_min";
            this.Sutun_R_min.ReadOnly = true;
            this.Sutun_R_min.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Sutun_R_mak
            // 
            this.Sutun_R_mak.HeaderText = "R mak (Ω)";
            this.Sutun_R_mak.MinimumWidth = 8;
            this.Sutun_R_mak.Name = "Sutun_R_mak";
            this.Sutun_R_mak.ReadOnly = true;
            this.Sutun_R_mak.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Girdi_ÜreticiKodu
            // 
            this.Girdi_ÜreticiKodu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Girdi_ÜreticiKodu.Location = new System.Drawing.Point(11, 37);
            this.Girdi_ÜreticiKodu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Girdi_ÜreticiKodu.Name = "Girdi_ÜreticiKodu";
            this.Girdi_ÜreticiKodu.Size = new System.Drawing.Size(289, 22);
            this.Girdi_ÜreticiKodu.TabIndex = 39;
            this.toolTip1.SetToolTip(this.Girdi_ÜreticiKodu, "Üretici Kodu");
            // 
            // Girdi_Üretici
            // 
            this.Girdi_Üretici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Girdi_Üretici.Location = new System.Drawing.Point(11, 11);
            this.Girdi_Üretici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Girdi_Üretici.Name = "Girdi_Üretici";
            this.Girdi_Üretici.Size = new System.Drawing.Size(289, 22);
            this.Girdi_Üretici.TabIndex = 38;
            this.toolTip1.SetToolTip(this.Girdi_Üretici, "Üretici");
            // 
            // Notlar_Butonu
            // 
            this.Notlar_Butonu.AutoSize = true;
            this.Notlar_Butonu.Location = new System.Drawing.Point(11, 62);
            this.Notlar_Butonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Notlar_Butonu.Name = "Notlar_Butonu";
            this.Notlar_Butonu.Size = new System.Drawing.Size(68, 21);
            this.Notlar_Butonu.TabIndex = 40;
            this.Notlar_Butonu.Text = "Notlar";
            this.toolTip1.SetToolTip(this.Notlar_Butonu, "ArgeMup");
            this.Notlar_Butonu.UseVisualStyleBackColor = true;
            this.Notlar_Butonu.CheckedChanged += new System.EventHandler(this.Notlar_Butonu_CheckedChanged);
            // 
            // Yüzde
            // 
            this.Yüzde.Location = new System.Drawing.Point(140, 62);
            this.Yüzde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Yüzde.Name = "Yüzde";
            this.Yüzde.Size = new System.Drawing.Size(56, 22);
            this.Yüzde.TabIndex = 45;
            this.Yüzde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.Yüzde, "Sarı İşaret için Yüzde fark Değeri");
            this.Yüzde.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Yüzde.ValueChanged += new System.EventHandler(this.Ntc_ler_SelectedIndexChanged);
            // 
            // Ntc_Arama
            // 
            this.Ntc_Arama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ntc_Arama.Location = new System.Drawing.Point(306, 11);
            this.Ntc_Arama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ntc_Arama.Name = "Ntc_Arama";
            this.Ntc_Arama.Size = new System.Drawing.Size(265, 22);
            this.Ntc_Arama.TabIndex = 46;
            this.Ntc_Arama.Tag = "";
            this.toolTip1.SetToolTip(this.Ntc_Arama, "Arama Kutusu");
            this.Ntc_Arama.TextChanged += new System.EventHandler(this.Ntc_Arama_TextChanged);
            // 
            // Girdi_Pdf
            // 
            this.Girdi_Pdf.AutoSize = true;
            this.Girdi_Pdf.Location = new System.Drawing.Point(84, 63);
            this.Girdi_Pdf.Name = "Girdi_Pdf";
            this.Girdi_Pdf.Size = new System.Drawing.Size(35, 17);
            this.Girdi_Pdf.TabIndex = 41;
            this.Girdi_Pdf.TabStop = true;
            this.Girdi_Pdf.Text = "PDF";
            this.Girdi_Pdf.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Girdi_Pdf_LinkClicked);
            // 
            // Girdi_Notlar
            // 
            this.Girdi_Notlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Girdi_Notlar.Location = new System.Drawing.Point(11, 90);
            this.Girdi_Notlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Girdi_Notlar.Multiline = true;
            this.Girdi_Notlar.Name = "Girdi_Notlar";
            this.Girdi_Notlar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Girdi_Notlar.Size = new System.Drawing.Size(289, 215);
            this.Girdi_Notlar.TabIndex = 42;
            this.Girdi_Notlar.Visible = false;
            this.Girdi_Notlar.WordWrap = false;
            // 
            // Ntc_ler
            // 
            this.Ntc_ler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ntc_ler.FormattingEnabled = true;
            this.Ntc_ler.ItemHeight = 16;
            this.Ntc_ler.Location = new System.Drawing.Point(306, 37);
            this.Ntc_ler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ntc_ler.Name = "Ntc_ler";
            this.Ntc_ler.Size = new System.Drawing.Size(265, 276);
            this.Ntc_ler.TabIndex = 43;
            this.Ntc_ler.SelectedIndexChanged += new System.EventHandler(this.Ntc_ler_SelectedIndexChanged);
            this.Ntc_ler.DoubleClick += new System.EventHandler(this.Ntc_ler_DoubleClick);
            // 
            // Araştır
            // 
            this.Araştır.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Araştır.Location = new System.Drawing.Point(224, 59);
            this.Araştır.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Araştır.Name = "Araştır";
            this.Araştır.Size = new System.Drawing.Size(76, 27);
            this.Araştır.TabIndex = 44;
            this.Araştır.Text = "Araştır";
            this.Araştır.UseVisualStyleBackColor = true;
            this.Araştır.Click += new System.EventHandler(this.Araştır_Click);
            // 
            // Grafik
            // 
            chartArea1.BackColor = System.Drawing.Color.Red;
            chartArea1.Name = "ChartArea1";
            this.Grafik.ChartAreas.Add(chartArea1);
            this.Grafik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grafik.Location = new System.Drawing.Point(0, 0);
            this.Grafik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grafik.Name = "Grafik";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            this.Grafik.Series.Add(series1);
            this.Grafik.Size = new System.Drawing.Size(265, 315);
            this.Grafik.SuppressExceptions = true;
            this.Grafik.TabIndex = 45;
            this.Grafik.Text = "chart1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Ntc_Arama);
            this.splitContainer1.Panel1.Controls.Add(this.Yüzde);
            this.splitContainer1.Panel1.Controls.Add(this.Ntc_ler);
            this.splitContainer1.Panel1.Controls.Add(this.Araştır);
            this.splitContainer1.Panel1.Controls.Add(this.Girdi_ÜreticiKodu);
            this.splitContainer1.Panel1.Controls.Add(this.Girdi_Pdf);
            this.splitContainer1.Panel1.Controls.Add(this.Liste);
            this.splitContainer1.Panel1.Controls.Add(this.Girdi_Üretici);
            this.splitContainer1.Panel1.Controls.Add(this.Notlar_Butonu);
            this.splitContainer1.Panel1.Controls.Add(this.Girdi_Notlar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Grafik);
            this.splitContainer1.Size = new System.Drawing.Size(842, 315);
            this.splitContainer1.SplitterDistance = 573;
            this.splitContainer1.TabIndex = 47;
            // 
            // Sensör_Bilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 314);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sensör_Bilgileri";
            this.Text = "SensorBilgileri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sensör_Bilgileri_FormClosing);
            this.Load += new System.EventHandler(this.Sensör_Bilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yüzde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafik)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.LinkLabel Girdi_Pdf;
        public System.Windows.Forms.TextBox Girdi_ÜreticiKodu;
        public System.Windows.Forms.TextBox Girdi_Üretici;
        private System.Windows.Forms.CheckBox Notlar_Butonu;
        public System.Windows.Forms.TextBox Girdi_Notlar;
        private System.Windows.Forms.ListBox Ntc_ler;
        private System.Windows.Forms.Button Araştır;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafik;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sutun_R_normal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sutun_R_min;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sutun_R_mak;
        public System.Windows.Forms.NumericUpDown Yüzde;
        private System.Windows.Forms.TextBox Ntc_Arama;
    }
}