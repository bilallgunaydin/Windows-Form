namespace _160906_HafızaOyunu
{
    partial class FormGiris
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
            this.txtOyuncuAdı = new System.Windows.Forms.TextBox();
            this.lblOyuncuAdı = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvOyuncuSkor = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtOyuncuAdı
            // 
            this.txtOyuncuAdı.Location = new System.Drawing.Point(21, 38);
            this.txtOyuncuAdı.Name = "txtOyuncuAdı";
            this.txtOyuncuAdı.Size = new System.Drawing.Size(185, 20);
            this.txtOyuncuAdı.TabIndex = 0;
            // 
            // lblOyuncuAdı
            // 
            this.lblOyuncuAdı.AutoSize = true;
            this.lblOyuncuAdı.Location = new System.Drawing.Point(18, 22);
            this.lblOyuncuAdı.Name = "lblOyuncuAdı";
            this.lblOyuncuAdı.Size = new System.Drawing.Size(71, 13);
            this.lblOyuncuAdı.TabIndex = 1;
            this.lblOyuncuAdı.Text = "Oyuncu Adı : ";
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(21, 64);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(185, 23);
            this.btnBasla.TabIndex = 2;
            this.btnBasla.Text = "Haydi Başlayalım";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Oyuncu Puanları";
            // 
            // lvOyuncuSkor
            // 
            this.lvOyuncuSkor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvOyuncuSkor.Location = new System.Drawing.Point(21, 139);
            this.lvOyuncuSkor.Name = "lvOyuncuSkor";
            this.lvOyuncuSkor.Size = new System.Drawing.Size(161, 142);
            this.lvOyuncuSkor.TabIndex = 4;
            this.lvOyuncuSkor.UseCompatibleStateImageBehavior = false;
            this.lvOyuncuSkor.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Skor";
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(236, 318);
            this.Controls.Add(this.lvOyuncuSkor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lblOyuncuAdı);
            this.Controls.Add(this.txtOyuncuAdı);
            this.MaximumSize = new System.Drawing.Size(252, 356);
            this.MinimumSize = new System.Drawing.Size(252, 356);
            this.Name = "FormGiris";
            this.Text = "FormGiris";
            this.Load += new System.EventHandler(this.FormGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOyuncuAdı;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.TextBox txtOyuncuAdı;
        public System.Windows.Forms.ListView lvOyuncuSkor;
    }
}