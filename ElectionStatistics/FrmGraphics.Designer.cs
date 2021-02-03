
namespace ElectionStatistics
{
    partial class FrmGraphics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAkp = new System.Windows.Forms.Label();
            this.lblChp = new System.Windows.Forms.Label();
            this.lblIyi = new System.Windows.Forms.Label();
            this.lblMhp = new System.Windows.Forms.Label();
            this.lblGelecek = new System.Windows.Forms.Label();
            this.lblAfg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(-3, -14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightBlue;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 16);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Party";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(794, 288);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(177, 362);
            this.progressBar1.Maximum = 1000000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(318, 35);
            this.progressBar1.TabIndex = 1;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(177, 412);
            this.progressBar2.Maximum = 1000000;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(318, 35);
            this.progressBar2.TabIndex = 1;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(177, 462);
            this.progressBar3.Maximum = 1000000;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(318, 35);
            this.progressBar3.TabIndex = 1;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(177, 512);
            this.progressBar4.Maximum = 1000000;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(318, 35);
            this.progressBar4.TabIndex = 1;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(177, 562);
            this.progressBar5.Maximum = 1000000;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(318, 35);
            this.progressBar5.TabIndex = 1;
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(177, 612);
            this.progressBar6.Maximum = 1000000;
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(318, 35);
            this.progressBar6.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(267, 300);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 37);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(202, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Citys";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(104, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "AKP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(102, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "CHP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(121, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "İYİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(99, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "MHP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(53, 567);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "GELECEK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(102, 619);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "AFG";
            // 
            // lblAkp
            // 
            this.lblAkp.AutoSize = true;
            this.lblAkp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAkp.Location = new System.Drawing.Point(510, 368);
            this.lblAkp.Name = "lblAkp";
            this.lblAkp.Size = new System.Drawing.Size(47, 24);
            this.lblAkp.TabIndex = 3;
            this.lblAkp.Text = "AKP";
            // 
            // lblChp
            // 
            this.lblChp.AutoSize = true;
            this.lblChp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChp.Location = new System.Drawing.Point(510, 419);
            this.lblChp.Name = "lblChp";
            this.lblChp.Size = new System.Drawing.Size(49, 24);
            this.lblChp.TabIndex = 3;
            this.lblChp.Text = "CHP";
            // 
            // lblIyi
            // 
            this.lblIyi.AutoSize = true;
            this.lblIyi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIyi.Location = new System.Drawing.Point(510, 470);
            this.lblIyi.Name = "lblIyi";
            this.lblIyi.Size = new System.Drawing.Size(30, 24);
            this.lblIyi.TabIndex = 3;
            this.lblIyi.Text = "İYİ";
            // 
            // lblMhp
            // 
            this.lblMhp.AutoSize = true;
            this.lblMhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMhp.Location = new System.Drawing.Point(510, 519);
            this.lblMhp.Name = "lblMhp";
            this.lblMhp.Size = new System.Drawing.Size(52, 24);
            this.lblMhp.TabIndex = 3;
            this.lblMhp.Text = "MHP";
            // 
            // lblGelecek
            // 
            this.lblGelecek.AutoSize = true;
            this.lblGelecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelecek.Location = new System.Drawing.Point(510, 567);
            this.lblGelecek.Name = "lblGelecek";
            this.lblGelecek.Size = new System.Drawing.Size(98, 24);
            this.lblGelecek.TabIndex = 3;
            this.lblGelecek.Text = "GELECEK";
            // 
            // lblAfg
            // 
            this.lblAfg.AutoSize = true;
            this.lblAfg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAfg.Location = new System.Drawing.Point(510, 619);
            this.lblAfg.Name = "lblAfg";
            this.lblAfg.Size = new System.Drawing.Size(49, 24);
            this.lblAfg.TabIndex = 3;
            this.lblAfg.Text = "AFG";
            // 
            // FrmGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.lblAfg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblGelecek);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMhp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblIyi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblChp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAkp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.progressBar6);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGraphics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphics";
            this.Load += new System.EventHandler(this.FrmGraphics_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAkp;
        private System.Windows.Forms.Label lblChp;
        private System.Windows.Forms.Label lblIyi;
        private System.Windows.Forms.Label lblMhp;
        private System.Windows.Forms.Label lblGelecek;
        private System.Windows.Forms.Label lblAfg;
    }
}