namespace Clinics_Management_System
{
    partial class Checked_pat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checked_pat));
            this.clinicsDatabaseDataSet1 = new Clinics_Management_System.ClinicsDatabaseDataSet1();
            this.allpathistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.all_pat_historyTableAdapter = new Clinics_Management_System.ClinicsDatabaseDataSet1TableAdapters.All_pat_historyTableAdapter();
            this.AppointDoc_lbl = new System.Windows.Forms.Label();
            this.checked_pat_dataGrid = new System.Windows.Forms.DataGridView();
            this.close_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clinicsDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allpathistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checked_pat_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // clinicsDatabaseDataSet1
            // 
            this.clinicsDatabaseDataSet1.DataSetName = "ClinicsDatabaseDataSet1";
            this.clinicsDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allpathistoryBindingSource
            // 
            this.allpathistoryBindingSource.DataMember = "All_pat_history";
            this.allpathistoryBindingSource.DataSource = this.clinicsDatabaseDataSet1;
            // 
            // all_pat_historyTableAdapter
            // 
            this.all_pat_historyTableAdapter.ClearBeforeFill = true;
            // 
            // AppointDoc_lbl
            // 
            this.AppointDoc_lbl.AutoSize = true;
            this.AppointDoc_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AppointDoc_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold);
            this.AppointDoc_lbl.ForeColor = System.Drawing.Color.Navy;
            this.AppointDoc_lbl.Location = new System.Drawing.Point(264, 9);
            this.AppointDoc_lbl.Name = "AppointDoc_lbl";
            this.AppointDoc_lbl.Size = new System.Drawing.Size(295, 41);
            this.AppointDoc_lbl.TabIndex = 1;
            this.AppointDoc_lbl.Text = "All Patients History";
            // 
            // checked_pat_dataGrid
            // 
            this.checked_pat_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checked_pat_dataGrid.Location = new System.Drawing.Point(12, 73);
            this.checked_pat_dataGrid.Name = "checked_pat_dataGrid";
            this.checked_pat_dataGrid.Size = new System.Drawing.Size(748, 365);
            this.checked_pat_dataGrid.TabIndex = 2;
            // 
            // close_btn
            // 
            this.close_btn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.close_btn.Location = new System.Drawing.Point(631, 452);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(129, 37);
            this.close_btn.TabIndex = 6;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // Checked_pat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 501);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.checked_pat_dataGrid);
            this.Controls.Add(this.AppointDoc_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Checked_pat";
            this.Text = "Checked Patients";
            this.Load += new System.EventHandler(this.Checked_pat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clinicsDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allpathistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checked_pat_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource allpathistoryBindingSource;
        private ClinicsDatabaseDataSet1 clinicsDatabaseDataSet1;
        private ClinicsDatabaseDataSet1TableAdapters.All_pat_historyTableAdapter all_pat_historyTableAdapter;
        private System.Windows.Forms.Label AppointDoc_lbl;
        private System.Windows.Forms.DataGridView checked_pat_dataGrid;
        private System.Windows.Forms.Button close_btn;
    }
}