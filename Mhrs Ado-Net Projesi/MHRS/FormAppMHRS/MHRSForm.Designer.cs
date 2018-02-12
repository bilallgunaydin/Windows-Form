namespace FormAppMHRS
{
    partial class MHRSForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbCounty = new System.Windows.Forms.ComboBox();
            this.cmbClinic = new System.Windows.Forms.ComboBox();
            this.cmbHospital = new System.Windows.Forms.ComboBox();
            this.cmbExamination = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpReserveDate = new System.Windows.Forms.DateTimePicker();
            this.lviewDoctor = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlRecerseTime = new System.Windows.Forms.Panel();
            this.lblPorrly = new System.Windows.Forms.Label();
            this.lblSystemDate = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTANE RANDEVU ARAMA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.Color.White;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(32, 95);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(187, 21);
            this.cmbCity.TabIndex = 1;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedValueChanged);
            // 
            // cmbCounty
            // 
            this.cmbCounty.BackColor = System.Drawing.Color.White;
            this.cmbCounty.FormattingEnabled = true;
            this.cmbCounty.Location = new System.Drawing.Point(32, 122);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Size = new System.Drawing.Size(187, 21);
            this.cmbCounty.TabIndex = 1;
            this.cmbCounty.SelectedIndexChanged += new System.EventHandler(this.cmbCounty_SelectedIndexChanged);
            // 
            // cmbClinic
            // 
            this.cmbClinic.BackColor = System.Drawing.Color.White;
            this.cmbClinic.FormattingEnabled = true;
            this.cmbClinic.Location = new System.Drawing.Point(32, 149);
            this.cmbClinic.Name = "cmbClinic";
            this.cmbClinic.Size = new System.Drawing.Size(187, 21);
            this.cmbClinic.TabIndex = 1;
            // 
            // cmbHospital
            // 
            this.cmbHospital.BackColor = System.Drawing.Color.White;
            this.cmbHospital.FormattingEnabled = true;
            this.cmbHospital.Location = new System.Drawing.Point(32, 176);
            this.cmbHospital.Name = "cmbHospital";
            this.cmbHospital.Size = new System.Drawing.Size(187, 21);
            this.cmbHospital.TabIndex = 1;
            this.cmbHospital.SelectedIndexChanged += new System.EventHandler(this.cmbHospital_SelectedIndexChanged);
            // 
            // cmbExamination
            // 
            this.cmbExamination.BackColor = System.Drawing.Color.White;
            this.cmbExamination.FormattingEnabled = true;
            this.cmbExamination.Location = new System.Drawing.Point(32, 234);
            this.cmbExamination.Name = "cmbExamination";
            this.cmbExamination.Size = new System.Drawing.Size(187, 21);
            this.cmbExamination.TabIndex = 2;
            this.cmbExamination.SelectedIndexChanged += new System.EventHandler(this.cmbExamination_SelectedIndexChanged);
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.BackColor = System.Drawing.Color.White;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(32, 261);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(187, 21);
            this.cmbDoctor.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(32, 306);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 31);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(130, 306);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 31);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Randevu Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpReserveDate
            // 
            this.dtpReserveDate.Location = new System.Drawing.Point(32, 61);
            this.dtpReserveDate.Name = "dtpReserveDate";
            this.dtpReserveDate.Size = new System.Drawing.Size(187, 20);
            this.dtpReserveDate.TabIndex = 7;
            this.dtpReserveDate.ValueChanged += new System.EventHandler(this.dtpReserveDate_ValueChanged);
            // 
            // lviewDoctor
            // 
            this.lviewDoctor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lviewDoctor.Location = new System.Drawing.Point(32, 367);
            this.lviewDoctor.Name = "lviewDoctor";
            this.lviewDoctor.Size = new System.Drawing.Size(911, 157);
            this.lviewDoctor.TabIndex = 8;
            this.lviewDoctor.UseCompatibleStateImageBehavior = false;
            this.lviewDoctor.View = System.Windows.Forms.View.Details;
            this.lviewDoctor.SelectedIndexChanged += new System.EventHandler(this.lviewDoctor_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hekim";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "En Erken Tarih";
            this.columnHeader2.Width = 147;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kurum Adı";
            this.columnHeader3.Width = 129;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Klinik Adı";
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Muayene Yeri";
            this.columnHeader5.Width = 97;
            // 
            // pnlRecerseTime
            // 
            this.pnlRecerseTime.Location = new System.Drawing.Point(240, 61);
            this.pnlRecerseTime.Name = "pnlRecerseTime";
            this.pnlRecerseTime.Size = new System.Drawing.Size(703, 285);
            this.pnlRecerseTime.TabIndex = 9;
            // 
            // lblPorrly
            // 
            this.lblPorrly.AutoSize = true;
            this.lblPorrly.Location = new System.Drawing.Point(11, 13);
            this.lblPorrly.Name = "lblPorrly";
            this.lblPorrly.Size = new System.Drawing.Size(0, 13);
            this.lblPorrly.TabIndex = 10;
            // 
            // lblSystemDate
            // 
            this.lblSystemDate.AutoSize = true;
            this.lblSystemDate.Location = new System.Drawing.Point(430, 8);
            this.lblSystemDate.Name = "lblSystemDate";
            this.lblSystemDate.Size = new System.Drawing.Size(0, 13);
            this.lblSystemDate.TabIndex = 10;
            this.lblSystemDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(545, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MHRSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 548);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSystemDate);
            this.Controls.Add(this.lblPorrly);
            this.Controls.Add(this.pnlRecerseTime);
            this.Controls.Add(this.lviewDoctor);
            this.Controls.Add(this.dtpReserveDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.cmbExamination);
            this.Controls.Add(this.cmbHospital);
            this.Controls.Add(this.cmbClinic);
            this.Controls.Add(this.cmbCounty);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.label1);
            this.Name = "MHRSForm";
            this.Text = "MHRSForm";
            this.Load += new System.EventHandler(this.MHRSForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbCounty;
        private System.Windows.Forms.ComboBox cmbClinic;
        private System.Windows.Forms.ComboBox cmbHospital;
        private System.Windows.Forms.ComboBox cmbExamination;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpReserveDate;
        private System.Windows.Forms.ListView lviewDoctor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel pnlRecerseTime;
        private System.Windows.Forms.Label lblPorrly;
        private System.Windows.Forms.Label lblSystemDate;
        private System.Windows.Forms.Button btnExit;
    }
}