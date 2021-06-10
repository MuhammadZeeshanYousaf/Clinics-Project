
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionist));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Dashboard_tab = new System.Windows.Forms.TabPage();
            this.choices_lbl = new System.Windows.Forms.Label();
            this.Hereucan_lbl = new System.Windows.Forms.Label();
            this.Recetionist_name_label = new System.Windows.Forms.Label();
            this.welcome_lbl = new System.Windows.Forms.Label();
            this.Patient_tab = new System.Windows.Forms.TabPage();
            this.patients_manage = new System.Windows.Forms.Label();
            this.appoint_dr_btn = new System.Windows.Forms.Button();
            this.ViewRprt_btn = new System.Windows.Forms.Button();
            this.RegPat_btn = new System.Windows.Forms.Button();
            this.CNIC_txtbox = new System.Windows.Forms.TextBox();
            this.PatCNIC_lbl = new System.Windows.Forms.Label();
            this.Doctor_tab = new System.Windows.Forms.TabPage();
            this.manage_doctors = new System.Windows.Forms.Label();
            this.DctrInfo_btn = new System.Windows.Forms.Button();
            this.Spec_combobox = new System.Windows.Forms.ComboBox();
            this.DctrSp_lbl = new System.Windows.Forms.Label();
            this.Room_tab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.StsInfo_btn = new System.Windows.Forms.Button();
            this.RoomNo_lbl = new System.Windows.Forms.Label();
            this.RoomNo_txtbox_c = new System.Windows.Forms.ComboBox();
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
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(671, 446);
            this.tabControl1.TabIndex = 2;
            // 
            // Dashboard_tab
            // 
            this.Dashboard_tab.Controls.Add(this.choices_lbl);
            this.Dashboard_tab.Controls.Add(this.Hereucan_lbl);
            this.Dashboard_tab.Controls.Add(this.Recetionist_name_label);
            this.Dashboard_tab.Controls.Add(this.welcome_lbl);
            this.Dashboard_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_tab.Location = new System.Drawing.Point(4, 25);
            this.Dashboard_tab.Name = "Dashboard_tab";
            this.Dashboard_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Dashboard_tab.Size = new System.Drawing.Size(663, 417);
            this.Dashboard_tab.TabIndex = 0;
            this.Dashboard_tab.Text = "Dashboard";
            this.Dashboard_tab.UseVisualStyleBackColor = true;
            this.Dashboard_tab.Click += new System.EventHandler(this.Dashboard_tab_Click);
            // 
            // choices_lbl
            // 
            this.choices_lbl.AutoSize = true;
            this.choices_lbl.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choices_lbl.Location = new System.Drawing.Point(200, 142);
            this.choices_lbl.Name = "choices_lbl";
            this.choices_lbl.Size = new System.Drawing.Size(249, 207);
            this.choices_lbl.TabIndex = 6;
            this.choices_lbl.Text = "- Register Patients\r\n\r\n- View paitent reports\r\n\r\n- Check doctor status\r\n\r\n- Check" +
    " room status\r\n\r\n(Just navigate through tabs)";
            // 
            // Hereucan_lbl
            // 
            this.Hereucan_lbl.AutoSize = true;
            this.Hereucan_lbl.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hereucan_lbl.Location = new System.Drawing.Point(133, 107);
            this.Hereucan_lbl.Name = "Hereucan_lbl";
            this.Hereucan_lbl.Size = new System.Drawing.Size(140, 25);
            this.Hereucan_lbl.TabIndex = 5;
            this.Hereucan_lbl.Text = "Here you can:";
            // 
            // Recetionist_name_label
            // 
            this.Recetionist_name_label.AutoSize = true;
            this.Recetionist_name_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recetionist_name_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Recetionist_name_label.Location = new System.Drawing.Point(364, 26);
            this.Recetionist_name_label.Name = "Recetionist_name_label";
            this.Recetionist_name_label.Size = new System.Drawing.Size(85, 33);
            this.Recetionist_name_label.TabIndex = 4;
            this.Recetionist_name_label.Text = "Name";
            this.Recetionist_name_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_lbl.Location = new System.Drawing.Point(68, 26);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(301, 35);
            this.welcome_lbl.TabIndex = 3;
            this.welcome_lbl.Text = "Welcome Receptionist";
            // 
            // Patient_tab
            // 
            this.Patient_tab.Controls.Add(this.patients_manage);
            this.Patient_tab.Controls.Add(this.appoint_dr_btn);
            this.Patient_tab.Controls.Add(this.ViewRprt_btn);
            this.Patient_tab.Controls.Add(this.RegPat_btn);
            this.Patient_tab.Controls.Add(this.CNIC_txtbox);
            this.Patient_tab.Controls.Add(this.PatCNIC_lbl);
            this.Patient_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_tab.Location = new System.Drawing.Point(4, 25);
            this.Patient_tab.Name = "Patient_tab";
            this.Patient_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Patient_tab.Size = new System.Drawing.Size(663, 417);
            this.Patient_tab.TabIndex = 1;
            this.Patient_tab.Text = "Patient";
            this.Patient_tab.UseVisualStyleBackColor = true;
            // 
            // patients_manage
            // 
            this.patients_manage.AutoSize = true;
            this.patients_manage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.patients_manage.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patients_manage.ForeColor = System.Drawing.SystemColors.GrayText;
            this.patients_manage.Location = new System.Drawing.Point(7, 15);
            this.patients_manage.Name = "patients_manage";
            this.patients_manage.Size = new System.Drawing.Size(230, 37);
            this.patients_manage.TabIndex = 5;
            this.patients_manage.Text = "Manage Patients";
            this.patients_manage.Click += new System.EventHandler(this.patients_manage_Click);
            // 
            // appoint_dr_btn
            // 
            this.appoint_dr_btn.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.appoint_dr_btn.Location = new System.Drawing.Point(232, 233);
            this.appoint_dr_btn.Name = "appoint_dr_btn";
            this.appoint_dr_btn.Size = new System.Drawing.Size(151, 54);
            this.appoint_dr_btn.TabIndex = 4;
            this.appoint_dr_btn.Text = "Appoint a Doctor";
            this.appoint_dr_btn.UseVisualStyleBackColor = true;
            this.appoint_dr_btn.Click += new System.EventHandler(this.Dctr_btn_Click);
            // 
            // ViewRprt_btn
            // 
            this.ViewRprt_btn.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.ViewRprt_btn.Location = new System.Drawing.Point(232, 322);
            this.ViewRprt_btn.Name = "ViewRprt_btn";
            this.ViewRprt_btn.Size = new System.Drawing.Size(151, 54);
            this.ViewRprt_btn.TabIndex = 3;
            this.ViewRprt_btn.Text = "View Patients History Report";
            this.ViewRprt_btn.UseVisualStyleBackColor = true;
            this.ViewRprt_btn.Click += new System.EventHandler(this.ViewRprt_btn_Click);
            // 
            // RegPat_btn
            // 
            this.RegPat_btn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegPat_btn.Location = new System.Drawing.Point(232, 149);
            this.RegPat_btn.Name = "RegPat_btn";
            this.RegPat_btn.Size = new System.Drawing.Size(151, 53);
            this.RegPat_btn.TabIndex = 2;
            this.RegPat_btn.Text = "Register Patient";
            this.RegPat_btn.UseVisualStyleBackColor = true;
            this.RegPat_btn.Click += new System.EventHandler(this.RegPat_btn_Click);
            // 
            // CNIC_txtbox
            // 
            this.CNIC_txtbox.Location = new System.Drawing.Point(232, 103);
            this.CNIC_txtbox.Name = "CNIC_txtbox";
            this.CNIC_txtbox.Size = new System.Drawing.Size(237, 22);
            this.CNIC_txtbox.TabIndex = 1;
            // 
            // PatCNIC_lbl
            // 
            this.PatCNIC_lbl.AutoSize = true;
            this.PatCNIC_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatCNIC_lbl.Location = new System.Drawing.Point(106, 100);
            this.PatCNIC_lbl.Name = "PatCNIC_lbl";
            this.PatCNIC_lbl.Size = new System.Drawing.Size(126, 23);
            this.PatCNIC_lbl.TabIndex = 0;
            this.PatCNIC_lbl.Text = "Patient CNIC :";
            this.PatCNIC_lbl.Click += new System.EventHandler(this.PatCNIC_lbl_Click);
            // 
            // Doctor_tab
            // 
            this.Doctor_tab.Controls.Add(this.manage_doctors);
            this.Doctor_tab.Controls.Add(this.DctrInfo_btn);
            this.Doctor_tab.Controls.Add(this.Spec_combobox);
            this.Doctor_tab.Controls.Add(this.DctrSp_lbl);
            this.Doctor_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctor_tab.Location = new System.Drawing.Point(4, 25);
            this.Doctor_tab.Name = "Doctor_tab";
            this.Doctor_tab.Size = new System.Drawing.Size(663, 417);
            this.Doctor_tab.TabIndex = 2;
            this.Doctor_tab.Text = "Doctor";
            this.Doctor_tab.UseVisualStyleBackColor = true;
            // 
            // manage_doctors
            // 
            this.manage_doctors.AutoSize = true;
            this.manage_doctors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.manage_doctors.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manage_doctors.ForeColor = System.Drawing.SystemColors.GrayText;
            this.manage_doctors.Location = new System.Drawing.Point(7, 15);
            this.manage_doctors.Name = "manage_doctors";
            this.manage_doctors.Size = new System.Drawing.Size(227, 37);
            this.manage_doctors.TabIndex = 6;
            this.manage_doctors.Text = "Manage Doctors";
            // 
            // DctrInfo_btn
            // 
            this.DctrInfo_btn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.DctrInfo_btn.Location = new System.Drawing.Point(300, 203);
            this.DctrInfo_btn.Name = "DctrInfo_btn";
            this.DctrInfo_btn.Size = new System.Drawing.Size(173, 64);
            this.DctrInfo_btn.TabIndex = 3;
            this.DctrInfo_btn.Text = "Doctor Info";
            this.DctrInfo_btn.UseVisualStyleBackColor = true;
            this.DctrInfo_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Spec_combobox
            // 
            this.Spec_combobox.FormattingEnabled = true;
            this.Spec_combobox.Items.AddRange(new object[] {
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
            this.Spec_combobox.Location = new System.Drawing.Point(300, 137);
            this.Spec_combobox.Name = "Spec_combobox";
            this.Spec_combobox.Size = new System.Drawing.Size(238, 24);
            this.Spec_combobox.TabIndex = 1;
            this.Spec_combobox.SelectedIndexChanged += new System.EventHandler(this.Spcls_combo_SelectedIndexChanged);
            // 
            // DctrSp_lbl
            // 
            this.DctrSp_lbl.AutoSize = true;
            this.DctrSp_lbl.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.DctrSp_lbl.Location = new System.Drawing.Point(75, 132);
            this.DctrSp_lbl.Name = "DctrSp_lbl";
            this.DctrSp_lbl.Size = new System.Drawing.Size(219, 25);
            this.DctrSp_lbl.TabIndex = 0;
            this.DctrSp_lbl.Text = "Doctor Specialization :";
            // 
            // Room_tab
            // 
            this.Room_tab.Controls.Add(this.RoomNo_txtbox_c);
            this.Room_tab.Controls.Add(this.label1);
            this.Room_tab.Controls.Add(this.StsInfo_btn);
            this.Room_tab.Controls.Add(this.RoomNo_lbl);
            this.Room_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_tab.Location = new System.Drawing.Point(4, 25);
            this.Room_tab.Name = "Room_tab";
            this.Room_tab.Size = new System.Drawing.Size(663, 417);
            this.Room_tab.TabIndex = 3;
            this.Room_tab.Text = "Room";
            this.Room_tab.UseVisualStyleBackColor = true;
            this.Room_tab.Click += new System.EventHandler(this.Room_tab_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "View Rooms";
            // 
            // StsInfo_btn
            // 
            this.StsInfo_btn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.StsInfo_btn.Location = new System.Drawing.Point(224, 201);
            this.StsInfo_btn.Name = "StsInfo_btn";
            this.StsInfo_btn.Size = new System.Drawing.Size(153, 55);
            this.StsInfo_btn.TabIndex = 2;
            this.StsInfo_btn.Text = "Room Information";
            this.StsInfo_btn.UseVisualStyleBackColor = true;
            this.StsInfo_btn.Click += new System.EventHandler(this.StsInfo_btn_Click);
            // 
            // RoomNo_lbl
            // 
            this.RoomNo_lbl.AutoSize = true;
            this.RoomNo_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNo_lbl.Location = new System.Drawing.Point(123, 139);
            this.RoomNo_lbl.Name = "RoomNo_lbl";
            this.RoomNo_lbl.Size = new System.Drawing.Size(95, 23);
            this.RoomNo_lbl.TabIndex = 0;
            this.RoomNo_lbl.Text = "Room No :";
            this.RoomNo_lbl.Click += new System.EventHandler(this.RoomNo_lbl_Click);
            // 
            // RoomNo_txtbox_c
            // 
            this.RoomNo_txtbox_c.FormattingEnabled = true;
            this.RoomNo_txtbox_c.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.RoomNo_txtbox_c.Location = new System.Drawing.Point(224, 138);
            this.RoomNo_txtbox_c.Name = "RoomNo_txtbox_c";
            this.RoomNo_txtbox_c.Size = new System.Drawing.Size(197, 24);
            this.RoomNo_txtbox_c.TabIndex = 8;
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label Recetionist_name_label;
        private System.Windows.Forms.Label welcome_lbl;
        private System.Windows.Forms.Label Hereucan_lbl;
        private System.Windows.Forms.Label choices_lbl;
        private System.Windows.Forms.Label PatCNIC_lbl;
        private System.Windows.Forms.Button appoint_dr_btn;
        private System.Windows.Forms.Button ViewRprt_btn;
        private System.Windows.Forms.Button RegPat_btn;
        private System.Windows.Forms.TextBox CNIC_txtbox;
        private System.Windows.Forms.Label DctrSp_lbl;
        private System.Windows.Forms.Button DctrInfo_btn;
        private System.Windows.Forms.ComboBox Spec_combobox;
        private System.Windows.Forms.Button StsInfo_btn;
        private System.Windows.Forms.Label RoomNo_lbl;
        private System.Windows.Forms.Label patients_manage;
        private System.Windows.Forms.Label manage_doctors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RoomNo_txtbox_c;
    }
}