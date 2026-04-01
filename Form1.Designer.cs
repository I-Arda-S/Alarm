namespace Alarm2v
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
            if(disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrSayac = new System.Windows.Forms.Timer(this.components);
            this.btn = new System.Windows.Forms.Button();
            this.tabCntrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.lblHiz = new System.Windows.Forms.Label();
            this.trckBar = new System.Windows.Forms.TrackBar();
            this.dmnSaniye = new System.Windows.Forms.NumericUpDown();
            this.dmnDakika = new System.Windows.Forms.NumericUpDown();
            this.dmnSaat = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.tmrAlarm = new System.Windows.Forms.Timer(this.components);
            this.tabCntrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmnSaniye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmnDakika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmnSaat)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrSayac
            // 
            this.tmrSayac.Interval = 1000;
            this.tmrSayac.Tick += new System.EventHandler(this.tmrSayac_Tick);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn.Location = new System.Drawing.Point(6, 292);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(358, 75);
            this.btn.TabIndex = 12;
            this.btn.Text = "Zamanlayıcıyı Başlat";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // tabCntrl
            // 
            this.tabCntrl.Controls.Add(this.tabPage1);
            this.tabCntrl.Controls.Add(this.tabPage2);
            this.tabCntrl.Location = new System.Drawing.Point(12, 12);
            this.tabCntrl.Name = "tabCntrl";
            this.tabCntrl.SelectedIndex = 0;
            this.tabCntrl.Size = new System.Drawing.Size(378, 399);
            this.tabCntrl.TabIndex = 8;
            this.tabCntrl.SelectedIndexChanged += new System.EventHandler(this.tabCntrl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblBilgi);
            this.tabPage1.Controls.Add(this.btn);
            this.tabPage1.Controls.Add(this.lblHiz);
            this.tabPage1.Controls.Add(this.trckBar);
            this.tabPage1.Controls.Add(this.dmnSaniye);
            this.tabPage1.Controls.Add(this.dmnDakika);
            this.tabPage1.Controls.Add(this.dmnSaat);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(370, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zamanlayıcı";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.Location = new System.Drawing.Point(81, 215);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(209, 25);
            this.lblBilgi.TabIndex = 13;
            this.lblBilgi.Text = "Saat     Dakika  Saniye";
            // 
            // lblHiz
            // 
            this.lblHiz.AutoSize = true;
            this.lblHiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHiz.Location = new System.Drawing.Point(148, 65);
            this.lblHiz.Name = "lblHiz";
            this.lblHiz.Size = new System.Drawing.Size(89, 25);
            this.lblHiz.TabIndex = 12;
            this.lblHiz.Text = "Hız: 0.25";
            // 
            // trckBar
            // 
            this.trckBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trckBar.LargeChange = 0;
            this.trckBar.Location = new System.Drawing.Point(86, 93);
            this.trckBar.Maximum = 5;
            this.trckBar.Minimum = 1;
            this.trckBar.Name = "trckBar";
            this.trckBar.Size = new System.Drawing.Size(195, 56);
            this.trckBar.TabIndex = 11;
            this.trckBar.Value = 1;
            this.trckBar.Scroll += new System.EventHandler(this.trckBar_Scroll);
            // 
            // dmnSaniye
            // 
            this.dmnSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dmnSaniye.Location = new System.Drawing.Point(220, 167);
            this.dmnSaniye.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.dmnSaniye.Name = "dmnSaniye";
            this.dmnSaniye.Size = new System.Drawing.Size(61, 45);
            this.dmnSaniye.TabIndex = 10;
            // 
            // dmnDakika
            // 
            this.dmnDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dmnDakika.Location = new System.Drawing.Point(153, 167);
            this.dmnDakika.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.dmnDakika.Name = "dmnDakika";
            this.dmnDakika.Size = new System.Drawing.Size(61, 45);
            this.dmnDakika.TabIndex = 9;
            // 
            // dmnSaat
            // 
            this.dmnSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dmnSaat.Location = new System.Drawing.Point(86, 167);
            this.dmnSaat.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.dmnSaat.Name = "dmnSaat";
            this.dmnSaat.Size = new System.Drawing.Size(61, 45);
            this.dmnSaat.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.btnAlarm);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(370, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alarm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(110, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(140, 30);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "00:00:00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 38);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2026, 3, 31, 13, 49, 21, 0);
            // 
            // btnAlarm
            // 
            this.btnAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlarm.Location = new System.Drawing.Point(6, 289);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(358, 75);
            this.btnAlarm.TabIndex = 11;
            this.btnAlarm.Text = "Alarmı Başlat";
            this.btnAlarm.UseVisualStyleBackColor = true;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // tmrAlarm
            // 
            this.tmrAlarm.Interval = 1000;
            this.tmrAlarm.Tick += new System.EventHandler(this.tmrAlarm_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 423);
            this.Controls.Add(this.tabCntrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(420, 470);
            this.MinimumSize = new System.Drawing.Size(420, 470);
            this.Name = "Form1";
            this.Text = "Zamanlayıcı";
            this.tabCntrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmnSaniye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmnDakika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmnSaat)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrSayac;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TabControl tabCntrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Label lblHiz;
        private System.Windows.Forms.TrackBar trckBar;
        private System.Windows.Forms.NumericUpDown dmnSaniye;
        private System.Windows.Forms.NumericUpDown dmnDakika;
        private System.Windows.Forms.NumericUpDown dmnSaat;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Timer tmrAlarm;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

