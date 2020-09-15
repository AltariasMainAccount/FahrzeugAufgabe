using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace Fahrzeuge_Projekt
{
	partial class Autobahn
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autobahn));
            this.BlackCar = new System.Windows.Forms.PictureBox();
            this.BlueCar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BlackCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueCar)).BeginInit();
            this.SuspendLayout();
            // 
            // BlackCar
            // 
            this.BlackCar.BackColor = System.Drawing.Color.Transparent;
            this.BlackCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BlackCar.BackgroundImage")));
            this.BlackCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BlackCar.Location = new System.Drawing.Point(828, 174);
            this.BlackCar.Name = "BlackCar";
            this.BlackCar.Size = new System.Drawing.Size(144, 76);
            this.BlackCar.TabIndex = 0;
            this.BlackCar.TabStop = false;
            // 
            // BlueCar
            // 
            this.BlueCar.BackColor = System.Drawing.Color.Transparent;
            this.BlueCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BlueCar.BackgroundImage")));
            this.BlueCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BlueCar.Location = new System.Drawing.Point(39, 310);
            this.BlueCar.Name = "BlueCar";
            this.BlueCar.Size = new System.Drawing.Size(141, 76);
            this.BlueCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BlueCar.TabIndex = 1;
            this.BlueCar.TabStop = false;
            // 
            // Autobahn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.BlackCar);
            this.Controls.Add(this.BlueCar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Autobahn";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autobahn-Simulation";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.BlackCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueCar)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        protected System.Windows.Forms.PictureBox BlueCar;
        protected System.Windows.Forms.PictureBox BlackCar;
    }
}

