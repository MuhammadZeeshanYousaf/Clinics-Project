
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Dash_tab = new System.Windows.Forms.TabPage();
            this.Patient_tab = new System.Windows.Forms.TabPage();
            this.welcome_lbl = new System.Windows.Forms.Label();
            this.DrNameShow_lbl = new System.Windows.Forms.Label();
            this.HereUcan_lbl = new System.Windows.Forms.Label();
            this.OptionsShow_lbl = new System.Windows.Forms.Label();
            this.UnchkdPat_btn = new System.Windows.Forms.Button();
            this.ChkdPat_btn = new System.Windows.Forms.Button();
            this.PatCNIC_lbl = new System.Windows.Forms.Label();
            this.CNIC_txtbox = new System.Windows.Forms.TextBox();
            this.MarkPat_btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Dash_tab.SuspendLayout();
            this.Patient_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Dash_tab);
            this.tabControl1.Controls.Add(this.Patient_tab);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // Dash_tab
            // 
            this.Dash_tab.Controls.Add(this.OptionsShow_lbl);
            this.Dash_tab.Controls.Add(this.HereUcan_lbl);
            this.Dash_tab.Controls.Add(this.DrNameShow_lbl);
            this.Dash_tab.Controls.Add(this.welcome_lbl);
            this.Dash_tab.Location = new System.Drawing.Point(4, 22);
            this.Dash_tab.Name = "Dash_tab";
            this.Dash_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Dash_tab.Size = new System.Drawing.Size(790, 424);
            this.Dash_tab.TabIndex = 0;
            this.Dash_tab.Text = "Dashboard";
            this.Dash_tab.UseVisualStyleBackColor = true;
            // 
            // Patient_tab
            // 
            this.Patient_tab.Controls.Add(this.MarkPat_btn);
            this.Patient_tab.Controls.Add(this.CNIC_txtbox);
            this.Patient_tab.Controls.Add(this.PatCNIC_lbl);
            this.Patient_tab.Controls.Add(this.ChkdPat_btn);
            this.Patient_tab.Controls.Add(this.UnchkdPat_btn);
            this.Patient_tab.Location = new System.Drawing.Point(4, 22);
            this.Patient_tab.Name = "Patient_tab";
            this.Patient_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Patient_tab.Size = new System.Drawing.Size(790, 424);
            this.Patient_tab.TabIndex = 1;
            this.Patient_tab.Text = "Patients";
            this.Patient_tab.UseVisualStyleBackColor = true;
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold);
            this.welcome_lbl.Location = new System.Drawing.Point(96, 37);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(134, 35);
            this.welcome_lbl.TabIndex = 0;
            this.welcome_lbl.Text = "Welcome";
            // 
            // DrNameShow_lbl
            // 
            this.DrNameShow_lbl.AutoSize = true;
            this.DrNameShow_lbl.Font = new System.Drawing.Font("Bahnschrift Light", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.DrNameShow_lbl.Location = new System.Drawing.Point(236, 39);
            this.DrNameShow_lbl.Name = "DrNameShow_lbl";
            this.DrNameShow_lbl.Size = new System.Drawing.Size(205, 33);
            this.DrNameShow_lbl.TabIndex = 1;
            this.DrNameShow_lbl.Text = "Doctor\'s Name";
            // 
            // HereUcan_lbl
            // 
            this.HereUcan_lbl.AutoSize = true;
            this.HereUcan_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.HereUcan_lbl.Location = new System.Drawing.Point(97, 146);
            this.HereUcan_lbl.Name = "HereUcan_lbl";
            this.HereUcan_lbl.Size = new System.Drawing.Size(140, 25);
            this.HereUcan_lbl.TabIndex = 2;
            this.HereUcan_lbl.Text = "Here you can:";
            // 
            // OptionsShow_lbl
            // 
            this.OptionsShow_lbl.AutoSize = true;
            this.OptionsShow_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.OptionsShow_lbl.Location = new System.Drawing.Point(242, 205);
            this.OptionsShow_lbl.Name = "OptionsShow_lbl";
            this.OptionsShow_lbl.Size = new System.Drawing.Size(279, 161);
            this.OptionsShow_lbl.TabIndex = 3;
            this.OptionsShow_lbl.Text = "- View your patients\r\n\r\n-View Patient Queue\r\n\r\n-Manage your profile\r\n\r\nJUST NAVIG" +
    "ATE THROUGH TABS";
            // 
            // UnchkdPat_btn
            // 
            this.UnchkdPat_btn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.UnchkdPat_btn.Location = new System.Drawing.Point(202, 229);
            this.UnchkdPat_btn.Name = "UnchkdPat_btn";
            this.UnchkdPat_btn.Size = new System.Drawing.Size(175, 28);
            this.UnchkdPat_btn.TabIndex = 0;
            this.UnchkdPat_btn.Text = "Unchecked Patient";
            this.UnchkdPat_btn.UseVisualStyleBackColor = true;
            // 
            // ChkdPat_btn
            // 
            this.ChkdPat_btn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.ChkdPat_btn.Location = new System.Drawing.Point(484, 229);
            this.ChkdPat_btn.Name = "ChkdPat_btn";
            this.ChkdPat_btn.Size = new System.Drawing.Size(175, 28);
            this.ChkdPat_btn.TabIndex = 1;
            this.ChkdPat_btn.Text = "Checked Patients";
            this.ChkdPat_btn.UseVisualStyleBackColor = true;
            // 
            // PatCNIC_lbl
            // 
            this.PatCNIC_lbl.AutoSize = true;
            this.PatCNIC_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.PatCNIC_lbl.Location = new System.Drawing.Point(187, 56);
            this.PatCNIC_lbl.Name = "PatCNIC_lbl";
            this.PatCNIC_lbl.Size = new System.Drawing.Size(120, 23);
            this.PatCNIC_lbl.TabIndex = 2;
            this.PatCNIC_lbl.Text = "Patient CNIC:";
            // 
            // CNIC_txtbox
            // 
            this.CNIC_txtbox.Font = new System.Drawing.Font("Bahnschrift", 13.5F);
            this.CNIC_txtbox.Location = new System.Drawing.Point(313, 54);
            this.CNIC_txtbox.Name = "CNIC_txtbox";
            this.CNIC_txtbox.Size = new System.Drawing.Size(236, 29);
            this.CNIC_txtbox.TabIndex = 3;
            // 
            // MarkPat_btn
            // 
            this.MarkPat_btn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.MarkPat_btn.Location = new System.Drawing.Point(344, 110);
            this.MarkPat_btn.Name = "MarkPat_btn";
            this.MarkPat_btn.Size = new System.Drawing.Size(175, 28);
            this.MarkPat_btn.TabIndex = 4;
            this.MarkPat_btn.Text = "Mark Patient Checked";
            this.MarkPat_btn.UseVisualStyleBackColor = true;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
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
        private System.Windows.Forms.Label DrNameShow_lbl;
        private System.Windows.Forms.Label HereUcan_lbl;
        private System.Windows.Forms.Label OptionsShow_lbl;
        private System.Windows.Forms.Label PatCNIC_lbl;
        private System.Windows.Forms.Button ChkdPat_btn;
        private System.Windows.Forms.Button UnchkdPat_btn;
        private System.Windows.Forms.TextBox CNIC_txtbox;
        private System.Windows.Forms.Button MarkPat_btn;
    }
}