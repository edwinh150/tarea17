namespace RegistroPelicula
{
    partial class ReproducirForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReproducirForm));
            this.ReproductoraxWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.ReproductoraxWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // ReproductoraxWindowsMediaPlayer
            // 
            this.ReproductoraxWindowsMediaPlayer.Enabled = true;
            this.ReproductoraxWindowsMediaPlayer.Location = new System.Drawing.Point(12, 12);
            this.ReproductoraxWindowsMediaPlayer.Name = "ReproductoraxWindowsMediaPlayer";
            this.ReproductoraxWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ReproductoraxWindowsMediaPlayer.OcxState")));
            this.ReproductoraxWindowsMediaPlayer.Size = new System.Drawing.Size(862, 412);
            this.ReproductoraxWindowsMediaPlayer.TabIndex = 0;
            this.ReproductoraxWindowsMediaPlayer.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // ReproducirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 436);
            this.Controls.Add(this.ReproductoraxWindowsMediaPlayer);
            this.Name = "ReproducirForm";
            this.Text = "ReproducirForm";
            ((System.ComponentModel.ISupportInitialize)(this.ReproductoraxWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer ReproductoraxWindowsMediaPlayer;
    }
}