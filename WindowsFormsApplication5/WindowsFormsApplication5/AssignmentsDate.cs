using System;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class AssignmentsDate : Form
    {
        public AssignmentsDate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ASSIGN_report.SetDate(textBox1.Text); //Устанавливаем дату для поиска указаний
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
            this.Dispose(); //Высвобождаем ресурсы
        }
    }
}
