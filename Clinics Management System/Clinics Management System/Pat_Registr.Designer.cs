
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
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.CNIC_txtbox = new System.Windows.Forms.TextBox();
            this.Prblm_txtbox = new System.Windows.Forms.TextBox();
            this.incharge_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.PCNIC_lbl.Location = new System.Drawing.Point(152, 176);
            this.PCNIC_lbl.Name = "PCNIC_lbl";
            this.PCNIC_lbl.Size = new System.Drawing.Size(126, 23);
            this.PCNIC_lbl.TabIndex = 1;
            this.PCNIC_lbl.Text = "Patient CNIC :";
            // 
            // Pname_lbl
            // 
            this.Pname_lbl.AutoSize = true;
            this.Pname_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.Pname_lbl.Location = new System.Drawing.Point(145, 125);
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
            this.Reg_btn.Location = new System.Drawing.Point(236, 340);
            this.Reg_btn.Name = "Reg_btn";
            this.Reg_btn.Size = new System.Drawing.Size(118, 49);
            this.Reg_btn.TabIndex = 5;
            this.Reg_btn.Text = "Register";
            this.Reg_btn.UseVisualStyleBackColor = true;
            // 
            // name_txtbox
            // 
            this.name_txtbox.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.name_txtbox.Location = new System.Drawing.Point(284, 122);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(246, 30);
            this.name_txtbox.TabIndex = 6;
            // 
            // CNIC_txtbox
            // 
            this.CNIC_txtbox.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.CNIC_txtbox.Location = new System.Drawing.Point(284, 173);
            this.CNIC_txtbox.Name = "CNIC_txtbox";
            this.CNIC_txtbox.Size = new System.Drawing.Size(246, 30);
            this.CNIC_txtbox.TabIndex = 7;
            // 
            // Prblm_txtbox
            // 
            this.Prblm_txtbox.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.Prblm_txtbox.Location = new System.Drawing.Point(284, 225);
            this.Prblm_txtbox.Name = "Prblm_txtbox";
            this.Prblm_txtbox.Size = new System.Drawing.Size(70, 30);
            this.Prblm_txtbox.TabIndex = 8;
            // 
            // incharge_combobox
            // 
            this.incharge_combobox.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.incharge_combobox.FormattingEnabled = true;
            this.incharge_combobox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Another"});
            this.incharge_combobox.Location = new System.Drawing.Point(284, 275);
            this.incharge_combobox.Name = "incharge_combobox";
            this.incharge_combobox.Size = new System.Drawing.Size(138, 31);
            this.incharge_combobox.TabIndex = 9;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.button1.Location = new System.Drawing.Point(402, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "Register and Appointment";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Pat_Registr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.incharge_combobox);
            this.Controls.Add(this.Prblm_txtbox);
            this.Controls.Add(this.CNIC_txtbox);
            this.Controls.Add(this.name_txtbox);
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
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.TextBox CNIC_txtbox;
        private System.Windows.Forms.TextBox Prblm_txtbox;
        private System.Windows.Forms.ComboBox incharge_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}