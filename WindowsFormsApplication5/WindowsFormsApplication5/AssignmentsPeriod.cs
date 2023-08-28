using System;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class AssignmentsPeriod : Form
    {
        public AssignmentsPeriod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ASSIGN_report.SetBeginDate(textBox1.Text); //Устанавлием нижнюю границу периода
                ASSIGN_report.SetEndDate(textBox2.Text); //Устанавлием верхнюю границу периода
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
            this.Dispose(); //Высвобождаем ресурсы
        }
    }
}
