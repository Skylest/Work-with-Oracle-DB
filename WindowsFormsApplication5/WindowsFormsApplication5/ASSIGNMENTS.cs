using System;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class ASSIGNMENTS : Form
    {
        public ASSIGNMENTS()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(ASSIGNMENTS_FormClosed); //Добавляем обработчки событий при закрытии формы
            comboBox1.Hide();
            textBox1.Hide();
            button1.Hide();
            comboBox1.SelectedIndex = 0;
        }

        void ASSIGNMENTS_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show(); //Показываем форму владельца при закрытии
        }

        private void aSSIGNMENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.aSSIGNMENTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }

        }

        private void ASSIGNMENTS_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.ASSIGNMENTS". При необходимости она может быть перемещена или удалена.
            this.aSSIGNMENTSTableAdapter.Fill(this.dataSet1.ASSIGNMENTS);

        }

        private void toolStripButton1_Click(object sender, EventArgs e) //В toolStrip добавляем новую кнопку которая открывает форму с отчетом по этой таблице
        {
            ASSIGN_report f = new ASSIGN_report(); //Создаем экземпляр формы ASSIGN_report
            f.Show(this); //Показываем форму ASSIGN_report и указываем владельцем эту форму
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            comboBox1.Show();
            button1.Show();
            textBox1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    this.aSSIGNMENTSTableAdapter.Fill(this.dataSet1.ASSIGNMENTS);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    this.aSSIGNMENTSTableAdapter.FillBy_ID(this.dataSet1.ASSIGNMENTS, Decimal.Parse(textBox1.Text));
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    this.aSSIGNMENTSTableAdapter.FillBy_Name(this.dataSet1.ASSIGNMENTS, textBox1.Text);
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    this.aSSIGNMENTSTableAdapter.FillBy_DATE_OF_ISSUE(this.dataSet1.ASSIGNMENTS, DateTime.Parse(textBox1.Text));
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    this.aSSIGNMENTSTableAdapter.FillBy_EXECUTION_DATE(this.dataSet1.ASSIGNMENTS, DateTime.Parse(textBox1.Text));
                }
                if (comboBox1.SelectedIndex == 5)
                {
                    this.aSSIGNMENTSTableAdapter.FillBy_DEADLINE(this.dataSet1.ASSIGNMENTS, DateTime.Parse(textBox1.Text));
                }
                comboBox1.Hide();
                textBox1.Hide();
                button1.Hide();
                textBox1.Text = "";
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            } 
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            diagram f = new diagram(); //Создаем экземпляр формы diagram
            f.Show(this); //Показываем форму diagram и указываем владельцем эту форму
        }

    }
}
