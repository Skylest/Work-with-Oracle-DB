namespace WindowsFormsApplication5
{
    partial class EMP_report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new WindowsFormsApplication5.DataSet1();
            this.EMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EMPLOYEETableAdapter = new WindowsFormsApplication5.DataSet1TableAdapters.EMPLOYEETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPLOYEEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EMPLOYEEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication5.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(773, 318);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EMPLOYEEBindingSource
            // 
            this.EMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.EMPLOYEEBindingSource.DataSource = this.DataSet1;
            // 
            // EMPLOYEETableAdapter
            // 
            this.EMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // EMP_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 316);
            this.Controls.Add(this.reportViewer1);
            this.Name = "EMP_report";
            this.Text = "EMP_report";
            this.Load += new System.EventHandler(this.EMP_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPLOYEEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EMPLOYEEBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.EMPLOYEETableAdapter EMPLOYEETableAdapter;
    }
}