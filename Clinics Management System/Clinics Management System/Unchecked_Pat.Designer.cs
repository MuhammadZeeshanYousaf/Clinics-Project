
namespace Clinics_Management_System
{
    partial class Unchecked_Pat
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
            this.PatQue_lbl = new System.Windows.Forms.Label();
            this.CNICShow_lstbox = new System.Windows.Forms.ListBox();
            this.NameShow_lstbox = new System.Windows.Forms.ListBox();
            this.PatCNIC_lbl = new System.Windows.Forms.Label();
            this.PatName_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PatQue_lbl
            // 
            this.PatQue_lbl.AutoSize = true;
            this.PatQue_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold);
            this.PatQue_lbl.Location = new System.Drawing.Point(199, 39);
            this.PatQue_lbl.Name = "PatQue_lbl";
            this.PatQue_lbl.Size = new System.Drawing.Size(399, 39);
            this.PatQue_lbl.TabIndex = 0;
            this.PatQue_lbl.Text = "Unchecked Patients Queue";
            // 
            // CNICShow_lstbox
            // 
            this.CNICShow_lstbox.FormattingEnabled = true;
            this.CNICShow_lstbox.Location = new System.Drawing.Point(186, 148);
            this.CNICShow_lstbox.Name = "CNICShow_lstbox";
            this.CNICShow_lstbox.Size = new System.Drawing.Size(173, 212);
            this.CNICShow_lstbox.TabIndex = 1;
            // 
            // NameShow_lstbox
            // 
            this.NameShow_lstbox.FormattingEnabled = true;
            this.NameShow_lstbox.Location = new System.Drawing.Point(456, 148);
            this.NameShow_lstbox.Name = "NameShow_lstbox";
            this.NameShow_lstbox.Size = new System.Drawing.Size(173, 212);
            this.NameShow_lstbox.TabIndex = 2;
            // 
            // PatCNIC_lbl
            // 
            this.PatCNIC_lbl.AutoSize = true;
            this.PatCNIC_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.PatCNIC_lbl.Location = new System.Drawing.Point(202, 112);
            this.PatCNIC_lbl.Name = "PatCNIC_lbl";
            this.PatCNIC_lbl.Size = new System.Drawing.Size(117, 23);
            this.PatCNIC_lbl.TabIndex = 3;
            this.PatCNIC_lbl.Text = "Patient CNIC";
            // 
            // PatName_lbl
            // 
            this.PatName_lbl.AutoSize = true;
            this.PatName_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.PatName_lbl.Location = new System.Drawing.Point(474, 112);
            this.PatName_lbl.Name = "PatName_lbl";
            this.PatName_lbl.Size = new System.Drawing.Size(124, 23);
            this.PatName_lbl.TabIndex = 4;
            this.PatName_lbl.Text = "Patient Name";
            // 
            // Unchecked_Pat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PatName_lbl);
            this.Controls.Add(this.PatCNIC_lbl);
            this.Controls.Add(this.NameShow_lstbox);
            this.Controls.Add(this.CNICShow_lstbox);
            this.Controls.Add(this.PatQue_lbl);
            this.Name = "Unchecked_Pat";
            this.Text = "Unchecked Patients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatQue_lbl;
        private System.Windows.Forms.ListBox CNICShow_lstbox;
        private System.Windows.Forms.ListBox NameShow_lstbox;
        private System.Windows.Forms.Label PatCNIC_lbl;
        private System.Windows.Forms.Label PatName_lbl;
    }
}