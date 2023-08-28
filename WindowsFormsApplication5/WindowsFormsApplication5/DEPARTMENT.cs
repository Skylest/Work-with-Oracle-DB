using System;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class DEPARTMENT : Form
    {
        public DEPARTMENT()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(DEPARTMENT_FormClosed); //Добавляем обработчки событий при закрытии формы
            comboBox1.Hide();
            textBox1.Hide();
            button1.Hide();
            comboBox1.SelectedIndex = 0;
        }


        void DEPARTMENT_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show(); //Показываем форму владельца при закрытии
        }

        private void dEPARTMENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.dEPARTMENTBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }

        }

        private void DEPARTMENT_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.DEPARTMENT". При необходимости она может быть перемещена или удалена.
            this.dEPARTMENTTableAdapter.Fill(this.dataSet1.DEPARTMENT);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    this.dEPARTMENTTableAdapter.Fill(this.dataSet1.DEPARTMENT);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    this.dEPARTMENTTableAdapter.FillBy_ID(this.dataSet1.DEPARTMENT, Decimal.Parse(textBox1.Text));
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    this.dEPARTMENTTableAdapter.FillBy_NAME(this.dataSet1.DEPARTMENT, textBox1.Text);
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            comboBox1.Show();
            button1.Show();
            textBox1.Show();
        }
    }
}
