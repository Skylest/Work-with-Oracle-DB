using System;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class EMP_report : Form
    {
        public EMP_report()
        {
            InitializeComponent();
        }

        private void EMP_report_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet1.EMPLOYEE". При необходимости она может быть перемещена или удалена.
            this.EMPLOYEETableAdapter.Fill(this.DataSet1.EMPLOYEE);
            this.reportViewer1.RefreshReport();
        }
    }
}
