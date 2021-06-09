namespace Clinics_Management_System
{
    partial class Checked_Pat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checked_Pat));
            this.button1 = new System.Windows.Forms.Button();
            this.PatName_lbl = new System.Windows.Forms.Label();
            this.PatCNIC_lbl = new System.Windows.Forms.Label();
            this.NameShow_lstbox = new System.Windows.Forms.ListBox();
            this.CNICShow_lstbox = new System.Windows.Forms.ListBox();
            this.PatQue_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.button1.Location = new System.Drawing.Point(569, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 42);
            this.button1.TabIndex = 20;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PatName_lbl
            // 
            this.PatName_lbl.AutoSize = true;
            this.PatName_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.PatName_lbl.Location = new System.Drawing.Point(337, 109);
            this.PatName_lbl.Name = "PatName_lbl";
            this.PatName_lbl.Size = new System.Drawing.Size(124, 23);
            this.PatName_lbl.TabIndex = 19;
            this.PatName_lbl.Text = "Patient Name";
            // 
            // PatCNIC_lbl
            // 
            this.PatCNIC_lbl.AutoSize = true;
            this.PatCNIC_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.PatCNIC_lbl.Location = new System.Drawing.Point(158, 109);
            this.PatCNIC_lbl.Name = "PatCNIC_lbl";
            this.PatCNIC_lbl.Size = new System.Drawing.Size(117, 23);
            this.PatCNIC_lbl.TabIndex = 18;
            this.PatCNIC_lbl.Text = "Patient CNIC";
            // 
            // NameShow_lstbox
            // 
            this.NameShow_lstbox.FormattingEnabled = true;
            this.NameShow_lstbox.Location = new System.Drawing.Point(341, 145);
            this.NameShow_lstbox.Name = "NameShow_lstbox";
            this.NameShow_lstbox.Size = new System.Drawing.Size(173, 238);
            this.NameShow_lstbox.TabIndex = 17;
            // 
            // CNICShow_lstbox
            // 
            this.CNICShow_lstbox.FormattingEnabled = true;
            this.CNICShow_lstbox.Location = new System.Drawing.Point(162, 145);
            this.CNICShow_lstbox.Name = "CNICShow_lstbox";
            this.CNICShow_lstbox.Size = new System.Drawing.Size(173, 238);
            this.CNICShow_lstbox.TabIndex = 16;
            // 
            // PatQue_lbl
            // 
            this.PatQue_lbl.AutoSize = true;
            this.PatQue_lbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PatQue_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PatQue_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold);
            this.PatQue_lbl.ForeColor = System.Drawing.Color.Navy;
            this.PatQue_lbl.Location = new System.Drawing.Point(201, 36);
            this.PatQue_lbl.Name = "PatQue_lbl";
            this.PatQue_lbl.Size = new System.Drawing.Size(266, 41);
            this.PatQue_lbl.TabIndex = 15;
            this.PatQue_lbl.Text = "Checked Patients";
            // 
            // Checked_Pat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PatName_lbl);
            this.Controls.Add(this.PatCNIC_lbl);
            this.Controls.Add(this.NameShow_lstbox);
            this.Controls.Add(this.CNICShow_lstbox);
            this.Controls.Add(this.PatQue_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Checked_Pat";
            this.Text = "Checked Patients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PatName_lbl;
        private System.Windows.Forms.Label PatCNIC_lbl;
        private System.Windows.Forms.ListBox NameShow_lstbox;
        private System.Windows.Forms.ListBox CNICShow_lstbox;
        private System.Windows.Forms.Label PatQue_lbl;
    }
}