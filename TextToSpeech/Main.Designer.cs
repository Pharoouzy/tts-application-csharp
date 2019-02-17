namespace TextToSpeech
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.plainText_tb = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.voice_cmb = new System.Windows.Forms.ComboBox();
            this.pause_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.resume_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.stop_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.read_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.speed_tb = new System.Windows.Forms.TrackBar();
            this.vol_tb = new System.Windows.Forms.TrackBar();
            this.speedVal = new System.Windows.Forms.Label();
            this.volVal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pdf_pause_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pdf_resume_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pdf_stop_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pdf_read_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label8 = new System.Windows.Forms.Label();
            this.open_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vol_tb)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Metro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-5, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 550);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PLAIN TEXT READER";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PDF/DOC READER";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.plainText_tb);
            this.groupBox1.Font = new System.Drawing.Font("MetropolitainesD", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 524);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // plainText_tb
            // 
            this.plainText_tb.AcceptsTab = true;
            this.plainText_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plainText_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plainText_tb.EnableAutoDragDrop = true;
            this.plainText_tb.Location = new System.Drawing.Point(6, 14);
            this.plainText_tb.Name = "plainText_tb";
            this.plainText_tb.Size = new System.Drawing.Size(759, 400);
            this.plainText_tb.TabIndex = 22;
            this.plainText_tb.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.volVal);
            this.panel1.Controls.Add(this.speedVal);
            this.panel1.Controls.Add(this.vol_tb);
            this.panel1.Controls.Add(this.speed_tb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.voice_cmb);
            this.panel1.Controls.Add(this.pause_btn);
            this.panel1.Controls.Add(this.resume_btn);
            this.panel1.Controls.Add(this.stop_btn);
            this.panel1.Controls.Add(this.read_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 97);
            this.panel1.TabIndex = 23;
            // 
            // voice_cmb
            // 
            this.voice_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voice_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voice_cmb.FormattingEnabled = true;
            this.voice_cmb.Items.AddRange(new object[] {
            "Female"});
            this.voice_cmb.Location = new System.Drawing.Point(614, 3);
            this.voice_cmb.Name = "voice_cmb";
            this.voice_cmb.Size = new System.Drawing.Size(139, 33);
            this.voice_cmb.TabIndex = 26;
            this.voice_cmb.Text = "Male";
            this.voice_cmb.SelectedIndexChanged += new System.EventHandler(this.voice_cmb_SelectedIndexChanged);
            // 
            // pause_btn
            // 
            this.pause_btn.BackColor = System.Drawing.Color.Transparent;
            this.pause_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause_btn.Depth = 0;
            this.pause_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pause_btn.Location = new System.Drawing.Point(121, 2);
            this.pause_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Primary = true;
            this.pause_btn.Size = new System.Drawing.Size(111, 36);
            this.pause_btn.TabIndex = 25;
            this.pause_btn.Text = "Pause";
            this.pause_btn.UseVisualStyleBackColor = false;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // resume_btn
            // 
            this.resume_btn.BackColor = System.Drawing.Color.Transparent;
            this.resume_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resume_btn.Depth = 0;
            this.resume_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resume_btn.Location = new System.Drawing.Point(238, 3);
            this.resume_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.resume_btn.Name = "resume_btn";
            this.resume_btn.Primary = true;
            this.resume_btn.Size = new System.Drawing.Size(111, 36);
            this.resume_btn.TabIndex = 24;
            this.resume_btn.Text = "Resume";
            this.resume_btn.UseVisualStyleBackColor = false;
            this.resume_btn.Click += new System.EventHandler(this.resume_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.Transparent;
            this.stop_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop_btn.Depth = 0;
            this.stop_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stop_btn.Location = new System.Drawing.Point(355, 3);
            this.stop_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Primary = true;
            this.stop_btn.Size = new System.Drawing.Size(111, 36);
            this.stop_btn.TabIndex = 23;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // read_btn
            // 
            this.read_btn.BackColor = System.Drawing.Color.Transparent;
            this.read_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.read_btn.Depth = 0;
            this.read_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.read_btn.Location = new System.Drawing.Point(4, 3);
            this.read_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.read_btn.Name = "read_btn";
            this.read_btn.Primary = true;
            this.read_btn.Size = new System.Drawing.Size(111, 36);
            this.read_btn.TabIndex = 22;
            this.read_btn.Text = "Read";
            this.read_btn.UseVisualStyleBackColor = false;
            this.read_btn.Click += new System.EventHandler(this.read_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Select Voice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Volume";
            // 
            // speed_tb
            // 
            this.speed_tb.Location = new System.Drawing.Point(169, 51);
            this.speed_tb.Minimum = -10;
            this.speed_tb.Name = "speed_tb";
            this.speed_tb.Size = new System.Drawing.Size(104, 45);
            this.speed_tb.TabIndex = 30;
            this.speed_tb.Value = 2;
            this.speed_tb.Scroll += new System.EventHandler(this.speed_tb_Scroll);
            // 
            // vol_tb
            // 
            this.vol_tb.Location = new System.Drawing.Point(571, 51);
            this.vol_tb.Maximum = 100;
            this.vol_tb.Name = "vol_tb";
            this.vol_tb.Size = new System.Drawing.Size(104, 45);
            this.vol_tb.TabIndex = 31;
            this.vol_tb.Value = 50;
            this.vol_tb.Scroll += new System.EventHandler(this.vol_tb_Scroll);
            // 
            // speedVal
            // 
            this.speedVal.AutoSize = true;
            this.speedVal.Font = new System.Drawing.Font("Minion Pro", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedVal.ForeColor = System.Drawing.Color.Maroon;
            this.speedVal.Location = new System.Drawing.Point(279, 51);
            this.speedVal.Name = "speedVal";
            this.speedVal.Size = new System.Drawing.Size(20, 17);
            this.speedVal.TabIndex = 32;
            this.speedVal.Text = "10";
            // 
            // volVal
            // 
            this.volVal.AutoSize = true;
            this.volVal.Font = new System.Drawing.Font("Minion Pro", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volVal.ForeColor = System.Drawing.Color.Maroon;
            this.volVal.Location = new System.Drawing.Point(681, 53);
            this.volVal.Name = "volVal";
            this.volVal.Size = new System.Drawing.Size(32, 17);
            this.volVal.TabIndex = 33;
            this.volVal.Text = "50 %";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.axAcroPDF1);
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 516);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(6, 12);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(753, 401);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.open_btn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.trackBar2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.pdf_pause_btn);
            this.panel2.Controls.Add(this.pdf_resume_btn);
            this.panel2.Controls.Add(this.pdf_stop_btn);
            this.panel2.Controls.Add(this.pdf_read_btn);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(6, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 99);
            this.panel2.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minion Pro", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(681, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "50 %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minion Pro", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(279, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "10";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(571, 51);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 31;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(169, 51);
            this.trackBar2.Minimum = -10;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 30;
            this.trackBar2.Value = 2;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Minion Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(510, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Volume";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Minion Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(119, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Speed";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(614, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 33);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.Text = "Male";
            // 
            // pdf_pause_btn
            // 
            this.pdf_pause_btn.BackColor = System.Drawing.Color.Transparent;
            this.pdf_pause_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pdf_pause_btn.Depth = 0;
            this.pdf_pause_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pdf_pause_btn.Location = new System.Drawing.Point(121, 2);
            this.pdf_pause_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.pdf_pause_btn.Name = "pdf_pause_btn";
            this.pdf_pause_btn.Primary = true;
            this.pdf_pause_btn.Size = new System.Drawing.Size(111, 36);
            this.pdf_pause_btn.TabIndex = 25;
            this.pdf_pause_btn.Text = "Pause";
            this.pdf_pause_btn.UseVisualStyleBackColor = false;
            this.pdf_pause_btn.Click += new System.EventHandler(this.pdf_pause_btn_Click);
            // 
            // pdf_resume_btn
            // 
            this.pdf_resume_btn.BackColor = System.Drawing.Color.Transparent;
            this.pdf_resume_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pdf_resume_btn.Depth = 0;
            this.pdf_resume_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pdf_resume_btn.Location = new System.Drawing.Point(238, 3);
            this.pdf_resume_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.pdf_resume_btn.Name = "pdf_resume_btn";
            this.pdf_resume_btn.Primary = true;
            this.pdf_resume_btn.Size = new System.Drawing.Size(111, 36);
            this.pdf_resume_btn.TabIndex = 24;
            this.pdf_resume_btn.Text = "Resume";
            this.pdf_resume_btn.UseVisualStyleBackColor = false;
            this.pdf_resume_btn.Click += new System.EventHandler(this.pdf_resume_btn_Click);
            // 
            // pdf_stop_btn
            // 
            this.pdf_stop_btn.BackColor = System.Drawing.Color.Transparent;
            this.pdf_stop_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pdf_stop_btn.Depth = 0;
            this.pdf_stop_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pdf_stop_btn.Location = new System.Drawing.Point(355, 3);
            this.pdf_stop_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.pdf_stop_btn.Name = "pdf_stop_btn";
            this.pdf_stop_btn.Primary = true;
            this.pdf_stop_btn.Size = new System.Drawing.Size(111, 36);
            this.pdf_stop_btn.TabIndex = 23;
            this.pdf_stop_btn.Text = "Stop";
            this.pdf_stop_btn.UseVisualStyleBackColor = false;
            this.pdf_stop_btn.Click += new System.EventHandler(this.pdf_stop_btn_Click);
            // 
            // pdf_read_btn
            // 
            this.pdf_read_btn.BackColor = System.Drawing.Color.Transparent;
            this.pdf_read_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pdf_read_btn.Depth = 0;
            this.pdf_read_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pdf_read_btn.Location = new System.Drawing.Point(4, 3);
            this.pdf_read_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.pdf_read_btn.Name = "pdf_read_btn";
            this.pdf_read_btn.Primary = true;
            this.pdf_read_btn.Size = new System.Drawing.Size(111, 36);
            this.pdf_read_btn.TabIndex = 22;
            this.pdf_read_btn.Text = "Read";
            this.pdf_read_btn.UseVisualStyleBackColor = false;
            this.pdf_read_btn.Click += new System.EventHandler(this.pdf_read_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(509, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 26);
            this.label8.TabIndex = 27;
            this.label8.Text = "Select Voice";
            // 
            // open_btn
            // 
            this.open_btn.BackColor = System.Drawing.Color.Transparent;
            this.open_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open_btn.Depth = 0;
            this.open_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.open_btn.Location = new System.Drawing.Point(4, 45);
            this.open_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.open_btn.Name = "open_btn";
            this.open_btn.Primary = true;
            this.open_btn.Size = new System.Drawing.Size(111, 36);
            this.open_btn.TabIndex = 34;
            this.open_btn.Text = "Open";
            this.open_btn.UseVisualStyleBackColor = false;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 545);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text To Speech Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vol_tb)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox plainText_tb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox voice_cmb;
        private MaterialSkin.Controls.MaterialRaisedButton pause_btn;
        private MaterialSkin.Controls.MaterialRaisedButton resume_btn;
        private MaterialSkin.Controls.MaterialRaisedButton stop_btn;
        private MaterialSkin.Controls.MaterialRaisedButton read_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar vol_tb;
        private System.Windows.Forms.TrackBar speed_tb;
        private System.Windows.Forms.Label volVal;
        private System.Windows.Forms.Label speedVal;
        private System.Windows.Forms.GroupBox groupBox2;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton open_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialRaisedButton pdf_pause_btn;
        private MaterialSkin.Controls.MaterialRaisedButton pdf_resume_btn;
        private MaterialSkin.Controls.MaterialRaisedButton pdf_stop_btn;
        private MaterialSkin.Controls.MaterialRaisedButton pdf_read_btn;
        private System.Windows.Forms.Label label8;
    }
}

