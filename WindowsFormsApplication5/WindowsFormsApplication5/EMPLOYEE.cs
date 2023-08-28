using System;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class EMPLOYEE : Form
    {
        public EMPLOYEE()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(EMPLOYEE_FormClosed); //Добавляем обработчки событий при закрытии формы
            comboBox1.Hide();
            textBox1.Hide();
            button1.Hide();
            comboBox1.SelectedIndex = 0;
        }

        void EMPLOYEE_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show(); //Показываем форму владельца при закрытии
        }

        private void eMPLOYEEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.eMPLOYEEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }

        }

        private void EMPLOYEE_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.EMPLOYEE". При необходимости она может быть перемещена или удалена.
            this.eMPLOYEETableAdapter.Fill(this.dataSet1.EMPLOYEE);
        }

        private void toolStripButton1_Click(object sender, EventArgs e) //В toolStrip добавляем новую кнопку которая открывает форму с отчетом по этой таблице
        {
            EMP_report f = new EMP_report(); //Создаем экземпляр формы EMP_report
            f.Show(this); //Показываем форму EMP_report и указываем владельцем эту форму
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
                    this.eMPLOYEETableAdapter.Fill(this.dataSet1.EMPLOYEE);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    this.eMPLOYEETableAdapter.FillBy_ID(this.dataSet1.EMPLOYEE, Decimal.Parse(textBox1.Text));
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    this.eMPLOYEETableAdapter.FillBy_NAME(this.dataSet1.EMPLOYEE, textBox1.Text);
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    this.eMPLOYEETableAdapter.FillBy_JOB(this.dataSet1.EMPLOYEE, textBox1.Text);
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    this.eMPLOYEETableAdapter.FillBy_SalaryMore(this.dataSet1.EMPLOYEE, Decimal.Parse(textBox1.Text));
                }
                if (comboBox1.SelectedIndex == 5)
                {
                    this.eMPLOYEETableAdapter.FillBy_SalaryLess(this.dataSet1.EMPLOYEE, Decimal.Parse(textBox1.Text));
                }
                if (comboBox1.SelectedIndex == 6)
                {
                    this.eMPLOYEETableAdapter.FillBy_HIRE_DATE(this.dataSet1.EMPLOYEE, DateTime.Parse(textBox1.Text));
                }
                if (comboBox1.SelectedIndex == 7)
                {
                    this.eMPLOYEETableAdapter.FillBy_DEPT_ID(this.dataSet1.EMPLOYEE, Decimal.Parse(textBox1.Text));
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


    }
}
