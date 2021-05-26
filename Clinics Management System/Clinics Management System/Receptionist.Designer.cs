
namespace Clinics_Management_System
{
    partial class Receptionist
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Dashboard_tab = new System.Windows.Forms.TabPage();
            this.choices_lbl = new System.Windows.Forms.Label();
            this.Hereucan_lbl = new System.Windows.Forms.Label();
            this.RecName_lbl = new System.Windows.Forms.Label();
            this.welcome_lbl = new System.Windows.Forms.Label();
            this.Patient_tab = new System.Windows.Forms.TabPage();
            this.Dctr_btn = new System.Windows.Forms.Button();
            this.ViewRprt_btn = new System.Windows.Forms.Button();
            this.RegPat_btn = new System.Windows.Forms.Button();
            this.CNIC_txtbox = new System.Windows.Forms.TextBox();
            this.PatCNIC_lbl = new System.Windows.Forms.Label();
            this.Doctor_tab = new System.Windows.Forms.TabPage();
            this.DctrInfo_btn = new System.Windows.Forms.Button();
            this.DctrStat_btn = new System.Windows.Forms.Button();
            this.Spcls_combo = new System.Windows.Forms.ComboBox();
            this.DctrSp_lbl = new System.Windows.Forms.Label();
            this.Room_tab = new System.Windows.Forms.TabPage();
            this.StsInfo_btn = new System.Windows.Forms.Button();
            this.RoomNo_txtbox = new System.Windows.Forms.TextBox();
            this.RoomNo_lbl = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Dashboard_tab.SuspendLayout();
            this.Patient_tab.SuspendLayout();
            this.Doctor_tab.SuspendLayout();
            this.Room_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Dashboard_tab);
            this.tabControl1.Controls.Add(this.Patient_tab);
            this.tabControl1.Controls.Add(this.Doctor_tab);
            this.tabControl1.Controls.Add(this.Room_tab);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 446);
            this.tabControl1.TabIndex = 2;
            // 
            // Dashboard_tab
            // 
            this.Dashboard_tab.Controls.Add(this.choices_lbl);
            this.Dashboard_tab.Controls.Add(this.Hereucan_lbl);
            this.Dashboard_tab.Controls.Add(this.RecName_lbl);
            this.Dashboard_tab.Controls.Add(this.welcome_lbl);
            this.Dashboard_tab.Location = new System.Drawing.Point(4, 22);
            this.Dashboard_tab.Name = "Dashboard_tab";
            this.Dashboard_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Dashboard_tab.Size = new System.Drawing.Size(788, 420);
            this.Dashboard_tab.TabIndex = 0;
            this.Dashboard_tab.Text = "Dashboard";
            this.Dashboard_tab.UseVisualStyleBackColor = true;
            this.Dashboard_tab.Click += new System.EventHandler(this.Dashboard_tab_Click);
            // 
            // choices_lbl
            // 
            this.choices_lbl.AutoSize = true;
            this.choices_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choices_lbl.Location = new System.Drawing.Point(215, 171);
            this.choices_lbl.Name = "choices_lbl";
            this.choices_lbl.Size = new System.Drawing.Size(195, 161);
            this.choices_lbl.TabIndex = 6;
            this.choices_lbl.Text = "- Register Patients\r\n\r\n- View paitent reports\r\n\r\n- Check doctor status\r\n\r\n- Check" +
    " room status";
            // 
            // Hereucan_lbl
            // 
            this.Hereucan_lbl.AutoSize = true;
            this.Hereucan_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hereucan_lbl.Location = new System.Drawing.Point(69, 121);
            this.Hereucan_lbl.Name = "Hereucan_lbl";
            this.Hereucan_lbl.Size = new System.Drawing.Size(140, 25);
            this.Hereucan_lbl.TabIndex = 5;
            this.Hereucan_lbl.Text = "Here you can:";
            // 
            // RecName_lbl
            // 
            this.RecName_lbl.AutoSize = true;
            this.RecName_lbl.Font = new System.Drawing.Font("Bahnschrift Light", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.RecName_lbl.Location = new System.Drawing.Point(208, 30);
            this.RecName_lbl.Name = "RecName_lbl";
            this.RecName_lbl.Size = new System.Drawing.Size(258, 33);
            this.RecName_lbl.TabIndex = 4;
            this.RecName_lbl.Text = "Receptionist Name";
            this.RecName_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_lbl.Location = new System.Drawing.Point(68, 26);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(134, 35);
            this.welcome_lbl.TabIndex = 3;
            this.welcome_lbl.Text = "Welcome";
            // 
            // Patient_tab
            // 
            this.Patient_tab.Controls.Add(this.Dctr_btn);
            this.Patient_tab.Controls.Add(this.ViewRprt_btn);
            this.Patient_tab.Controls.Add(this.RegPat_btn);
            this.Patient_tab.Controls.Add(this.CNIC_txtbox);
            this.Patient_tab.Controls.Add(this.PatCNIC_lbl);
            this.Patient_tab.Location = new System.Drawing.Point(4, 22);
            this.Patient_tab.Name = "Patient_tab";
            this.Patient_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Patient_tab.Size = new System.Drawing.Size(788, 420);
            this.Patient_tab.TabIndex = 1;
            this.Patient_tab.Text = "Patient";
            this.Patient_tab.UseVisualStyleBackColor = true;
            // 
            // Dctr_btn
            // 
            this.Dctr_btn.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.Dctr_btn.Location = new System.Drawing.Point(341, 244);
            this.Dctr_btn.Name = "Dctr_btn";
            this.Dctr_btn.Size = new System.Drawing.Size(151, 29);
            this.Dctr_btn.TabIndex = 4;
            this.Dctr_btn.Text = "Appoint a Doctor";
            this.Dctr_btn.UseVisualStyleBackColor = true;
            // 
            // ViewRprt_btn
            // 
            this.ViewRprt_btn.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.ViewRprt_btn.Location = new System.Drawing.Point(341, 182);
            this.ViewRprt_btn.Name = "ViewRprt_btn";
            this.ViewRprt_btn.Size = new System.Drawing.Size(151, 29);
            this.ViewRprt_btn.TabIndex = 3;
            this.ViewRprt_btn.Text = "View Patient Report";
            this.ViewRprt_btn.UseVisualStyleBackColor = true;
            // 
            // RegPat_btn
            // 
            this.RegPat_btn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegPat_btn.Location = new System.Drawing.Point(341, 120);
            this.RegPat_btn.Name = "RegPat_btn";
            this.RegPat_btn.Size = new System.Drawing.Size(151, 29);
            this.RegPat_btn.TabIndex = 2;
            this.RegPat_btn.Text = "Register Patient";
            this.RegPat_btn.UseVisualStyleBackColor = true;
            this.RegPat_btn.Click += new System.EventHandler(this.RegPat_btn_Click);
            // 
            // CNIC_txtbox
            // 
            this.CNIC_txtbox.Location = new System.Drawing.Point(299, 62);
            this.CNIC_txtbox.Name = "CNIC_txtbox";
            this.CNIC_txtbox.Size = new System.Drawing.Size(236, 20);
            this.CNIC_txtbox.TabIndex = 1;
            // 
            // PatCNIC_lbl
            // 
            this.PatCNIC_lbl.AutoSize = true;
            this.PatCNIC_lbl.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatCNIC_lbl.Location = new System.Drawing.Point(149, 57);
            this.PatCNIC_lbl.Name = "PatCNIC_lbl";
            this.PatCNIC_lbl.Size = new System.Drawing.Size(134, 25);
            this.PatCNIC_lbl.TabIndex = 0;
            this.PatCNIC_lbl.Text = "Patient CNIC:";
            this.PatCNIC_lbl.Click += new System.EventHandler(this.PatCNIC_lbl_Click);
            // 
            // Doctor_tab
            // 
            this.Doctor_tab.Controls.Add(this.DctrInfo_btn);
            this.Doctor_tab.Controls.Add(this.DctrStat_btn);
            this.Doctor_tab.Controls.Add(this.Spcls_combo);
            this.Doctor_tab.Controls.Add(this.DctrSp_lbl);
            this.Doctor_tab.Location = new System.Drawing.Point(4, 22);
            this.Doctor_tab.Name = "Doctor_tab";
            this.Doctor_tab.Size = new System.Drawing.Size(788, 420);
            this.Doctor_tab.TabIndex = 2;
            this.Doctor_tab.Text = "Doctor";
            this.Doctor_tab.UseVisualStyleBackColor = true;
            // 
            // DctrInfo_btn
            // 
            this.DctrInfo_btn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.DctrInfo_btn.Location = new System.Drawing.Point(489, 200);
            this.DctrInfo_btn.Name = "DctrInfo_btn";
            this.DctrInfo_btn.Size = new System.Drawing.Size(126, 33);
            this.DctrInfo_btn.TabIndex = 3;
            this.DctrInfo_btn.Text = "Doctor Info";
            this.DctrInfo_btn.UseVisualStyleBackColor = true;
            this.DctrInfo_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // DctrStat_btn
            // 
            this.DctrStat_btn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.DctrStat_btn.Location = new System.Drawing.Point(206, 200);
            this.DctrStat_btn.Name = "DctrStat_btn";
            this.DctrStat_btn.Size = new System.Drawing.Size(126, 33);
            this.DctrStat_btn.TabIndex = 2;
            this.DctrStat_btn.Text = "Doctor Status";
            this.DctrStat_btn.UseVisualStyleBackColor = true;
            // 
            // Spcls_combo
            // 
            this.Spcls_combo.FormattingEnabled = true;
            this.Spcls_combo.Items.AddRange(new object[] {
            "Gynecologist",
            "Surgeon",
            "Psychiatrist",
            "Cardiologist",
            "Dermatologist",
            "Dentist",
            "Neurologist"});
            this.Spcls_combo.Location = new System.Drawing.Point(313, 59);
            this.Spcls_combo.Name = "Spcls_combo";
            this.Spcls_combo.Size = new System.Drawing.Size(178, 21);
            this.Spcls_combo.TabIndex = 1;
            // 
            // DctrSp_lbl
            // 
            this.DctrSp_lbl.AutoSize = true;
            this.DctrSp_lbl.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.DctrSp_lbl.Location = new System.Drawing.Point(69, 55);
            this.DctrSp_lbl.Name = "DctrSp_lbl";
            this.DctrSp_lbl.Size = new System.Drawing.Size(213, 25);
            this.DctrSp_lbl.TabIndex = 0;
            this.DctrSp_lbl.Text = "Doctor Specialization:";
            // 
            // Room_tab
            // 
            this.Room_tab.Controls.Add(this.StsInfo_btn);
            this.Room_tab.Controls.Add(this.RoomNo_txtbox);
            this.Room_tab.Controls.Add(this.RoomNo_lbl);
            this.Room_tab.Location = new System.Drawing.Point(4, 22);
            this.Room_tab.Name = "Room_tab";
            this.Room_tab.Size = new System.Drawing.Size(788, 420);
            this.Room_tab.TabIndex = 3;
            this.Room_tab.Text = "Room";
            this.Room_tab.UseVisualStyleBackColor = true;
            // 
            // StsInfo_btn
            // 
            this.StsInfo_btn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.StsInfo_btn.Location = new System.Drawing.Point(337, 149);
            this.StsInfo_btn.Name = "StsInfo_btn";
            this.StsInfo_btn.Size = new System.Drawing.Size(153, 27);
            this.StsInfo_btn.TabIndex = 2;
            this.StsInfo_btn.Text = "Room Status/Info";
            this.StsInfo_btn.UseVisualStyleBackColor = true;
            // 
            // RoomNo_txtbox
            // 
            this.RoomNo_txtbox.Location = new System.Drawing.Point(351, 67);
            this.RoomNo_txtbox.Name = "RoomNo_txtbox";
            this.RoomNo_txtbox.Size = new System.Drawing.Size(118, 20);
            this.RoomNo_txtbox.TabIndex = 1;
            // 
            // RoomNo_lbl
            // 
            this.RoomNo_lbl.AutoSize = true;
            this.RoomNo_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNo_lbl.Location = new System.Drawing.Point(255, 64);
            this.RoomNo_lbl.Name = "RoomNo_lbl";
            this.RoomNo_lbl.Size = new System.Drawing.Size(90, 23);
            this.RoomNo_lbl.TabIndex = 0;
            this.RoomNo_lbl.Text = "Room No:";
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Receptionist";
            this.Text = "Receptionist";
            this.tabControl1.ResumeLayout(false);
            this.Dashboard_tab.ResumeLayout(false);
            this.Dashboard_tab.PerformLayout();
            this.Patient_tab.ResumeLayout(false);
            this.Patient_tab.PerformLayout();
            this.Doctor_tab.ResumeLayout(false);
            this.Doctor_tab.PerformLayout();
            this.Room_tab.ResumeLayout(false);
            this.Room_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Dashboard_tab;
        private System.Windows.Forms.TabPage Patient_tab;
        private System.Windows.Forms.TabPage Doctor_tab;
        private System.Windows.Forms.TabPage Room_tab;
        private System.Windows.Forms.Label RecName_lbl;
        private System.Windows.Forms.Label welcome_lbl;
        private System.Windows.Forms.Label Hereucan_lbl;
        private System.Windows.Forms.Label choices_lbl;
        private System.Windows.Forms.Label PatCNIC_lbl;
        private System.Windows.Forms.Button Dctr_btn;
        private System.Windows.Forms.Button ViewRprt_btn;
        private System.Windows.Forms.Button RegPat_btn;
        private System.Windows.Forms.TextBox CNIC_txtbox;
        private System.Windows.Forms.Label DctrSp_lbl;
        private System.Windows.Forms.Button DctrInfo_btn;
        private System.Windows.Forms.Button DctrStat_btn;
        private System.Windows.Forms.ComboBox Spcls_combo;
        private System.Windows.Forms.Button StsInfo_btn;
        private System.Windows.Forms.TextBox RoomNo_txtbox;
        private System.Windows.Forms.Label RoomNo_lbl;
    }
}