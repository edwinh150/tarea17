namespace RegistroPelicula
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.openFileDialogImagen = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogPeliculaV = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.peliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarGeneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GenerocomboBox = new System.Windows.Forms.ComboBox();
            this.AnocomboBox = new System.Windows.Forms.ComboBox();
            this.Rutabutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.CategoriacomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RutatextBox = new System.Windows.Forms.TextBox();
            this.PortadapictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.PeliculaIdtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TitulotextBox = new System.Windows.Forms.TextBox();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Imlabel = new System.Windows.Forms.Label();
            this.Calabel = new System.Windows.Forms.Label();
            this.IMDBtextBox = new System.Windows.Forms.TextBox();
            this.CalificaciontextBox = new System.Windows.Forms.TextBox();
            this.CIlabel = new System.Windows.Forms.Label();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Tlabel = new System.Windows.Forms.Label();
            this.Alabel = new System.Windows.Forms.Label();
            this.Delabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Limpiarbutton = new System.Windows.Forms.Button();
            this.Reproducirbutton = new System.Windows.Forms.Button();
            this.ConsultargroupBox = new System.Windows.Forms.GroupBox();
            this.ConcomboBox = new System.Windows.Forms.ComboBox();
            this.Consultarbutton = new System.Windows.Forms.Button();
            this.ConsultartextBox = new System.Windows.Forms.TextBox();
            this.ResultadodataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortadapictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ConsultargroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1065, 548);
            this.tabControl1.TabIndex = 7;
            // 
            // openFileDialogImagen
            // 
            this.openFileDialogImagen.FileName = "openFileDialogImagenP";
            // 
            // openFileDialogPeliculaV
            // 
            this.openFileDialogPeliculaV.FileName = "openFileDialogPelicula";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peliculasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // peliculasToolStripMenuItem
            // 
            this.peliculasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarGeneroToolStripMenuItem});
            this.peliculasToolStripMenuItem.Name = "peliculasToolStripMenuItem";
            this.peliculasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.peliculasToolStripMenuItem.Text = "Peliculas";
            // 
            // agregarGeneroToolStripMenuItem
            // 
            this.agregarGeneroToolStripMenuItem.Name = "agregarGeneroToolStripMenuItem";
            this.agregarGeneroToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.agregarGeneroToolStripMenuItem.Text = "Agregar Genero";
            this.agregarGeneroToolStripMenuItem.Click += new System.EventHandler(this.agregarGeneroToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::RegistroPelicula.Properties.Resources.tiras_de_pelicula_17_1122222402;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.GenerocomboBox);
            this.tabPage1.Controls.Add(this.AnocomboBox);
            this.tabPage1.Controls.Add(this.Rutabutton);
            this.tabPage1.Controls.Add(this.Buscarbutton);
            this.tabPage1.Controls.Add(this.Eliminarbutton);
            this.tabPage1.Controls.Add(this.CategoriacomboBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.RutatextBox);
            this.tabPage1.Controls.Add(this.PortadapictureBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Nuevobutton);
            this.tabPage1.Controls.Add(this.PeliculaIdtextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Modificarbutton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TitulotextBox);
            this.tabPage1.Controls.Add(this.DescripciontextBox);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.CIlabel);
            this.tabPage1.Controls.Add(this.Guardarbutton);
            this.tabPage1.Controls.Add(this.Tlabel);
            this.tabPage1.Controls.Add(this.Alabel);
            this.tabPage1.Controls.Add(this.Delabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1057, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GenerocomboBox
            // 
            this.GenerocomboBox.FormattingEnabled = true;
            this.GenerocomboBox.Location = new System.Drawing.Point(773, 316);
            this.GenerocomboBox.Name = "GenerocomboBox";
            this.GenerocomboBox.Size = new System.Drawing.Size(181, 21);
            this.GenerocomboBox.TabIndex = 21;
            // 
            // AnocomboBox
            // 
            this.AnocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnocomboBox.FormattingEnabled = true;
            this.AnocomboBox.Items.AddRange(new object[] {
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.AnocomboBox.Location = new System.Drawing.Point(351, 289);
            this.AnocomboBox.Name = "AnocomboBox";
            this.AnocomboBox.Size = new System.Drawing.Size(210, 21);
            this.AnocomboBox.TabIndex = 20;
            // 
            // Rutabutton
            // 
            this.Rutabutton.Location = new System.Drawing.Point(292, 358);
            this.Rutabutton.Name = "Rutabutton";
            this.Rutabutton.Size = new System.Drawing.Size(22, 23);
            this.Rutabutton.TabIndex = 19;
            this.Rutabutton.Text = ".....";
            this.Rutabutton.UseVisualStyleBackColor = true;
            this.Rutabutton.Click += new System.EventHandler(this.Rutabutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::RegistroPelicula.Properties.Resources._1444590159_system_search;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(842, 391);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(83, 39);
            this.Buscarbutton.TabIndex = 18;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::RegistroPelicula.Properties.Resources._1444618207_edit_delete;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(931, 391);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(83, 39);
            this.Eliminarbutton.TabIndex = 17;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CategoriacomboBox
            // 
            this.CategoriacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriacomboBox.FormattingEnabled = true;
            this.CategoriacomboBox.Items.AddRange(new object[] {
            "Aventura",
            "Accion",
            "Comedia",
            "Terror",
            "Romantica",
            "Animacion",
            "Infantil",
            "Historico",
            "Suspenso"});
            this.CategoriacomboBox.Location = new System.Drawing.Point(351, 334);
            this.CategoriacomboBox.Name = "CategoriacomboBox";
            this.CategoriacomboBox.Size = new System.Drawing.Size(210, 21);
            this.CategoriacomboBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Portada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ruta de la Pelicula";
            // 
            // RutatextBox
            // 
            this.RutatextBox.Location = new System.Drawing.Point(87, 360);
            this.RutatextBox.Name = "RutatextBox";
            this.RutatextBox.Size = new System.Drawing.Size(199, 20);
            this.RutatextBox.TabIndex = 12;
            this.RutatextBox.DoubleClick += new System.EventHandler(this.RutatextBox_DoubleClick);
            // 
            // PortadapictureBox
            // 
            this.PortadapictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortadapictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PortadapictureBox.Location = new System.Drawing.Point(87, 139);
            this.PortadapictureBox.Name = "PortadapictureBox";
            this.PortadapictureBox.Size = new System.Drawing.Size(199, 168);
            this.PortadapictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PortadapictureBox.TabIndex = 11;
            this.PortadapictureBox.TabStop = false;
            this.PortadapictureBox.Click += new System.EventHandler(this.PortadapictureBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(770, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Genero";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::RegistroPelicula.Properties.Resources._1444590269_1;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(566, 391);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(83, 39);
            this.Nuevobutton.TabIndex = 9;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // PeliculaIdtextBox
            // 
            this.PeliculaIdtextBox.Location = new System.Drawing.Point(351, 155);
            this.PeliculaIdtextBox.Name = "PeliculaIdtextBox";
            this.PeliculaIdtextBox.Size = new System.Drawing.Size(315, 20);
            this.PeliculaIdtextBox.TabIndex = 7;
            this.PeliculaIdtextBox.TextChanged += new System.EventHandler(this.PeliculaIdtextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "PeliculaId";
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Image = global::RegistroPelicula.Properties.Resources._1444590127_edit_find_replace;
            this.Modificarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Modificarbutton.Location = new System.Drawing.Point(655, 391);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(92, 39);
            this.Modificarbutton.TabIndex = 6;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Modificarbutton.UseVisualStyleBackColor = true;
            this.Modificarbutton.Click += new System.EventHandler(this.Modificarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(408, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese los datos de la pelicula";
            // 
            // TitulotextBox
            // 
            this.TitulotextBox.Location = new System.Drawing.Point(351, 197);
            this.TitulotextBox.Name = "TitulotextBox";
            this.TitulotextBox.Size = new System.Drawing.Size(315, 20);
            this.TitulotextBox.TabIndex = 0;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(351, 243);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(315, 20);
            this.DescripciontextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Imlabel);
            this.groupBox1.Controls.Add(this.Calabel);
            this.groupBox1.Controls.Add(this.IMDBtextBox);
            this.groupBox1.Controls.Add(this.CalificaciontextBox);
            this.groupBox1.Location = new System.Drawing.Point(754, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puntuacion";
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
            // IMDBtextBox
            // 
            this.IMDBtextBox.Location = new System.Drawing.Point(19, 29);
            this.IMDBtextBox.Name = "IMDBtextBox";
            this.IMDBtextBox.Size = new System.Drawing.Size(181, 20);
            this.IMDBtextBox.TabIndex = 0;
            // 
            // CalificaciontextBox
            // 
            this.CalificaciontextBox.Location = new System.Drawing.Point(19, 83);
            this.CalificaciontextBox.Name = "CalificaciontextBox";
            this.CalificaciontextBox.Size = new System.Drawing.Size(181, 20);
            this.CalificaciontextBox.TabIndex = 0;
            // 
            // CIlabel
            // 
            this.CIlabel.AutoSize = true;
            this.CIlabel.BackColor = System.Drawing.Color.Transparent;
            this.CIlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CIlabel.Location = new System.Drawing.Point(351, 316);
            this.CIlabel.Name = "CIlabel";
            this.CIlabel.Size = new System.Drawing.Size(69, 15);
            this.CIlabel.TabIndex = 2;
            this.CIlabel.Text = "Categoria";
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::RegistroPelicula.Properties.Resources._1442212393_Save;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(753, 391);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(83, 39);
            this.Guardarbutton.TabIndex = 1;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Tlabel
            // 
            this.Tlabel.AutoSize = true;
            this.Tlabel.BackColor = System.Drawing.Color.Transparent;
            this.Tlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tlabel.Location = new System.Drawing.Point(351, 179);
            this.Tlabel.Name = "Tlabel";
            this.Tlabel.Size = new System.Drawing.Size(43, 15);
            this.Tlabel.TabIndex = 2;
            this.Tlabel.Text = "Titulo";
            // 
            // Alabel
            // 
            this.Alabel.AutoSize = true;
            this.Alabel.BackColor = System.Drawing.Color.Transparent;
            this.Alabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alabel.Location = new System.Drawing.Point(351, 266);
            this.Alabel.Name = "Alabel";
            this.Alabel.Size = new System.Drawing.Size(31, 15);
            this.Alabel.TabIndex = 2;
            this.Alabel.Text = "Ano";
            // 
            // Delabel
            // 
            this.Delabel.AutoSize = true;
            this.Delabel.BackColor = System.Drawing.Color.Transparent;
            this.Delabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delabel.Location = new System.Drawing.Point(351, 225);
            this.Delabel.Name = "Delabel";
            this.Delabel.Size = new System.Drawing.Size(83, 15);
            this.Delabel.TabIndex = 2;
            this.Delabel.Text = "Descripcion";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::RegistroPelicula.Properties.Resources.tira_de_pelicula_antigua_antiga_pixmac_imagen_85285258;
            this.tabPage2.Controls.Add(this.Limpiarbutton);
            this.tabPage2.Controls.Add(this.Reproducirbutton);
            this.tabPage2.Controls.Add(this.ConsultargroupBox);
            this.tabPage2.Controls.Add(this.ResultadodataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1057, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Limpiarbutton
            // 
            this.Limpiarbutton.Image = global::RegistroPelicula.Properties.Resources._1442211594_edit_clear;
            this.Limpiarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Limpiarbutton.Location = new System.Drawing.Point(745, 485);
            this.Limpiarbutton.Name = "Limpiarbutton";
            this.Limpiarbutton.Size = new System.Drawing.Size(149, 31);
            this.Limpiarbutton.TabIndex = 5;
            this.Limpiarbutton.Text = "Limpiar";
            this.Limpiarbutton.UseVisualStyleBackColor = true;
            this.Limpiarbutton.Click += new System.EventHandler(this.Reproducirbutton_Click);
            // 
            // Reproducirbutton
            // 
            this.Reproducirbutton.Image = global::RegistroPelicula.Properties.Resources._1444618275_play_store;
            this.Reproducirbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reproducirbutton.Location = new System.Drawing.Point(900, 485);
            this.Reproducirbutton.Name = "Reproducirbutton";
            this.Reproducirbutton.Size = new System.Drawing.Size(149, 31);
            this.Reproducirbutton.TabIndex = 5;
            this.Reproducirbutton.Text = "Reproducir";
            this.Reproducirbutton.UseVisualStyleBackColor = true;
            this.Reproducirbutton.Click += new System.EventHandler(this.Reproducirbutton_Click);
            // 
            // ConsultargroupBox
            // 
            this.ConsultargroupBox.Controls.Add(this.ConcomboBox);
            this.ConsultargroupBox.Controls.Add(this.Consultarbutton);
            this.ConsultargroupBox.Controls.Add(this.ConsultartextBox);
            this.ConsultargroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultargroupBox.Location = new System.Drawing.Point(155, 6);
            this.ConsultargroupBox.Name = "ConsultargroupBox";
            this.ConsultargroupBox.Size = new System.Drawing.Size(742, 53);
            this.ConsultargroupBox.TabIndex = 4;
            this.ConsultargroupBox.TabStop = false;
            this.ConsultargroupBox.Text = "       Filtro";
            // 
            // ConcomboBox
            // 
            this.ConcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConcomboBox.FormattingEnabled = true;
            this.ConcomboBox.Items.AddRange(new object[] {
            "Todos",
            "Id",
            "Titulo",
            "Ano",
            "Categoria",
            "Genero"});
            this.ConcomboBox.Location = new System.Drawing.Point(24, 19);
            this.ConcomboBox.Name = "ConcomboBox";
            this.ConcomboBox.Size = new System.Drawing.Size(135, 21);
            this.ConcomboBox.TabIndex = 2;
            // 
            // Consultarbutton
            // 
            this.Consultarbutton.Image = global::RegistroPelicula.Properties.Resources._1444590159_system_search;
            this.Consultarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultarbutton.Location = new System.Drawing.Point(597, 13);
            this.Consultarbutton.Name = "Consultarbutton";
            this.Consultarbutton.Size = new System.Drawing.Size(118, 30);
            this.Consultarbutton.TabIndex = 1;
            this.Consultarbutton.Text = "Consultar";
            this.Consultarbutton.UseVisualStyleBackColor = true;
            this.Consultarbutton.Click += new System.EventHandler(this.Consultarbutton_Click);
            // 
            // ConsultartextBox
            // 
            this.ConsultartextBox.Location = new System.Drawing.Point(177, 19);
            this.ConsultartextBox.Name = "ConsultartextBox";
            this.ConsultartextBox.Size = new System.Drawing.Size(401, 20);
            this.ConsultartextBox.TabIndex = 0;
            // 
            // ResultadodataGridView
            // 
            this.ResultadodataGridView.AllowUserToAddRows = false;
            this.ResultadodataGridView.AllowUserToDeleteRows = false;
            this.ResultadodataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultadodataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ResultadodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultadodataGridView.Location = new System.Drawing.Point(10, 65);
            this.ResultadodataGridView.Name = "ResultadodataGridView";
            this.ResultadodataGridView.ReadOnly = true;
            this.ResultadodataGridView.Size = new System.Drawing.Size(1039, 417);
            this.ResultadodataGridView.TabIndex = 3;
            this.ResultadodataGridView.Tag = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1065, 572);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Peliculas Al Instante";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortadapictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ConsultargroupBox.ResumeLayout(false);
            this.ConsultargroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadodataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitulotextBox;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Imlabel;
        private System.Windows.Forms.Label Calabel;
        private System.Windows.Forms.TextBox IMDBtextBox;
        private System.Windows.Forms.TextBox CalificaciontextBox;
        private System.Windows.Forms.Label CIlabel;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Label Tlabel;
        private System.Windows.Forms.Label Alabel;
        private System.Windows.Forms.Label Delabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox ConsultargroupBox;
        private System.Windows.Forms.ComboBox ConcomboBox;
        private System.Windows.Forms.Button Consultarbutton;
        private System.Windows.Forms.TextBox ConsultartextBox;
        private System.Windows.Forms.DataGridView ResultadodataGridView;
        private System.Windows.Forms.Button Modificarbutton;
        private System.Windows.Forms.TextBox PeliculaIdtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.ComboBox CategoriacomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RutatextBox;
        private System.Windows.Forms.PictureBox PortadapictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialogImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialogPeliculaV;
        private System.Windows.Forms.Button Rutabutton;
        private System.Windows.Forms.ComboBox AnocomboBox;
        private System.Windows.Forms.Button Reproducirbutton;
        private System.Windows.Forms.ComboBox GenerocomboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarGeneroToolStripMenuItem;
        private System.Windows.Forms.Button Limpiarbutton;
    }
}

