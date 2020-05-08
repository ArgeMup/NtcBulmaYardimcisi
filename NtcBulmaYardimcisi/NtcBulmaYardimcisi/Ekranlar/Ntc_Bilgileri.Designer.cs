namespace NtcBulmaYardimcisi
{
    partial class Ntc_Bilgileri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Girdi_Üretici = new System.Windows.Forms.TextBox();
            this.Girdi_ÜreticiKodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RefR = new System.Windows.Forms.Label();
            this.Ref_HataOranı = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Hesaplat = new System.Windows.Forms.Button();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sutun_R_normal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sutun_R_min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sutun_R_mak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sutun_HataOranı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Girdi_Beta = new System.Windows.Forms.NumericUpDown();
            this.Girdi_Beta_HataOranı = new System.Windows.Forms.NumericUpDown();
            this.Girdi_Ref_HataOranı = new System.Windows.Forms.NumericUpDown();
            this.Girdi_Ref_R = new System.Windows.Forms.NumericUpDown();
            this.Girdi_Ref_T = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Notlar_Butonu = new System.Windows.Forms.CheckBox();
            this.Girdi_EnYüksek = new System.Windows.Forms.NumericUpDown();
            this.Girdi_EnDüşük = new System.Windows.Forms.NumericUpDown();
            this.Girdi_Aralık = new System.Windows.Forms.NumericUpDown();
            this.Girdi_Notlar = new System.Windows.Forms.TextBox();
            this.Girdi_ÇalışmaSıcaklığı = new System.Windows.Forms.Label();
            this.Girdi_Pdf = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Girdi_Beta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Girdi_Beta_HataOranı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Girdi_Ref_HataOranı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Girdi_Ref_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Girdi_Ref_T)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Girdi_EnYüksek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Girdi_EnDüşük)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Girdi_Aralık)).BeginInit();
            this.SuspendLayout();
            // 
            // Girdi_Üretici
            // 
            this.Girdi_Üretici.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Girdi_Üretici.Location = new System.Drawing.Point(375, 6);
            this.Girdi_Üretici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Girdi_Üretici.Name = "Girdi_Üretici";
            this.Girdi_Üretici.Size = new System.Drawing.Size(146, 22);
            this.Girdi_Üretici.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Girdi_Üretici, "Üretici");
            // 
            // Girdi_ÜreticiKodu
            // 
            this.Girdi_ÜreticiKodu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Girdi_ÜreticiKodu.Location = new System.Drawing.Point(375, 31);
            this.Girdi_ÜreticiKodu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Girdi_ÜreticiKodu.Name = "Girdi_ÜreticiKodu";
            this.Girdi_ÜreticiKodu.Size = new System.Drawing.Size(146, 22);
            this.Girdi_ÜreticiKodu.TabIndex = 2;
            this.toolTip1.SetToolTip(this.Girdi_ÜreticiKodu, "Üretici Kodu");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Beta (K)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Referans Sıcaklık Değeri (°C)";
            // 
            // RefR
            // 
            this.RefR.AutoSize = true;
            this.RefR.Location = new System.Drawing.Point(8, 84);
            this.RefR.Name = "RefR";
            this.RefR.Size = new System.Drawing.Size(255, 17);
            this.RefR.TabIndex = 14;
            this.RefR.Text = "Referans Sıcaklıktaki Direnç Değeri (Ω)";
            // 
            // Ref_HataOranı
            // 
            this.Ref_HataOranı.AutoSize = true;
            this.Ref_HataOranı.Location = new System.Drawing.Point(8, 110);
            this.Ref_HataOranı.Name = "Ref_HataOranı";
            this.Ref_HataOranı.Size = new System.Drawing.Size(238, 17);
            this.Ref_HataOranı.TabIndex = 18;
            this.Ref_HataOranı.Text = "Referans Sıcaklıktaki Hata Oranı (%)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Beta Hata Oranı (%)";
            // 
            // Hesaplat
            // 
            this.Hesaplat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Hesaplat.Location = new System.Drawing.Point(213, 333);
            this.Hesaplat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Hesaplat.Name = "Hesaplat";
            this.Hesaplat.Size = new System.Drawing.Size(308, 27);
            this.Hesaplat.TabIndex = 21;
            this.Hesaplat.Text = "Hesaplat";
            this.Hesaplat.UseVisualStyleBackColor = true;
            this.Hesaplat.Click += new System.EventHandler(this.Hesaplat_Click);
            // 
            // Liste
            // 
            this.Liste.AllowUserToAddRows = false;
            this.Liste.AllowUserToDeleteRows = false;
            this.Liste.AllowUserToResizeColumns = false;
            this.Liste.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Liste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.Liste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Liste.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Liste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sutun_R_normal,
            this.Sutun_R_min,
            this.Sutun_R_mak,
            this.Sutun_HataOranı});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Liste.DefaultCellStyle = dataGridViewCellStyle23;
            this.Liste.Location = new System.Drawing.Point(12, 134);
            this.Liste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Liste.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.Liste.RowHeadersWidth = 62;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Liste.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.Liste.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Liste.RowTemplate.Height = 28;
            this.Liste.ShowCellErrors = false;
            this.Liste.ShowCellToolTips = false;
            this.Liste.ShowEditingIcon = false;
            this.Liste.ShowRowErrors = false;
            this.Liste.Size = new System.Drawing.Size(509, 195);
            this.Liste.TabIndex = 22;
            // 
            // Sutun_R_normal
            // 
            this.Sutun_R_normal.HeaderText = "R nor (Ω)";
            this.Sutun_R_normal.MinimumWidth = 8;
            this.Sutun_R_normal.Name = "Sutun_R_normal";
            this.Sutun_R_normal.ReadOnly = true;
            // 
            // Sutun_R_min
            // 
            this.Sutun_R_min.HeaderText = "R min (Ω)";
            this.Sutun_R_min.MinimumWidth = 8;
            this.Sutun_R_min.Name = "Sutun_R_min";
            this.Sutun_R_min.ReadOnly = true;
            // 
            // Sutun_R_mak
            // 
            this.Sutun_R_mak.HeaderText = "R mak (Ω) ";
            this.Sutun_R_mak.MinimumWidth = 8;
            this.Sutun_R_mak.Name = "Sutun_R_mak";
            this.Sutun_R_mak.ReadOnly = true;
            // 
            // Sutun_HataOranı
            // 
            this.Sutun_HataOranı.HeaderText = "Hata (±%)";
            this.Sutun_HataOranı.MinimumWidth = 8;
            this.Sutun_HataOranı.Name = "Sutun_HataOranı";
            this.Sutun_HataOranı.ReadOnly = true;
            // 
            // Girdi_Beta
            // 
            this.Girdi_Beta.Location = new System.Drawing.Point(267, 6);
            this.Girdi_Beta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Girdi_Beta.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Girdi_Beta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Girdi_Beta.Name = "Girdi_Beta";
            this.Girdi_Beta.Size = new System.Drawing.Size(92, 22);
            this.Girdi_Beta.TabIndex = 23;
            this.Girdi_Beta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Girdi_Beta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Girdi_Beta_HataOranı
            // 
            this.Girdi_Beta_HataOranı.DecimalPlaces = 3;
            this.Girdi_Beta_HataOranı.Location = new System.Drawing.Point(267, 31);
            this.Girdi_Beta_HataOranı.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Girdi_Beta_HataOranı.Name = "Girdi_Beta_HataOranı";
            this.Girdi_Beta_HataOranı.Size = new System.Drawing.Size(92, 22);
            this.Girdi_Beta_HataOranı.TabIndex = 24;
            this.Girdi_Beta_HataOranı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Girdi_Ref_HataOranı
            // 
            this.Girdi_Ref_HataOranı.DecimalPlaces = 3;
            this.Girdi_Ref_HataOranı.Location = new System.Drawing.Point(267, 108);
            this.Girdi_Ref_HataOranı.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Girdi_Ref_HataOranı.Name = "Girdi_Ref_HataOranı";
            this.Girdi_Ref_HataOranı.Size = new System.Drawing.Size(92, 22);
            this.Girdi_Ref_HataOranı.TabIndex = 25;
            this.Girdi_Ref_HataOranı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Girdi_Ref_R
            // 
            this.Girdi_Ref_R.Location = new System.Drawing.Point(267, 82);
            this.Girdi_Ref_R.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Girdi_Ref_R.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Girdi_Ref_R.Name = "Girdi_Ref_R";
            this.Girdi_Ref_R.Size = new System.Drawing.Size(92, 22);
            this.Girdi_Ref_R.TabIndex = 26;
            this.Girdi_Ref_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Girdi_Ref_T
            // 
            this.Girdi_Ref_T.DecimalPlaces = 2;
            this.Girdi_Ref_T.Location = new System.Drawing.Point(267, 57);
            this.Girdi_Ref_T.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Girdi_Ref_T.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.Girdi_Ref_T.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.Girdi_Ref_T.Name = "Girdi_Ref_T";
            this.Girdi_Ref_T.Size = new System.Drawing.Size(92, 22);
            this.Girdi_Ref_T.TabIndex = 27;
            this.Girdi_Ref_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Notlar_Butonu
            // 
            this.Notlar_Butonu.AutoSize = true;
            this.Notlar_Butonu.Location = new System.Drawing.Point(375, 110);
            this.Notlar_Butonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Notlar_Butonu.Name = "Notlar_Butonu";
            this.Notlar_Butonu.Size = new System.Drawing.Size(68, 21);
            this.Notlar_Butonu.TabIndex = 28;
            this.Notlar_Butonu.Text = "Notlar";
            this.toolTip1.SetToolTip(this.Notlar_Butonu, "ArgeMup");
            this.Notlar_Butonu.UseVisualStyleBackColor = true;
            this.Notlar_Butonu.CheckedChanged += new System.EventHandler(this.Notlar_Butonu_CheckedChanged);
            // 
            // Girdi_EnYüksek
            // 
            this.Girdi_EnYüksek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Girdi_EnYüksek.Location = new System.Drawing.Point(74, 336);
            this.Girdi_EnYüksek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Girdi_EnYüksek.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Girdi_EnYüksek.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.Girdi_EnYüksek.Name = "Girdi_EnYüksek";
            this.Girdi_EnYüksek.Size = new System.Drawing.Size(57, 22);
            this.Girdi_EnYüksek.TabIndex = 30;
            this.Girdi_EnYüksek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.Girdi_EnYüksek, "En yüksek sıcaklık");
            // 
            // Girdi_EnDüşük
            // 
            this.Girdi_EnDüşük.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Girdi_EnDüşük.Location = new System.Drawing.Point(12, 336);
            this.Girdi_EnDüşük.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Girdi_EnDüşük.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Girdi_EnDüşük.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.Girdi_EnDüşük.Name = "Girdi_EnDüşük";
            this.Girdi_EnDüşük.Size = new System.Drawing.Size(57, 22);
            this.Girdi_EnDüşük.TabIndex = 31;
            this.Girdi_EnDüşük.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.Girdi_EnDüşük, "En düşük sıcaklık");
            // 
            // Girdi_Aralık
            // 
            this.Girdi_Aralık.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Girdi_Aralık.DecimalPlaces = 3;
            this.Girdi_Aralık.Location = new System.Drawing.Point(136, 336);
            this.Girdi_Aralık.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Girdi_Aralık.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Girdi_Aralık.Name = "Girdi_Aralık";
            this.Girdi_Aralık.Size = new System.Drawing.Size(72, 22);
            this.Girdi_Aralık.TabIndex = 32;
            this.Girdi_Aralık.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.Girdi_Aralık, "Sıcaklık aralığı");
            this.Girdi_Aralık.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Girdi_Notlar
            // 
            this.Girdi_Notlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Girdi_Notlar.Location = new System.Drawing.Point(12, 134);
            this.Girdi_Notlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Girdi_Notlar.Multiline = true;
            this.Girdi_Notlar.Name = "Girdi_Notlar";
            this.Girdi_Notlar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Girdi_Notlar.Size = new System.Drawing.Size(510, 196);
            this.Girdi_Notlar.TabIndex = 29;
            this.Girdi_Notlar.Visible = false;
            this.Girdi_Notlar.WordWrap = false;
            // 
            // Girdi_ÇalışmaSıcaklığı
            // 
            this.Girdi_ÇalışmaSıcaklığı.AutoSize = true;
            this.Girdi_ÇalışmaSıcaklığı.Location = new System.Drawing.Point(372, 58);
            this.Girdi_ÇalışmaSıcaklığı.Name = "Girdi_ÇalışmaSıcaklığı";
            this.Girdi_ÇalışmaSıcaklığı.Size = new System.Drawing.Size(155, 17);
            this.Girdi_ÇalışmaSıcaklığı.TabIndex = 36;
            this.Girdi_ÇalışmaSıcaklığı.Text = "Çalışma Sıcaklığı Aralığı";
            // 
            // Girdi_Pdf
            // 
            this.Girdi_Pdf.AutoSize = true;
            this.Girdi_Pdf.Location = new System.Drawing.Point(372, 84);
            this.Girdi_Pdf.Name = "Girdi_Pdf";
            this.Girdi_Pdf.Size = new System.Drawing.Size(35, 17);
            this.Girdi_Pdf.TabIndex = 37;
            this.Girdi_Pdf.TabStop = true;
            this.Girdi_Pdf.Text = "PDF";
            this.Girdi_Pdf.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Girdi_Pdf_LinkClicked);
            // 
            // Ntc_Bilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 362);
            this.Controls.Add(this.Girdi_Pdf);
            this.Controls.Add(this.Girdi_ÇalışmaSıcaklığı);
            this.Controls.Add(this.Girdi_Aralık);
            this.Controls.Add(this.Girdi_EnDüşük);
            this.Controls.Add(this.Girdi_EnYüksek);
            this.Controls.Add(this.Girdi_Ref_T);
            this.Controls.Add(this.Girdi_Ref_R);
            this.Controls.Add(this.Girdi_Ref_HataOranı);
            this.Controls.Add(this.Girdi_Beta_HataOranı);
            this.Controls.Add(this.Girdi_Beta);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.Hesaplat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Ref_HataOranı);
            this.Controls.Add(this.RefR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Girdi_ÜreticiKodu);
            this.Controls.Add(this.Girdi_Üretici);
            this.Controls.Add(this.Girdi_Notlar);
            this.Controls.Add(this.Notlar_Butonu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(553, 284);
            this.Name = "Ntc_Bilgileri";
            this.Text = "NTC Bilgileri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ntc_Bilgileri_FormClosing);
            this.Load += new System.EventHandler(this.Ntc_Bilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Girdi_Beta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Girdi_Beta_HataOranı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Girdi_Ref_HataOranı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Girdi_Ref_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Girdi_Ref_T)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Girdi_EnYüksek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Girdi_EnDüşük)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Girdi_Aralık)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Girdi_Üretici;
        public System.Windows.Forms.TextBox Girdi_ÜreticiKodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RefR;
        private System.Windows.Forms.Label Ref_HataOranı;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Hesaplat;
        private System.Windows.Forms.DataGridView Liste;
        public System.Windows.Forms.NumericUpDown Girdi_Beta;
        public System.Windows.Forms.NumericUpDown Girdi_Beta_HataOranı;
        public System.Windows.Forms.NumericUpDown Girdi_Ref_HataOranı;
        public System.Windows.Forms.NumericUpDown Girdi_Ref_R;
        public System.Windows.Forms.NumericUpDown Girdi_Ref_T;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sutun_R_normal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sutun_R_min;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sutun_R_mak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sutun_HataOranı;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox Notlar_Butonu;
        public System.Windows.Forms.TextBox Girdi_Notlar;
        public System.Windows.Forms.NumericUpDown Girdi_EnYüksek;
        public System.Windows.Forms.NumericUpDown Girdi_EnDüşük;
        public System.Windows.Forms.NumericUpDown Girdi_Aralık;
        public System.Windows.Forms.Label Girdi_ÇalışmaSıcaklığı;
        public System.Windows.Forms.LinkLabel Girdi_Pdf;
    }
}