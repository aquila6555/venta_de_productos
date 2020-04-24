namespace two
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
            DevComponents.DotNetBar.Controls.ClockStyleData clockStyleData1 = new DevComponents.DotNetBar.Controls.ClockStyleData();
            DevComponents.DotNetBar.Controls.ColorData colorData1 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ColorData colorData2 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ColorData colorData3 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ClockHandStyleData clockHandStyleData1 = new DevComponents.DotNetBar.Controls.ClockHandStyleData();
            DevComponents.DotNetBar.Controls.ColorData colorData4 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ColorData colorData5 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ClockHandStyleData clockHandStyleData2 = new DevComponents.DotNetBar.Controls.ClockHandStyleData();
            DevComponents.DotNetBar.Controls.ColorData colorData6 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ClockHandStyleData clockHandStyleData3 = new DevComponents.DotNetBar.Controls.ClockHandStyleData();
            DevComponents.DotNetBar.Controls.ColorData colorData7 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ColorData colorData8 = new DevComponents.DotNetBar.Controls.ColorData();
            MetroSuite.MetroComboBox.MainColorScheme mainColorScheme1 = new MetroSuite.MetroComboBox.MainColorScheme();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MetroSuite.MetroButton.MainColorScheme mainColorScheme2 = new MetroSuite.MetroButton.MainColorScheme();
            MetroSuite.MetroButton.MainColorScheme mainColorScheme3 = new MetroSuite.MetroButton.MainColorScheme();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.analogClockControl1 = new DevComponents.DotNetBar.Controls.AnalogClockControl();
            this.txtCantidad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtPrecio = new MetroFramework.Controls.MetroTextBox();
            this.lvDetalle = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.btnMostrar = new MetroFramework.Controls.MetroButton();
            this.cboProductos = new MetroSuite.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.lblPago = new MetroFramework.Controls.MetroLabel();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEliminar = new MetroSuite.MetroButton();
            this.btnLImpiar = new MetroSuite.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::two.Properties.Resources.Sin_título;
            this.pictureBox1.Location = new System.Drawing.Point(232, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(192, 80);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PromptText = "Nombre";
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(119, 23);
            this.txtNombre.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtNombre.TabIndex = 3;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMark = "Nombre";
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // analogClockControl1
            // 
            this.analogClockControl1.AutomaticMode = true;
            this.analogClockControl1.BackColor = System.Drawing.Color.Transparent;
            this.analogClockControl1.ClockStyle = DevComponents.DotNetBar.Controls.eClockStyles.Custom;
            colorData1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData1.BrushAngle = 90F;
            colorData1.BrushSBSScale = 1F;
            colorData1.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear;
            colorData1.Color1 = System.Drawing.Color.Gold;
            colorData1.Color2 = System.Drawing.Color.Orange;
            clockStyleData1.BezelColor = colorData1;
            colorData2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData2.BorderWidth = 0.01F;
            colorData2.BrushSBSScale = 1F;
            colorData2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            colorData2.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            clockStyleData1.CapColor = colorData2;
            clockStyleData1.CapSize = 0.1F;
            colorData3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData3.BrushAngle = 90F;
            colorData3.BrushSBSScale = 1F;
            colorData3.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear;
            colorData3.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            colorData3.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            clockStyleData1.FaceColor = colorData3;
            clockStyleData1.GlassAngle = 0;
            colorData4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData4.BorderWidth = 0.01F;
            colorData4.BrushAngle = 90F;
            colorData4.BrushSBSScale = 1F;
            colorData4.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear;
            colorData4.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData4.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            clockHandStyleData1.HandColor = colorData4;
            clockHandStyleData1.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style3;
            clockHandStyleData1.Length = 0.45F;
            clockHandStyleData1.Width = 0.175F;
            clockStyleData1.HourHandStyle = clockHandStyleData1;
            colorData5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData5.BorderWidth = 0.01F;
            colorData5.BrushSBSScale = 1F;
            colorData5.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData5.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            clockStyleData1.LargeTickColor = colorData5;
            clockStyleData1.LargeTickWidth = 0.01F;
            colorData6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData6.BorderWidth = 0.01F;
            colorData6.BrushAngle = 90F;
            colorData6.BrushSBSScale = 1F;
            colorData6.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear;
            colorData6.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData6.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            clockHandStyleData2.HandColor = colorData6;
            clockHandStyleData2.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style3;
            clockHandStyleData2.Length = 0.75F;
            clockHandStyleData2.Width = 0.175F;
            clockStyleData1.MinuteHandStyle = clockHandStyleData2;
            clockStyleData1.NumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            clockStyleData1.NumberFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            clockHandStyleData3.DrawOverCap = true;
            colorData7.BorderColor = System.Drawing.Color.Black;
            colorData7.BorderWidth = 0.01F;
            colorData7.BrushSBSScale = 1F;
            colorData7.Color1 = System.Drawing.Color.Gold;
            colorData7.Color2 = System.Drawing.Color.Gold;
            clockHandStyleData3.HandColor = colorData7;
            clockHandStyleData3.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style3;
            clockHandStyleData3.Length = 0.9F;
            clockHandStyleData3.Width = 0.01F;
            clockStyleData1.SecondHandStyle = clockHandStyleData3;
            colorData8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData8.BorderWidth = 0.01F;
            colorData8.BrushSBSScale = 1F;
            colorData8.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData8.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            clockStyleData1.SmallTickColor = colorData8;
            clockStyleData1.SmallTickLength = 0.01F;
            clockStyleData1.SmallTickWidth = 0.01F;
            clockStyleData1.Style = DevComponents.DotNetBar.Controls.eClockStyles.Custom;
            this.analogClockControl1.ClockStyleData = clockStyleData1;
            this.analogClockControl1.IndicatorStyle = DevComponents.DotNetBar.Controls.eClockIndicatorStyles.Numbers;
            this.analogClockControl1.Location = new System.Drawing.Point(510, 20);
            this.analogClockControl1.Name = "analogClockControl1";
            this.analogClockControl1.Size = new System.Drawing.Size(100, 100);
            this.analogClockControl1.TabIndex = 5;
            this.analogClockControl1.Text = "analogClockControl1";
            this.analogClockControl1.Value = new System.DateTime(2017, 7, 26, 16, 55, 28, 546);
            // 
            // txtCantidad
            // 
            // 
            // 
            // 
            this.txtCantidad.CustomButton.Image = null;
            this.txtCantidad.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtCantidad.CustomButton.Name = "";
            this.txtCantidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantidad.CustomButton.TabIndex = 1;
            this.txtCantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantidad.CustomButton.UseSelectable = true;
            this.txtCantidad.CustomButton.Visible = false;
            this.txtCantidad.Lines = new string[0];
            this.txtCantidad.Location = new System.Drawing.Point(327, 80);
            this.txtCantidad.MaxLength = 32767;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.PromptText = "Cantidad";
            this.txtCantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.SelectionLength = 0;
            this.txtCantidad.SelectionStart = 0;
            this.txtCantidad.ShortcutsEnabled = true;
            this.txtCantidad.Size = new System.Drawing.Size(119, 23);
            this.txtCantidad.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.UseSelectable = true;
            this.txtCantidad.WaterMark = "Cantidad";
            this.txtCantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(64, 113);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Producto";
            // 
            // txtPrecio
            // 
            // 
            // 
            // 
            this.txtPrecio.CustomButton.Image = null;
            this.txtPrecio.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtPrecio.CustomButton.Name = "";
            this.txtPrecio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecio.CustomButton.TabIndex = 1;
            this.txtPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecio.CustomButton.UseSelectable = true;
            this.txtPrecio.CustomButton.Visible = false;
            this.txtPrecio.Lines = new string[0];
            this.txtPrecio.Location = new System.Drawing.Point(403, 109);
            this.txtPrecio.MaxLength = 32767;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.PromptText = "Precio por Unidad";
            this.txtPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.ShortcutsEnabled = true;
            this.txtPrecio.Size = new System.Drawing.Size(119, 23);
            this.txtPrecio.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtPrecio.TabIndex = 10;
            this.txtPrecio.UseSelectable = true;
            this.txtPrecio.WaterMark = "Precio por Unidad";
            this.txtPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lvDetalle
            // 
            this.lvDetalle.BackColor = System.Drawing.Color.White;
            this.lvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvDetalle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDetalle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvDetalle.FullRowSelect = true;
            this.lvDetalle.GridLines = true;
            this.lvDetalle.Location = new System.Drawing.Point(12, 161);
            this.lvDetalle.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.lvDetalle.MultiSelect = false;
            this.lvDetalle.Name = "lvDetalle";
            this.lvDetalle.OwnerDraw = true;
            this.lvDetalle.Size = new System.Drawing.Size(656, 172);
            this.lvDetalle.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lvDetalle.TabIndex = 11;
            this.lvDetalle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lvDetalle.UseCompatibleStateImageBehavior = false;
            this.lvDetalle.UseCustomBackColor = true;
            this.lvDetalle.UseCustomForeColor = true;
            this.lvDetalle.UseSelectable = true;
            this.lvDetalle.UseStyleColors = true;
            this.lvDetalle.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Producto";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cantidad";
            this.columnHeader3.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio Unidad";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sub total";
            this.columnHeader5.Width = 78;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Descuento";
            this.columnHeader6.Width = 87;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(499, 337);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(94, 19);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total a pagar: ";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(267, 132);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(125, 24);
            this.btnMostrar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnMostrar.TabIndex = 14;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseSelectable = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // cboProductos
            // 
            mainColorScheme1.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            mainColorScheme1.ArrowBoxColor = System.Drawing.Color.Yellow;
            mainColorScheme1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            mainColorScheme1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            mainColorScheme1.FillColor = System.Drawing.Color.White;
            mainColorScheme1.SelectedItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboProductos.ColorScheme = mainColorScheme1;
            this.cboProductos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboProductos.ForeColor = System.Drawing.Color.Black;
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Items.AddRange(new object[] {
            "camisa",
            "canguro",
            "cinturon",
            "corbata",
            "chalina",
            "chaleco",
            "jean",
            "pantalon",
            "polera",
            "sombrero",
            "",
            ""});
            this.cboProductos.Location = new System.Drawing.Point(133, 109);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(121, 24);
            this.cboProductos.TabIndex = 16;
            this.cboProductos.Value = "";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Transparent;
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(629, 94);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(39, 39);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.White;
            this.metroButton1.TabIndex = 17;
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(594, 347);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(0, 0);
            this.lblPago.TabIndex = 18;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(23, 335);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(459, 18);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "Promocion! descuento mas de 10 en un producto tiene 15% de descuento y mas de 20 " +
    "un 30%\r\n";
            // 
            // btnEliminar
            // 
            mainColorScheme2.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            mainColorScheme2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            mainColorScheme2.FillColor = System.Drawing.Color.White;
            mainColorScheme2.HoverFillColor = System.Drawing.Color.White;
            mainColorScheme2.PressAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            mainColorScheme2.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.ColorScheme = mainColorScheme2;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(555, 132);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(55, 27);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLImpiar
            // 
            mainColorScheme3.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            mainColorScheme3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            mainColorScheme3.FillColor = System.Drawing.Color.White;
            mainColorScheme3.HoverFillColor = System.Drawing.Color.White;
            mainColorScheme3.PressAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            mainColorScheme3.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLImpiar.ColorScheme = mainColorScheme3;
            this.btnLImpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLImpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLImpiar.Location = new System.Drawing.Point(616, 132);
            this.btnLImpiar.Name = "btnLImpiar";
            this.btnLImpiar.Size = new System.Drawing.Size(55, 27);
            this.btnLImpiar.TabIndex = 22;
            this.btnLImpiar.Text = "Limpiar";
            this.btnLImpiar.Click += new System.EventHandler(this.btnLImpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.ClientSize = new System.Drawing.Size(686, 376);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLImpiar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.cboProductos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lvDetalle);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.analogClockControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Venta de productos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private DevComponents.DotNetBar.Controls.AnalogClockControl analogClockControl1;
        private MetroFramework.Controls.MetroTextBox txtCantidad;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPrecio;
        private MetroFramework.Controls.MetroListView lvDetalle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroButton btnMostrar;
        private MetroSuite.MetroComboBox cboProductos;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel lblPago;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox textBox1;
        private MetroSuite.MetroButton btnEliminar;
        private MetroSuite.MetroButton btnLImpiar;
    }
}

