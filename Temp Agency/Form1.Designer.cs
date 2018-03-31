namespace TempAgency {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.No_Hours_Worked_label = new System.Windows.Forms.Label();
            this.No_of_Departments_label = new System.Windows.Forms.Label();
            this.Gross_Pay_label = new System.Windows.Forms.Label();
            this.Federal_Ded_label = new System.Windows.Forms.Label();
            this.Soc_Sec_Ded_lebel = new System.Windows.Forms.Label();
            this.Agency_Fee_label = new System.Windows.Forms.Label();
            this.Net_Pay_label = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxHourWork = new System.Windows.Forms.TextBox();
            this.textBoxNoDepart = new System.Windows.Forms.TextBox();
            this.textBoxGrossPay = new System.Windows.Forms.TextBox();
            this.textBoxFederalDed = new System.Windows.Forms.TextBox();
            this.textBoxSocSec = new System.Windows.Forms.TextBox();
            this.textBoxAgencyFee = new System.Windows.Forms.TextBox();
            this.textBoxNetPay = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABC Job Source";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.Location = new System.Drawing.Point(56, 81);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(71, 24);
            this.Name_label.TabIndex = 1;
            this.Name_label.Text = "Name: ";
            // 
            // No_Hours_Worked_label
            // 
            this.No_Hours_Worked_label.AutoSize = true;
            this.No_Hours_Worked_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_Hours_Worked_label.Location = new System.Drawing.Point(56, 127);
            this.No_Hours_Worked_label.Name = "No_Hours_Worked_label";
            this.No_Hours_Worked_label.Size = new System.Drawing.Size(172, 24);
            this.No_Hours_Worked_label.TabIndex = 2;
            this.No_Hours_Worked_label.Text = "No Hours Worked: ";
            this.No_Hours_Worked_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // No_of_Departments_label
            // 
            this.No_of_Departments_label.AutoSize = true;
            this.No_of_Departments_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_of_Departments_label.Location = new System.Drawing.Point(56, 175);
            this.No_of_Departments_label.Name = "No_of_Departments_label";
            this.No_of_Departments_label.Size = new System.Drawing.Size(176, 24);
            this.No_of_Departments_label.TabIndex = 3;
            this.No_of_Departments_label.Text = "No of Departments: ";
            // 
            // Gross_Pay_label
            // 
            this.Gross_Pay_label.AutoSize = true;
            this.Gross_Pay_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gross_Pay_label.Location = new System.Drawing.Point(56, 230);
            this.Gross_Pay_label.Name = "Gross_Pay_label";
            this.Gross_Pay_label.Size = new System.Drawing.Size(100, 24);
            this.Gross_Pay_label.TabIndex = 4;
            this.Gross_Pay_label.Text = "Gross Pay:";
            // 
            // Federal_Ded_label
            // 
            this.Federal_Ded_label.AutoSize = true;
            this.Federal_Ded_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Federal_Ded_label.Location = new System.Drawing.Point(56, 280);
            this.Federal_Ded_label.Name = "Federal_Ded_label";
            this.Federal_Ded_label.Size = new System.Drawing.Size(120, 24);
            this.Federal_Ded_label.TabIndex = 5;
            this.Federal_Ded_label.Text = "Federal Ded:";
            // 
            // Soc_Sec_Ded_lebel
            // 
            this.Soc_Sec_Ded_lebel.AutoSize = true;
            this.Soc_Sec_Ded_lebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soc_Sec_Ded_lebel.Location = new System.Drawing.Point(56, 333);
            this.Soc_Sec_Ded_lebel.Name = "Soc_Sec_Ded_lebel";
            this.Soc_Sec_Ded_lebel.Size = new System.Drawing.Size(126, 24);
            this.Soc_Sec_Ded_lebel.TabIndex = 6;
            this.Soc_Sec_Ded_lebel.Text = "Soc Sec Ded:";
            // 
            // Agency_Fee_label
            // 
            this.Agency_Fee_label.AutoSize = true;
            this.Agency_Fee_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agency_Fee_label.Location = new System.Drawing.Point(56, 377);
            this.Agency_Fee_label.Name = "Agency_Fee_label";
            this.Agency_Fee_label.Size = new System.Drawing.Size(119, 24);
            this.Agency_Fee_label.TabIndex = 7;
            this.Agency_Fee_label.Text = "Agency Fee:";
            // 
            // Net_Pay_label
            // 
            this.Net_Pay_label.AutoSize = true;
            this.Net_Pay_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Net_Pay_label.Location = new System.Drawing.Point(56, 427);
            this.Net_Pay_label.Name = "Net_Pay_label";
            this.Net_Pay_label.Size = new System.Drawing.Size(80, 24);
            this.Net_Pay_label.TabIndex = 8;
            this.Net_Pay_label.Text = "Net Pay:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(269, 81);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxHourWork
            // 
            this.textBoxHourWork.Location = new System.Drawing.Point(269, 132);
            this.textBoxHourWork.Name = "textBoxHourWork";
            this.textBoxHourWork.Size = new System.Drawing.Size(100, 20);
            this.textBoxHourWork.TabIndex = 11;
            // 
            // textBoxNoDepart
            // 
            this.textBoxNoDepart.Location = new System.Drawing.Point(269, 180);
            this.textBoxNoDepart.Name = "textBoxNoDepart";
            this.textBoxNoDepart.Size = new System.Drawing.Size(100, 20);
            this.textBoxNoDepart.TabIndex = 12;
            // 
            // textBoxGrossPay
            // 
            this.textBoxGrossPay.Location = new System.Drawing.Point(269, 235);
            this.textBoxGrossPay.Name = "textBoxGrossPay";
            this.textBoxGrossPay.Size = new System.Drawing.Size(100, 20);
            this.textBoxGrossPay.TabIndex = 13;
            // 
            // textBoxFederalDed
            // 
            this.textBoxFederalDed.Location = new System.Drawing.Point(269, 284);
            this.textBoxFederalDed.Name = "textBoxFederalDed";
            this.textBoxFederalDed.Size = new System.Drawing.Size(100, 20);
            this.textBoxFederalDed.TabIndex = 14;
            // 
            // textBoxSocSec
            // 
            this.textBoxSocSec.Location = new System.Drawing.Point(269, 333);
            this.textBoxSocSec.Name = "textBoxSocSec";
            this.textBoxSocSec.Size = new System.Drawing.Size(100, 20);
            this.textBoxSocSec.TabIndex = 15;
            // 
            // textBoxAgencyFee
            // 
            this.textBoxAgencyFee.Location = new System.Drawing.Point(269, 381);
            this.textBoxAgencyFee.Name = "textBoxAgencyFee";
            this.textBoxAgencyFee.Size = new System.Drawing.Size(100, 20);
            this.textBoxAgencyFee.TabIndex = 16;
            // 
            // textBoxNetPay
            // 
            this.textBoxNetPay.Location = new System.Drawing.Point(269, 432);
            this.textBoxNetPay.Name = "textBoxNetPay";
            this.textBoxNetPay.Size = new System.Drawing.Size(100, 20);
            this.textBoxNetPay.TabIndex = 17;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(60, 492);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(96, 23);
            this.buttonCalculate.TabIndex = 19;
            this.buttonCalculate.Text = "CALCULATE";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(269, 492);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 23);
            this.buttonReset.TabIndex = 20;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 572);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxNetPay);
            this.Controls.Add(this.textBoxAgencyFee);
            this.Controls.Add(this.textBoxSocSec);
            this.Controls.Add(this.textBoxFederalDed);
            this.Controls.Add(this.textBoxGrossPay);
            this.Controls.Add(this.textBoxNoDepart);
            this.Controls.Add(this.textBoxHourWork);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.Net_Pay_label);
            this.Controls.Add(this.Agency_Fee_label);
            this.Controls.Add(this.Soc_Sec_Ded_lebel);
            this.Controls.Add(this.Federal_Ded_label);
            this.Controls.Add(this.Gross_Pay_label);
            this.Controls.Add(this.No_of_Departments_label);
            this.Controls.Add(this.No_Hours_Worked_label);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label No_Hours_Worked_label;
        private System.Windows.Forms.Label No_of_Departments_label;
        private System.Windows.Forms.Label Gross_Pay_label;
        private System.Windows.Forms.Label Federal_Ded_label;
        private System.Windows.Forms.Label Soc_Sec_Ded_lebel;
        private System.Windows.Forms.Label Agency_Fee_label;
        private System.Windows.Forms.Label Net_Pay_label;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxHourWork;
        private System.Windows.Forms.TextBox textBoxNoDepart;
        private System.Windows.Forms.TextBox textBoxGrossPay;
        private System.Windows.Forms.TextBox textBoxFederalDed;
        private System.Windows.Forms.TextBox textBoxSocSec;
        private System.Windows.Forms.TextBox textBoxAgencyFee;
        private System.Windows.Forms.TextBox textBoxNetPay;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;
    }
}

