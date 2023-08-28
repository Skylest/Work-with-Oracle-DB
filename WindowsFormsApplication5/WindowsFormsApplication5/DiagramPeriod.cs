using System;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class DiagramPeriod : Form
    {
        public DiagramPeriod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                diagram.SetBeginDate(textBox1.Text); //Устанавлием нижнюю границу периода
                diagram.SetEndDate(textBox2.Text); //Устанавлием верхнюю границу периода
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
            this.Dispose(); //Высвобождаем ресурсы
        }
    }
}
