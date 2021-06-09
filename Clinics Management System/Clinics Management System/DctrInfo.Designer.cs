
namespace Clinics_Management_System
{
    partial class DctrInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DctrInfo));
            this.InfoHeading_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.age_lbl = new System.Windows.Forms.Label();
            this.spcl_lbl = new System.Windows.Forms.Label();
            this.room_lbl = new System.Windows.Forms.Label();
            this.years_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dr_name_label = new System.Windows.Forms.Label();
            this.dr_spec_label = new System.Windows.Forms.Label();
            this.dr_age_label = new System.Windows.Forms.Label();
            this.dr_room_label = new System.Windows.Forms.Label();
            this.spec_details_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoHeading_lbl
            // 
            this.InfoHeading_lbl.AutoSize = true;
            this.InfoHeading_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoHeading_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold);
            this.InfoHeading_lbl.ForeColor = System.Drawing.Color.Navy;
            this.InfoHeading_lbl.Location = new System.Drawing.Point(197, 36);
            this.InfoHeading_lbl.Name = "InfoHeading_lbl";
            this.InfoHeading_lbl.Size = new System.Drawing.Size(288, 41);
            this.InfoHeading_lbl.TabIndex = 0;
            this.InfoHeading_lbl.Text = "Doctor Information";
            this.InfoHeading_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.name_lbl.Location = new System.Drawing.Point(206, 114);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(128, 23);
            this.name_lbl.TabIndex = 1;
            this.name_lbl.Text = "Doctor Name :";
            // 
            // age_lbl
            // 
            this.age_lbl.AutoSize = true;
            this.age_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.age_lbl.Location = new System.Drawing.Point(223, 214);
            this.age_lbl.Name = "age_lbl";
            this.age_lbl.Size = new System.Drawing.Size(111, 23);
            this.age_lbl.TabIndex = 2;
            this.age_lbl.Text = "Doctor Age :";
            // 
            // spcl_lbl
            // 
            this.spcl_lbl.AutoSize = true;
            this.spcl_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.spcl_lbl.Location = new System.Drawing.Point(172, 166);
            this.spcl_lbl.Name = "spcl_lbl";
            this.spcl_lbl.Size = new System.Drawing.Size(162, 23);
            this.spcl_lbl.TabIndex = 3;
            this.spcl_lbl.Text = "Dr Specialization :";
            // 
            // room_lbl
            // 
            this.room_lbl.AutoSize = true;
            this.room_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.room_lbl.Location = new System.Drawing.Point(207, 263);
            this.room_lbl.Name = "room_lbl";
            this.room_lbl.Size = new System.Drawing.Size(127, 23);
            this.room_lbl.TabIndex = 4;
            this.room_lbl.Text = "Doctor Room :";
            this.room_lbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // years_lbl
            // 
            this.years_lbl.AutoSize = true;
            this.years_lbl.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.years_lbl.Location = new System.Drawing.Point(383, 217);
            this.years_lbl.Name = "years_lbl";
            this.years_lbl.Size = new System.Drawing.Size(52, 21);
            this.years_lbl.TabIndex = 11;
            this.years_lbl.Text = "years";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.button1.Location = new System.Drawing.Point(572, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dr_name_label
            // 
            this.dr_name_label.AutoSize = true;
            this.dr_name_label.BackColor = System.Drawing.Color.White;
            this.dr_name_label.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.dr_name_label.Location = new System.Drawing.Point(340, 114);
            this.dr_name_label.Name = "dr_name_label";
            this.dr_name_label.Size = new System.Drawing.Size(57, 23);
            this.dr_name_label.TabIndex = 14;
            this.dr_name_label.Text = "name";
            // 
            // dr_spec_label
            // 
            this.dr_spec_label.AutoSize = true;
            this.dr_spec_label.BackColor = System.Drawing.Color.White;
            this.dr_spec_label.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.dr_spec_label.Location = new System.Drawing.Point(340, 166);
            this.dr_spec_label.Name = "dr_spec_label";
            this.dr_spec_label.Size = new System.Drawing.Size(93, 23);
            this.dr_spec_label.TabIndex = 15;
            this.dr_spec_label.Text = "Specialist";
            // 
            // dr_age_label
            // 
            this.dr_age_label.AutoSize = true;
            this.dr_age_label.BackColor = System.Drawing.Color.White;
            this.dr_age_label.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.dr_age_label.Location = new System.Drawing.Point(340, 216);
            this.dr_age_label.Name = "dr_age_label";
            this.dr_age_label.Size = new System.Drawing.Size(40, 23);
            this.dr_age_label.TabIndex = 16;
            this.dr_age_label.Text = "age";
            // 
            // dr_room_label
            // 
            this.dr_room_label.AutoSize = true;
            this.dr_room_label.BackColor = System.Drawing.Color.White;
            this.dr_room_label.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.dr_room_label.Location = new System.Drawing.Point(340, 263);
            this.dr_room_label.Name = "dr_room_label";
            this.dr_room_label.Size = new System.Drawing.Size(54, 23);
            this.dr_room_label.TabIndex = 17;
            this.dr_room_label.Text = "room";
            // 
            // spec_details_label
            // 
            this.spec_details_label.AutoSize = true;
            this.spec_details_label.BackColor = System.Drawing.Color.White;
            this.spec_details_label.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spec_details_label.Location = new System.Drawing.Point(23, 360);
            this.spec_details_label.Name = "spec_details_label";
            this.spec_details_label.Size = new System.Drawing.Size(55, 18);
            this.spec_details_label.TabIndex = 18;
            this.spec_details_label.Text = "Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(76, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "_________________________________Details_________________________________";
            // 
            // DctrInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spec_details_label);
            this.Controls.Add(this.dr_room_label);
            this.Controls.Add(this.dr_age_label);
            this.Controls.Add(this.dr_spec_label);
            this.Controls.Add(this.dr_name_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.years_lbl);
            this.Controls.Add(this.room_lbl);
            this.Controls.Add(this.spcl_lbl);
            this.Controls.Add(this.age_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.InfoHeading_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DctrInfo";
            this.Text = "Doctor Information";
            this.Load += new System.EventHandler(this.DctrInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoHeading_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label age_lbl;
        private System.Windows.Forms.Label spcl_lbl;
        private System.Windows.Forms.Label room_lbl;
        private System.Windows.Forms.Label years_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dr_name_label;
        private System.Windows.Forms.Label dr_spec_label;
        private System.Windows.Forms.Label dr_age_label;
        private System.Windows.Forms.Label dr_room_label;
        private System.Windows.Forms.Label spec_details_label;
        private System.Windows.Forms.Label label2;
    }
}