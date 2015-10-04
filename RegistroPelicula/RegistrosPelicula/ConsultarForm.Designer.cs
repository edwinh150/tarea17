namespace RegistroPelicula.RegistrosPelicula
{
    partial class ConsultarForm
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
            this.ResultadodataGridView = new System.Windows.Forms.DataGridView();
            this.Mostrarbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConsultarcomboBox = new System.Windows.Forms.ComboBox();
            this.Consultarbutton = new System.Windows.Forms.Button();
            this.ConsultartextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadodataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultadodataGridView
            // 
            this.ResultadodataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultadodataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ResultadodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultadodataGridView.Location = new System.Drawing.Point(12, 61);
            this.ResultadodataGridView.Name = "ResultadodataGridView";
            this.ResultadodataGridView.Size = new System.Drawing.Size(743, 358);
            this.ResultadodataGridView.TabIndex = 0;
            this.ResultadodataGridView.Tag = "";
            // 
            // Mostrarbutton
            // 
            this.Mostrarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mostrarbutton.Location = new System.Drawing.Point(651, 425);
            this.Mostrarbutton.Name = "Mostrarbutton";
            this.Mostrarbutton.Size = new System.Drawing.Size(104, 23);
            this.Mostrarbutton.TabIndex = 1;
            this.Mostrarbutton.Text = "Mostrar";
            this.Mostrarbutton.UseVisualStyleBackColor = true;
            this.Mostrarbutton.Click += new System.EventHandler(this.Mostrarbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConsultarcomboBox);
            this.groupBox1.Controls.Add(this.Consultarbutton);
            this.groupBox1.Controls.Add(this.ConsultartextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 42);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar";
            // 
            // ConsultarcomboBox
            // 
            this.ConsultarcomboBox.FormattingEnabled = true;
            this.ConsultarcomboBox.Location = new System.Drawing.Point(46, 14);
            this.ConsultarcomboBox.Name = "ConsultarcomboBox";
            this.ConsultarcomboBox.Size = new System.Drawing.Size(133, 21);
            this.ConsultarcomboBox.TabIndex = 2;
            // 
            // Consultarbutton
            // 
            this.Consultarbutton.Location = new System.Drawing.Point(580, 12);
            this.Consultarbutton.Name = "Consultarbutton";
            this.Consultarbutton.Size = new System.Drawing.Size(120, 23);
            this.Consultarbutton.TabIndex = 1;
            this.Consultarbutton.Text = "Consultar";
            this.Consultarbutton.UseVisualStyleBackColor = true;
            // 
            // ConsultartextBox
            // 
            this.ConsultartextBox.Location = new System.Drawing.Point(202, 14);
            this.ConsultartextBox.Name = "ConsultartextBox";
            this.ConsultartextBox.Size = new System.Drawing.Size(352, 20);
            this.ConsultartextBox.TabIndex = 0;
            // 
            // ConsultarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistroPelicula.Properties.Resources.Ver_Peliculas_Completas_Online_Gratis;
            this.ClientSize = new System.Drawing.Size(767, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Mostrarbutton);
            this.Controls.Add(this.ResultadodataGridView);
            this.Name = "ConsultarForm";
            this.Text = "ConsultarForm";
            ((System.ComponentModel.ISupportInitialize)(this.ResultadodataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultadodataGridView;
        private System.Windows.Forms.Button Mostrarbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ConsultarcomboBox;
        private System.Windows.Forms.Button Consultarbutton;
        private System.Windows.Forms.TextBox ConsultartextBox;
    }
}