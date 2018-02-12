namespace _160906_HafızaOyunu
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblPuan = new System.Windows.Forms.Label();
            this.rbtnKolay = new System.Windows.Forms.RadioButton();
            this.rbtnOrta = new System.Windows.Forms.RadioButton();
            this.rbtnZor = new System.Windows.Forms.RadioButton();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lblSure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(480, 39);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(41, 13);
            this.lblPuan.TabIndex = 0;
            this.lblPuan.Text = "Puan : ";
            // 
            // rbtnKolay
            // 
            this.rbtnKolay.AutoSize = true;
            this.rbtnKolay.Location = new System.Drawing.Point(483, 72);
            this.rbtnKolay.Name = "rbtnKolay";
            this.rbtnKolay.Size = new System.Drawing.Size(51, 17);
            this.rbtnKolay.TabIndex = 1;
            this.rbtnKolay.Text = "Kolay";
            this.rbtnKolay.UseVisualStyleBackColor = true;
            this.rbtnKolay.CheckedChanged += new System.EventHandler(this.rbtnKolay_CheckedChanged);
            // 
            // rbtnOrta
            // 
            this.rbtnOrta.AutoSize = true;
            this.rbtnOrta.Location = new System.Drawing.Point(483, 95);
            this.rbtnOrta.Name = "rbtnOrta";
            this.rbtnOrta.Size = new System.Drawing.Size(45, 17);
            this.rbtnOrta.TabIndex = 2;
            this.rbtnOrta.Text = "Orta";
            this.rbtnOrta.UseVisualStyleBackColor = true;
            this.rbtnOrta.CheckedChanged += new System.EventHandler(this.rbtnOrta_CheckedChanged);
            // 
            // rbtnZor
            // 
            this.rbtnZor.AutoSize = true;
            this.rbtnZor.Location = new System.Drawing.Point(483, 118);
            this.rbtnZor.Name = "rbtnZor";
            this.rbtnZor.Size = new System.Drawing.Size(41, 17);
            this.rbtnZor.TabIndex = 3;
            this.rbtnZor.Text = "Zor";
            this.rbtnZor.UseVisualStyleBackColor = true;
            this.rbtnZor.CheckedChanged += new System.EventHandler(this.rbtnZor_CheckedChanged);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(480, 14);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(38, 13);
            this.lblSure.TabIndex = 0;
            this.lblSure.Text = "Süre : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(549, 480);
            this.Controls.Add(this.rbtnZor);
            this.Controls.Add(this.rbtnOrta);
            this.Controls.Add(this.rbtnKolay);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblPuan);
            this.MaximumSize = new System.Drawing.Size(565, 518);
            this.MinimumSize = new System.Drawing.Size(565, 518);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.RadioButton rbtnKolay;
        private System.Windows.Forms.RadioButton rbtnOrta;
        private System.Windows.Forms.RadioButton rbtnZor;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lblSure;

    }
}

