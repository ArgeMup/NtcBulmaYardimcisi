namespace NtcBulmaYardimcisi
{
    partial class AnaEkran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.Ntc_Arama = new System.Windows.Forms.TextBox();
            this.Ntc_ler = new System.Windows.Forms.ListBox();
            this.group_ntc = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Sensör_Arama = new System.Windows.Forms.TextBox();
            this.group_sensör = new System.Windows.Forms.GroupBox();
            this.Sensör_ler = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Menu_aA = new System.Windows.Forms.ToolStripDropDownButton();
            this.Menu_aA_100 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_aA_125 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_aA_150 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_aA_175 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_aA_200 = new System.Windows.Forms.ToolStripMenuItem();
            this.group_ntc.SuspendLayout();
            this.group_sensör.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ntc_Arama
            // 
            this.Ntc_Arama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ntc_Arama.Location = new System.Drawing.Point(5, 20);
            this.Ntc_Arama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ntc_Arama.Name = "Ntc_Arama";
            this.Ntc_Arama.Size = new System.Drawing.Size(363, 22);
            this.Ntc_Arama.TabIndex = 0;
            this.Ntc_Arama.Tag = "";
            this.toolTip1.SetToolTip(this.Ntc_Arama, "Arama Kutusu");
            this.Ntc_Arama.TextChanged += new System.EventHandler(this.Ntc_Arama_TextChanged);
            // 
            // Ntc_ler
            // 
            this.Ntc_ler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ntc_ler.FormattingEnabled = true;
            this.Ntc_ler.ItemHeight = 16;
            this.Ntc_ler.Location = new System.Drawing.Point(5, 46);
            this.Ntc_ler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ntc_ler.Name = "Ntc_ler";
            this.Ntc_ler.Size = new System.Drawing.Size(363, 324);
            this.Ntc_ler.Sorted = true;
            this.Ntc_ler.TabIndex = 1;
            this.Ntc_ler.DoubleClick += new System.EventHandler(this.Ntc_ler_DoubleClick);
            // 
            // group_ntc
            // 
            this.group_ntc.Controls.Add(this.Ntc_ler);
            this.group_ntc.Controls.Add(this.Ntc_Arama);
            this.group_ntc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_ntc.Location = new System.Drawing.Point(0, 0);
            this.group_ntc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_ntc.Name = "group_ntc";
            this.group_ntc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_ntc.Size = new System.Drawing.Size(373, 412);
            this.group_ntc.TabIndex = 2;
            this.group_ntc.TabStop = false;
            this.group_ntc.Text = "NTC";
            // 
            // Sensör_Arama
            // 
            this.Sensör_Arama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sensör_Arama.Location = new System.Drawing.Point(5, 20);
            this.Sensör_Arama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sensör_Arama.Name = "Sensör_Arama";
            this.Sensör_Arama.Size = new System.Drawing.Size(350, 22);
            this.Sensör_Arama.TabIndex = 2;
            this.Sensör_Arama.Tag = "";
            this.toolTip1.SetToolTip(this.Sensör_Arama, "Arama Kutusu");
            this.Sensör_Arama.TextChanged += new System.EventHandler(this.Sensor_Arama_TextChanged);
            // 
            // group_sensör
            // 
            this.group_sensör.Controls.Add(this.Sensör_ler);
            this.group_sensör.Controls.Add(this.Sensör_Arama);
            this.group_sensör.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_sensör.Location = new System.Drawing.Point(0, 0);
            this.group_sensör.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_sensör.Name = "group_sensör";
            this.group_sensör.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_sensör.Size = new System.Drawing.Size(360, 412);
            this.group_sensör.TabIndex = 2;
            this.group_sensör.TabStop = false;
            this.group_sensör.Text = "Sensör";
            // 
            // Sensör_ler
            // 
            this.Sensör_ler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sensör_ler.FormattingEnabled = true;
            this.Sensör_ler.ItemHeight = 16;
            this.Sensör_ler.Location = new System.Drawing.Point(5, 46);
            this.Sensör_ler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sensör_ler.Name = "Sensör_ler";
            this.Sensör_ler.Size = new System.Drawing.Size(350, 324);
            this.Sensör_ler.Sorted = true;
            this.Sensör_ler.TabIndex = 3;
            this.Sensör_ler.DoubleClick += new System.EventHandler(this.Sensor_ler_DoubleClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.group_sensör);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.group_ntc);
            this.splitContainer1.Size = new System.Drawing.Size(737, 412);
            this.splitContainer1.SplitterDistance = 360;
            this.splitContainer1.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.Menu_aA});
            this.statusStrip1.Location = new System.Drawing.Point(0, 381);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(737, 31);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.ShowDropDownArrow = false;
            this.toolStripSplitButton1.Size = new System.Drawing.Size(29, 29);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ToolTipText = "ArgeMup";
            // 
            // Menu_aA
            // 
            this.Menu_aA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Menu_aA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_aA_100,
            this.Menu_aA_125,
            this.Menu_aA_150,
            this.Menu_aA_175,
            this.Menu_aA_200});
            this.Menu_aA.Image = ((System.Drawing.Image)(resources.GetObject("Menu_aA.Image")));
            this.Menu_aA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_aA.Name = "Menu_aA";
            this.Menu_aA.Size = new System.Drawing.Size(47, 29);
            this.Menu_aA.Text = "a..A";
            // 
            // Menu_aA_100
            // 
            this.Menu_aA_100.Name = "Menu_aA_100";
            this.Menu_aA_100.Size = new System.Drawing.Size(224, 26);
            this.Menu_aA_100.Text = "% 100";
            this.Menu_aA_100.Click += new System.EventHandler(this.Menu_aA_100_Click);
            // 
            // Menu_aA_125
            // 
            this.Menu_aA_125.Name = "Menu_aA_125";
            this.Menu_aA_125.Size = new System.Drawing.Size(224, 26);
            this.Menu_aA_125.Text = "% 125";
            this.Menu_aA_125.Click += new System.EventHandler(this.Menu_aA_125_Click);
            // 
            // Menu_aA_150
            // 
            this.Menu_aA_150.Name = "Menu_aA_150";
            this.Menu_aA_150.Size = new System.Drawing.Size(224, 26);
            this.Menu_aA_150.Text = "% 150";
            this.Menu_aA_150.Click += new System.EventHandler(this.Menu_aA_150_Click);
            // 
            // Menu_aA_175
            // 
            this.Menu_aA_175.Name = "Menu_aA_175";
            this.Menu_aA_175.Size = new System.Drawing.Size(224, 26);
            this.Menu_aA_175.Text = "% 175";
            this.Menu_aA_175.Click += new System.EventHandler(this.Menu_aA_175_Click);
            // 
            // Menu_aA_200
            // 
            this.Menu_aA_200.Name = "Menu_aA_200";
            this.Menu_aA_200.Size = new System.Drawing.Size(224, 26);
            this.Menu_aA_200.Text = "% 200";
            this.Menu_aA_200.Click += new System.EventHandler(this.Menu_aA_200_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 412);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnaEkran";
            this.Text = "ARGEMUP NTC Bulma Yardımcısı";
            this.Shown += new System.EventHandler(this.AnaEkran_Shown);
            this.group_ntc.ResumeLayout(false);
            this.group_ntc.PerformLayout();
            this.group_sensör.ResumeLayout(false);
            this.group_sensör.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ntc_Arama;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox Ntc_ler;
        private System.Windows.Forms.GroupBox group_ntc;
        private System.Windows.Forms.GroupBox group_sensör;
        private System.Windows.Forms.ListBox Sensör_ler;
        private System.Windows.Forms.TextBox Sensör_Arama;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripDropDownButton Menu_aA;
        private System.Windows.Forms.ToolStripMenuItem Menu_aA_100;
        private System.Windows.Forms.ToolStripMenuItem Menu_aA_125;
        private System.Windows.Forms.ToolStripMenuItem Menu_aA_150;
        private System.Windows.Forms.ToolStripMenuItem Menu_aA_175;
        private System.Windows.Forms.ToolStripMenuItem Menu_aA_200;
    }
}

