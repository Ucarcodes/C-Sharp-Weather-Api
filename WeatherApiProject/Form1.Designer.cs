namespace WeatherApiProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlUst = new Panel();
            lblHissedilen = new Label();
            lblSicaklik = new Label();
            pBoxHava = new PictureBox();
            lblTarih = new Label();
            lblSehir = new Label();
            pnlAlt = new Panel();
            lblBasinc = new Label();
            lblRuzgar = new Label();
            lblNem = new Label();
            lblMaxSicaklik = new Label();
            lblMinSicaklik = new Label();
            pBoxBasinc = new PictureBox();
            pBoxRuzgar = new PictureBox();
            pBoxNem = new PictureBox();
            pBoxMaxSicaklik = new PictureBox();
            pBoxMinSicaklik = new PictureBox();
            pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxHava).BeginInit();
            pnlAlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxBasinc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxRuzgar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxNem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxMaxSicaklik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxMinSicaklik).BeginInit();
            SuspendLayout();
            // 
            // pnlUst
            // 
            pnlUst.BackColor = Color.FromArgb(203, 240, 254);
            pnlUst.Controls.Add(lblHissedilen);
            pnlUst.Controls.Add(lblSicaklik);
            pnlUst.Controls.Add(pBoxHava);
            pnlUst.Controls.Add(lblTarih);
            pnlUst.Controls.Add(lblSehir);
            pnlUst.Dock = DockStyle.Top;
            pnlUst.Location = new Point(0, 0);
            pnlUst.Name = "pnlUst";
            pnlUst.Size = new Size(432, 369);
            pnlUst.TabIndex = 0;
            // 
            // lblHissedilen
            // 
            lblHissedilen.AutoSize = true;
            lblHissedilen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblHissedilen.Location = new Point(134, 286);
            lblHissedilen.Name = "lblHissedilen";
            lblHissedilen.Size = new Size(100, 28);
            lblHissedilen.TabIndex = 4;
            lblHissedilen.Text = "Hissedilen";
            // 
            // lblSicaklik
            // 
            lblSicaklik.AutoSize = true;
            lblSicaklik.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSicaklik.Location = new Point(145, 240);
            lblSicaklik.Name = "lblSicaklik";
            lblSicaklik.Size = new Size(129, 46);
            lblSicaklik.TabIndex = 3;
            lblSicaklik.Text = "Sıcaklık";
            // 
            // pBoxHava
            // 
            pBoxHava.Location = new Point(134, 86);
            pBoxHava.Name = "pBoxHava";
            pBoxHava.Size = new Size(151, 151);
            pBoxHava.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxHava.TabIndex = 2;
            pBoxHava.TabStop = false;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTarih.Location = new Point(134, 55);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(53, 28);
            lblTarih.TabIndex = 1;
            lblTarih.Text = "Tarih";
            // 
            // lblSehir
            // 
            lblSehir.AutoSize = true;
            lblSehir.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSehir.Location = new Point(154, 9);
            lblSehir.Name = "lblSehir";
            lblSehir.Size = new Size(95, 46);
            lblSehir.TabIndex = 0;
            lblSehir.Text = "Şehir";
            // 
            // pnlAlt
            // 
            pnlAlt.BackColor = Color.FromArgb(255, 254, 245);
            pnlAlt.Controls.Add(lblBasinc);
            pnlAlt.Controls.Add(lblRuzgar);
            pnlAlt.Controls.Add(lblNem);
            pnlAlt.Controls.Add(lblMaxSicaklik);
            pnlAlt.Controls.Add(lblMinSicaklik);
            pnlAlt.Controls.Add(pBoxBasinc);
            pnlAlt.Controls.Add(pBoxRuzgar);
            pnlAlt.Controls.Add(pBoxNem);
            pnlAlt.Controls.Add(pBoxMaxSicaklik);
            pnlAlt.Controls.Add(pBoxMinSicaklik);
            pnlAlt.Dock = DockStyle.Fill;
            pnlAlt.Location = new Point(0, 369);
            pnlAlt.Name = "pnlAlt";
            pnlAlt.Size = new Size(432, 384);
            pnlAlt.TabIndex = 1;
            // 
            // lblBasinc
            // 
            lblBasinc.AutoSize = true;
            lblBasinc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBasinc.Location = new Point(67, 314);
            lblBasinc.Name = "lblBasinc";
            lblBasinc.Size = new Size(137, 28);
            lblBasinc.TabIndex = 12;
            lblBasinc.Text = "Basınç Şiddeti:";
            // 
            // lblRuzgar
            // 
            lblRuzgar.AutoSize = true;
            lblRuzgar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblRuzgar.Location = new Point(67, 244);
            lblRuzgar.Name = "lblRuzgar";
            lblRuzgar.Size = new Size(115, 28);
            lblRuzgar.TabIndex = 11;
            lblRuzgar.Text = "Rüzgar Hızı:";
            // 
            // lblNem
            // 
            lblNem.AutoSize = true;
            lblNem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblNem.Location = new Point(67, 175);
            lblNem.Name = "lblNem";
            lblNem.Size = new Size(111, 28);
            lblNem.TabIndex = 10;
            lblNem.Text = "Nem Oranı:";
            // 
            // lblMaxSicaklik
            // 
            lblMaxSicaklik.AutoSize = true;
            lblMaxSicaklik.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMaxSicaklik.Location = new Point(67, 109);
            lblMaxSicaklik.Name = "lblMaxSicaklik";
            lblMaxSicaklik.Size = new Size(182, 28);
            lblMaxSicaklik.TabIndex = 9;
            lblMaxSicaklik.Text = "Maksimum Sıcaklık:";
            // 
            // lblMinSicaklik
            // 
            lblMinSicaklik.AutoSize = true;
            lblMinSicaklik.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMinSicaklik.Location = new Point(67, 41);
            lblMinSicaklik.Name = "lblMinSicaklik";
            lblMinSicaklik.Size = new Size(170, 28);
            lblMinSicaklik.TabIndex = 8;
            lblMinSicaklik.Text = "Minimum Sıcaklık:";
            // 
            // pBoxBasinc
            // 
            pBoxBasinc.Image = (Image)resources.GetObject("pBoxBasinc.Image");
            pBoxBasinc.Location = new Point(12, 302);
            pBoxBasinc.Name = "pBoxBasinc";
            pBoxBasinc.Size = new Size(49, 50);
            pBoxBasinc.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxBasinc.TabIndex = 7;
            pBoxBasinc.TabStop = false;
            // 
            // pBoxRuzgar
            // 
            pBoxRuzgar.Image = (Image)resources.GetObject("pBoxRuzgar.Image");
            pBoxRuzgar.Location = new Point(12, 234);
            pBoxRuzgar.Name = "pBoxRuzgar";
            pBoxRuzgar.Size = new Size(49, 50);
            pBoxRuzgar.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxRuzgar.TabIndex = 6;
            pBoxRuzgar.TabStop = false;
            // 
            // pBoxNem
            // 
            pBoxNem.Image = (Image)resources.GetObject("pBoxNem.Image");
            pBoxNem.Location = new Point(12, 166);
            pBoxNem.Name = "pBoxNem";
            pBoxNem.Size = new Size(49, 50);
            pBoxNem.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxNem.TabIndex = 5;
            pBoxNem.TabStop = false;
            // 
            // pBoxMaxSicaklik
            // 
            pBoxMaxSicaklik.Image = (Image)resources.GetObject("pBoxMaxSicaklik.Image");
            pBoxMaxSicaklik.Location = new Point(12, 98);
            pBoxMaxSicaklik.Name = "pBoxMaxSicaklik";
            pBoxMaxSicaklik.Size = new Size(49, 50);
            pBoxMaxSicaklik.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxMaxSicaklik.TabIndex = 4;
            pBoxMaxSicaklik.TabStop = false;
            // 
            // pBoxMinSicaklik
            // 
            pBoxMinSicaklik.Image = (Image)resources.GetObject("pBoxMinSicaklik.Image");
            pBoxMinSicaklik.Location = new Point(12, 30);
            pBoxMinSicaklik.Name = "pBoxMinSicaklik";
            pBoxMinSicaklik.Size = new Size(49, 50);
            pBoxMinSicaklik.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxMinSicaklik.TabIndex = 3;
            pBoxMinSicaklik.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(432, 753);
            Controls.Add(pnlAlt);
            Controls.Add(pnlUst);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hava Durumu";
            Load += Form1_Load;
            pnlUst.ResumeLayout(false);
            pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxHava).EndInit();
            pnlAlt.ResumeLayout(false);
            pnlAlt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxBasinc).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxRuzgar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxNem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxMaxSicaklik).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxMinSicaklik).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlUst;
        private Label lblSehir;
        private Panel pnlAlt;
        private Label lblTarih;
        private Label lblHissedilen;
        private Label lblSicaklik;
        private PictureBox pBoxHava;
        private PictureBox pBoxMinSicaklik;
        private PictureBox pBoxBasinc;
        private PictureBox pBoxRuzgar;
        private PictureBox pBoxNem;
        private PictureBox pBoxMaxSicaklik;
        private Label lblMaxSicaklik;
        private Label lblMinSicaklik;
        private Label lblBasinc;
        private Label lblRuzgar;
        private Label lblNem;
    }
}
