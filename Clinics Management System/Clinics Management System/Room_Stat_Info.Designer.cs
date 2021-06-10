
namespace Clinics_Management_System
{
    partial class Room_Stat_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room_Stat_Info));
            this.StatInfoHead_lbl = new System.Windows.Forms.Label();
            this.RoomNo_lbl = new System.Windows.Forms.Label();
            this.RoomDr_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.room_no_txtbox = new System.Windows.Forms.Label();
            this.dr_name_txtbox = new System.Windows.Forms.Label();
            this.spec_txtbox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StatInfoHead_lbl
            // 
            this.StatInfoHead_lbl.AutoSize = true;
            this.StatInfoHead_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatInfoHead_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold);
            this.StatInfoHead_lbl.ForeColor = System.Drawing.Color.Navy;
            this.StatInfoHead_lbl.Location = new System.Drawing.Point(197, 36);
            this.StatInfoHead_lbl.Name = "StatInfoHead_lbl";
            this.StatInfoHead_lbl.Size = new System.Drawing.Size(274, 41);
            this.StatInfoHead_lbl.TabIndex = 0;
            this.StatInfoHead_lbl.Text = "Room Information";
            // 
            // RoomNo_lbl
            // 
            this.RoomNo_lbl.AutoSize = true;
            this.RoomNo_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.RoomNo_lbl.Location = new System.Drawing.Point(226, 145);
            this.RoomNo_lbl.Name = "RoomNo_lbl";
            this.RoomNo_lbl.Size = new System.Drawing.Size(95, 23);
            this.RoomNo_lbl.TabIndex = 1;
            this.RoomNo_lbl.Text = "Room No :";
            // 
            // RoomDr_lbl
            // 
            this.RoomDr_lbl.AutoSize = true;
            this.RoomDr_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.RoomDr_lbl.Location = new System.Drawing.Point(193, 202);
            this.RoomDr_lbl.Name = "RoomDr_lbl";
            this.RoomDr_lbl.Size = new System.Drawing.Size(127, 23);
            this.RoomDr_lbl.TabIndex = 2;
            this.RoomDr_lbl.Text = "Room Doctor :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.button1.Location = new System.Drawing.Point(567, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // room_no_txtbox
            // 
            this.room_no_txtbox.AutoSize = true;
            this.room_no_txtbox.BackColor = System.Drawing.Color.White;
            this.room_no_txtbox.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.room_no_txtbox.Location = new System.Drawing.Point(327, 145);
            this.room_no_txtbox.Name = "room_no_txtbox";
            this.room_no_txtbox.Size = new System.Drawing.Size(77, 23);
            this.room_no_txtbox.TabIndex = 14;
            this.room_no_txtbox.Text = "roomNo";
            // 
            // dr_name_txtbox
            // 
            this.dr_name_txtbox.AutoSize = true;
            this.dr_name_txtbox.BackColor = System.Drawing.Color.White;
            this.dr_name_txtbox.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.dr_name_txtbox.Location = new System.Drawing.Point(326, 202);
            this.dr_name_txtbox.Name = "dr_name_txtbox";
            this.dr_name_txtbox.Size = new System.Drawing.Size(115, 23);
            this.dr_name_txtbox.TabIndex = 15;
            this.dr_name_txtbox.Text = "doctor name";
            // 
            // spec_txtbox
            // 
            this.spec_txtbox.AutoSize = true;
            this.spec_txtbox.BackColor = System.Drawing.Color.White;
            this.spec_txtbox.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.spec_txtbox.Location = new System.Drawing.Point(326, 266);
            this.spec_txtbox.Name = "spec_txtbox";
            this.spec_txtbox.Size = new System.Drawing.Size(128, 23);
            this.spec_txtbox.TabIndex = 17;
            this.spec_txtbox.Text = "Specialization";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label4.Location = new System.Drawing.Point(123, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Doctor Specialization :";
            // 
            // Room_Stat_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 406);
            this.Controls.Add(this.spec_txtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dr_name_txtbox);
            this.Controls.Add(this.room_no_txtbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RoomDr_lbl);
            this.Controls.Add(this.RoomNo_lbl);
            this.Controls.Add(this.StatInfoHead_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Room_Stat_Info";
            this.Text = "Room Status & Info";
            this.Load += new System.EventHandler(this.Room_Stat_Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatInfoHead_lbl;
        private System.Windows.Forms.Label RoomNo_lbl;
        private System.Windows.Forms.Label RoomDr_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label room_no_txtbox;
        private System.Windows.Forms.Label dr_name_txtbox;
        private System.Windows.Forms.Label spec_txtbox;
        private System.Windows.Forms.Label label4;
    }
}