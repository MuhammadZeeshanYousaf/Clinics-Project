namespace Clinics_Management_System
{
    partial class App_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App_Login));
            this.Welcome_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IsReceptionist = new System.Windows.Forms.RadioButton();
            this.IsDoctor = new System.Windows.Forms.RadioButton();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.Location = new System.Drawing.Point(12, 9);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(679, 39);
            this.Welcome_label.TabIndex = 0;
            this.Welcome_label.Text = "WELCOME TO CLINICS MANAGEMENT SYSTEM";
            this.Welcome_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IsReceptionist);
            this.panel1.Controls.Add(this.IsDoctor);
            this.panel1.Controls.Add(this.password_txt);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.username_txt);
            this.panel1.Controls.Add(this.Login_btn);
            this.panel1.Location = new System.Drawing.Point(12, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 188);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // IsReceptionist
            // 
            this.IsReceptionist.AutoSize = true;
            this.IsReceptionist.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsReceptionist.Location = new System.Drawing.Point(341, 77);
            this.IsReceptionist.Name = "IsReceptionist";
            this.IsReceptionist.Size = new System.Drawing.Size(139, 24);
            this.IsReceptionist.TabIndex = 6;
            this.IsReceptionist.TabStop = true;
            this.IsReceptionist.Text = "RECEPTIONIST";
            this.IsReceptionist.UseVisualStyleBackColor = true;
            this.IsReceptionist.CheckedChanged += new System.EventHandler(this.IsReceptionist_CheckedChanged);
            // 
            // IsDoctor
            // 
            this.IsDoctor.AutoSize = true;
            this.IsDoctor.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsDoctor.Location = new System.Drawing.Point(218, 77);
            this.IsDoctor.Name = "IsDoctor";
            this.IsDoctor.Size = new System.Drawing.Size(95, 24);
            this.IsDoctor.TabIndex = 5;
            this.IsDoctor.TabStop = true;
            this.IsDoctor.Text = "DOCTOR";
            this.IsDoctor.UseVisualStyleBackColor = true;
            this.IsDoctor.CheckedChanged += new System.EventHandler(this.IsDoctor_CheckedChanged);
            // 
            // password_txt
            // 
            this.password_txt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.Location = new System.Drawing.Point(465, 26);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(190, 27);
            this.password_txt.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(357, 28);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(104, 23);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username / ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // username_txt
            // 
            this.username_txt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.Location = new System.Drawing.Point(149, 27);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(186, 27);
            this.username_txt.TabIndex = 1;
            // 
            // Login_btn
            // 
            this.Login_btn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.Location = new System.Drawing.Point(281, 124);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(96, 40);
            this.Login_btn.TabIndex = 0;
            this.Login_btn.Text = "Log in";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(558, 305);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // App_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 575);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Welcome_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "App_Login";
            this.Text = "Clinics Management Login";
            this.Load += new System.EventHandler(this.App_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton IsReceptionist;
        private System.Windows.Forms.RadioButton IsDoctor;
    }
}