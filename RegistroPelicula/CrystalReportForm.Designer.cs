namespace RegistroPelicula
{
    partial class CrystalReportForm
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
            this.PeliculacrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // PeliculacrystalReportViewer
            // 
            this.PeliculacrystalReportViewer.ActiveViewIndex = -1;
            this.PeliculacrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PeliculacrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.PeliculacrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PeliculacrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.PeliculacrystalReportViewer.Name = "PeliculacrystalReportViewer";
            this.PeliculacrystalReportViewer.Size = new System.Drawing.Size(790, 453);
            this.PeliculacrystalReportViewer.TabIndex = 0;
            // 
            // CrystalReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 453);
            this.Controls.Add(this.PeliculacrystalReportViewer);
            this.Name = "CrystalReportForm";
            this.Text = "CrystalReportForm";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer PeliculacrystalReportViewer;
    }
}