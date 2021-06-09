
namespace Clinics_Management_System
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Dash_tab = new System.Windows.Forms.TabPage();
            this.choices_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Doctor_name_label = new System.Windows.Forms.Label();
            this.welcome_lbl = new System.Windows.Forms.Label();
            this.Patient_tab = new System.Windows.Forms.TabPage();
            this.unchecked_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.patients_manage = new System.Windows.Forms.Label();
            this.MarkPat_btn = new System.Windows.Forms.Button();
            this.CNIC_txtbox = new System.Windows.Forms.TextBox();
            this.PatCNIC_lbl = new System.Windows.Forms.Label();
            this.ChkdPat_btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Dash_tab.SuspendLayout();
            this.Patient_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Dash_tab);
            this.tabControl1.Controls.Add(this.Patient_tab);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(687, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // Dash_tab
            // 
            this.Dash_tab.Controls.Add(this.choices_lbl);
            this.Dash_tab.Controls.Add(this.label1);
            this.Dash_tab.Controls.Add(this.Doctor_name_label);
            this.Dash_tab.Controls.Add(this.welcome_lbl);
            this.Dash_tab.Location = new System.Drawing.Point(4, 25);
            this.Dash_tab.Name = "Dash_tab";
            this.Dash_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Dash_tab.Size = new System.Drawing.Size(679, 421);
            this.Dash_tab.TabIndex = 0;
            this.Dash_tab.Text = "Dashboard";
            this.Dash_tab.UseVisualStyleBackColor = true;
            // 
            // choices_lbl
            // 
            this.choices_lbl.AutoSize = true;
            this.choices_lbl.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choices_lbl.Location = new System.Drawing.Point(203, 179);
            this.choices_lbl.Name = "choices_lbl";
            this.choices_lbl.Size = new System.Drawing.Size(249, 115);
            this.choices_lbl.TabIndex = 7;
            this.choices_lbl.Text = "- View your Patients\r\n\r\n- View Patients Queue\r\n\r\n(Just navigate through tabs)";
            this.choices_lbl.Click += new System.EventHandler(this.choices_lbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Here you can:";
            // 
            // Doctor_name_label
            // 
            this.Doctor_name_label.AutoSize = true;
            this.Doctor_name_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctor_name_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Doctor_name_label.Location = new System.Drawing.Point(301, 34);
            this.Doctor_name_label.Name = "Doctor_name_label";
            this.Doctor_name_label.Size = new System.Drawing.Size(85, 33);
            this.Doctor_name_label.TabIndex = 5;
            this.Doctor_name_label.Text = "Name";
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold);
            this.welcome_lbl.Location = new System.Drawing.Point(78, 32);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(228, 35);
            this.welcome_lbl.TabIndex = 0;
            this.welcome_lbl.Text = "Welcome Doctor";
            // 
            // Patient_tab
            // 
            this.Patient_tab.Controls.Add(this.unchecked_btn);
            this.Patient_tab.Controls.Add(this.label2);
            this.Patient_tab.Controls.Add(this.patients_manage);
            this.Patient_tab.Controls.Add(this.MarkPat_btn);
            this.Patient_tab.Controls.Add(this.CNIC_txtbox);
            this.Patient_tab.Controls.Add(this.PatCNIC_lbl);
            this.Patient_tab.Controls.Add(this.ChkdPat_btn);
            this.Patient_tab.Location = new System.Drawing.Point(4, 25);
            this.Patient_tab.Name = "Patient_tab";
            this.Patient_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Patient_tab.Size = new System.Drawing.Size(679, 421);
            this.Patient_tab.TabIndex = 1;
            this.Patient_tab.Text = "Patients";
            this.Patient_tab.UseVisualStyleBackColor = true;
            // 
            // unchecked_btn
            // 
            this.unchecked_btn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.unchecked_btn.Location = new System.Drawing.Point(117, 303);
            this.unchecked_btn.Name = "unchecked_btn";
            this.unchecked_btn.Size = new System.Drawing.Size(175, 60);
            this.unchecked_btn.TabIndex = 8;
            this.unchecked_btn.Text = "UnChecked Patients";
            this.unchecked_btn.UseVisualStyleBackColor = true;
            this.unchecked_btn.Click += new System.EventHandler(this.unchecked_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(53, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(578, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "___________________________________Pateints View_________________________________" +
    "__";
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
            this.patients_manage.TabIndex = 6;
            this.patients_manage.Text = "Manage Patients";
            // 
            // MarkPat_btn
            // 
            this.MarkPat_btn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.MarkPat_btn.Location = new System.Drawing.Point(239, 171);
            this.MarkPat_btn.Name = "MarkPat_btn";
            this.MarkPat_btn.Size = new System.Drawing.Size(175, 36);
            this.MarkPat_btn.TabIndex = 4;
            this.MarkPat_btn.Text = "Mark Patient Checked";
            this.MarkPat_btn.UseVisualStyleBackColor = true;
            this.MarkPat_btn.Click += new System.EventHandler(this.MarkPat_btn_Click);
            // 
            // CNIC_txtbox
            // 
            this.CNIC_txtbox.Font = new System.Drawing.Font("Bahnschrift", 13.5F);
            this.CNIC_txtbox.Location = new System.Drawing.Point(239, 118);
            this.CNIC_txtbox.Name = "CNIC_txtbox";
            this.CNIC_txtbox.Size = new System.Drawing.Size(236, 29);
            this.CNIC_txtbox.TabIndex = 3;
            // 
            // PatCNIC_lbl
            // 
            this.PatCNIC_lbl.AutoSize = true;
            this.PatCNIC_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.PatCNIC_lbl.Location = new System.Drawing.Point(113, 120);
            this.PatCNIC_lbl.Name = "PatCNIC_lbl";
            this.PatCNIC_lbl.Size = new System.Drawing.Size(126, 23);
            this.PatCNIC_lbl.TabIndex = 2;
            this.PatCNIC_lbl.Text = "Patient CNIC :";
            // 
            // ChkdPat_btn
            // 
            this.ChkdPat_btn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.ChkdPat_btn.Location = new System.Drawing.Point(394, 303);
            this.ChkdPat_btn.Name = "ChkdPat_btn";
            this.ChkdPat_btn.Size = new System.Drawing.Size(175, 60);
            this.ChkdPat_btn.TabIndex = 1;
            this.ChkdPat_btn.Text = "Checked Patients";
            this.ChkdPat_btn.UseVisualStyleBackColor = true;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.tabControl1.ResumeLayout(false);
            this.Dash_tab.ResumeLayout(false);
            this.Dash_tab.PerformLayout();
            this.Patient_tab.ResumeLayout(false);
            this.Patient_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Dash_tab;
        private System.Windows.Forms.Label welcome_lbl;
        private System.Windows.Forms.TabPage Patient_tab;
        private System.Windows.Forms.Label PatCNIC_lbl;
        private System.Windows.Forms.Button ChkdPat_btn;
        private System.Windows.Forms.TextBox CNIC_txtbox;
        private System.Windows.Forms.Button MarkPat_btn;
        private System.Windows.Forms.Label Doctor_name_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label choices_lbl;
        private System.Windows.Forms.Label patients_manage;
        private System.Windows.Forms.Button unchecked_btn;
        private System.Windows.Forms.Label label2;
    }
}