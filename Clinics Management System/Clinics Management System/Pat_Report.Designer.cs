
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
            this.doctorIncharge_lstbox = new System.Windows.Forms.ListBox();
            this.CNICshow_lbl = new System.Windows.Forms.Label();
            this.PnameShow_lbl = new System.Windows.Forms.Label();
            this.ProblemShow_lbl = new System.Windows.Forms.Label();
            this.appointShow_lbl = new System.Windows.Forms.Label();
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
            this.probheading_lbl.Location = new System.Drawing.Point(104, 202);
            this.probheading_lbl.Name = "probheading_lbl";
            this.probheading_lbl.Size = new System.Drawing.Size(208, 22);
            this.probheading_lbl.TabIndex = 3;
            this.probheading_lbl.Text = "Recent Health Problem :";
            // 
            // inchargheading_lbl
            // 
            this.inchargheading_lbl.AutoSize = true;
            this.inchargheading_lbl.Font = new System.Drawing.Font("Bahnschrift", 13.5F);
            this.inchargheading_lbl.Location = new System.Drawing.Point(152, 291);
            this.inchargheading_lbl.Name = "inchargheading_lbl";
            this.inchargheading_lbl.Size = new System.Drawing.Size(160, 22);
            this.inchargheading_lbl.TabIndex = 4;
            this.inchargheading_lbl.Text = "Doctors Incharge :";
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
            this.close_btn.Location = new System.Drawing.Point(570, 388);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(98, 42);
            this.close_btn.TabIndex = 6;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            // 
            // doctorIncharge_lstbox
            // 
            this.doctorIncharge_lstbox.BackColor = System.Drawing.SystemColors.Window;
            this.doctorIncharge_lstbox.FormattingEnabled = true;
            this.doctorIncharge_lstbox.Location = new System.Drawing.Point(322, 291);
            this.doctorIncharge_lstbox.Name = "doctorIncharge_lstbox";
            this.doctorIncharge_lstbox.Size = new System.Drawing.Size(197, 82);
            this.doctorIncharge_lstbox.TabIndex = 7;
            // 
            // CNICshow_lbl
            // 
            this.CNICshow_lbl.AutoSize = true;
            this.CNICshow_lbl.BackColor = System.Drawing.Color.White;
            this.CNICshow_lbl.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.CNICshow_lbl.Location = new System.Drawing.Point(318, 99);
            this.CNICshow_lbl.Name = "CNICshow_lbl";
            this.CNICshow_lbl.Size = new System.Drawing.Size(44, 23);
            this.CNICshow_lbl.TabIndex = 8;
            this.CNICshow_lbl.Text = "cnic";
            // 
            // PnameShow_lbl
            // 
            this.PnameShow_lbl.AutoSize = true;
            this.PnameShow_lbl.BackColor = System.Drawing.Color.White;
            this.PnameShow_lbl.Font = new System.Drawing.Font("Bahnschrift Light", 13.5F);
            this.PnameShow_lbl.Location = new System.Drawing.Point(318, 150);
            this.PnameShow_lbl.Name = "PnameShow_lbl";
            this.PnameShow_lbl.Size = new System.Drawing.Size(55, 22);
            this.PnameShow_lbl.TabIndex = 9;
            this.PnameShow_lbl.Text = "name";
            // 
            // ProblemShow_lbl
            // 
            this.ProblemShow_lbl.AutoSize = true;
            this.ProblemShow_lbl.BackColor = System.Drawing.Color.White;
            this.ProblemShow_lbl.Font = new System.Drawing.Font("Bahnschrift Light", 13.5F);
            this.ProblemShow_lbl.Location = new System.Drawing.Point(318, 202);
            this.ProblemShow_lbl.Name = "ProblemShow_lbl";
            this.ProblemShow_lbl.Size = new System.Drawing.Size(78, 22);
            this.ProblemShow_lbl.TabIndex = 10;
            this.ProblemShow_lbl.Text = "problem";
            // 
            // appointShow_lbl
            // 
            this.appointShow_lbl.AutoSize = true;
            this.appointShow_lbl.BackColor = System.Drawing.Color.White;
            this.appointShow_lbl.Font = new System.Drawing.Font("Bahnschrift Light", 13.5F);
            this.appointShow_lbl.Location = new System.Drawing.Point(318, 243);
            this.appointShow_lbl.Name = "appointShow_lbl";
            this.appointShow_lbl.Size = new System.Drawing.Size(172, 22);
            this.appointShow_lbl.TabIndex = 11;
            this.appointShow_lbl.Text = "No of Appointments";
            // 
            // Pat_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 442);
            this.Controls.Add(this.appointShow_lbl);
            this.Controls.Add(this.ProblemShow_lbl);
            this.Controls.Add(this.PnameShow_lbl);
            this.Controls.Add(this.CNICshow_lbl);
            this.Controls.Add(this.doctorIncharge_lstbox);
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
        private System.Windows.Forms.ListBox doctorIncharge_lstbox;
        private System.Windows.Forms.Label CNICshow_lbl;
        private System.Windows.Forms.Label PnameShow_lbl;
        private System.Windows.Forms.Label ProblemShow_lbl;
        private System.Windows.Forms.Label appointShow_lbl;
    }
}