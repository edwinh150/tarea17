namespace RegistroPelicula.RegistrosPelicula
{
    partial class AgregarForm
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
            this.PeliculaIdtextBox = new System.Windows.Forms.TextBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.TitulotextBox = new System.Windows.Forms.TextBox();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.AnotextBox = new System.Windows.Forms.TextBox();
            this.CalificaciontextBox = new System.Windows.Forms.TextBox();
            this.IMDBtextBox = new System.Windows.Forms.TextBox();
            this.CategoriaIdtextBox = new System.Windows.Forms.TextBox();
            this.PIlabel = new System.Windows.Forms.Label();
            this.Tlabel = new System.Windows.Forms.Label();
            this.Delabel = new System.Windows.Forms.Label();
            this.Alabel = new System.Windows.Forms.Label();
            this.Calabel = new System.Windows.Forms.Label();
            this.CIlabel = new System.Windows.Forms.Label();
            this.Imlabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.limpiarbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PeliculaIdtextBox
            // 
            this.PeliculaIdtextBox.Location = new System.Drawing.Point(140, 69);
            this.PeliculaIdtextBox.Name = "PeliculaIdtextBox";
            this.PeliculaIdtextBox.ReadOnly = true;
            this.PeliculaIdtextBox.Size = new System.Drawing.Size(79, 20);
            this.PeliculaIdtextBox.TabIndex = 0;
            this.PeliculaIdtextBox.TextChanged += new System.EventHandler(this.PeliculaIdtextBox_TextChanged);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::RegistroPelicula.Properties.Resources._1442212393_Save;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(235, 253);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(96, 39);
            this.Guardarbutton.TabIndex = 1;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // TitulotextBox
            // 
            this.TitulotextBox.Location = new System.Drawing.Point(51, 114);
            this.TitulotextBox.Name = "TitulotextBox";
            this.TitulotextBox.Size = new System.Drawing.Size(168, 20);
            this.TitulotextBox.TabIndex = 0;
            this.TitulotextBox.TextChanged += new System.EventHandler(this.TitulotextBox_TextChanged);
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(51, 169);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(168, 20);
            this.DescripciontextBox.TabIndex = 0;
            this.DescripciontextBox.TextChanged += new System.EventHandler(this.DescripciontextBox_TextChanged);
            // 
            // AnotextBox
            // 
            this.AnotextBox.Location = new System.Drawing.Point(51, 217);
            this.AnotextBox.Name = "AnotextBox";
            this.AnotextBox.Size = new System.Drawing.Size(133, 20);
            this.AnotextBox.TabIndex = 0;
            this.AnotextBox.TextChanged += new System.EventHandler(this.AnotextBox_TextChanged);
            // 
            // CalificaciontextBox
            // 
            this.CalificaciontextBox.Location = new System.Drawing.Point(19, 83);
            this.CalificaciontextBox.Name = "CalificaciontextBox";
            this.CalificaciontextBox.Size = new System.Drawing.Size(139, 20);
            this.CalificaciontextBox.TabIndex = 0;
            // 
            // IMDBtextBox
            // 
            this.IMDBtextBox.Location = new System.Drawing.Point(19, 29);
            this.IMDBtextBox.Name = "IMDBtextBox";
            this.IMDBtextBox.Size = new System.Drawing.Size(139, 20);
            this.IMDBtextBox.TabIndex = 0;
            // 
            // CategoriaIdtextBox
            // 
            this.CategoriaIdtextBox.Location = new System.Drawing.Point(51, 272);
            this.CategoriaIdtextBox.Name = "CategoriaIdtextBox";
            this.CategoriaIdtextBox.Size = new System.Drawing.Size(133, 20);
            this.CategoriaIdtextBox.TabIndex = 0;
            this.CategoriaIdtextBox.TextChanged += new System.EventHandler(this.CategoriaIdtextBox_TextChanged);
            // 
            // PIlabel
            // 
            this.PIlabel.AutoSize = true;
            this.PIlabel.BackColor = System.Drawing.Color.Transparent;
            this.PIlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIlabel.Location = new System.Drawing.Point(48, 72);
            this.PIlabel.Name = "PIlabel";
            this.PIlabel.Size = new System.Drawing.Size(75, 15);
            this.PIlabel.TabIndex = 2;
            this.PIlabel.Text = "Pelicula Id";
            this.PIlabel.Click += new System.EventHandler(this.PIlabel_Click);
            // 
            // Tlabel
            // 
            this.Tlabel.AutoSize = true;
            this.Tlabel.BackColor = System.Drawing.Color.Transparent;
            this.Tlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tlabel.Location = new System.Drawing.Point(48, 98);
            this.Tlabel.Name = "Tlabel";
            this.Tlabel.Size = new System.Drawing.Size(43, 15);
            this.Tlabel.TabIndex = 2;
            this.Tlabel.Text = "Titulo";
            this.Tlabel.Click += new System.EventHandler(this.Tlabel_Click);
            // 
            // Delabel
            // 
            this.Delabel.AutoSize = true;
            this.Delabel.BackColor = System.Drawing.Color.Transparent;
            this.Delabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delabel.Location = new System.Drawing.Point(51, 153);
            this.Delabel.Name = "Delabel";
            this.Delabel.Size = new System.Drawing.Size(83, 15);
            this.Delabel.TabIndex = 2;
            this.Delabel.Text = "Descripcion";
            this.Delabel.Click += new System.EventHandler(this.Delabel_Click);
            // 
            // Alabel
            // 
            this.Alabel.AutoSize = true;
            this.Alabel.BackColor = System.Drawing.Color.Transparent;
            this.Alabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alabel.Location = new System.Drawing.Point(51, 201);
            this.Alabel.Name = "Alabel";
            this.Alabel.Size = new System.Drawing.Size(31, 15);
            this.Alabel.TabIndex = 2;
            this.Alabel.Text = "Ano";
            this.Alabel.Click += new System.EventHandler(this.Alabel_Click);
            // 
            // Calabel
            // 
            this.Calabel.AutoSize = true;
            this.Calabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calabel.Location = new System.Drawing.Point(16, 67);
            this.Calabel.Name = "Calabel";
            this.Calabel.Size = new System.Drawing.Size(82, 15);
            this.Calabel.TabIndex = 2;
            this.Calabel.Text = "Calificacion";
            // 
            // CIlabel
            // 
            this.CIlabel.AutoSize = true;
            this.CIlabel.BackColor = System.Drawing.Color.Transparent;
            this.CIlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CIlabel.Location = new System.Drawing.Point(51, 253);
            this.CIlabel.Name = "CIlabel";
            this.CIlabel.Size = new System.Drawing.Size(87, 15);
            this.CIlabel.TabIndex = 2;
            this.CIlabel.Text = "Categoria ID";
            this.CIlabel.Click += new System.EventHandler(this.CIlabel_Click);
            // 
            // Imlabel
            // 
            this.Imlabel.AutoSize = true;
            this.Imlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imlabel.Location = new System.Drawing.Point(16, 14);
            this.Imlabel.Name = "Imlabel";
            this.Imlabel.Size = new System.Drawing.Size(138, 15);
            this.Imlabel.TabIndex = 2;
            this.Imlabel.Text = "Puntuacion de IMDB";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Imlabel);
            this.groupBox1.Controls.Add(this.Calabel);
            this.groupBox1.Controls.Add(this.IMDBtextBox);
            this.groupBox1.Controls.Add(this.CalificaciontextBox);
            this.groupBox1.Location = new System.Drawing.Point(255, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 136);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puntuacion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese los datos de la pelicula";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // limpiarbutton
            // 
            this.limpiarbutton.Image = global::RegistroPelicula.Properties.Resources._1442211594_edit_clear;
            this.limpiarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.limpiarbutton.Location = new System.Drawing.Point(352, 253);
            this.limpiarbutton.Name = "limpiarbutton";
            this.limpiarbutton.Size = new System.Drawing.Size(96, 39);
            this.limpiarbutton.TabIndex = 5;
            this.limpiarbutton.Text = "Limpiar";
            this.limpiarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.limpiarbutton.UseVisualStyleBackColor = true;
            this.limpiarbutton.Click += new System.EventHandler(this.limpiarbutton_Click);
            // 
            // AgregarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RegistroPelicula.Properties.Resources.tira_de_pelicula_antigua_antiga_pixmac_imagen_85285258;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(479, 387);
            this.Controls.Add(this.limpiarbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CIlabel);
            this.Controls.Add(this.CategoriaIdtextBox);
            this.Controls.Add(this.Alabel);
            this.Controls.Add(this.Delabel);
            this.Controls.Add(this.Tlabel);
            this.Controls.Add(this.PIlabel);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.AnotextBox);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.TitulotextBox);
            this.Controls.Add(this.PeliculaIdtextBox);
            this.Name = "AgregarForm";
            this.Text = "Agregar Peliculas";
            this.TransparencyKey = System.Drawing.Color.White;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PeliculaIdtextBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.TextBox TitulotextBox;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.TextBox AnotextBox;
        private System.Windows.Forms.TextBox CalificaciontextBox;
        private System.Windows.Forms.TextBox IMDBtextBox;
        private System.Windows.Forms.TextBox CategoriaIdtextBox;
        private System.Windows.Forms.Label PIlabel;
        private System.Windows.Forms.Label Tlabel;
        private System.Windows.Forms.Label Delabel;
        private System.Windows.Forms.Label Alabel;
        private System.Windows.Forms.Label Calabel;
        private System.Windows.Forms.Label CIlabel;
        private System.Windows.Forms.Label Imlabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiarbutton;
    }
}