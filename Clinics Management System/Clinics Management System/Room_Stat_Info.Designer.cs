
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.HavePat_rbtn = new System.Windows.Forms.RadioButton();
            this.NoPat_rbtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // StatInfoHead_lbl
            // 
            this.StatInfoHead_lbl.AutoSize = true;
            this.StatInfoHead_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold);
            this.StatInfoHead_lbl.Location = new System.Drawing.Point(203, 37);
            this.StatInfoHead_lbl.Name = "StatInfoHead_lbl";
            this.StatInfoHead_lbl.Size = new System.Drawing.Size(394, 39);
            this.StatInfoHead_lbl.TabIndex = 0;
            this.StatInfoHead_lbl.Text = "Room Status / Information";
            // 
            // RoomNo_lbl
            // 
            this.RoomNo_lbl.AutoSize = true;
            this.RoomNo_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.RoomNo_lbl.Location = new System.Drawing.Point(231, 135);
            this.RoomNo_lbl.Name = "RoomNo_lbl";
            this.RoomNo_lbl.Size = new System.Drawing.Size(90, 23);
            this.RoomNo_lbl.TabIndex = 1;
            this.RoomNo_lbl.Text = "Room No:";
            // 
            // RoomDr_lbl
            // 
            this.RoomDr_lbl.AutoSize = true;
            this.RoomDr_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.RoomDr_lbl.Location = new System.Drawing.Point(200, 202);
            this.RoomDr_lbl.Name = "RoomDr_lbl";
            this.RoomDr_lbl.Size = new System.Drawing.Size(121, 23);
            this.RoomDr_lbl.TabIndex = 2;
            this.RoomDr_lbl.Text = "Room Doctor:";
            // 
            // Status_lbl
            // 
            this.Status_lbl.AutoSize = true;
            this.Status_lbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.Status_lbl.Location = new System.Drawing.Point(229, 274);
            this.Status_lbl.Name = "Status_lbl";
            this.Status_lbl.Size = new System.Drawing.Size(69, 23);
            this.Status_lbl.TabIndex = 3;
            this.Status_lbl.Text = "Status:";
            this.Status_lbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift", 13F);
            this.textBox1.Location = new System.Drawing.Point(327, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Bahnschrift", 13F);
            this.textBox2.Location = new System.Drawing.Point(327, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 28);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // HavePat_rbtn
            // 
            this.HavePat_rbtn.AutoSize = true;
            this.HavePat_rbtn.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.HavePat_rbtn.Location = new System.Drawing.Point(335, 275);
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
            this.NoPat_rbtn.Location = new System.Drawing.Point(335, 304);
            this.NoPat_rbtn.Name = "NoPat_rbtn";
            this.NoPat_rbtn.Size = new System.Drawing.Size(177, 23);
            this.NoPat_rbtn.TabIndex = 7;
            this.NoPat_rbtn.TabStop = true;
            this.NoPat_rbtn.Text = "Doesn\'t Have Patient";
            this.NoPat_rbtn.UseVisualStyleBackColor = true;
            // 
            // Room_Stat_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NoPat_rbtn);
            this.Controls.Add(this.HavePat_rbtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton HavePat_rbtn;
        private System.Windows.Forms.RadioButton NoPat_rbtn;
    }
}