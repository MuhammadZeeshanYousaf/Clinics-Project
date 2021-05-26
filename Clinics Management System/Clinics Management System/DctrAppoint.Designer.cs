
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
            this.AppointDoc_lbl = new System.Windows.Forms.Label();
            this.PCNIC_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.slctDoc_lbl = new System.Windows.Forms.Label();
            this.DctrsOpt_combobox = new System.Windows.Forms.ComboBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.PatCNIC_txtbox = new System.Windows.Forms.TextBox();
            this.PatName_lbl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AppointDoc_lbl
            // 
            this.AppointDoc_lbl.AutoSize = true;
            this.AppointDoc_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold);
            this.AppointDoc_lbl.Location = new System.Drawing.Point(270, 42);
            this.AppointDoc_lbl.Name = "AppointDoc_lbl";
            this.AppointDoc_lbl.Size = new System.Drawing.Size(255, 39);
            this.AppointDoc_lbl.TabIndex = 0;
            this.AppointDoc_lbl.Text = "Appoint a Doctor";
            // 
            // PCNIC_lbl
            // 
            this.PCNIC_lbl.AutoSize = true;
            this.PCNIC_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.PCNIC_lbl.Location = new System.Drawing.Point(246, 134);
            this.PCNIC_lbl.Name = "PCNIC_lbl";
            this.PCNIC_lbl.Size = new System.Drawing.Size(120, 23);
            this.PCNIC_lbl.TabIndex = 1;
            this.PCNIC_lbl.Text = "Patient CNIC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label3.Location = new System.Drawing.Point(238, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patient Name:";
            // 
            // slctDoc_lbl
            // 
            this.slctDoc_lbl.AutoSize = true;
            this.slctDoc_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.slctDoc_lbl.Location = new System.Drawing.Point(234, 260);
            this.slctDoc_lbl.Name = "slctDoc_lbl";
            this.slctDoc_lbl.Size = new System.Drawing.Size(132, 23);
            this.slctDoc_lbl.TabIndex = 3;
            this.slctDoc_lbl.Text = "Select Doctor :";
            // 
            // DctrsOpt_combobox
            // 
            this.DctrsOpt_combobox.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.DctrsOpt_combobox.FormattingEnabled = true;
            this.DctrsOpt_combobox.Location = new System.Drawing.Point(372, 260);
            this.DctrsOpt_combobox.Name = "DctrsOpt_combobox";
            this.DctrsOpt_combobox.Size = new System.Drawing.Size(185, 27);
            this.DctrsOpt_combobox.TabIndex = 4;
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.submit_btn.Location = new System.Drawing.Point(417, 360);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(75, 27);
            this.submit_btn.TabIndex = 5;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            // 
            // PatCNIC_txtbox
            // 
            this.PatCNIC_txtbox.Font = new System.Drawing.Font("Bahnschrift", 13.5F);
            this.PatCNIC_txtbox.Location = new System.Drawing.Point(372, 132);
            this.PatCNIC_txtbox.Name = "PatCNIC_txtbox";
            this.PatCNIC_txtbox.Size = new System.Drawing.Size(218, 29);
            this.PatCNIC_txtbox.TabIndex = 6;
            // 
            // PatName_lbl
            // 
            this.PatName_lbl.Font = new System.Drawing.Font("Bahnschrift", 13.5F);
            this.PatName_lbl.Location = new System.Drawing.Point(372, 197);
            this.PatName_lbl.Name = "PatName_lbl";
            this.PatName_lbl.Size = new System.Drawing.Size(218, 29);
            this.PatName_lbl.TabIndex = 7;
            // 
            // DctrAppoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PatName_lbl);
            this.Controls.Add(this.PatCNIC_txtbox);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.DctrsOpt_combobox);
            this.Controls.Add(this.slctDoc_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PCNIC_lbl);
            this.Controls.Add(this.AppointDoc_lbl);
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
        private System.Windows.Forms.ComboBox DctrsOpt_combobox;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.TextBox PatCNIC_txtbox;
        private System.Windows.Forms.TextBox PatName_lbl;
    }
}