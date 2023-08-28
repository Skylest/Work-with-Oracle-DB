namespace WindowsFormsApplication5
{
    partial class ASSIGN_report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ASSIGNMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new WindowsFormsApplication5.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ASSIGNMENTSTableAdapter = new WindowsFormsApplication5.DataSet1TableAdapters.ASSIGNMENTSTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ASSIGNMENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ASSIGNMENTSBindingSource
            // 
            this.ASSIGNMENTSBindingSource.DataMember = "ASSIGNMENTS";
            this.ASSIGNMENTSBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.ASSIGNMENTSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication5.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(872, 306);
            this.reportViewer1.TabIndex = 0;
            // 
            // ASSIGNMENTSTableAdapter
            // 
            this.ASSIGNMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(880, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "Поручения на определенную дату";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(880, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Поручения за сегодня";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(880, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 65);
            this.button3.TabIndex = 5;
            this.button3.Text = "Поручения за заданый период";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(880, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 65);
            this.button4.TabIndex = 6;
            this.button4.Text = "Ближайшие дедлайны";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ASSIGN_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 311);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ASSIGN_report";
            this.Text = "ASSIGN_report";
            this.Load += new System.EventHandler(this.ASSIGN_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ASSIGNMENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ASSIGNMENTSBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.ASSIGNMENTSTableAdapter ASSIGNMENTSTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}