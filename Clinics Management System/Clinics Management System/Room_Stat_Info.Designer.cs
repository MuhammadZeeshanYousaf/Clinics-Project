
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
            this.StatInfoHead_lbl = new System.Windows.Forms.Label();
            this.RoomNo_lbl = new System.Windows.Forms.Label();
            this.RoomDr_lbl = new System.Windows.Forms.Label();
            this.Status_lbl = new System.Windows.Forms.Label();
            this.HavePat_rbtn = new System.Windows.Forms.RadioButton();
            this.NoPat_rbtn = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StatInfoHead_lbl
            // 
            this.StatInfoHead_lbl.AutoSize = true;
            this.StatInfoHead_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatInfoHead_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold);
            this.StatInfoHead_lbl.ForeColor = System.Drawing.Color.Navy;
            this.StatInfoHead_lbl.Location = new System.Drawing.Point(149, 41);
            this.StatInfoHead_lbl.Name = "StatInfoHead_lbl";
            this.StatInfoHead_lbl.Size = new System.Drawing.Size(396, 41);
            this.StatInfoHead_lbl.TabIndex = 0;
            this.StatInfoHead_lbl.Text = "Room Status / Information";
            // 
            // RoomNo_lbl
            // 
            this.RoomNo_lbl.AutoSize = true;
            this.RoomNo_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.RoomNo_lbl.Location = new System.Drawing.Point(226, 135);
            this.RoomNo_lbl.Name = "RoomNo_lbl";
            this.RoomNo_lbl.Size = new System.Drawing.Size(95, 23);
            this.RoomNo_lbl.TabIndex = 1;
            this.RoomNo_lbl.Text = "Room No :";
            // 
            // RoomDr_lbl
            // 
            this.RoomDr_lbl.AutoSize = true;
            this.RoomDr_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.RoomDr_lbl.Location = new System.Drawing.Point(194, 191);
            this.RoomDr_lbl.Name = "RoomDr_lbl";
            this.RoomDr_lbl.Size = new System.Drawing.Size(127, 23);
            this.RoomDr_lbl.TabIndex = 2;
            this.RoomDr_lbl.Text = "Room Doctor :";
            // 
            // Status_lbl
            // 
            this.Status_lbl.AutoSize = true;
            this.Status_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.Status_lbl.Location = new System.Drawing.Point(247, 249);
            this.Status_lbl.Name = "Status_lbl";
            this.Status_lbl.Size = new System.Drawing.Size(74, 23);
            this.Status_lbl.TabIndex = 3;
            this.Status_lbl.Text = "Status :";
            this.Status_lbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // HavePat_rbtn
            // 
            this.HavePat_rbtn.AutoSize = true;
            this.HavePat_rbtn.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.HavePat_rbtn.Location = new System.Drawing.Point(327, 249);
            this.HavePat_rbtn.Name = "HavePat_rbtn";
            this.HavePat_rbtn.Size = new System.Drawing.Size(119, 23);
            this.HavePat_rbtn.TabIndex = 6;
            this.HavePat_rbtn.TabStop = true;
            this.HavePat_rbtn.Text = "Have Patient";
            this.HavePat_rbtn.UseVisualStyleBackColor = true;
            // 
            // NoPat_rbtn
            // 
            this.NoPat_rbtn.AutoSize = true;
            this.NoPat_rbtn.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.NoPat_rbtn.Location = new System.Drawing.Point(327, 278);
            this.NoPat_rbtn.Name = "NoPat_rbtn";
            this.NoPat_rbtn.Size = new System.Drawing.Size(177, 23);
            this.NoPat_rbtn.TabIndex = 7;
            this.NoPat_rbtn.TabStop = true;
            this.NoPat_rbtn.Text = "Doesn\'t Have Patient";
            this.NoPat_rbtn.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.label1.Location = new System.Drawing.Point(327, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.label2.Location = new System.Drawing.Point(327, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "doctor name";
            // 
            // Room_Stat_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 406);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NoPat_rbtn);
            this.Controls.Add(this.HavePat_rbtn);
            this.Controls.Add(this.Status_lbl);
            this.Controls.Add(this.RoomDr_lbl);
            this.Controls.Add(this.RoomNo_lbl);
            this.Controls.Add(this.StatInfoHead_lbl);
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
        private System.Windows.Forms.Label Status_lbl;
        private System.Windows.Forms.RadioButton HavePat_rbtn;
        private System.Windows.Forms.RadioButton NoPat_rbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}