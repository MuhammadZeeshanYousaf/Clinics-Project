
namespace Clinics_Management_System
{
    partial class Pat_Registr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pat_Registr));
            this.PatReg_lbl = new System.Windows.Forms.Label();
            this.PCNIC_lbl = new System.Windows.Forms.Label();
            this.Pname_lbl = new System.Windows.Forms.Label();
            this.Prblm_lbl = new System.Windows.Forms.Label();
            this.DctrIncharge_lbl = new System.Windows.Forms.Label();
            this.Reg_btn = new System.Windows.Forms.Button();
            this.pat_name_txtbox = new System.Windows.Forms.TextBox();
            this.pat_age_txtbox = new System.Windows.Forms.TextBox();
            this.pat_gender_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cninc_show_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PatReg_lbl
            // 
            this.PatReg_lbl.AutoSize = true;
            this.PatReg_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PatReg_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatReg_lbl.ForeColor = System.Drawing.Color.Navy;
            this.PatReg_lbl.Location = new System.Drawing.Point(145, 34);
            this.PatReg_lbl.Name = "PatReg_lbl";
            this.PatReg_lbl.Size = new System.Drawing.Size(385, 41);
            this.PatReg_lbl.TabIndex = 0;
            this.PatReg_lbl.Text = "Patient Registration Form";
            // 
            // PCNIC_lbl
            // 
            this.PCNIC_lbl.AutoSize = true;
            this.PCNIC_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.PCNIC_lbl.Location = new System.Drawing.Point(150, 121);
            this.PCNIC_lbl.Name = "PCNIC_lbl";
            this.PCNIC_lbl.Size = new System.Drawing.Size(126, 23);
            this.PCNIC_lbl.TabIndex = 1;
            this.PCNIC_lbl.Text = "Patient CNIC :";
            // 
            // Pname_lbl
            // 
            this.Pname_lbl.AutoSize = true;
            this.Pname_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.Pname_lbl.Location = new System.Drawing.Point(145, 172);
            this.Pname_lbl.Name = "Pname_lbl";
            this.Pname_lbl.Size = new System.Drawing.Size(133, 23);
            this.Pname_lbl.TabIndex = 2;
            this.Pname_lbl.Text = "Patient Name :";
            // 
            // Prblm_lbl
            // 
            this.Prblm_lbl.AutoSize = true;
            this.Prblm_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.Prblm_lbl.Location = new System.Drawing.Point(160, 226);
            this.Prblm_lbl.Name = "Prblm_lbl";
            this.Prblm_lbl.Size = new System.Drawing.Size(116, 23);
            this.Prblm_lbl.TabIndex = 3;
            this.Prblm_lbl.Text = "Patient Age :";
            this.Prblm_lbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // DctrIncharge_lbl
            // 
            this.DctrIncharge_lbl.AutoSize = true;
            this.DctrIncharge_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.DctrIncharge_lbl.Location = new System.Drawing.Point(194, 278);
            this.DctrIncharge_lbl.Name = "DctrIncharge_lbl";
            this.DctrIncharge_lbl.Size = new System.Drawing.Size(80, 23);
            this.DctrIncharge_lbl.TabIndex = 4;
            this.DctrIncharge_lbl.Text = "Gender :";
            this.DctrIncharge_lbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // Reg_btn
            // 
            this.Reg_btn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.Reg_btn.Location = new System.Drawing.Point(282, 340);
            this.Reg_btn.Name = "Reg_btn";
            this.Reg_btn.Size = new System.Drawing.Size(118, 49);
            this.Reg_btn.TabIndex = 5;
            this.Reg_btn.Text = "Register";
            this.Reg_btn.UseVisualStyleBackColor = true;
            this.Reg_btn.Click += new System.EventHandler(this.Reg_btn_Click);
            // 
            // pat_name_txtbox
            // 
            this.pat_name_txtbox.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.pat_name_txtbox.Location = new System.Drawing.Point(284, 169);
            this.pat_name_txtbox.Name = "pat_name_txtbox";
            this.pat_name_txtbox.Size = new System.Drawing.Size(246, 30);
            this.pat_name_txtbox.TabIndex = 6;
            // 
            // pat_age_txtbox
            // 
            this.pat_age_txtbox.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.pat_age_txtbox.Location = new System.Drawing.Point(284, 225);
            this.pat_age_txtbox.Name = "pat_age_txtbox";
            this.pat_age_txtbox.Size = new System.Drawing.Size(70, 30);
            this.pat_age_txtbox.TabIndex = 8;
            // 
            // pat_gender_comboBox
            // 
            this.pat_gender_comboBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.pat_gender_comboBox.FormattingEnabled = true;
            this.pat_gender_comboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Another"});
            this.pat_gender_comboBox.Location = new System.Drawing.Point(284, 275);
            this.pat_gender_comboBox.Name = "pat_gender_comboBox";
            this.pat_gender_comboBox.Size = new System.Drawing.Size(138, 31);
            this.pat_gender_comboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label1.Location = new System.Drawing.Point(360, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "years";
            // 
            // cninc_show_label
            // 
            this.cninc_show_label.AutoSize = true;
            this.cninc_show_label.BackColor = System.Drawing.Color.White;
            this.cninc_show_label.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.cninc_show_label.Location = new System.Drawing.Point(282, 121);
            this.cninc_show_label.Name = "cninc_show_label";
            this.cninc_show_label.Size = new System.Drawing.Size(44, 23);
            this.cninc_show_label.TabIndex = 12;
            this.cninc_show_label.Text = "cnic";
            // 
            // Pat_Registr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.cninc_show_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pat_gender_comboBox);
            this.Controls.Add(this.pat_age_txtbox);
            this.Controls.Add(this.pat_name_txtbox);
            this.Controls.Add(this.Reg_btn);
            this.Controls.Add(this.DctrIncharge_lbl);
            this.Controls.Add(this.Prblm_lbl);
            this.Controls.Add(this.Pname_lbl);
            this.Controls.Add(this.PCNIC_lbl);
            this.Controls.Add(this.PatReg_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pat_Registr";
            this.Text = "Patient Registration";
            this.Load += new System.EventHandler(this.Pat_Registr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatReg_lbl;
        private System.Windows.Forms.Label PCNIC_lbl;
        private System.Windows.Forms.Label Pname_lbl;
        private System.Windows.Forms.Label Prblm_lbl;
        private System.Windows.Forms.Label DctrIncharge_lbl;
        private System.Windows.Forms.Button Reg_btn;
        private System.Windows.Forms.TextBox pat_name_txtbox;
        private System.Windows.Forms.TextBox pat_age_txtbox;
        private System.Windows.Forms.ComboBox pat_gender_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cninc_show_label;
    }
}