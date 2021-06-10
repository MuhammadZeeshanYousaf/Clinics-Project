
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
            this.unchecked_pat_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.patients_manage = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dr_appointed_listBox = new System.Windows.Forms.ListBox();
            this.pat_healthProblem_listBox = new System.Windows.Forms.ListBox();
            this.pat_name_listBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pat_cnic_listBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checked_pat_btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Dash_tab.SuspendLayout();
            this.Patient_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Dash_tab);
            this.tabControl1.Controls.Add(this.Patient_tab);
            this.tabControl1.Controls.Add(this.tabPage1);
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
            this.Patient_tab.Controls.Add(this.checked_pat_btn);
            this.Patient_tab.Controls.Add(this.unchecked_pat_btn);
            this.Patient_tab.Controls.Add(this.label2);
            this.Patient_tab.Controls.Add(this.patients_manage);
            this.Patient_tab.Location = new System.Drawing.Point(4, 25);
            this.Patient_tab.Name = "Patient_tab";
            this.Patient_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Patient_tab.Size = new System.Drawing.Size(679, 421);
            this.Patient_tab.TabIndex = 1;
            this.Patient_tab.Text = "Patients";
            this.Patient_tab.UseVisualStyleBackColor = true;
            // 
            // unchecked_pat_btn
            // 
            this.unchecked_pat_btn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.unchecked_pat_btn.Location = new System.Drawing.Point(107, 210);
            this.unchecked_pat_btn.Name = "unchecked_pat_btn";
            this.unchecked_pat_btn.Size = new System.Drawing.Size(175, 60);
            this.unchecked_pat_btn.TabIndex = 8;
            this.unchecked_pat_btn.Text = "UnChecked Patients";
            this.unchecked_pat_btn.UseVisualStyleBackColor = true;
            this.unchecked_pat_btn.Click += new System.EventHandler(this.unchecked_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(53, 123);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.refresh_btn);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dr_appointed_listBox);
            this.tabPage1.Controls.Add(this.pat_healthProblem_listBox);
            this.tabPage1.Controls.Add(this.pat_name_listBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.pat_cnic_listBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(679, 421);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Appointed Patients";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.refresh_btn.Location = new System.Drawing.Point(574, 16);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(97, 36);
            this.refresh_btn.TabIndex = 17;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(515, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Doctor Appointed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(301, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Health Problem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Patient Name";
            // 
            // dr_appointed_listBox
            // 
            this.dr_appointed_listBox.FormattingEnabled = true;
            this.dr_appointed_listBox.ItemHeight = 16;
            this.dr_appointed_listBox.Location = new System.Drawing.Point(519, 109);
            this.dr_appointed_listBox.Name = "dr_appointed_listBox";
            this.dr_appointed_listBox.Size = new System.Drawing.Size(152, 276);
            this.dr_appointed_listBox.TabIndex = 13;
            // 
            // pat_healthProblem_listBox
            // 
            this.pat_healthProblem_listBox.FormattingEnabled = true;
            this.pat_healthProblem_listBox.ItemHeight = 16;
            this.pat_healthProblem_listBox.Location = new System.Drawing.Point(305, 109);
            this.pat_healthProblem_listBox.Name = "pat_healthProblem_listBox";
            this.pat_healthProblem_listBox.Size = new System.Drawing.Size(208, 276);
            this.pat_healthProblem_listBox.TabIndex = 11;
            // 
            // pat_name_listBox
            // 
            this.pat_name_listBox.FormattingEnabled = true;
            this.pat_name_listBox.ItemHeight = 16;
            this.pat_name_listBox.Location = new System.Drawing.Point(139, 109);
            this.pat_name_listBox.Name = "pat_name_listBox";
            this.pat_name_listBox.Size = new System.Drawing.Size(160, 276);
            this.pat_name_listBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Patient CNIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Appointed View Patients";
            // 
            // pat_cnic_listBox
            // 
            this.pat_cnic_listBox.FormattingEnabled = true;
            this.pat_cnic_listBox.ItemHeight = 16;
            this.pat_cnic_listBox.Location = new System.Drawing.Point(7, 109);
            this.pat_cnic_listBox.Name = "pat_cnic_listBox";
            this.pat_cnic_listBox.Size = new System.Drawing.Size(126, 276);
            this.pat_cnic_listBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.button1.Location = new System.Drawing.Point(380, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 56);
            this.button1.TabIndex = 18;
            this.button1.Text = "Mark Top Patient Checked";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // checked_pat_btn
            // 
            this.checked_pat_btn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.checked_pat_btn.Location = new System.Drawing.Point(392, 210);
            this.checked_pat_btn.Name = "checked_pat_btn";
            this.checked_pat_btn.Size = new System.Drawing.Size(175, 60);
            this.checked_pat_btn.TabIndex = 9;
            this.checked_pat_btn.Text = "Checked Patients";
            this.checked_pat_btn.UseVisualStyleBackColor = true;
            this.checked_pat_btn.Click += new System.EventHandler(this.checked_pat_btn_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 452);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.tabControl1.ResumeLayout(false);
            this.Dash_tab.ResumeLayout(false);
            this.Dash_tab.PerformLayout();
            this.Patient_tab.ResumeLayout(false);
            this.Patient_tab.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Dash_tab;
        private System.Windows.Forms.Label welcome_lbl;
        private System.Windows.Forms.TabPage Patient_tab;
        private System.Windows.Forms.Label Doctor_name_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label choices_lbl;
        private System.Windows.Forms.Label patients_manage;
        private System.Windows.Forms.Button unchecked_pat_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox dr_appointed_listBox;
        private System.Windows.Forms.ListBox pat_healthProblem_listBox;
        private System.Windows.Forms.ListBox pat_name_listBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox pat_cnic_listBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button checked_pat_btn;
    }
}