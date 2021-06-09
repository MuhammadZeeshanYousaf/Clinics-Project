
namespace Clinics_Management_System
{
    partial class Pat_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pat_Report));
            this.PatReportHead_lbl = new System.Windows.Forms.Label();
            this.CNICheading_lbl = new System.Windows.Forms.Label();
            this.nameheading_lbl = new System.Windows.Forms.Label();
            this.probheading_lbl = new System.Windows.Forms.Label();
            this.inchargheading_lbl = new System.Windows.Forms.Label();
            this.appointheading_lbl = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.app_doctors_lstbox = new System.Windows.Forms.ListBox();
            this.CNIC_show_label = new System.Windows.Forms.Label();
            this.pat_nameShow_label = new System.Windows.Forms.Label();
            this.ProblemShow_label = new System.Windows.Forms.Label();
            this.appointShow_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PatReportHead_lbl
            // 
            this.PatReportHead_lbl.AutoSize = true;
            this.PatReportHead_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PatReportHead_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold);
            this.PatReportHead_lbl.ForeColor = System.Drawing.Color.Navy;
            this.PatReportHead_lbl.Location = new System.Drawing.Point(222, 23);
            this.PatReportHead_lbl.Name = "PatReportHead_lbl";
            this.PatReportHead_lbl.Size = new System.Drawing.Size(222, 41);
            this.PatReportHead_lbl.TabIndex = 0;
            this.PatReportHead_lbl.Text = "Patient Report";
            // 
            // CNICheading_lbl
            // 
            this.CNICheading_lbl.AutoSize = true;
            this.CNICheading_lbl.Font = new System.Drawing.Font("Bahnschrift", 13.5F);
            this.CNICheading_lbl.Location = new System.Drawing.Point(190, 99);
            this.CNICheading_lbl.Name = "CNICheading_lbl";
            this.CNICheading_lbl.Size = new System.Drawing.Size(122, 22);
            this.CNICheading_lbl.TabIndex = 1;
            this.CNICheading_lbl.Text = "Patient CNIC :";
            // 
            // nameheading_lbl
            // 
            this.nameheading_lbl.AutoSize = true;
            this.nameheading_lbl.Font = new System.Drawing.Font("Bahnschrift", 13.5F);
            this.nameheading_lbl.Location = new System.Drawing.Point(182, 150);
            this.nameheading_lbl.Name = "nameheading_lbl";
            this.nameheading_lbl.Size = new System.Drawing.Size(130, 22);
            this.nameheading_lbl.TabIndex = 2;
            this.nameheading_lbl.Text = "Patient Name :";
            // 
            // probheading_lbl
            // 
            this.probheading_lbl.AutoSize = true;
            this.probheading_lbl.Font = new System.Drawing.Font("Bahnschrift", 13.5F);
            this.probheading_lbl.Location = new System.Drawing.Point(104, 199);
            this.probheading_lbl.Name = "probheading_lbl";
            this.probheading_lbl.Size = new System.Drawing.Size(208, 22);
            this.probheading_lbl.TabIndex = 3;
            this.probheading_lbl.Text = "Recent Health Problem :";
            // 
            // inchargheading_lbl
            // 
            this.inchargheading_lbl.AutoSize = true;
            this.inchargheading_lbl.Font = new System.Drawing.Font("Bahnschrift", 13.5F);
            this.inchargheading_lbl.Location = new System.Drawing.Point(141, 291);
            this.inchargheading_lbl.Name = "inchargheading_lbl";
            this.inchargheading_lbl.Size = new System.Drawing.Size(171, 22);
            this.inchargheading_lbl.TabIndex = 4;
            this.inchargheading_lbl.Text = "Appointed Doctors :";
            this.inchargheading_lbl.Click += new System.EventHandler(this.inchargheading_lbl_Click);
            // 
            // appointheading_lbl
            // 
            this.appointheading_lbl.AutoSize = true;
            this.appointheading_lbl.Font = new System.Drawing.Font("Bahnschrift", 13.5F);
            this.appointheading_lbl.Location = new System.Drawing.Point(136, 243);
            this.appointheading_lbl.Name = "appointheading_lbl";
            this.appointheading_lbl.Size = new System.Drawing.Size(176, 22);
            this.appointheading_lbl.TabIndex = 5;
            this.appointheading_lbl.Text = "Total Appointments :";
            this.appointheading_lbl.Click += new System.EventHandler(this.label6_Click);
            // 
            // close_btn
            // 
            this.close_btn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.close_btn.Location = new System.Drawing.Point(570, 400);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(98, 42);
            this.close_btn.TabIndex = 6;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // app_doctors_lstbox
            // 
            this.app_doctors_lstbox.BackColor = System.Drawing.SystemColors.Window;
            this.app_doctors_lstbox.FormattingEnabled = true;
            this.app_doctors_lstbox.Location = new System.Drawing.Point(322, 291);
            this.app_doctors_lstbox.Name = "app_doctors_lstbox";
            this.app_doctors_lstbox.Size = new System.Drawing.Size(197, 82);
            this.app_doctors_lstbox.TabIndex = 7;
            // 
            // CNIC_show_label
            // 
            this.CNIC_show_label.AutoSize = true;
            this.CNIC_show_label.BackColor = System.Drawing.Color.White;
            this.CNIC_show_label.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.CNIC_show_label.Location = new System.Drawing.Point(318, 99);
            this.CNIC_show_label.Name = "CNIC_show_label";
            this.CNIC_show_label.Size = new System.Drawing.Size(44, 23);
            this.CNIC_show_label.TabIndex = 8;
            this.CNIC_show_label.Text = "cnic";
            // 
            // pat_nameShow_label
            // 
            this.pat_nameShow_label.AutoSize = true;
            this.pat_nameShow_label.BackColor = System.Drawing.Color.White;
            this.pat_nameShow_label.Font = new System.Drawing.Font("Bahnschrift Light", 13.5F);
            this.pat_nameShow_label.Location = new System.Drawing.Point(318, 150);
            this.pat_nameShow_label.Name = "pat_nameShow_label";
            this.pat_nameShow_label.Size = new System.Drawing.Size(55, 22);
            this.pat_nameShow_label.TabIndex = 9;
            this.pat_nameShow_label.Text = "name";
            // 
            // ProblemShow_label
            // 
            this.ProblemShow_label.AutoSize = true;
            this.ProblemShow_label.BackColor = System.Drawing.Color.White;
            this.ProblemShow_label.Font = new System.Drawing.Font("Bahnschrift Light", 13.5F);
            this.ProblemShow_label.Location = new System.Drawing.Point(318, 199);
            this.ProblemShow_label.Name = "ProblemShow_label";
            this.ProblemShow_label.Size = new System.Drawing.Size(78, 22);
            this.ProblemShow_label.TabIndex = 10;
            this.ProblemShow_label.Text = "problem";
            // 
            // appointShow_label
            // 
            this.appointShow_label.AutoSize = true;
            this.appointShow_label.BackColor = System.Drawing.Color.White;
            this.appointShow_label.Font = new System.Drawing.Font("Bahnschrift Light", 13.5F);
            this.appointShow_label.Location = new System.Drawing.Point(318, 243);
            this.appointShow_label.Name = "appointShow_label";
            this.appointShow_label.Size = new System.Drawing.Size(172, 22);
            this.appointShow_label.TabIndex = 11;
            this.appointShow_label.Text = "No of Appointments";
            // 
            // Pat_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 454);
            this.Controls.Add(this.appointShow_label);
            this.Controls.Add(this.ProblemShow_label);
            this.Controls.Add(this.pat_nameShow_label);
            this.Controls.Add(this.CNIC_show_label);
            this.Controls.Add(this.app_doctors_lstbox);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.appointheading_lbl);
            this.Controls.Add(this.inchargheading_lbl);
            this.Controls.Add(this.probheading_lbl);
            this.Controls.Add(this.nameheading_lbl);
            this.Controls.Add(this.CNICheading_lbl);
            this.Controls.Add(this.PatReportHead_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pat_Report";
            this.Text = "Patient Report";
            this.Load += new System.EventHandler(this.Pat_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatReportHead_lbl;
        private System.Windows.Forms.Label CNICheading_lbl;
        private System.Windows.Forms.Label nameheading_lbl;
        private System.Windows.Forms.Label probheading_lbl;
        private System.Windows.Forms.Label inchargheading_lbl;
        private System.Windows.Forms.Label appointheading_lbl;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.ListBox app_doctors_lstbox;
        private System.Windows.Forms.Label CNIC_show_label;
        private System.Windows.Forms.Label pat_nameShow_label;
        private System.Windows.Forms.Label ProblemShow_label;
        private System.Windows.Forms.Label appointShow_label;
    }
}