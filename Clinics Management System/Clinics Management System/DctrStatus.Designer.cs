
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
            this.DctrStat_lbl = new System.Windows.Forms.Label();
            this.DrSpec_lbl = new System.Windows.Forms.Label();
            this.DrName_lbl = new System.Windows.Forms.Label();
            this.Status_lbl = new System.Windows.Forms.Label();
            this.IsAvailable_rbtn = new System.Windows.Forms.RadioButton();
            this.IsUnavailable_rbtn = new System.Windows.Forms.RadioButton();
            this.DrName_txtbox = new System.Windows.Forms.TextBox();
            this.DrSpec_txtbox = new System.Windows.Forms.TextBox();
            this.Close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DctrStat_lbl
            // 
            this.DctrStat_lbl.AutoSize = true;
            this.DctrStat_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold);
            this.DctrStat_lbl.Location = new System.Drawing.Point(289, 41);
            this.DctrStat_lbl.Name = "DctrStat_lbl";
            this.DctrStat_lbl.Size = new System.Drawing.Size(213, 39);
            this.DctrStat_lbl.TabIndex = 0;
            this.DctrStat_lbl.Text = "Doctor Status";
            // 
            // DrSpec_lbl
            // 
            this.DrSpec_lbl.AutoSize = true;
            this.DrSpec_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.DrSpec_lbl.Location = new System.Drawing.Point(133, 210);
            this.DrSpec_lbl.Name = "DrSpec_lbl";
            this.DrSpec_lbl.Size = new System.Drawing.Size(160, 23);
            this.DrSpec_lbl.TabIndex = 1;
            this.DrSpec_lbl.Text = "Dr. Specialization:";
            // 
            // DrName_lbl
            // 
            this.DrName_lbl.AutoSize = true;
            this.DrName_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.DrName_lbl.Location = new System.Drawing.Point(170, 154);
            this.DrName_lbl.Name = "DrName_lbl";
            this.DrName_lbl.Size = new System.Drawing.Size(123, 23);
            this.DrName_lbl.TabIndex = 2;
            this.DrName_lbl.Text = "Doctor Name:";
            // 
            // Status_lbl
            // 
            this.Status_lbl.AutoSize = true;
            this.Status_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.Status_lbl.Location = new System.Drawing.Point(224, 267);
            this.Status_lbl.Name = "Status_lbl";
            this.Status_lbl.Size = new System.Drawing.Size(69, 23);
            this.Status_lbl.TabIndex = 3;
            this.Status_lbl.Text = "Status:";
            // 
            // IsAvailable_rbtn
            // 
            this.IsAvailable_rbtn.AutoSize = true;
            this.IsAvailable_rbtn.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.IsAvailable_rbtn.Location = new System.Drawing.Point(320, 273);
            this.IsAvailable_rbtn.Name = "IsAvailable_rbtn";
            this.IsAvailable_rbtn.Size = new System.Drawing.Size(95, 23);
            this.IsAvailable_rbtn.TabIndex = 4;
            this.IsAvailable_rbtn.TabStop = true;
            this.IsAvailable_rbtn.Text = "Available";
            this.IsAvailable_rbtn.UseVisualStyleBackColor = true;
            // 
            // IsUnavailable_rbtn
            // 
            this.IsUnavailable_rbtn.AutoSize = true;
            this.IsUnavailable_rbtn.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.IsUnavailable_rbtn.Location = new System.Drawing.Point(320, 310);
            this.IsUnavailable_rbtn.Name = "IsUnavailable_rbtn";
            this.IsUnavailable_rbtn.Size = new System.Drawing.Size(113, 23);
            this.IsUnavailable_rbtn.TabIndex = 5;
            this.IsUnavailable_rbtn.TabStop = true;
            this.IsUnavailable_rbtn.Text = "Unavailable";
            this.IsUnavailable_rbtn.UseVisualStyleBackColor = true;
            // 
            // DrName_txtbox
            // 
            this.DrName_txtbox.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.DrName_txtbox.Location = new System.Drawing.Point(320, 156);
            this.DrName_txtbox.Name = "DrName_txtbox";
            this.DrName_txtbox.Size = new System.Drawing.Size(221, 30);
            this.DrName_txtbox.TabIndex = 6;
            // 
            // DrSpec_txtbox
            // 
            this.DrSpec_txtbox.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.DrSpec_txtbox.Location = new System.Drawing.Point(320, 212);
            this.DrSpec_txtbox.Name = "DrSpec_txtbox";
            this.DrSpec_txtbox.Size = new System.Drawing.Size(221, 30);
            this.DrSpec_txtbox.TabIndex = 7;
            this.DrSpec_txtbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Close_btn
            // 
            this.Close_btn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.Close_btn.Location = new System.Drawing.Point(674, 382);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(75, 27);
            this.Close_btn.TabIndex = 8;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            // 
            // DrStatHead_lbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.DrSpec_txtbox);
            this.Controls.Add(this.DrName_txtbox);
            this.Controls.Add(this.IsUnavailable_rbtn);
            this.Controls.Add(this.IsAvailable_rbtn);
            this.Controls.Add(this.Status_lbl);
            this.Controls.Add(this.DrName_lbl);
            this.Controls.Add(this.DrSpec_lbl);
            this.Controls.Add(this.DctrStat_lbl);
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
        private System.Windows.Forms.RadioButton IsAvailable_rbtn;
        private System.Windows.Forms.RadioButton IsUnavailable_rbtn;
        private System.Windows.Forms.TextBox DrName_txtbox;
        private System.Windows.Forms.TextBox DrSpec_txtbox;
        private System.Windows.Forms.Button Close_btn;
    }
}