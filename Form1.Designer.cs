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
            this.dmnSaat = new System.Windows.Forms.NumericUpDown();
            this.dmnDakika = new System.Windows.Forms.NumericUpDown();
            this.dmnSaniye = new System.Windows.Forms.NumericUpDown();
            this.trckBar = new System.Windows.Forms.TrackBar();
            this.lblHiz = new System.Windows.Forms.Label();
            this.tmrAlarmSesDongu = new System.Windows.Forms.Timer(this.components);
            this.lblBilgi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dmnSaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmnDakika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmnSaniye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrSayac
            // 
            this.tmrSayac.Interval = 1000;
            this.tmrSayac.Tick += new System.EventHandler(this.tmrSayac_Tick);
            // 
            // btn
            // 
            this.btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn.Location = new System.Drawing.Point(0, 352);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(402, 71);
            this.btn.TabIndex = 0;
            this.btn.Text = "Alarmı Başlat";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // dmnSaat
            // 
            this.dmnSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dmnSaat.Location = new System.Drawing.Point(106, 168);
            this.dmnSaat.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.dmnSaat.Name = "dmnSaat";
            this.dmnSaat.Size = new System.Drawing.Size(61, 45);
            this.dmnSaat.TabIndex = 1;
            // 
            // dmnDakika
            // 
            this.dmnDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dmnDakika.Location = new System.Drawing.Point(173, 168);
            this.dmnDakika.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.dmnDakika.Name = "dmnDakika";
            this.dmnDakika.Size = new System.Drawing.Size(61, 45);
            this.dmnDakika.TabIndex = 2;
            // 
            // dmnSaniye
            // 
            this.dmnSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dmnSaniye.Location = new System.Drawing.Point(240, 168);
            this.dmnSaniye.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.dmnSaniye.Name = "dmnSaniye";
            this.dmnSaniye.Size = new System.Drawing.Size(61, 45);
            this.dmnSaniye.TabIndex = 3;
            // 
            // trckBar
            // 
            this.trckBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trckBar.LargeChange = 0;
            this.trckBar.Location = new System.Drawing.Point(106, 94);
            this.trckBar.Maximum = 5;
            this.trckBar.Minimum = 1;
            this.trckBar.Name = "trckBar";
            this.trckBar.Size = new System.Drawing.Size(195, 56);
            this.trckBar.TabIndex = 4;
            this.trckBar.Value = 1;
            this.trckBar.Scroll += new System.EventHandler(this.trckBar_Scroll);
            // 
            // lblHiz
            // 
            this.lblHiz.AutoSize = true;
            this.lblHiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHiz.Location = new System.Drawing.Point(168, 66);
            this.lblHiz.Name = "lblHiz";
            this.lblHiz.Size = new System.Drawing.Size(89, 25);
            this.lblHiz.TabIndex = 6;
            this.lblHiz.Text = "Hız: 0.25";
            // 
            // tmrAlarmSesDongu
            // 
            this.tmrAlarmSesDongu.Interval = 6200;
            this.tmrAlarmSesDongu.Tick += new System.EventHandler(this.tmrAlarmSesDongu_Tick);
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.Location = new System.Drawing.Point(101, 216);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(209, 25);
            this.lblBilgi.TabIndex = 7;
            this.lblBilgi.Text = "Saat     Dakika  Saniye";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 423);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.lblHiz);
            this.Controls.Add(this.trckBar);
            this.Controls.Add(this.dmnSaniye);
            this.Controls.Add(this.dmnDakika);
            this.Controls.Add(this.dmnSaat);
            this.Controls.Add(this.btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(420, 470);
            this.MinimumSize = new System.Drawing.Size(420, 470);
            this.Name = "Form1";
            this.Text = "Alarm";
            ((System.ComponentModel.ISupportInitialize)(this.dmnSaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmnDakika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmnSaniye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrSayac;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.NumericUpDown dmnSaat;
        private System.Windows.Forms.NumericUpDown dmnDakika;
        private System.Windows.Forms.NumericUpDown dmnSaniye;
        private System.Windows.Forms.TrackBar trckBar;
        private System.Windows.Forms.Label lblHiz;
        private System.Windows.Forms.Timer tmrAlarmSesDongu;
        private System.Windows.Forms.Label lblBilgi;
    }
}

