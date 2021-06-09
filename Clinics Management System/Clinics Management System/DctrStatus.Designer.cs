
namespace Clinics_Management_System
{
    partial class DrStatHead_lbl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrStatHead_lbl));
            this.DctrStat_lbl = new System.Windows.Forms.Label();
            this.DrSpec_lbl = new System.Windows.Forms.Label();
            this.DrName_lbl = new System.Windows.Forms.Label();
            this.Status_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NoPat_rbtn = new System.Windows.Forms.RadioButton();
            this.HavePat_rbtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // DctrStat_lbl
            // 
            this.DctrStat_lbl.AutoSize = true;
            this.DctrStat_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.DctrStat_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DctrStat_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold);
            this.DctrStat_lbl.ForeColor = System.Drawing.Color.Navy;
            this.DctrStat_lbl.Location = new System.Drawing.Point(215, 31);
            this.DctrStat_lbl.Name = "DctrStat_lbl";
            this.DctrStat_lbl.Size = new System.Drawing.Size(215, 41);
            this.DctrStat_lbl.TabIndex = 0;
            this.DctrStat_lbl.Text = "Doctor Status";
            // 
            // DrSpec_lbl
            // 
            this.DrSpec_lbl.AutoSize = true;
            this.DrSpec_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.DrSpec_lbl.Location = new System.Drawing.Point(154, 179);
            this.DrSpec_lbl.Name = "DrSpec_lbl";
            this.DrSpec_lbl.Size = new System.Drawing.Size(165, 23);
            this.DrSpec_lbl.TabIndex = 1;
            this.DrSpec_lbl.Text = "Dr. Specialization :";
            // 
            // DrName_lbl
            // 
            this.DrName_lbl.AutoSize = true;
            this.DrName_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.DrName_lbl.Location = new System.Drawing.Point(191, 126);
            this.DrName_lbl.Name = "DrName_lbl";
            this.DrName_lbl.Size = new System.Drawing.Size(128, 23);
            this.DrName_lbl.TabIndex = 2;
            this.DrName_lbl.Text = "Doctor Name :";
            // 
            // Status_lbl
            // 
            this.Status_lbl.AutoSize = true;
            this.Status_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.Status_lbl.Location = new System.Drawing.Point(245, 234);
            this.Status_lbl.Name = "Status_lbl";
            this.Status_lbl.Size = new System.Drawing.Size(74, 23);
            this.Status_lbl.TabIndex = 3;
            this.Status_lbl.Text = "Status :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.label1.Location = new System.Drawing.Point(325, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.label2.Location = new System.Drawing.Point(325, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Specialist";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.button1.Location = new System.Drawing.Point(574, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NoPat_rbtn
            // 
            this.NoPat_rbtn.AutoSize = true;
            this.NoPat_rbtn.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.NoPat_rbtn.Location = new System.Drawing.Point(330, 261);
            this.NoPat_rbtn.Name = "NoPat_rbtn";
            this.NoPat_rbtn.Size = new System.Drawing.Size(61, 23);
            this.NoPat_rbtn.TabIndex = 14;
            this.NoPat_rbtn.TabStop = true;
            this.NoPat_rbtn.Text = "Free";
            this.NoPat_rbtn.UseVisualStyleBackColor = true;
            // 
            // HavePat_rbtn
            // 
            this.HavePat_rbtn.AutoSize = true;
            this.HavePat_rbtn.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.HavePat_rbtn.Location = new System.Drawing.Point(330, 232);
            this.HavePat_rbtn.Name = "HavePat_rbtn";
            this.HavePat_rbtn.Size = new System.Drawing.Size(62, 23);
            this.HavePat_rbtn.TabIndex = 13;
            this.HavePat_rbtn.TabStop = true;
            this.HavePat_rbtn.Text = "Busy";
            this.HavePat_rbtn.UseVisualStyleBackColor = true;
            // 
            // DrStatHead_lbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 389);
            this.Controls.Add(this.NoPat_rbtn);
            this.Controls.Add(this.HavePat_rbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status_lbl);
            this.Controls.Add(this.DrName_lbl);
            this.Controls.Add(this.DrSpec_lbl);
            this.Controls.Add(this.DctrStat_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DrStatHead_lbl";
            this.Text = "Doctor Status";
            this.Load += new System.EventHandler(this.DctrStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DctrStat_lbl;
        private System.Windows.Forms.Label DrSpec_lbl;
        private System.Windows.Forms.Label DrName_lbl;
        private System.Windows.Forms.Label Status_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton NoPat_rbtn;
        private System.Windows.Forms.RadioButton HavePat_rbtn;
    }
}