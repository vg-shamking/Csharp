
namespace MobileSeller
{
    partial class Splash
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
            this.VProgressBar = new Guna.UI.WinForms.GunaProgressBar();
            this.LProgressBar = new Guna.UI.WinForms.GunaVProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // VProgressBar
            // 
            this.VProgressBar.BorderColor = System.Drawing.Color.Black;
            this.VProgressBar.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.VProgressBar.IdleColor = System.Drawing.Color.DarkKhaki;
            this.VProgressBar.Location = new System.Drawing.Point(1, 286);
            this.VProgressBar.Name = "VProgressBar";
            this.VProgressBar.ProgressMaxColor = System.Drawing.Color.White;
            this.VProgressBar.ProgressMinColor = System.Drawing.Color.White;
            this.VProgressBar.Size = new System.Drawing.Size(506, 10);
            this.VProgressBar.TabIndex = 0;
            // 
            // LProgressBar
            // 
            this.LProgressBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LProgressBar.BorderColor = System.Drawing.Color.RosyBrown;
            this.LProgressBar.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.LProgressBar.IdleColor = System.Drawing.Color.DarkKhaki;
            this.LProgressBar.Location = new System.Drawing.Point(53, 0);
            this.LProgressBar.Name = "LProgressBar";
            this.LProgressBar.ProgressMaxColor = System.Drawing.Color.White;
            this.LProgressBar.ProgressMinColor = System.Drawing.Color.White;
            this.LProgressBar.Size = new System.Drawing.Size(10, 322);
            this.LProgressBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sprzedawca telefonow";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MobileSeller.Properties.Resources.clipart2074208;
            this.pictureBox1.Location = new System.Drawing.Point(155, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(506, 319);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LProgressBar);
            this.Controls.Add(this.VProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaProgressBar VProgressBar;
        private Guna.UI.WinForms.GunaVProgressBar LProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

