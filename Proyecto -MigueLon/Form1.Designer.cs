namespace Proyecto__Miguel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Botones = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorRosa = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ColorAzul = new System.Windows.Forms.Button();
            this.BtnColorActual = new System.Windows.Forms.Button();
            this.ColorVerde = new System.Windows.Forms.Button();
            this.ColorRojo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelTamañoPixel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button_Recta = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.pintarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAyudaPixel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAyudaRecta = new System.Windows.Forms.ToolStripMenuItem();
            this.poligonosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAyudaRegular = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAyudaIrregular = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAyudaCirculo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAyudaElipse = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTamaño = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAyudaEstilos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAyudaColores = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAyudaRellenar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAyudaLimpiar = new System.Windows.Forms.ToolStripMenuItem();
            this.BotonPoligonoIrregular = new System.Windows.Forms.Button();
            this.BotonPoligoRegular = new System.Windows.Forms.Button();
            this.LabelRadio = new System.Windows.Forms.Label();
            this.ValorRadio = new System.Windows.Forms.NumericUpDown();
            this.OpcionLadosPoligonos = new System.Windows.Forms.ComboBox();
            this.BotonCirculo = new System.Windows.Forms.Button();
            this.BotonElipse = new System.Windows.Forms.Button();
            this.BotonRellenar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.EstiloNormal = new System.Windows.Forms.Button();
            this.EstiloPunto = new System.Windows.Forms.Button();
            this.EstiloGuion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelEstiloActual = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ptb = new System.Windows.Forms.PictureBox();
            this.Botones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValorRadio)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).BeginInit();
            this.SuspendLayout();
            // 
            // Botones
            // 
            this.Botones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Botones.Controls.Add(this.label3);
            this.Botones.Controls.Add(this.ColorRosa);
            this.Botones.Controls.Add(this.button5);
            this.Botones.Controls.Add(this.ColorAzul);
            this.Botones.Controls.Add(this.BtnColorActual);
            this.Botones.Controls.Add(this.ColorVerde);
            this.Botones.Controls.Add(this.ColorRojo);
            this.Botones.Location = new System.Drawing.Point(784, 49);
            this.Botones.Name = "Botones";
            this.Botones.Size = new System.Drawing.Size(127, 112);
            this.Botones.TabIndex = 1;
            this.Botones.TabStop = false;
            this.Botones.Text = "Colores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Actual:";
            // 
            // ColorRosa
            // 
            this.ColorRosa.BackColor = System.Drawing.Color.Pink;
            this.ColorRosa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorRosa.Location = new System.Drawing.Point(34, 84);
            this.ColorRosa.Name = "ColorRosa";
            this.ColorRosa.Size = new System.Drawing.Size(21, 22);
            this.ColorRosa.TabIndex = 3;
            this.ColorRosa.UseVisualStyleBackColor = false;
            this.ColorRosa.Click += new System.EventHandler(this.Color_Rosa);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(61, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 45);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Paleta_Colores);
            // 
            // ColorAzul
            // 
            this.ColorAzul.BackColor = System.Drawing.Color.Blue;
            this.ColorAzul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorAzul.Location = new System.Drawing.Point(8, 84);
            this.ColorAzul.Name = "ColorAzul";
            this.ColorAzul.Size = new System.Drawing.Size(20, 22);
            this.ColorAzul.TabIndex = 2;
            this.ColorAzul.UseVisualStyleBackColor = false;
            this.ColorAzul.Click += new System.EventHandler(this.Color_Azul);
            // 
            // BtnColorActual
            // 
            this.BtnColorActual.Location = new System.Drawing.Point(61, 19);
            this.BtnColorActual.Name = "BtnColorActual";
            this.BtnColorActual.Size = new System.Drawing.Size(60, 31);
            this.BtnColorActual.TabIndex = 3;
            this.BtnColorActual.UseVisualStyleBackColor = true;
            // 
            // ColorVerde
            // 
            this.ColorVerde.BackColor = System.Drawing.Color.DarkGreen;
            this.ColorVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorVerde.Location = new System.Drawing.Point(34, 55);
            this.ColorVerde.Name = "ColorVerde";
            this.ColorVerde.Size = new System.Drawing.Size(21, 23);
            this.ColorVerde.TabIndex = 1;
            this.ColorVerde.UseVisualStyleBackColor = false;
            this.ColorVerde.Click += new System.EventHandler(this.Color_Verde);
            // 
            // ColorRojo
            // 
            this.ColorRojo.BackColor = System.Drawing.Color.Red;
            this.ColorRojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorRojo.Location = new System.Drawing.Point(8, 55);
            this.ColorRojo.Name = "ColorRojo";
            this.ColorRojo.Size = new System.Drawing.Size(21, 23);
            this.ColorRojo.TabIndex = 0;
            this.ColorRojo.UseVisualStyleBackColor = false;
            this.ColorRojo.Click += new System.EventHandler(this.Color_Rojo);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LabelTamañoPixel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Location = new System.Drawing.Point(784, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 85);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tamaño";
            // 
            // LabelTamañoPixel
            // 
            this.LabelTamañoPixel.AutoSize = true;
            this.LabelTamañoPixel.Location = new System.Drawing.Point(46, 16);
            this.LabelTamañoPixel.Name = "LabelTamañoPixel";
            this.LabelTamañoPixel.Size = new System.Drawing.Size(54, 13);
            this.LabelTamañoPixel.TabIndex = 5;
            this.LabelTamañoPixel.Text = "Chico 2px";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Actual:";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(87, 38);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(34, 27);
            this.button9.TabIndex = 6;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Tamaño_PixelGrande);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(8, 38);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(33, 27);
            this.button7.TabIndex = 4;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Tamaño_PixelChico);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(47, 38);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(34, 27);
            this.button8.TabIndex = 5;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Tamaño_PixelMediano);
            // 
            // button_Recta
            // 
            this.button_Recta.Location = new System.Drawing.Point(104, 27);
            this.button_Recta.Name = "button_Recta";
            this.button_Recta.Size = new System.Drawing.Size(75, 23);
            this.button_Recta.TabIndex = 9;
            this.button_Recta.Text = "Recta";
            this.button_Recta.UseVisualStyleBackColor = true;
            this.button_Recta.Click += new System.EventHandler(this.Boton_Recta);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(23, 27);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 10;
            this.button10.Text = "Pixel";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Boton_Pixel);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuAyuda
            // 
            this.MenuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pintarToolStripMenuItem,
            this.MenuTamaño,
            this.MenuAyudaEstilos,
            this.MenuAyudaColores,
            this.MenuAyudaRellenar,
            this.MenuAyudaLimpiar});
            this.MenuAyuda.Name = "MenuAyuda";
            this.MenuAyuda.Size = new System.Drawing.Size(66, 20);
            this.MenuAyuda.Text = "Ayuda(?)";
            // 
            // pintarToolStripMenuItem
            // 
            this.pintarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAyudaPixel,
            this.MenuAyudaRecta,
            this.poligonosToolStripMenuItem1,
            this.MenuAyudaCirculo,
            this.MenuAyudaElipse});
            this.pintarToolStripMenuItem.Name = "pintarToolStripMenuItem";
            this.pintarToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.pintarToolStripMenuItem.Text = "Pintar";
            // 
            // MenuAyudaPixel
            // 
            this.MenuAyudaPixel.Name = "MenuAyudaPixel";
            this.MenuAyudaPixel.Size = new System.Drawing.Size(127, 22);
            this.MenuAyudaPixel.Text = "Pixel";
            this.MenuAyudaPixel.Click += new System.EventHandler(this.MenuAyudaPixel_Click);
            // 
            // MenuAyudaRecta
            // 
            this.MenuAyudaRecta.Name = "MenuAyudaRecta";
            this.MenuAyudaRecta.Size = new System.Drawing.Size(127, 22);
            this.MenuAyudaRecta.Text = "Recta";
            this.MenuAyudaRecta.Click += new System.EventHandler(this.MenuAyudaRecta_Click);
            // 
            // poligonosToolStripMenuItem1
            // 
            this.poligonosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAyudaRegular,
            this.MenuAyudaIrregular});
            this.poligonosToolStripMenuItem1.Name = "poligonosToolStripMenuItem1";
            this.poligonosToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.poligonosToolStripMenuItem1.Text = "Poligonos";
            // 
            // MenuAyudaRegular
            // 
            this.MenuAyudaRegular.Name = "MenuAyudaRegular";
            this.MenuAyudaRegular.Size = new System.Drawing.Size(118, 22);
            this.MenuAyudaRegular.Text = "Regular";
            this.MenuAyudaRegular.Click += new System.EventHandler(this.MenuAyudaRegular_Click);
            // 
            // MenuAyudaIrregular
            // 
            this.MenuAyudaIrregular.Name = "MenuAyudaIrregular";
            this.MenuAyudaIrregular.Size = new System.Drawing.Size(118, 22);
            this.MenuAyudaIrregular.Text = "Irregular";
            this.MenuAyudaIrregular.Click += new System.EventHandler(this.MenuAyudaIrregular_Click);
            // 
            // MenuAyudaCirculo
            // 
            this.MenuAyudaCirculo.Name = "MenuAyudaCirculo";
            this.MenuAyudaCirculo.Size = new System.Drawing.Size(127, 22);
            this.MenuAyudaCirculo.Text = "Circulo";
            this.MenuAyudaCirculo.Click += new System.EventHandler(this.MenuAyudaCirculo_Click);
            // 
            // MenuAyudaElipse
            // 
            this.MenuAyudaElipse.Name = "MenuAyudaElipse";
            this.MenuAyudaElipse.Size = new System.Drawing.Size(127, 22);
            this.MenuAyudaElipse.Text = "Elipse";
            this.MenuAyudaElipse.Click += new System.EventHandler(this.MenuAyudaElipse_Click);
            // 
            // MenuTamaño
            // 
            this.MenuTamaño.Name = "MenuTamaño";
            this.MenuTamaño.Size = new System.Drawing.Size(149, 22);
            this.MenuTamaño.Text = "Tamaño";
            this.MenuTamaño.Click += new System.EventHandler(this.MenuTamaño_Click);
            // 
            // MenuAyudaEstilos
            // 
            this.MenuAyudaEstilos.Name = "MenuAyudaEstilos";
            this.MenuAyudaEstilos.Size = new System.Drawing.Size(149, 22);
            this.MenuAyudaEstilos.Text = "Estilos";
            this.MenuAyudaEstilos.Click += new System.EventHandler(this.MenuAyudaEstilos_Click);
            // 
            // MenuAyudaColores
            // 
            this.MenuAyudaColores.Name = "MenuAyudaColores";
            this.MenuAyudaColores.Size = new System.Drawing.Size(149, 22);
            this.MenuAyudaColores.Text = "Colores";
            this.MenuAyudaColores.Click += new System.EventHandler(this.MenuAyudaColores_Click);
            // 
            // MenuAyudaRellenar
            // 
            this.MenuAyudaRellenar.Name = "MenuAyudaRellenar";
            this.MenuAyudaRellenar.Size = new System.Drawing.Size(149, 22);
            this.MenuAyudaRellenar.Text = "Rellenar";
            this.MenuAyudaRellenar.Click += new System.EventHandler(this.MenuAyudaRellenar_Click);
            // 
            // MenuAyudaLimpiar
            // 
            this.MenuAyudaLimpiar.Name = "MenuAyudaLimpiar";
            this.MenuAyudaLimpiar.Size = new System.Drawing.Size(149, 22);
            this.MenuAyudaLimpiar.Text = "Boton Limpiar";
            this.MenuAyudaLimpiar.Click += new System.EventHandler(this.MenuAyudaLimpiar_Click);
            // 
            // BotonPoligonoIrregular
            // 
            this.BotonPoligonoIrregular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPoligonoIrregular.Location = new System.Drawing.Point(347, 28);
            this.BotonPoligonoIrregular.Name = "BotonPoligonoIrregular";
            this.BotonPoligonoIrregular.Size = new System.Drawing.Size(111, 23);
            this.BotonPoligonoIrregular.TabIndex = 14;
            this.BotonPoligonoIrregular.Text = "Poligono Irregular";
            this.BotonPoligonoIrregular.UseVisualStyleBackColor = true;
            this.BotonPoligonoIrregular.Click += new System.EventHandler(this.Boton_Poligono_Irregular);
            // 
            // BotonPoligoRegular
            // 
            this.BotonPoligoRegular.Location = new System.Drawing.Point(464, 28);
            this.BotonPoligoRegular.Name = "BotonPoligoRegular";
            this.BotonPoligoRegular.Size = new System.Drawing.Size(105, 23);
            this.BotonPoligoRegular.TabIndex = 17;
            this.BotonPoligoRegular.Text = "Poligono Regular";
            this.BotonPoligoRegular.UseVisualStyleBackColor = true;
            this.BotonPoligoRegular.Click += new System.EventHandler(this.Boton_Poligono_Regular);
            // 
            // LabelRadio
            // 
            this.LabelRadio.AutoSize = true;
            this.LabelRadio.Location = new System.Drawing.Point(708, 11);
            this.LabelRadio.Name = "LabelRadio";
            this.LabelRadio.Size = new System.Drawing.Size(35, 13);
            this.LabelRadio.TabIndex = 19;
            this.LabelRadio.Text = "Radio";
            // 
            // ValorRadio
            // 
            this.ValorRadio.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ValorRadio.Location = new System.Drawing.Point(704, 29);
            this.ValorRadio.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ValorRadio.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ValorRadio.Name = "ValorRadio";
            this.ValorRadio.Size = new System.Drawing.Size(41, 20);
            this.ValorRadio.TabIndex = 20;
            this.ValorRadio.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ValorRadio.ValueChanged += new System.EventHandler(this.ValorRadio_ValueChanged);
            // 
            // OpcionLadosPoligonos
            // 
            this.OpcionLadosPoligonos.FormattingEnabled = true;
            this.OpcionLadosPoligonos.Items.AddRange(new object[] {
            "3-Triangulo",
            "4-Cuadrado",
            "4-Rectangulo",
            "5-Pentágono",
            "6-Hexágono",
            "7-Heptágono",
            "8-Octágono",
            "9-Eneágono",
            "10-Decágono"});
            this.OpcionLadosPoligonos.Location = new System.Drawing.Point(575, 29);
            this.OpcionLadosPoligonos.Name = "OpcionLadosPoligonos";
            this.OpcionLadosPoligonos.Size = new System.Drawing.Size(121, 21);
            this.OpcionLadosPoligonos.TabIndex = 21;
            this.OpcionLadosPoligonos.Tag = "";
            this.OpcionLadosPoligonos.Text = "Elija Una Opcion";
            this.OpcionLadosPoligonos.SelectedIndexChanged += new System.EventHandler(this.LadosPoligonos_SelectedIndexChanged);
            this.OpcionLadosPoligonos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BloquearTexto);
            // 
            // BotonCirculo
            // 
            this.BotonCirculo.Location = new System.Drawing.Point(185, 27);
            this.BotonCirculo.Name = "BotonCirculo";
            this.BotonCirculo.Size = new System.Drawing.Size(75, 23);
            this.BotonCirculo.TabIndex = 22;
            this.BotonCirculo.Text = "Circulo";
            this.BotonCirculo.UseVisualStyleBackColor = true;
            this.BotonCirculo.Click += new System.EventHandler(this.Boton_Circulo);
            // 
            // BotonElipse
            // 
            this.BotonElipse.Location = new System.Drawing.Point(266, 27);
            this.BotonElipse.Name = "BotonElipse";
            this.BotonElipse.Size = new System.Drawing.Size(75, 23);
            this.BotonElipse.TabIndex = 23;
            this.BotonElipse.Text = "Elipse";
            this.BotonElipse.UseVisualStyleBackColor = true;
            this.BotonElipse.Click += new System.EventHandler(this.Boton_Elipse);
            // 
            // BotonRellenar
            // 
            this.BotonRellenar.Location = new System.Drawing.Point(758, 6);
            this.BotonRellenar.Name = "BotonRellenar";
            this.BotonRellenar.Size = new System.Drawing.Size(75, 23);
            this.BotonRellenar.TabIndex = 24;
            this.BotonRellenar.Text = "Rellenar";
            this.BotonRellenar.UseVisualStyleBackColor = true;
            this.BotonRellenar.Click += new System.EventHandler(this.BotonRellenar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Limpiar.Location = new System.Drawing.Point(807, 446);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 11;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Boton_Limpiar);
            // 
            // EstiloNormal
            // 
            this.EstiloNormal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EstiloNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstiloNormal.Location = new System.Drawing.Point(23, 57);
            this.EstiloNormal.Name = "EstiloNormal";
            this.EstiloNormal.Size = new System.Drawing.Size(75, 23);
            this.EstiloNormal.TabIndex = 0;
            this.EstiloNormal.Text = "--------";
            this.EstiloNormal.UseVisualStyleBackColor = true;
            this.EstiloNormal.Click += new System.EventHandler(this.EstiloNormal_Click);
            // 
            // EstiloPunto
            // 
            this.EstiloPunto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.EstiloPunto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EstiloPunto.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstiloPunto.Location = new System.Drawing.Point(23, 115);
            this.EstiloPunto.Name = "EstiloPunto";
            this.EstiloPunto.Size = new System.Drawing.Size(75, 23);
            this.EstiloPunto.TabIndex = 1;
            this.EstiloPunto.Text = " . . . . . . ";
            this.EstiloPunto.UseVisualStyleBackColor = false;
            this.EstiloPunto.Click += new System.EventHandler(this.EstiloPunto_Click);
            // 
            // EstiloGuion
            // 
            this.EstiloGuion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstiloGuion.Location = new System.Drawing.Point(23, 86);
            this.EstiloGuion.Name = "EstiloGuion";
            this.EstiloGuion.Size = new System.Drawing.Size(75, 23);
            this.EstiloGuion.TabIndex = 2;
            this.EstiloGuion.Text = "- - - - - -";
            this.EstiloGuion.UseVisualStyleBackColor = true;
            this.EstiloGuion.Click += new System.EventHandler(this.EstiloGuion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Actual:";
            // 
            // LabelEstiloActual
            // 
            this.LabelEstiloActual.AutoSize = true;
            this.LabelEstiloActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEstiloActual.Location = new System.Drawing.Point(53, 24);
            this.LabelEstiloActual.Name = "LabelEstiloActual";
            this.LabelEstiloActual.Size = new System.Drawing.Size(0, 20);
            this.LabelEstiloActual.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.LabelEstiloActual);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.EstiloGuion);
            this.groupBox2.Controls.Add(this.EstiloPunto);
            this.groupBox2.Controls.Add(this.EstiloNormal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(784, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 144);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estilos";
            // 
            // ptb
            // 
            this.ptb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ptb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptb.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptb.Location = new System.Drawing.Point(12, 55);
            this.ptb.Name = "ptb";
            this.ptb.Size = new System.Drawing.Size(741, 403);
            this.ptb.TabIndex = 0;
            this.ptb.TabStop = false;
            this.ptb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptb_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(928, 471);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BotonRellenar);
            this.Controls.Add(this.BotonElipse);
            this.Controls.Add(this.BotonCirculo);
            this.Controls.Add(this.OpcionLadosPoligonos);
            this.Controls.Add(this.ValorRadio);
            this.Controls.Add(this.LabelRadio);
            this.Controls.Add(this.BotonPoligonoIrregular);
            this.Controls.Add(this.BotonPoligoRegular);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button_Recta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Botones);
            this.Controls.Add(this.ptb);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Elaborado por Miguel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Botones.ResumeLayout(false);
            this.Botones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValorRadio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb;
        private System.Windows.Forms.GroupBox Botones;
        private System.Windows.Forms.Button ColorRojo;
        private System.Windows.Forms.Button ColorVerde;
        private System.Windows.Forms.Button ColorAzul;
        private System.Windows.Forms.Button ColorRosa;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BtnColorActual;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Recta;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuAyuda;
        private System.Windows.Forms.ToolStripMenuItem MenuAyudaColores;
        private System.Windows.Forms.ToolStripMenuItem MenuTamaño;
        private System.Windows.Forms.ToolStripMenuItem MenuAyudaLimpiar;
        private System.Windows.Forms.Button BotonPoligonoIrregular;
        private System.Windows.Forms.Button BotonPoligoRegular;
        private System.Windows.Forms.Label LabelRadio;
        private System.Windows.Forms.NumericUpDown ValorRadio;
        private System.Windows.Forms.ComboBox OpcionLadosPoligonos;
        private System.Windows.Forms.Button BotonCirculo;
        private System.Windows.Forms.Button BotonElipse;
        private System.Windows.Forms.Button BotonRellenar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button EstiloNormal;
        private System.Windows.Forms.Button EstiloPunto;
        private System.Windows.Forms.Button EstiloGuion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelEstiloActual;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelTamañoPixel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem MenuAyudaEstilos;
        private System.Windows.Forms.ToolStripMenuItem MenuAyudaRellenar;
        private System.Windows.Forms.ToolStripMenuItem pintarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuAyudaPixel;
        private System.Windows.Forms.ToolStripMenuItem MenuAyudaRecta;
        private System.Windows.Forms.ToolStripMenuItem poligonosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuAyudaRegular;
        private System.Windows.Forms.ToolStripMenuItem MenuAyudaIrregular;
        private System.Windows.Forms.ToolStripMenuItem MenuAyudaCirculo;
        private System.Windows.Forms.ToolStripMenuItem MenuAyudaElipse;
    }
}

