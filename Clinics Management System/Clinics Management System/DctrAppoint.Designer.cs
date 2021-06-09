
namespace Clinics_Management_System
{
    partial class DctrAppoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DctrAppoint));
            this.AppointDoc_lbl = new System.Windows.Forms.Label();
            this.PCNIC_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.slctDoc_lbl = new System.Windows.Forms.Label();
            this.doctor_spec_combobox = new System.Windows.Forms.ComboBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.CNIC_show_label = new System.Windows.Forms.Label();
            this.pat_nameShow_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.healthProb_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AppointDoc_lbl
            // 
            this.AppointDoc_lbl.AutoSize = true;
            this.AppointDoc_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AppointDoc_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold);
            this.AppointDoc_lbl.ForeColor = System.Drawing.Color.Navy;
            this.AppointDoc_lbl.Location = new System.Drawing.Point(222, 32);
            this.AppointDoc_lbl.Name = "AppointDoc_lbl";
            this.AppointDoc_lbl.Size = new System.Drawing.Size(257, 41);
            this.AppointDoc_lbl.TabIndex = 0;
            this.AppointDoc_lbl.Text = "Appoint a Doctor";
            // 
            // PCNIC_lbl
            // 
            this.PCNIC_lbl.AutoSize = true;
            this.PCNIC_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.PCNIC_lbl.Location = new System.Drawing.Point(162, 121);
            this.PCNIC_lbl.Name = "PCNIC_lbl";
            this.PCNIC_lbl.Size = new System.Drawing.Size(126, 23);
            this.PCNIC_lbl.TabIndex = 1;
            this.PCNIC_lbl.Text = "Patient CNIC :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label3.Location = new System.Drawing.Point(154, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patient Name :";
            // 
            // slctDoc_lbl
            // 
            this.slctDoc_lbl.AutoSize = true;
            this.slctDoc_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.slctDoc_lbl.Location = new System.Drawing.Point(155, 280);
            this.slctDoc_lbl.Name = "slctDoc_lbl";
            this.slctDoc_lbl.Size = new System.Drawing.Size(132, 23);
            this.slctDoc_lbl.TabIndex = 3;
            this.slctDoc_lbl.Text = "Select Doctor :";
            // 
            // doctor_spec_combobox
            // 
            this.doctor_spec_combobox.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.doctor_spec_combobox.FormattingEnabled = true;
            this.doctor_spec_combobox.Items.AddRange(new object[] {
            "Allergist",
            "Cardiologist",
            "Dermatologist",
            "Nephrologist",
            "Neurologist",
            "Ophthalmologist",
            "Otolaryngologist",
            "Psychiatrist",
            "Radiologist",
            "Surgeon"});
            this.doctor_spec_combobox.Location = new System.Drawing.Point(294, 280);
            this.doctor_spec_combobox.Name = "doctor_spec_combobox";
            this.doctor_spec_combobox.Size = new System.Drawing.Size(234, 27);
            this.doctor_spec_combobox.TabIndex = 4;
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.submit_btn.Location = new System.Drawing.Point(294, 344);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(110, 45);
            this.submit_btn.TabIndex = 5;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // CNIC_show_label
            // 
            this.CNIC_show_label.AutoSize = true;
            this.CNIC_show_label.BackColor = System.Drawing.Color.White;
            this.CNIC_show_label.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.CNIC_show_label.Location = new System.Drawing.Point(294, 121);
            this.CNIC_show_label.Name = "CNIC_show_label";
            this.CNIC_show_label.Size = new System.Drawing.Size(44, 23);
            this.CNIC_show_label.TabIndex = 9;
            this.CNIC_show_label.Text = "cnic";
            // 
            // pat_nameShow_label
            // 
            this.pat_nameShow_label.AutoSize = true;
            this.pat_nameShow_label.BackColor = System.Drawing.Color.White;
            this.pat_nameShow_label.Font = new System.Drawing.Font("Bahnschrift Light", 13.5F);
            this.pat_nameShow_label.Location = new System.Drawing.Point(294, 171);
            this.pat_nameShow_label.Name = "pat_nameShow_label";
            this.pat_nameShow_label.Size = new System.Drawing.Size(55, 22);
            this.pat_nameShow_label.TabIndex = 10;
            this.pat_nameShow_label.Text = "name";
            this.pat_nameShow_label.Click += new System.EventHandler(this.PnameShow_lbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label1.Location = new System.Drawing.Point(136, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Health Problem :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // healthProb_txtbox
            // 
            this.healthProb_txtbox.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.healthProb_txtbox.Location = new System.Drawing.Point(294, 224);
            this.healthProb_txtbox.Name = "healthProb_txtbox";
            this.healthProb_txtbox.Size = new System.Drawing.Size(234, 30);
            this.healthProb_txtbox.TabIndex = 12;
            // 
            // DctrAppoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.healthProb_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pat_nameShow_label);
            this.Controls.Add(this.CNIC_show_label);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.doctor_spec_combobox);
            this.Controls.Add(this.slctDoc_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PCNIC_lbl);
            this.Controls.Add(this.AppointDoc_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DctrAppoint";
            this.Text = "Doctor Appointment";
            this.Load += new System.EventHandler(this.DctrAppoint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppointDoc_lbl;
        private System.Windows.Forms.Label PCNIC_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label slctDoc_lbl;
        private System.Windows.Forms.ComboBox doctor_spec_combobox;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label CNIC_show_label;
        private System.Windows.Forms.Label pat_nameShow_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox healthProb_txtbox;
    }
}