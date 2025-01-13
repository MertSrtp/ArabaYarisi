namespace arabayarisi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.araba3 = new System.Windows.Forms.PictureBox();
            this.araba = new System.Windows.Forms.PictureBox();
            this.araba4 = new System.Windows.Forms.PictureBox();
            this.araba1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.araba2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.araba3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).BeginInit();
            this.SuspendLayout();
            // 
            // araba3
            // 
            this.araba3.BackColor = System.Drawing.Color.Transparent;
            this.araba3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("araba3.BackgroundImage")));
            this.araba3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.araba3.Location = new System.Drawing.Point(407, 12);
            this.araba3.Name = "araba3";
            this.araba3.Size = new System.Drawing.Size(57, 71);
            this.araba3.TabIndex = 0;
            this.araba3.TabStop = false;
            // 
            // araba
            // 
            this.araba.BackColor = System.Drawing.Color.Transparent;
            this.araba.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("araba.BackgroundImage")));
            this.araba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.araba.Location = new System.Drawing.Point(274, 477);
            this.araba.Name = "araba";
            this.araba.Size = new System.Drawing.Size(49, 57);
            this.araba.TabIndex = 1;
            this.araba.TabStop = false;
            // 
            // araba4
            // 
            this.araba4.BackColor = System.Drawing.Color.Transparent;
            this.araba4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("araba4.BackgroundImage")));
            this.araba4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.araba4.Location = new System.Drawing.Point(145, 99);
            this.araba4.Name = "araba4";
            this.araba4.Size = new System.Drawing.Size(52, 66);
            this.araba4.TabIndex = 2;
            this.araba4.TabStop = false;
            // 
            // araba1
            // 
            this.araba1.BackColor = System.Drawing.Color.Transparent;
            this.araba1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("araba1.BackgroundImage")));
            this.araba1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.araba1.Location = new System.Drawing.Point(314, 310);
            this.araba1.Name = "araba1";
            this.araba1.Size = new System.Drawing.Size(57, 71);
            this.araba1.TabIndex = 3;
            this.araba1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // araba2
            // 
            this.araba2.BackColor = System.Drawing.Color.Transparent;
            this.araba2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("araba2.BackgroundImage")));
            this.araba2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.araba2.Location = new System.Drawing.Point(224, 211);
            this.araba2.Name = "araba2";
            this.araba2.Size = new System.Drawing.Size(57, 71);
            this.araba2.TabIndex = 4;
            this.araba2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 562);
            this.Controls.Add(this.araba2);
            this.Controls.Add(this.araba1);
            this.Controls.Add(this.araba4);
            this.Controls.Add(this.araba);
            this.Controls.Add(this.araba3);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.araba3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox araba3;
        private System.Windows.Forms.PictureBox araba;
        private System.Windows.Forms.PictureBox araba4;
        private System.Windows.Forms.PictureBox araba1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox araba2;
    }
}

