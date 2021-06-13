namespace Clinics_Management_System
{
    partial class patient_history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patient_history));
            this.pat_history_dataGridView = new System.Windows.Forms.DataGridView();
            this.AppointDoc_lbl = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pat_history_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pat_history_dataGridView
            // 
            this.pat_history_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pat_history_dataGridView.Location = new System.Drawing.Point(12, 87);
            this.pat_history_dataGridView.Name = "pat_history_dataGridView";
            this.pat_history_dataGridView.Size = new System.Drawing.Size(776, 280);
            this.pat_history_dataGridView.TabIndex = 0;
            // 
            // AppointDoc_lbl
            // 
            this.AppointDoc_lbl.AutoSize = true;
            this.AppointDoc_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AppointDoc_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold);
            this.AppointDoc_lbl.ForeColor = System.Drawing.Color.Navy;
            this.AppointDoc_lbl.Location = new System.Drawing.Point(276, 23);
            this.AppointDoc_lbl.Name = "AppointDoc_lbl";
            this.AppointDoc_lbl.Size = new System.Drawing.Size(266, 41);
            this.AppointDoc_lbl.TabIndex = 2;
            this.AppointDoc_lbl.Text = "History of Patient";
            // 
            // close_btn
            // 
            this.close_btn.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.close_btn.Location = new System.Drawing.Point(675, 380);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(113, 44);
            this.close_btn.TabIndex = 26;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // patient_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.AppointDoc_lbl);
            this.Controls.Add(this.pat_history_dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "patient_history";
            this.Text = "Patient History";
            ((System.ComponentModel.ISupportInitialize)(this.pat_history_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pat_history_dataGridView;
        private System.Windows.Forms.Label AppointDoc_lbl;
        private System.Windows.Forms.Button close_btn;
    }
}