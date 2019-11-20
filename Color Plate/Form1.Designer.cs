namespace Color_Plate
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFont = new System.Windows.Forms.Button();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnMagenta = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnABBC = new System.Windows.Forms.Button();
            this.btnLavender = new System.Windows.Forms.Button();
            this.btnIvory = new System.Windows.Forms.Button();
            this.btnBrown = new System.Windows.Forms.Button();
            this.btnAlmond = new System.Windows.Forms.Button();
            this.btnDeepPink = new System.Windows.Forms.Button();
            this.btnCyan = new System.Windows.Forms.Button();
            this.btnIndigo = new System.Windows.Forms.Button();
            this.btnGold = new System.Windows.Forms.Button();
            this.btnViolet = new System.Windows.Forms.Button();
            this.btnCoral = new System.Windows.Forms.Button();
            this.btnFireBrick = new System.Windows.Forms.Button();
            this.btnBeige = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnResetColor = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(528, 414);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Wheat;
            this.tabPage2.Controls.Add(this.btnFont);
            this.tabPage2.Controls.Add(this.statusStrip2);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(520, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Studia";
            // 
            // btnFont
            // 
            this.btnFont.BackColor = System.Drawing.Color.Silver;
            this.btnFont.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Color_Plate.Properties.Settings.Default, "RealFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnFont.Font = global::Color_Plate.Properties.Settings.Default.RealFont;
            this.btnFont.Location = new System.Drawing.Point(390, 8);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(109, 60);
            this.btnFont.TabIndex = 8;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = false;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel2});
            this.statusStrip2.Location = new System.Drawing.Point(0, 366);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(520, 22);
            this.statusStrip2.TabIndex = 7;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // StatusLabel2
            // 
            this.StatusLabel2.Name = "StatusLabel2";
            this.StatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(263, 289);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 47);
            this.button5.TabIndex = 6;
            this.button5.Text = "NEXT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = global::Color_Plate.Properties.Settings.Default.BackGrd2;
            this.button4.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Color_Plate.Properties.Settings.Default, "ColFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button4.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "BackGrd2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button4.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Color_Plate.Properties.Settings.Default, "RealFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button4.Font = global::Color_Plate.Properties.Settings.Default.RealFont;
            this.button4.ForeColor = global::Color_Plate.Properties.Settings.Default.ColFont;
            this.button4.Location = new System.Drawing.Point(390, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 47);
            this.button4.TabIndex = 5;
            this.button4.Text = "EXIT";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = global::Color_Plate.Properties.Settings.Default.BackGrd2;
            this.button3.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "BackGrd2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Color_Plate.Properties.Settings.Default, "ColFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button3.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Color_Plate.Properties.Settings.Default, "RealFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button3.Font = global::Color_Plate.Properties.Settings.Default.RealFont;
            this.button3.ForeColor = global::Color_Plate.Properties.Settings.Default.ColFont;
            this.button3.Location = new System.Drawing.Point(43, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "ValueCard...";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = global::Color_Plate.Properties.Settings.Default.BackGrd2;
            this.button2.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "BackGrd2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(390, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "BackGround Color";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Color_Plate.Properties.Settings.Default, "ColFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = global::Color_Plate.Properties.Settings.Default.ColFont;
            this.button1.Location = new System.Drawing.Point(390, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 69);
            this.button1.TabIndex = 2;
            this.button1.Text = "Font Color";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = global::Color_Plate.Properties.Settings.Default.BackGrd2;
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "BackGrd2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Color_Plate.Properties.Settings.Default, "ColFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Color_Plate.Properties.Settings.Default, "RealFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listBox1.Font = global::Color_Plate.Properties.Settings.Default.RealFont;
            this.listBox1.ForeColor = global::Color_Plate.Properties.Settings.Default.ColFont;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "Pican Roxy",
            "Ray Patterson",
            "AaronHall Smith",
            "Peridot Oliver"});
            this.listBox1.Location = new System.Drawing.Point(43, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 156);
            this.listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = global::Color_Plate.Properties.Settings.Default.BackGrd2;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "BackGrd2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Color_Plate.Properties.Settings.Default, "ColFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Color_Plate.Properties.Settings.Default, "RealFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Font = global::Color_Plate.Properties.Settings.Default.RealFont;
            this.textBox1.ForeColor = global::Color_Plate.Properties.Settings.Default.ColFont;
            this.textBox1.Location = new System.Drawing.Point(43, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 26);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = global::Color_Plate.Properties.Settings.Default.NewColor;
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.btnMagenta);
            this.tabPage1.Controls.Add(this.btnYellow);
            this.tabPage1.Controls.Add(this.btnOrange);
            this.tabPage1.Controls.Add(this.btnABBC);
            this.tabPage1.Controls.Add(this.btnLavender);
            this.tabPage1.Controls.Add(this.btnIvory);
            this.tabPage1.Controls.Add(this.btnBrown);
            this.tabPage1.Controls.Add(this.btnAlmond);
            this.tabPage1.Controls.Add(this.btnDeepPink);
            this.tabPage1.Controls.Add(this.btnCyan);
            this.tabPage1.Controls.Add(this.btnIndigo);
            this.tabPage1.Controls.Add(this.btnGold);
            this.tabPage1.Controls.Add(this.btnViolet);
            this.tabPage1.Controls.Add(this.btnCoral);
            this.tabPage1.Controls.Add(this.btnFireBrick);
            this.tabPage1.Controls.Add(this.btnBeige);
            this.tabPage1.Controls.Add(this.btnGreen);
            this.tabPage1.Controls.Add(this.btnRed);
            this.tabPage1.Controls.Add(this.btnExit);
            this.tabPage1.Controls.Add(this.btnResetColor);
            this.tabPage1.Controls.Add(this.btnColor);
            this.tabPage1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "NewColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabPage1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(520, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Color Plate";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 363);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(514, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(20, 322);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 34);
            this.button6.TabIndex = 24;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnMagenta
            // 
            this.btnMagenta.BackColor = global::Color_Plate.Properties.Settings.Default.Magenta;
            this.btnMagenta.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "Magenta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnMagenta.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMagenta.Location = new System.Drawing.Point(107, 182);
            this.btnMagenta.Name = "btnMagenta";
            this.btnMagenta.Size = new System.Drawing.Size(60, 49);
            this.btnMagenta.TabIndex = 23;
            this.btnMagenta.Text = "Ma Genta";
            this.btnMagenta.UseVisualStyleBackColor = false;
            this.btnMagenta.Click += new System.EventHandler(this.btnMagenta_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = global::Color_Plate.Properties.Settings.Default.Yellow;
            this.btnYellow.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "Yellow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnYellow.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYellow.Location = new System.Drawing.Point(440, 182);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(60, 49);
            this.btnYellow.TabIndex = 22;
            this.btnYellow.Text = "Yellow";
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = global::Color_Plate.Properties.Settings.Default.Orange;
            this.btnOrange.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "Orange", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnOrange.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrange.Location = new System.Drawing.Point(193, 181);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(60, 49);
            this.btnOrange.TabIndex = 21;
            this.btnOrange.Text = "Orange";
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            // 
            // btnABBC
            // 
            this.btnABBC.BackColor = global::Color_Plate.Properties.Settings.Default.ABBC;
            this.btnABBC.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "ABBC", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnABBC.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABBC.Location = new System.Drawing.Point(20, 21);
            this.btnABBC.Name = "btnABBC";
            this.btnABBC.Size = new System.Drawing.Size(60, 49);
            this.btnABBC.TabIndex = 20;
            this.btnABBC.Text = "ABBC";
            this.btnABBC.UseVisualStyleBackColor = false;
            this.btnABBC.Click += new System.EventHandler(this.btnABBC_Click);
            // 
            // btnLavender
            // 
            this.btnLavender.BackColor = global::Color_Plate.Properties.Settings.Default.Lavender;
            this.btnLavender.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "Lavender", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnLavender.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLavender.Location = new System.Drawing.Point(20, 181);
            this.btnLavender.Name = "btnLavender";
            this.btnLavender.Size = new System.Drawing.Size(60, 49);
            this.btnLavender.TabIndex = 19;
            this.btnLavender.Text = "Laven";
            this.btnLavender.UseVisualStyleBackColor = false;
            this.btnLavender.Click += new System.EventHandler(this.btnLavender_Click);
            // 
            // btnIvory
            // 
            this.btnIvory.BackColor = global::Color_Plate.Properties.Settings.Default.Ivory;
            this.btnIvory.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "Ivory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnIvory.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIvory.Location = new System.Drawing.Point(435, 100);
            this.btnIvory.Name = "btnIvory";
            this.btnIvory.Size = new System.Drawing.Size(60, 49);
            this.btnIvory.TabIndex = 18;
            this.btnIvory.Text = "Ivory";
            this.btnIvory.UseVisualStyleBackColor = false;
            this.btnIvory.Click += new System.EventHandler(this.btnIvory_Click);
            // 
            // btnBrown
            // 
            this.btnBrown.BackColor = global::Color_Plate.Properties.Settings.Default.Brown;
            this.btnBrown.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "Brown", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnBrown.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrown.Location = new System.Drawing.Point(274, 21);
            this.btnBrown.Name = "btnBrown";
            this.btnBrown.Size = new System.Drawing.Size(60, 49);
            this.btnBrown.TabIndex = 17;
            this.btnBrown.Text = "Brown";
            this.btnBrown.UseVisualStyleBackColor = false;
            this.btnBrown.Click += new System.EventHandler(this.btnBrown_Click);
            // 
            // btnAlmond
            // 
            this.btnAlmond.BackColor = global::Color_Plate.Properties.Settings.Default.Almond;
            this.btnAlmond.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "Almond", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAlmond.Font = new System.Drawing.Font("Bookman Old Style", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmond.Location = new System.Drawing.Point(107, 22);
            this.btnAlmond.Name = "btnAlmond";
            this.btnAlmond.Size = new System.Drawing.Size(60, 49);
            this.btnAlmond.TabIndex = 16;
            this.btnAlmond.Text = "Almond";
            this.btnAlmond.UseVisualStyleBackColor = false;
            this.btnAlmond.Click += new System.EventHandler(this.btnAlmond_Click);
            // 
            // btnDeepPink
            // 
            this.btnDeepPink.BackColor = global::Color_Plate.Properties.Settings.Default.DeepPink;
            this.btnDeepPink.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "DeepPink", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnDeepPink.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeepPink.Location = new System.Drawing.Point(20, 100);
            this.btnDeepPink.Name = "btnDeepPink";
            this.btnDeepPink.Size = new System.Drawing.Size(60, 49);
            this.btnDeepPink.TabIndex = 15;
            this.btnDeepPink.Text = "Deep Pink";
            this.btnDeepPink.UseVisualStyleBackColor = false;
            this.btnDeepPink.Click += new System.EventHandler(this.btnDeepPink_Click);
            // 
            // btnCyan
            // 
            this.btnCyan.BackColor = global::Color_Plate.Properties.Settings.Default.Cyan;
            this.btnCyan.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "Cyan", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnCyan.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCyan.Location = new System.Drawing.Point(435, 19);
            this.btnCyan.Name = "btnCyan";
            this.btnCyan.Size = new System.Drawing.Size(60, 49);
            this.btnCyan.TabIndex = 14;
            this.btnCyan.Text = "Cyan";
            this.btnCyan.UseVisualStyleBackColor = false;
            this.btnCyan.Click += new System.EventHandler(this.btnCyan_Click);
            // 
            // btnIndigo
            // 
            this.btnIndigo.BackColor = global::Color_Plate.Properties.Settings.Default.Indigo;
            this.btnIndigo.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "Indigo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnIndigo.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndigo.Location = new System.Drawing.Point(355, 100);
            this.btnIndigo.Name = "btnIndigo";
            this.btnIndigo.Size = new System.Drawing.Size(60, 49);
            this.btnIndigo.TabIndex = 13;
            this.btnIndigo.Text = "Indigo";
            this.btnIndigo.UseVisualStyleBackColor = false;
            this.btnIndigo.Click += new System.EventHandler(this.btnIndigo_Click);
            // 
            // btnGold
            // 
            this.btnGold.BackColor = global::Color_Plate.Properties.Settings.Default.Gold;
            this.btnGold.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "Gold", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnGold.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGold.Location = new System.Drawing.Point(193, 100);
            this.btnGold.Name = "btnGold";
            this.btnGold.Size = new System.Drawing.Size(60, 49);
            this.btnGold.TabIndex = 12;
            this.btnGold.Text = "Gold";
            this.btnGold.UseVisualStyleBackColor = false;
            this.btnGold.Click += new System.EventHandler(this.btnGold_Click);
            // 
            // btnViolet
            // 
            this.btnViolet.BackColor = global::Color_Plate.Properties.Settings.Default.Violet;
            this.btnViolet.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "Violet", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnViolet.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViolet.Location = new System.Drawing.Point(355, 182);
            this.btnViolet.Name = "btnViolet";
            this.btnViolet.Size = new System.Drawing.Size(60, 49);
            this.btnViolet.TabIndex = 11;
            this.btnViolet.Text = "Violet";
            this.btnViolet.UseVisualStyleBackColor = false;
            this.btnViolet.Click += new System.EventHandler(this.btnViolet_Click);
            // 
            // btnCoral
            // 
            this.btnCoral.BackColor = global::Color_Plate.Properties.Settings.Default.Coral;
            this.btnCoral.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "Coral", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnCoral.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoral.Location = new System.Drawing.Point(355, 21);
            this.btnCoral.Name = "btnCoral";
            this.btnCoral.Size = new System.Drawing.Size(60, 49);
            this.btnCoral.TabIndex = 10;
            this.btnCoral.Text = "Coral";
            this.btnCoral.UseVisualStyleBackColor = false;
            this.btnCoral.Click += new System.EventHandler(this.btnCoral_Click);
            // 
            // btnFireBrick
            // 
            this.btnFireBrick.BackColor = global::Color_Plate.Properties.Settings.Default.FireBrick;
            this.btnFireBrick.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "FireBrick", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnFireBrick.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFireBrick.Location = new System.Drawing.Point(107, 99);
            this.btnFireBrick.Name = "btnFireBrick";
            this.btnFireBrick.Size = new System.Drawing.Size(60, 49);
            this.btnFireBrick.TabIndex = 8;
            this.btnFireBrick.Text = "Fire Brick";
            this.btnFireBrick.UseVisualStyleBackColor = false;
            this.btnFireBrick.Click += new System.EventHandler(this.btnFireBrick_Click);
            // 
            // btnBeige
            // 
            this.btnBeige.BackColor = global::Color_Plate.Properties.Settings.Default.Beige;
            this.btnBeige.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "Beige", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnBeige.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeige.Location = new System.Drawing.Point(193, 21);
            this.btnBeige.Name = "btnBeige";
            this.btnBeige.Size = new System.Drawing.Size(60, 49);
            this.btnBeige.TabIndex = 7;
            this.btnBeige.Text = "Beige";
            this.btnBeige.UseVisualStyleBackColor = false;
            this.btnBeige.Click += new System.EventHandler(this.btnBeige_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = global::Color_Plate.Properties.Settings.Default.Green;
            this.btnGreen.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "Green", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnGreen.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreen.Location = new System.Drawing.Point(274, 100);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(60, 49);
            this.btnGreen.TabIndex = 6;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = global::Color_Plate.Properties.Settings.Default.Red;
            this.btnRed.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "Red", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnRed.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRed.Location = new System.Drawing.Point(274, 182);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(60, 49);
            this.btnRed.TabIndex = 5;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(355, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 49);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnResetColor
            // 
            this.btnResetColor.BackColor = global::Color_Plate.Properties.Settings.Default.ResetColor;
            this.btnResetColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "ResetColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnResetColor.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetColor.Location = new System.Drawing.Point(20, 266);
            this.btnResetColor.Name = "btnResetColor";
            this.btnResetColor.Size = new System.Drawing.Size(147, 49);
            this.btnResetColor.TabIndex = 3;
            this.btnResetColor.Text = "Reset Color";
            this.btnResetColor.UseVisualStyleBackColor = false;
            this.btnResetColor.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = global::Color_Plate.Properties.Settings.Default.NewColor;
            this.btnColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Color_Plate.Properties.Settings.Default, "NewColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnColor.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(193, 266);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(141, 49);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "My Color";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(528, 414);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Color Studio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnABBC;
        private System.Windows.Forms.Button btnLavender;
        private System.Windows.Forms.Button btnIvory;
        private System.Windows.Forms.Button btnBrown;
        private System.Windows.Forms.Button btnAlmond;
        private System.Windows.Forms.Button btnDeepPink;
        private System.Windows.Forms.Button btnCyan;
        private System.Windows.Forms.Button btnIndigo;
        private System.Windows.Forms.Button btnGold;
        private System.Windows.Forms.Button btnViolet;
        private System.Windows.Forms.Button btnCoral;
        private System.Windows.Forms.Button btnFireBrick;
        private System.Windows.Forms.Button btnBeige;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnResetColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnMagenta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel2;
        private System.Windows.Forms.Button btnFont;
    }
}

